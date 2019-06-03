using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Excel;

namespace PlanoParinkimas
{
    public partial class PlanoPasirinkimas : Form
    {
        DataTable duomenys = new DataTable();
        bool uzpilde = false;
        private bool nuskaite = false;       

        public PlanoPasirinkimas()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            btn_Skaiciuoti.Enabled = false;
        }

       
        #region # prioritetai #
        private void slider_minutes_Scroll(object sender, EventArgs e)
        {
            keistiPrioriteta(lbl_sMinutes, slider_minutes.Value);
        }

        private void slider_SMS_Scroll(object sender, EventArgs e)
        {
            keistiPrioriteta(lbl_sSMS, slider_SMS.Value);
        }

        private void slider_GB_Scroll(object sender, EventArgs e)
        {
            keistiPrioriteta(lbl_sMB, slider_MB.Value);
        }

        private void slider_Kaina_Scroll(object sender, EventArgs e)
        {
            keistiPrioriteta(lbl_sKaina, slider_Kaina.Value);
        }

        private void keistiPrioriteta(Label elementas, int reiksme)
        {
            elementas.Text = (reiksme * 5).ToString() + "%";
            int suma = (slider_minutes.Value + slider_SMS.Value + slider_MB.Value + slider_Kaina.Value) * 5;
            lbl_PrioritetuSuma.Text = suma.ToString() + "%";

            if (suma == 100)
            {
                lbl_PrioritetuSuma.ForeColor = Color.Green;
                btn_Skaiciuoti.Enabled = true;
            }
            else
            {
                lbl_PrioritetuSuma.ForeColor = Color.Red;
                btn_Skaiciuoti.Enabled = false;
            }
        }
        #endregion

        #region # parametrai #
        private void cbox_minutes_CheckedChanged(object sender, EventArgs e)
        {
            keistiAtributa(cbox_minutes, txt_minutes);
        }

        private void cbox_SMS_CheckedChanged(object sender, EventArgs e)
        {
            keistiAtributa(cbox_SMS, txt_SMS);
        }

        private void cbox_GB_CheckedChanged(object sender, EventArgs e)
        {
            keistiAtributa(cbox_MB, txt_MB);
        }

        private void keistiAtributa(CheckBox cbox, NumericUpDown txt)
        {
            txt.Enabled = !cbox.Checked;
        }

        private void radio_santKoef_CheckedChanged(object sender, EventArgs e)
        {
            KeistiKoeficientus();
        }

        private void radio_AbsKoef_CheckedChanged(object sender, EventArgs e)
        {
            KeistiKoeficientus();
        }

        private void KeistiKoeficientus()
        {
            txt_SantKoef.Enabled = radio_santKoef.Checked;
            txt_AbsKoef.Enabled = radio_AbsKoef.Checked;
        }       
        #endregion

        #region # planų valdymas #
        public void btn_Nuskaityti_Click(object sender, EventArgs e)
        {
            duomenys = new DataTable();
            nuskaite = true;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XLS(X)|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (duomenys.Rows.Count > 0 && MessageBox.Show("Ar norite perrašyti esamus duomenis?", "Klausimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    duomenys.Clear();
                    duomenys.Columns.Clear();
                }

                duomenys.Columns.Add("Operatorius", typeof(String));
                duomenys.Columns.Add("Planas", typeof(String));
                duomenys.Columns.Add("Kaina", typeof(Double));
                duomenys.Columns.Add("Minutės", typeof(Double));
                duomenys.Columns.Add("SMS", typeof(Double));
                duomenys.Columns.Add("MB", typeof(Double));
                duomenys.Columns.Add("Euclid", typeof(Double));
                duomenys.Columns.Add("Manhattan", typeof(Double));

                foreach (Row eilute in Workbook.Worksheets(ofd.FileName).First().Rows.Skip(1))
                {
                    var eilutesElementai = eilute.Cells.Select(x => x.Text).ToArray();
                    Console.WriteLine(eilute.ToString());
                    duomenys.Rows.Add(eilutesElementai);
                }
                
                grid_Duomenys.DataSource = duomenys;
                btn_Skaiciuoti.Enabled = true;
            }
        }

