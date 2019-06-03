namespace PlanoParinkimas
{
    partial class PlanoPasirinkimas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_Planai = new System.Windows.Forms.GroupBox();
            this.btn_Valyti = new System.Windows.Forms.Button();
            this.btn_Nuskaityti = new System.Windows.Forms.Button();
            this.grid_Duomenys = new System.Windows.Forms.DataGridView();
            this.Operatorius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Planas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kaina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minutės = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Euclid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manhattan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_Pageidavimai = new System.Windows.Forms.GroupBox();
            this.txt_SMS = new System.Windows.Forms.NumericUpDown();
            this.txt_MB = new System.Windows.Forms.NumericUpDown();
            this.txt_Kaina = new System.Windows.Forms.NumericUpDown();
            this.txt_minutes = new System.Windows.Forms.NumericUpDown();
            this.btn_Skaiciuoti = new System.Windows.Forms.Button();
            this.lbl_PrioritetuSuma = new System.Windows.Forms.Label();
            this.lbl_sSMS = new System.Windows.Forms.Label();
            this.lbl_sMB = new System.Windows.Forms.Label();
            this.lbl_sKaina = new System.Windows.Forms.Label();
            this.lbl_sMinutes = new System.Windows.Forms.Label();
            this.lbl_PlanoMokestis = new System.Windows.Forms.Label();
            this.slider_Kaina = new System.Windows.Forms.TrackBar();
            this.lbl_MB = new System.Windows.Forms.Label();
            this.cbox_MB = new System.Windows.Forms.CheckBox();
            this.cbox_SMS = new System.Windows.Forms.CheckBox();
            this.slider_MB = new System.Windows.Forms.TrackBar();
            this.lbl_minutes = new System.Windows.Forms.Label();
            this.slider_SMS = new System.Windows.Forms.TrackBar();
            this.lbl_SMS = new System.Windows.Forms.Label();
            this.slider_minutes = new System.Windows.Forms.TrackBar();
            this.lbl_Prioritetas = new System.Windows.Forms.Label();
            this.cbox_minutes = new System.Windows.Forms.CheckBox();
            this.gbox_Nustatymai = new System.Windows.Forms.GroupBox();
            this.txt_AbsKoef = new System.Windows.Forms.NumericUpDown();
            this.txt_SantKoef = new System.Windows.Forms.NumericUpDown();
            this.radio_AbsKoef = new System.Windows.Forms.RadioButton();
            this.radio_santKoef = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbox_Planai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Duomenys)).BeginInit();
            this.gbox_Pageidavimai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Kaina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Kaina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_MB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_SMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_minutes)).BeginInit();
            this.gbox_Nustatymai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AbsKoef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SantKoef)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_Planai
            // 
            this.gbox_Planai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_Planai.Controls.Add(this.btn_Valyti);
            this.gbox_Planai.Controls.Add(this.btn_Nuskaityti);
            this.gbox_Planai.Controls.Add(this.grid_Duomenys);
            this.gbox_Planai.Location = new System.Drawing.Point(13, 13);
            this.gbox_Planai.Name = "gbox_Planai";
            this.gbox_Planai.Size = new System.Drawing.Size(626, 505);
            this.gbox_Planai.TabIndex = 0;
            this.gbox_Planai.TabStop = false;
            this.gbox_Planai.Text = "Galimi planai";
            // 
            // btn_Valyti
            // 
            this.btn_Valyti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Valyti.Location = new System.Drawing.Point(496, 476);
            this.btn_Valyti.Name = "btn_Valyti";
            this.btn_Valyti.Size = new System.Drawing.Size(124, 23);
            this.btn_Valyti.TabIndex = 2;
            this.btn_Valyti.Text = "Valyti duomenis";
            this.btn_Valyti.UseVisualStyleBackColor = true;
            this.btn_Valyti.Click += new System.EventHandler(this.btn_Valyti_Click);
            // 
            // btn_Nuskaityti
            // 
            this.btn_Nuskaityti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Nuskaityti.Location = new System.Drawing.Point(7, 476);
            this.btn_Nuskaityti.Name = "btn_Nuskaityti";
            this.btn_Nuskaityti.Size = new System.Drawing.Size(124, 23);
            this.btn_Nuskaityti.TabIndex = 1;
            this.btn_Nuskaityti.Text = "Nuskaityti duomenis";
            this.btn_Nuskaityti.UseVisualStyleBackColor = true;
            this.btn_Nuskaityti.Click += new System.EventHandler(this.btn_Nuskaityti_Click);
            // 
            // grid_Duomenys
            // 
            this.grid_Duomenys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Duomenys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_Duomenys.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_Duomenys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Duomenys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operatorius,
            this.Planas,
            this.Kaina,
            this.Minutės,
            this.SMS,
            this.MB,
            this.Euclid,
            this.Manhattan});
            this.grid_Duomenys.Location = new System.Drawing.Point(7, 20);
            this.grid_Duomenys.MultiSelect = false;
            this.grid_Duomenys.Name = "grid_Duomenys";
            this.grid_Duomenys.Size = new System.Drawing.Size(613, 450);
            this.grid_Duomenys.TabIndex = 0;
            this.grid_Duomenys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Duomenys_CellContentClick);
            // 
            // Operatorius
            // 
            this.Operatorius.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Operatorius.DataPropertyName = "Operatorius";
            this.Operatorius.HeaderText = "Operatorius";
            this.Operatorius.Name = "Operatorius";
            // 
            // Planas
            // 
            this.Planas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Planas.DataPropertyName = "Planas";
            this.Planas.HeaderText = "Planas";
            this.Planas.Name = "Planas";
            // 
            // Kaina
            // 
            this.Kaina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kaina.DataPropertyName = "Kaina";
            this.Kaina.HeaderText = "Kaina";
            this.Kaina.MinimumWidth = 70;
            this.Kaina.Name = "Kaina";
            this.Kaina.Width = 70;
            // 
            // Minutės
            // 
            this.Minutės.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Minutės.DataPropertyName = "Minutės";
            this.Minutės.HeaderText = "Minutės";
            this.Minutės.MinimumWidth = 70;
            this.Minutės.Name = "Minutės";
            this.Minutės.Width = 70;
            // 
            // SMS
            // 
            this.SMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SMS.DataPropertyName = "SMS";
            this.SMS.HeaderText = "SMS";
            this.SMS.MinimumWidth = 70;
            this.SMS.Name = "SMS";
            this.SMS.Width = 70;
            // 
            // MB
            // 
            this.MB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MB.DataPropertyName = "MB";
            this.MB.HeaderText = "MB";
            this.MB.MinimumWidth = 70;
            this.MB.Name = "MB";
            this.MB.Width = 70;
            // 
            // Euclid
            // 
            this.Euclid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Euclid.DataPropertyName = "Euclid";
            this.Euclid.HeaderText = "Euclid";
            this.Euclid.MinimumWidth = 70;
            this.Euclid.Name = "Euclid";
            this.Euclid.Width = 70;
            // 
            // Manhattan
            // 
            this.Manhattan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Manhattan.DataPropertyName = "Manhattan";
            this.Manhattan.HeaderText = "Manhattan";
            this.Manhattan.Name = "Manhattan";
            this.Manhattan.Width = 83;
            // 
            // gbox_Pageidavimai
            // 
            this.gbox_Pageidavimai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_Pageidavimai.Controls.Add(this.txt_SMS);
            this.gbox_Pageidavimai.Controls.Add(this.txt_MB);
            this.gbox_Pageidavimai.Controls.Add(this.txt_Kaina);
            this.gbox_Pageidavimai.Controls.Add(this.txt_minutes);
            this.gbox_Pageidavimai.Controls.Add(this.btn_Skaiciuoti);
            this.gbox_Pageidavimai.Controls.Add(this.lbl_PrioritetuSuma);
            this.gbox_Pageidavimai.Controls.Add(this.lbl_sSMS);
            this.gbox_Pageidavimai.Controls.Add(this.lbl_sMB);
            this.gbox_Pageidavimai.Controls.Add(this.lbl_sKaina);
            this.gbox_Pageidavimai.Controls.Add(this.lbl_sMinutes);
            this.gbox_Pageidavimai.Controls.Add(this.lbl_PlanoMokestis);
            this.gbox_Pageidavimai.Controls.Add(this.slider_Kaina);
            this.gbox_Pageidavimai.Controls.Add(this.lbl_MB);
            this.gbox_Pageidavimai.Controls.Add(this.cbox_MB);
            this.gbox_Pageidavimai.Controls.Add(this.cbox_SMS);
            this.gbox_Pageidavimai.Controls.Add(this.slider_MB);
            this.gbox_Pageidavimai.Controls.Add(this.lbl_minutes);
            this.gbox_Pageidavimai.Controls.Add(this.slider_SMS);
            this.gbox_Pageidavimai.Controls.Add(this.lbl_SMS);
            this.gbox_Pageidavimai.Controls.Add(this.slider_minutes);
            this.gbox_Pageidavimai.Controls.Add(this.lbl_Prioritetas);
            this.gbox_Pageidavimai.Controls.Add(this.cbox_minutes);
            this.gbox_Pageidavimai.Location = new System.Drawing.Point(645, 13);
            this.gbox_Pageidavimai.Name = "gbox_Pageidavimai";
            this.gbox_Pageidavimai.Size = new System.Drawing.Size(454, 216);
            this.gbox_Pageidavimai.TabIndex = 1;
            this.gbox_Pageidavimai.TabStop = false;
            this.gbox_Pageidavimai.Text = "Vartotojo pageidavimai";
            // 
            // txt_SMS
            // 
            this.txt_SMS.Location = new System.Drawing.Point(113, 70);
            this.txt_SMS.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_SMS.Name = "txt_SMS";
            this.txt_SMS.Size = new System.Drawing.Size(60, 20);
            this.txt_SMS.TabIndex = 25;
            this.txt_SMS.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txt_MB
            // 
            this.txt_MB.Location = new System.Drawing.Point(112, 100);
            this.txt_MB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_MB.Name = "txt_MB";
            this.txt_MB.Size = new System.Drawing.Size(60, 20);
            this.txt_MB.TabIndex = 24;
            this.txt_MB.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txt_Kaina
            // 
            this.txt_Kaina.DecimalPlaces = 2;
            this.txt_Kaina.Location = new System.Drawing.Point(112, 130);
            this.txt_Kaina.Name = "txt_Kaina";
            this.txt_Kaina.Size = new System.Drawing.Size(60, 20);
            this.txt_Kaina.TabIndex = 23;
            this.txt_Kaina.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // txt_minutes
            // 
            this.txt_minutes.Location = new System.Drawing.Point(113, 40);
            this.txt_minutes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_minutes.Name = "txt_minutes";
            this.txt_minutes.Size = new System.Drawing.Size(60, 20);
            this.txt_minutes.TabIndex = 2;
            this.txt_minutes.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // btn_Skaiciuoti
            // 
            this.btn_Skaiciuoti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Skaiciuoti.Location = new System.Drawing.Point(251, 181);
            this.btn_Skaiciuoti.Name = "btn_Skaiciuoti";
            this.btn_Skaiciuoti.Size = new System.Drawing.Size(158, 23);
            this.btn_Skaiciuoti.TabIndex = 22;
            this.btn_Skaiciuoti.Text = "Ieškoti geriausio pasiūlymo";
            this.btn_Skaiciuoti.UseVisualStyleBackColor = true;
            this.btn_Skaiciuoti.Click += new System.EventHandler(this.btn_Skaiciuoti_Click);
            // 
            // lbl_PrioritetuSuma
            // 
            this.lbl_PrioritetuSuma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PrioritetuSuma.AutoSize = true;
            this.lbl_PrioritetuSuma.ForeColor = System.Drawing.Color.Green;
            this.lbl_PrioritetuSuma.Location = new System.Drawing.Point(415, 162);
            this.lbl_PrioritetuSuma.Name = "lbl_PrioritetuSuma";
            this.lbl_PrioritetuSuma.Size = new System.Drawing.Size(33, 13);
            this.lbl_PrioritetuSuma.TabIndex = 21;
            this.lbl_PrioritetuSuma.Text = "100%";
            // 
            // lbl_sSMS
            // 
            this.lbl_sSMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sSMS.AutoSize = true;
            this.lbl_sSMS.Location = new System.Drawing.Point(421, 77);
            this.lbl_sSMS.Name = "lbl_sSMS";
            this.lbl_sSMS.Size = new System.Drawing.Size(27, 13);
            this.lbl_sSMS.TabIndex = 20;
            this.lbl_sSMS.Text = "25%";
            // 
            // lbl_sMB
            // 
            this.lbl_sMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sMB.AutoSize = true;
            this.lbl_sMB.Location = new System.Drawing.Point(421, 107);
            this.lbl_sMB.Name = "lbl_sMB";
            this.lbl_sMB.Size = new System.Drawing.Size(27, 13);
            this.lbl_sMB.TabIndex = 19;
            this.lbl_sMB.Text = "25%";
            // 
            // lbl_sKaina
            // 
            this.lbl_sKaina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sKaina.AutoSize = true;
            this.lbl_sKaina.Location = new System.Drawing.Point(421, 137);
            this.lbl_sKaina.Name = "lbl_sKaina";
            this.lbl_sKaina.Size = new System.Drawing.Size(27, 13);
            this.lbl_sKaina.TabIndex = 18;
            this.lbl_sKaina.Text = "25%";
            // 
            // lbl_sMinutes
            // 
            this.lbl_sMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sMinutes.AutoSize = true;
            this.lbl_sMinutes.Location = new System.Drawing.Point(421, 47);
            this.lbl_sMinutes.Name = "lbl_sMinutes";
            this.lbl_sMinutes.Size = new System.Drawing.Size(27, 13);
            this.lbl_sMinutes.TabIndex = 17;
            this.lbl_sMinutes.Text = "25%";
            // 
            // lbl_PlanoMokestis
            // 
            this.lbl_PlanoMokestis.AutoSize = true;
            this.lbl_PlanoMokestis.Location = new System.Drawing.Point(26, 133);
            this.lbl_PlanoMokestis.Name = "lbl_PlanoMokestis";
            this.lbl_PlanoMokestis.Size = new System.Drawing.Size(81, 13);
            this.lbl_PlanoMokestis.TabIndex = 4;
            this.lbl_PlanoMokestis.Text = "Plano mokestis:";
            // 
            // slider_Kaina
            // 
            this.slider_Kaina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider_Kaina.Location = new System.Drawing.Point(251, 130);
            this.slider_Kaina.Maximum = 17;
            this.slider_Kaina.Minimum = 1;
            this.slider_Kaina.Name = "slider_Kaina";
            this.slider_Kaina.Size = new System.Drawing.Size(158, 45);
            this.slider_Kaina.SmallChange = 5;
            this.slider_Kaina.TabIndex = 16;
            this.slider_Kaina.TickFrequency = 2;
            this.slider_Kaina.Value = 5;
            this.slider_Kaina.Scroll += new System.EventHandler(this.slider_Kaina_Scroll);
            // 
            // lbl_MB
            // 
            this.lbl_MB.AutoSize = true;
            this.lbl_MB.Location = new System.Drawing.Point(26, 103);
            this.lbl_MB.Name = "lbl_MB";
            this.lbl_MB.Size = new System.Drawing.Size(81, 13);
            this.lbl_MB.TabIndex = 5;
            this.lbl_MB.Text = "Suteikiama MB:";
            // 
            // cbox_MB
            // 
            this.cbox_MB.AutoSize = true;
            this.cbox_MB.Location = new System.Drawing.Point(179, 102);
            this.cbox_MB.Name = "cbox_MB";
            this.cbox_MB.Size = new System.Drawing.Size(66, 17);
            this.cbox_MB.TabIndex = 10;
            this.cbox_MB.Text = "neribotai";
            this.cbox_MB.UseVisualStyleBackColor = true;
            this.cbox_MB.CheckedChanged += new System.EventHandler(this.cbox_GB_CheckedChanged);
            // 
            // cbox_SMS
            // 
            this.cbox_SMS.AutoSize = true;
            this.cbox_SMS.Location = new System.Drawing.Point(179, 72);
            this.cbox_SMS.Name = "cbox_SMS";
            this.cbox_SMS.Size = new System.Drawing.Size(66, 17);
            this.cbox_SMS.TabIndex = 11;
            this.cbox_SMS.Text = "neribotai";
            this.cbox_SMS.UseVisualStyleBackColor = true;
            this.cbox_SMS.CheckedChanged += new System.EventHandler(this.cbox_SMS_CheckedChanged);
            // 
            // slider_MB
            // 
            this.slider_MB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider_MB.Location = new System.Drawing.Point(251, 100);
            this.slider_MB.Maximum = 17;
            this.slider_MB.Minimum = 1;
            this.slider_MB.Name = "slider_MB";
            this.slider_MB.Size = new System.Drawing.Size(158, 45);
            this.slider_MB.SmallChange = 5;
            this.slider_MB.TabIndex = 15;
            this.slider_MB.TickFrequency = 2;
            this.slider_MB.Value = 5;
            this.slider_MB.Scroll += new System.EventHandler(this.slider_GB_Scroll);
            // 
            // lbl_minutes
            // 
            this.lbl_minutes.AutoSize = true;
            this.lbl_minutes.Location = new System.Drawing.Point(6, 43);
            this.lbl_minutes.Name = "lbl_minutes";
            this.lbl_minutes.Size = new System.Drawing.Size(101, 13);
            this.lbl_minutes.TabIndex = 3;
            this.lbl_minutes.Text = "Suteikiama minučių:";
            // 
            // slider_SMS
            // 
            this.slider_SMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider_SMS.Location = new System.Drawing.Point(251, 70);
            this.slider_SMS.Maximum = 17;
            this.slider_SMS.Minimum = 1;
            this.slider_SMS.Name = "slider_SMS";
            this.slider_SMS.Size = new System.Drawing.Size(158, 45);
            this.slider_SMS.SmallChange = 5;
            this.slider_SMS.TabIndex = 14;
            this.slider_SMS.TickFrequency = 2;
            this.slider_SMS.Value = 5;
            this.slider_SMS.Scroll += new System.EventHandler(this.slider_SMS_Scroll);
            // 
            // lbl_SMS
            // 
            this.lbl_SMS.AutoSize = true;
            this.lbl_SMS.Location = new System.Drawing.Point(19, 73);
            this.lbl_SMS.Name = "lbl_SMS";
            this.lbl_SMS.Size = new System.Drawing.Size(88, 13);
            this.lbl_SMS.TabIndex = 6;
            this.lbl_SMS.Text = "Suteikiama SMS:";
            // 
            // slider_minutes
            // 
            this.slider_minutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider_minutes.Location = new System.Drawing.Point(251, 40);
            this.slider_minutes.Maximum = 17;
            this.slider_minutes.Minimum = 1;
            this.slider_minutes.Name = "slider_minutes";
            this.slider_minutes.Size = new System.Drawing.Size(158, 45);
            this.slider_minutes.SmallChange = 5;
            this.slider_minutes.TabIndex = 13;
            this.slider_minutes.TickFrequency = 2;
            this.slider_minutes.Value = 5;
            this.slider_minutes.Scroll += new System.EventHandler(this.slider_minutes_Scroll);
            // 
            // lbl_Prioritetas
            // 
            this.lbl_Prioritetas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Prioritetas.AutoSize = true;
            this.lbl_Prioritetas.Location = new System.Drawing.Point(311, 16);
            this.lbl_Prioritetas.Name = "lbl_Prioritetas";
            this.lbl_Prioritetas.Size = new System.Drawing.Size(53, 13);
            this.lbl_Prioritetas.TabIndex = 12;
            this.lbl_Prioritetas.Text = "Prioritetas";
            // 
            // cbox_minutes
            // 
            this.cbox_minutes.AutoSize = true;
            this.cbox_minutes.Location = new System.Drawing.Point(179, 42);
            this.cbox_minutes.Name = "cbox_minutes";
            this.cbox_minutes.Size = new System.Drawing.Size(66, 17);
            this.cbox_minutes.TabIndex = 8;
            this.cbox_minutes.Text = "neribotai";
            this.cbox_minutes.UseVisualStyleBackColor = true;
            this.cbox_minutes.CheckedChanged += new System.EventHandler(this.cbox_minutes_CheckedChanged);
            // 
            // gbox_Nustatymai
            // 
            this.gbox_Nustatymai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_Nustatymai.Controls.Add(this.txt_AbsKoef);
            this.gbox_Nustatymai.Controls.Add(this.txt_SantKoef);
            this.gbox_Nustatymai.Controls.Add(this.radio_AbsKoef);
            this.gbox_Nustatymai.Controls.Add(this.radio_santKoef);
            this.gbox_Nustatymai.Location = new System.Drawing.Point(646, 236);
            this.gbox_Nustatymai.Name = "gbox_Nustatymai";
            this.gbox_Nustatymai.Size = new System.Drawing.Size(453, 77);
            this.gbox_Nustatymai.TabIndex = 2;
            this.gbox_Nustatymai.TabStop = false;
            this.gbox_Nustatymai.Text = "Nustatymai";
            // 
            // txt_AbsKoef
            // 
            this.txt_AbsKoef.Enabled = false;
            this.txt_AbsKoef.Location = new System.Drawing.Point(267, 47);
            this.txt_AbsKoef.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_AbsKoef.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_AbsKoef.Name = "txt_AbsKoef";
            this.txt_AbsKoef.Size = new System.Drawing.Size(82, 20);
            this.txt_AbsKoef.TabIndex = 3;
            this.txt_AbsKoef.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // txt_SantKoef
            // 
            this.txt_SantKoef.Location = new System.Drawing.Point(265, 20);
            this.txt_SantKoef.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_SantKoef.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_SantKoef.Name = "txt_SantKoef";
            this.txt_SantKoef.Size = new System.Drawing.Size(84, 20);
            this.txt_SantKoef.TabIndex = 2;
            this.txt_SantKoef.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // radio_AbsKoef
            // 
            this.radio_AbsKoef.AutoSize = true;
            this.radio_AbsKoef.Location = new System.Drawing.Point(6, 47);
            this.radio_AbsKoef.Name = "radio_AbsKoef";
            this.radio_AbsKoef.Size = new System.Drawing.Size(252, 17);
            this.radio_AbsKoef.TabIndex = 1;
            this.radio_AbsKoef.Text = "Neribotiems planams taikyti absoliutų koeficientą";
            this.radio_AbsKoef.UseVisualStyleBackColor = true;
            this.radio_AbsKoef.CheckedChanged += new System.EventHandler(this.radio_AbsKoef_CheckedChanged);
            // 
            // radio_santKoef
            // 
            this.radio_santKoef.AutoSize = true;
            this.radio_santKoef.Checked = true;
            this.radio_santKoef.Location = new System.Drawing.Point(6, 20);
            this.radio_santKoef.Name = "radio_santKoef";
            this.radio_santKoef.Size = new System.Drawing.Size(251, 17);
            this.radio_santKoef.TabIndex = 0;
            this.radio_santKoef.TabStop = true;
            this.radio_santKoef.Text = "Neribotiems planams taikyti sąntykinį koeficientą";
            this.radio_santKoef.UseVisualStyleBackColor = true;
            this.radio_santKoef.CheckedChanged += new System.EventHandler(this.radio_santKoef_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Euklido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Manhattano";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(646, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagramos";
            // 
            // PlanoPasirinkimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbox_Nustatymai);
            this.Controls.Add(this.gbox_Pageidavimai);
            this.Controls.Add(this.gbox_Planai);
            this.Name = "PlanoPasirinkimas";
            this.Text = "Plano parinkimas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_Planai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Duomenys)).EndInit();
            this.gbox_Pageidavimai.ResumeLayout(false);
            this.gbox_Pageidavimai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Kaina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Kaina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_MB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_SMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_minutes)).EndInit();
            this.gbox_Nustatymai.ResumeLayout(false);
            this.gbox_Nustatymai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AbsKoef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SantKoef)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_Planai;
        private System.Windows.Forms.GroupBox gbox_Pageidavimai;
        private System.Windows.Forms.CheckBox cbox_SMS;
        private System.Windows.Forms.CheckBox cbox_MB;
        private System.Windows.Forms.CheckBox cbox_minutes;
        private System.Windows.Forms.Label lbl_SMS;
        private System.Windows.Forms.Label lbl_MB;
        private System.Windows.Forms.Label lbl_PlanoMokestis;
        private System.Windows.Forms.Label lbl_minutes;
        private System.Windows.Forms.TrackBar slider_minutes;
        private System.Windows.Forms.Label lbl_Prioritetas;
        private System.Windows.Forms.TrackBar slider_Kaina;
        private System.Windows.Forms.TrackBar slider_MB;
        private System.Windows.Forms.TrackBar slider_SMS;
        private System.Windows.Forms.Label lbl_sSMS;
        private System.Windows.Forms.Label lbl_sMB;
        private System.Windows.Forms.Label lbl_sKaina;
        private System.Windows.Forms.Label lbl_sMinutes;
        private System.Windows.Forms.Label lbl_PrioritetuSuma;
        private System.Windows.Forms.Button btn_Skaiciuoti;
        private System.Windows.Forms.NumericUpDown txt_minutes;
        private System.Windows.Forms.NumericUpDown txt_SMS;
        private System.Windows.Forms.NumericUpDown txt_MB;
        private System.Windows.Forms.NumericUpDown txt_Kaina;
        private System.Windows.Forms.DataGridView grid_Duomenys;
        private System.Windows.Forms.Button btn_Valyti;
        private System.Windows.Forms.Button btn_Nuskaityti;
        private System.Windows.Forms.GroupBox gbox_Nustatymai;
        private System.Windows.Forms.NumericUpDown txt_AbsKoef;
        private System.Windows.Forms.NumericUpDown txt_SantKoef;
        private System.Windows.Forms.RadioButton radio_AbsKoef;
        private System.Windows.Forms.RadioButton radio_santKoef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operatorius;
        private System.Windows.Forms.DataGridViewTextBoxColumn Planas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kaina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minutės;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Euclid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhattan;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

