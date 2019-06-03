using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PlanoParinkimas
{
    public partial class Euclid : Form
    {
        private DataTable duomenysFromTable;
        private DataGridView datagridViewFromFrom;

        public Euclid(DataGridView duomenys, DataTable duomenys2)
        {
            datagridViewFromFrom = duomenys;
            duomenysFromTable = duomenys2;
            InitializeComponent();
            chart1.MouseWheel += chData_MouseWheel;
         

        }

        private void EuklidoBetter_Load(object sender, EventArgs e)
        {

            var sortedTable = duomenysFromTable.AsEnumerable()
                .OrderBy(r => r.Field<double>("Manhattan"))
                .CopyToDataTable();

            chart1.DataSource = sortedTable;

            int amountofrows = sortedTable.Rows.Count;

            for (int i = 0; i < amountofrows; i++)
            {
                List<string> xvals = new List<string>();
                List<decimal> yvals = new List<decimal>();
                string seriesName = sortedTable.Rows[i]["Planas"].ToString();
                createNewSeries(seriesName);
                chart1.Series[seriesName].ChartType = SeriesChartType.Bar; //stackoverflow raso kad daro chart1.Series[i] .... bet exceptiona meta, kad out of bounds ir panasiai
                chart1.Series[seriesName].IsValueShownAsLabel = true;
                chart1.Series[seriesName].BorderWidth = 1;
                chart1.Series[seriesName]["PointWidth"] = "1";
                chart1.Series[seriesName].BorderColor = Color.Transparent;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;

                foreach (DataRow dr in sortedTable.Rows)
                {
                    try
                    {
                        if (String.Equals(seriesName, dr["Planas"].ToString(), StringComparison.Ordinal))
                        {
                            xvals.Add(dr["Operatorius"].ToString());
                            yvals.Add(Convert.ToDecimal(dr["Euclid"].ToString()));
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error");
                    }
                }
                try
                {
                    chart1.Series[seriesName].XValueType = ChartValueType.String;
                    chart1.Series[seriesName].YValueType = ChartValueType.Auto;
                    chart1.Series[seriesName].Points.DataBindXY(xvals.ToArray(), yvals.ToArray());
                }
                catch (Exception)
                {

                    MessageBox.Show("Error");
                }
            }            
            chart1.DataBind();
            chart1.Visible = true;
        }

        private void createNewSeries(String SeriesName)
        {
            if (chart1.Series.IsUniqueName(SeriesName))
            {
                chart1.Series.Add(SeriesName);
            }
        }

        private void chData_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta < 0)
                {
                    chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                }

                if (e.Delta > 0)
                {
                    double xMin = chart1.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = chart1.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = chart1.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = chart1.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    double posXFinish = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    double posYStart = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    double posYFinish = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    chart1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    chart1.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }
    }
}