        private void btn_Valyti_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite išvalyti duomenis?", "Klausimas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                duomenys.Clear();
                duomenys.Dispose();
                grid_Duomenys.DataSource = null;
                grid_Duomenys.Refresh();
                button1.Enabled = false;
                button2.Enabled = false;
                btn_Skaiciuoti.Enabled = false;
            }
        }
        #endregion

        #region # skaiciavimai #
        private void btn_Skaiciuoti_Click(object sender, EventArgs e)
        {
            if (duomenys.Rows.Count > 0)
            {
                int neribMinutes;
                int neribSMS;
                int neribMB;

                if (radio_santKoef.Checked)
                {
                    int maxMinutes = Convert.ToInt32(duomenys.Compute("max(Minutės)", string.Empty));
                    int maxSMS = Convert.ToInt32(duomenys.Compute("max(SMS)", string.Empty));
                    int maxMB = Convert.ToInt32(duomenys.Compute("max(MB)", string.Empty));

                    int modifier = (int)txt_SantKoef.Value;
                    neribMinutes = maxMinutes * modifier;
                    neribSMS = maxSMS * modifier;
                    neribMB = maxMB * modifier;
                }
                else
                {
                    int max = (int)txt_AbsKoef.Value;
                    neribMinutes = max;
                    neribSMS = max;
                    neribMB = max;
                }

                int norMin = (cbox_minutes.Checked ? neribMinutes : (int)txt_minutes.Value);
                int norSMS = (cbox_SMS.Checked ? neribSMS : (int)txt_SMS.Value);
                int norMB = (cbox_MB.Checked ? neribMB : (int)txt_MB.Value);
                double norKaina = (double)txt_Kaina.Value;

                double priorMin = slider_minutes.Value / 20.0;
                double priorSMS = slider_SMS.Value / 20.0;
                double priorMB = slider_MB.Value / 20.0;
                double priorKaina = slider_Kaina.Value / 20.0;

                foreach (DataRow item in duomenys.Rows)
                {
                    int siulMin = (Convert.ToInt32(item["Minutės"]) == -1 ? neribMinutes : Convert.ToInt32(item["Minutės"]));
                    int siulSMS = (Convert.ToInt32(item["SMS"]) == -1 ? neribSMS : Convert.ToInt32(item["SMS"]));
                    int siulMB = (Convert.ToInt32(item["MB"]) == -1 ? neribMB : Convert.ToInt32(item["MB"]));
                    double siulKaina = Convert.ToDouble(item["Kaina"]);
                    double reitingas = SkaiciuotiReitinga(norMin, norSMS, norMB, norKaina, priorMin, priorSMS, priorMB, priorKaina, siulMin, siulSMS, siulMB, siulKaina);
                    double distance = ManhattanDistance(norMin, norSMS, norMB, norKaina, priorMin, priorSMS, priorMB, priorKaina, siulMin, siulSMS, siulMB, siulKaina);
                    item["Manhattan"] = distance;
                    item["Euclid"] = reitingas;
                }

                DataView atrinktiRezultatai = new DataView(duomenys);
                atrinktiRezultatai.Sort = "Euclid ASC";
                atrinktiRezultatai.Sort = "Manhattan ASC";
                grid_Duomenys.DataSource = atrinktiRezultatai;

            }
            uzpilde = true;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private double SkaiciuotiReitinga(int norMin, int norSMS, int norMB, double norKaina,
            double priorMin, double priorSMS, double priorMB, double priorKaina,
            int siulMin, int siulSMS, int siulMB, double siulKaina)
        {

            return Math.Round(Math.Sqrt(
                priorMin * Math.Pow(norMin - siulMin, 2)
                + priorSMS * Math.Pow(norSMS - siulSMS, 2)
                + priorMB * Math.Pow(norMB - siulMB, 2)
                + priorKaina * Math.Pow(norKaina - siulKaina, 2)
            ), 4);
        }

        private double ManhattanDistance(int norMin, int norSMS, int norMB, double norKaina, double priorMin, double priorSMS, double priorMB, double priorKaina,
            int siulMin, int siulSMS, int siulMB, double siulKaina) 
            => Math.Round(priorMin * Math.Abs(norMin - siulMin) + priorSMS * Math.Abs(norSMS - siulSMS) + priorMB * Math.Abs(norMB - siulMB) + priorKaina * Math.Abs(norKaina - siulKaina));


        #endregion

        private void grid_Duomenys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {


            if (uzpilde != false)
            {
                Euclid euklidoBetter = new Euclid(grid_Duomenys, duomenys);
                euklidoBetter.ShowDialog();
            }
           
        }


        public void button2_Click(object sender, EventArgs e)
        {
            if (uzpilde != false)
            {
                Manhattan manhattanBetter = new Manhattan(grid_Duomenys, duomenys);
                manhattanBetter.ShowDialog();
            }
           
        }
    }
}
