namespace Projekt
{
    partial class InstruktorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstruktorForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.instruktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoskolaDataSet = new Projekt.AutoskolaDataSet();
            this.mjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbMjesto = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.TxtOIB = new System.Windows.Forms.TextBox();
            this.TxtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovi = new System.Windows.Forms.ToolStripButton();
            this.tsbSpremi = new System.Windows.Forms.ToolStripButton();
            this.tsbIzlaz = new System.Windows.Forms.ToolStripButton();
            this.dgvInstruktori = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaposlenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.voznjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.polaznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cibaOdrzano = new System.Windows.Forms.CheckBox();
            this.numTrajanje = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tsbIzalaz = new System.Windows.Forms.ToolStrip();
            this.tsbNovaVoznja = new System.Windows.Forms.ToolStripButton();
            this.tsbSpremiVozju = new System.Windows.Forms.ToolStripButton();
            this.tsbObrisiVoznju = new System.Windows.Forms.ToolStripButton();
            this.tsbIzlaz2 = new System.Windows.Forms.ToolStripButton();
            this.dgvVoznje = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPolaznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVoziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInstruktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPlaniranoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumStvarnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odrzanoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.instruktorTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.InstruktorTableAdapter();
            this.voznjaTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.VoznjaTableAdapter();
            this.mjestoTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.MjestoTableAdapter();
            this.polaznikTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.PolaznikTableAdapter();
            this.modelTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.ModelTableAdapter();
            this.fKVoznjaInstruktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instruktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstruktori)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voznjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrajanje)).BeginInit();
            this.tsbIzalaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoznje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVoznjaInstruktorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.cmbMjesto);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtAdresa);
            this.tabPage1.Controls.Add(this.TxtOIB);
            this.tabPage1.Controls.Add(this.TxtPrezime);
            this.tabPage1.Controls.Add(this.txtIme);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.dgvInstruktori);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Instruktori";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instruktorBindingSource, "idMjesto", true));
            this.comboBox4.DataSource = this.mjestoBindingSource;
            this.comboBox4.DisplayMember = "ID";
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(167, 220);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(105, 21);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.ValueMember = "ID";
            // 
            // instruktorBindingSource
            // 
            this.instruktorBindingSource.DataMember = "Instruktor";
            this.instruktorBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // autoskolaDataSet
            // 
            this.autoskolaDataSet.DataSetName = "AutoskolaDataSet";
            this.autoskolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mjestoBindingSource
            // 
            this.mjestoBindingSource.DataMember = "Mjesto";
            this.mjestoBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mjesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "OIB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.instruktorBindingSource, "DatumZaposlenja", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // cmbMjesto
            // 
            this.cmbMjesto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instruktorBindingSource, "idMjesto", true));
            this.cmbMjesto.DataSource = this.mjestoBindingSource;
            this.cmbMjesto.DisplayMember = "naziv";
            this.cmbMjesto.FormattingEnabled = true;
            this.cmbMjesto.Location = new System.Drawing.Point(72, 220);
            this.cmbMjesto.Name = "cmbMjesto";
            this.cmbMjesto.Size = new System.Drawing.Size(89, 21);
            this.cmbMjesto.TabIndex = 6;
            this.cmbMjesto.ValueMember = "ID";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instruktorBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(72, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Tag = "";
            // 
            // txtAdresa
            // 
            this.txtAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instruktorBindingSource, "Adresa", true));
            this.txtAdresa.Location = new System.Drawing.Point(72, 183);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(200, 20);
            this.txtAdresa.TabIndex = 4;
            this.txtAdresa.Tag = "";
            // 
            // TxtOIB
            // 
            this.TxtOIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instruktorBindingSource, "OIB", true));
            this.TxtOIB.Location = new System.Drawing.Point(72, 147);
            this.TxtOIB.Name = "TxtOIB";
            this.TxtOIB.Size = new System.Drawing.Size(200, 20);
            this.TxtOIB.TabIndex = 3;
            this.TxtOIB.Tag = "";
            this.TxtOIB.TextChanged += new System.EventHandler(this.TxtOIB_TextChanged);
            // 
            // TxtPrezime
            // 
            this.TxtPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instruktorBindingSource, "Prezime", true));
            this.TxtPrezime.Location = new System.Drawing.Point(72, 103);
            this.TxtPrezime.Name = "TxtPrezime";
            this.TxtPrezime.Size = new System.Drawing.Size(200, 20);
            this.TxtPrezime.TabIndex = 2;
            this.TxtPrezime.Tag = "";
            // 
            // txtIme
            // 
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instruktorBindingSource, "Ime", true));
            this.txtIme.Location = new System.Drawing.Point(72, 56);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 1;
            this.txtIme.Tag = "";
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovi,
            this.tsbSpremi,
            this.tsbIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1229, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbNovi
            // 
            this.tsbNovi.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovi.Image")));
            this.tsbNovi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovi.Name = "tsbNovi";
            this.tsbNovi.Size = new System.Drawing.Size(106, 22);
            this.tsbNovi.Text = "Novi instruktor";
            this.tsbNovi.Click += new System.EventHandler(this.tsbNovi_Click);
            // 
            // tsbSpremi
            // 
            this.tsbSpremi.Image = ((System.Drawing.Image)(resources.GetObject("tsbSpremi.Image")));
            this.tsbSpremi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSpremi.Name = "tsbSpremi";
            this.tsbSpremi.Size = new System.Drawing.Size(118, 22);
            this.tsbSpremi.Text = "Spremi promjene";
            this.tsbSpremi.Click += new System.EventHandler(this.tsbSpremi_Click);
            // 
            // tsbIzlaz
            // 
            this.tsbIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("tsbIzlaz.Image")));
            this.tsbIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIzlaz.Name = "tsbIzlaz";
            this.tsbIzlaz.Size = new System.Drawing.Size(49, 22);
            this.tsbIzlaz.Text = "Izlaz";
            this.tsbIzlaz.Click += new System.EventHandler(this.tsbIzlaz2_Click);
            // 
            // dgvInstruktori
            // 
            this.dgvInstruktori.AllowUserToAddRows = false;
            this.dgvInstruktori.AutoGenerateColumns = false;
            this.dgvInstruktori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstruktori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.OIB,
            this.Adresa,
            this.Mjesto,
            this.Zaposlenje,
            this.Email});
            this.dgvInstruktori.DataSource = this.instruktorBindingSource;
            this.dgvInstruktori.Location = new System.Drawing.Point(278, 31);
            this.dgvInstruktori.Name = "dgvInstruktori";
            this.dgvInstruktori.ReadOnly = true;
            this.dgvInstruktori.Size = new System.Drawing.Size(951, 442);
            this.dgvInstruktori.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // OIB
            // 
            this.OIB.DataPropertyName = "OIB";
            this.OIB.HeaderText = "OIB";
            this.OIB.Name = "OIB";
            this.OIB.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Mjesto
            // 
            this.Mjesto.DataPropertyName = "idMjesto";
            this.Mjesto.HeaderText = "Mjesto";
            this.Mjesto.Name = "Mjesto";
            this.Mjesto.ReadOnly = true;
            // 
            // Zaposlenje
            // 
            this.Zaposlenje.DataPropertyName = "DatumZaposlenja";
            this.Zaposlenje.HeaderText = "Datum Zaposlenja";
            this.Zaposlenje.Name = "Zaposlenje";
            this.Zaposlenje.ReadOnly = true;
            this.Zaposlenje.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.cibaOdrzano);
            this.tabPage2.Controls.Add(this.numTrajanje);
            this.tabPage2.Controls.Add(this.dateTimePicker3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.tsbIzalaz);
            this.tabPage2.Controls.Add(this.dgvVoznje);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Voznje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.voznjaBindingSource, "idInstruktor", true));
            this.comboBox3.DataSource = this.instruktorBindingSource;
            this.comboBox3.DisplayMember = "ID";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(125, 155);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 34;
            this.comboBox3.ValueMember = "ID";
            // 
            // voznjaBindingSource
            // 
            this.voznjaBindingSource.DataMember = "Voznja";
            this.voznjaBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.voznjaBindingSource, "idVozilo", true));
            this.comboBox2.DataSource = this.modelBindingSource;
            this.comboBox2.DisplayMember = "Naziv";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 33;
            this.comboBox2.ValueMember = "ID";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.voznjaBindingSource, "idPolaznik", true));
            this.comboBox1.DataSource = this.polaznikBindingSource;
            this.comboBox1.DisplayMember = "ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "ID";
            // 
            // polaznikBindingSource
            // 
            this.polaznikBindingSource.DataMember = "Polaznik";
            this.polaznikBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // cibaOdrzano
            // 
            this.cibaOdrzano.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voznjaBindingSource, "Odrzano", true));
            this.cibaOdrzano.Location = new System.Drawing.Point(125, 311);
            this.cibaOdrzano.Name = "cibaOdrzano";
            this.cibaOdrzano.Size = new System.Drawing.Size(200, 24);
            this.cibaOdrzano.TabIndex = 31;
            this.cibaOdrzano.Text = "Održana vožnja ";
            this.cibaOdrzano.UseVisualStyleBackColor = true;
            // 
            // numTrajanje
            // 
            this.numTrajanje.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.voznjaBindingSource, "Trajanje", true));
            this.numTrajanje.Location = new System.Drawing.Point(125, 263);
            this.numTrajanje.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numTrajanje.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrajanje.Name = "numTrajanje";
            this.numTrajanje.Size = new System.Drawing.Size(200, 20);
            this.numTrajanje.TabIndex = 30;
            this.numTrajanje.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.voznjaBindingSource, "DatumPlanirano", true));
            this.dateTimePicker3.Location = new System.Drawing.Point(125, 189);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Održano";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Trajanje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Održana vožnja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Planirana voznja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Instruktora";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "Vozilo ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Polaznika";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.voznjaBindingSource, "DatumStvarno", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(125, 227);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // tsbIzalaz
            // 
            this.tsbIzalaz.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovaVoznja,
            this.tsbSpremiVozju,
            this.tsbObrisiVoznju,
            this.tsbIzlaz2});
            this.tsbIzalaz.Location = new System.Drawing.Point(3, 3);
            this.tsbIzalaz.Name = "tsbIzalaz";
            this.tsbIzalaz.Size = new System.Drawing.Size(1229, 25);
            this.tsbIzalaz.TabIndex = 1;
            this.tsbIzalaz.Text = "toolStrip2";
            // 
            // tsbNovaVoznja
            // 
            this.tsbNovaVoznja.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovaVoznja.Image")));
            this.tsbNovaVoznja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovaVoznja.Name = "tsbNovaVoznja";
            this.tsbNovaVoznja.Size = new System.Drawing.Size(126, 22);
            this.tsbNovaVoznja.Text = "Dodaj novu vožnju";
            this.tsbNovaVoznja.Click += new System.EventHandler(this.tsbNovaVoznja_Click);
            // 
            // tsbSpremiVozju
            // 
            this.tsbSpremiVozju.Image = ((System.Drawing.Image)(resources.GetObject("tsbSpremiVozju.Image")));
            this.tsbSpremiVozju.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSpremiVozju.Name = "tsbSpremiVozju";
            this.tsbSpremiVozju.Size = new System.Drawing.Size(109, 22);
            this.tsbSpremiVozju.Text = "Spremni vožnju";
            this.tsbSpremiVozju.Click += new System.EventHandler(this.tsbSpremiVozju_Click);
            // 
            // tsbObrisiVoznju
            // 
            this.tsbObrisiVoznju.Image = ((System.Drawing.Image)(resources.GetObject("tsbObrisiVoznju.Image")));
            this.tsbObrisiVoznju.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbObrisiVoznju.Name = "tsbObrisiVoznju";
            this.tsbObrisiVoznju.Size = new System.Drawing.Size(96, 22);
            this.tsbObrisiVoznju.Text = "Obriši vožnju";
            this.tsbObrisiVoznju.Click += new System.EventHandler(this.tsbObrisiVoznju_Click);
            // 
            // tsbIzlaz2
            // 
            this.tsbIzlaz2.Image = ((System.Drawing.Image)(resources.GetObject("tsbIzlaz2.Image")));
            this.tsbIzlaz2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIzlaz2.Name = "tsbIzlaz2";
            this.tsbIzlaz2.Size = new System.Drawing.Size(49, 22);
            this.tsbIzlaz2.Text = "Izlaz";
            this.tsbIzlaz2.Click += new System.EventHandler(this.tsbIzalaz_Click);
            // 
            // dgvVoznje
            // 
            this.dgvVoznje.AllowUserToAddRows = false;
            this.dgvVoznje.AutoGenerateColumns = false;
            this.dgvVoznje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoznje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.idPolaznikDataGridViewTextBoxColumn,
            this.idVoziloDataGridViewTextBoxColumn,
            this.idInstruktorDataGridViewTextBoxColumn,
            this.datumPlaniranoDataGridViewTextBoxColumn,
            this.datumStvarnoDataGridViewTextBoxColumn,
            this.trajanjeDataGridViewTextBoxColumn,
            this.odrzanoDataGridViewCheckBoxColumn});
            this.dgvVoznje.DataSource = this.voznjaBindingSource;
            this.dgvVoznje.Location = new System.Drawing.Point(331, 31);
            this.dgvVoznje.Name = "dgvVoznje";
            this.dgvVoznje.ReadOnly = true;
            this.dgvVoznje.Size = new System.Drawing.Size(874, 450);
            this.dgvVoznje.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idPolaznikDataGridViewTextBoxColumn
            // 
            this.idPolaznikDataGridViewTextBoxColumn.DataPropertyName = "idPolaznik";
            this.idPolaznikDataGridViewTextBoxColumn.HeaderText = "Polaznik";
            this.idPolaznikDataGridViewTextBoxColumn.Name = "idPolaznikDataGridViewTextBoxColumn";
            this.idPolaznikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idVoziloDataGridViewTextBoxColumn
            // 
            this.idVoziloDataGridViewTextBoxColumn.DataPropertyName = "idVozilo";
            this.idVoziloDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.idVoziloDataGridViewTextBoxColumn.Name = "idVoziloDataGridViewTextBoxColumn";
            this.idVoziloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idInstruktorDataGridViewTextBoxColumn
            // 
            this.idInstruktorDataGridViewTextBoxColumn.DataPropertyName = "idInstruktor";
            this.idInstruktorDataGridViewTextBoxColumn.HeaderText = "Instruktor";
            this.idInstruktorDataGridViewTextBoxColumn.Name = "idInstruktorDataGridViewTextBoxColumn";
            this.idInstruktorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumPlaniranoDataGridViewTextBoxColumn
            // 
            this.datumPlaniranoDataGridViewTextBoxColumn.DataPropertyName = "DatumPlanirano";
            this.datumPlaniranoDataGridViewTextBoxColumn.HeaderText = "Datum planirano";
            this.datumPlaniranoDataGridViewTextBoxColumn.Name = "datumPlaniranoDataGridViewTextBoxColumn";
            this.datumPlaniranoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumPlaniranoDataGridViewTextBoxColumn.Width = 120;
            // 
            // datumStvarnoDataGridViewTextBoxColumn
            // 
            this.datumStvarnoDataGridViewTextBoxColumn.DataPropertyName = "DatumStvarno";
            this.datumStvarnoDataGridViewTextBoxColumn.HeaderText = "Datum stvarno";
            this.datumStvarnoDataGridViewTextBoxColumn.Name = "datumStvarnoDataGridViewTextBoxColumn";
            this.datumStvarnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            this.trajanjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odrzanoDataGridViewCheckBoxColumn
            // 
            this.odrzanoDataGridViewCheckBoxColumn.DataPropertyName = "Odrzano";
            this.odrzanoDataGridViewCheckBoxColumn.HeaderText = "Odrzano";
            this.odrzanoDataGridViewCheckBoxColumn.Name = "odrzanoDataGridViewCheckBoxColumn";
            this.odrzanoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // instruktorTableAdapter
            // 
            this.instruktorTableAdapter.ClearBeforeFill = true;
            // 
            // voznjaTableAdapter
            // 
            this.voznjaTableAdapter.ClearBeforeFill = true;
            // 
            // mjestoTableAdapter
            // 
            this.mjestoTableAdapter.ClearBeforeFill = true;
            // 
            // polaznikTableAdapter
            // 
            this.polaznikTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // fKVoznjaInstruktorBindingSource
            // 
            this.fKVoznjaInstruktorBindingSource.DataMember = "FK_Voznja_Instruktor";
            this.fKVoznjaInstruktorBindingSource.DataSource = this.instruktorBindingSource;
            // 
            // InstruktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 538);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstruktorForm";
            this.Text = "Instruktor";
            this.Load += new System.EventHandler(this.InstruktorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instruktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstruktori)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voznjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrajanje)).EndInit();
            this.tsbIzalaz.ResumeLayout(false);
            this.tsbIzalaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoznje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVoznjaInstruktorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AutoskolaDataSet autoskolaDataSet;
        private System.Windows.Forms.DataGridView dgvInstruktori;
        private System.Windows.Forms.BindingSource instruktorBindingSource;
        private AutoskolaDataSetTableAdapters.InstruktorTableAdapter instruktorTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dgvVoznje;
        private System.Windows.Forms.BindingSource voznjaBindingSource;
        private AutoskolaDataSetTableAdapters.VoznjaTableAdapter voznjaTableAdapter;
        private System.Windows.Forms.ToolStrip tsbIzalaz;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbMjesto;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox TxtOIB;
        private System.Windows.Forms.TextBox TxtPrezime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbNovi;
        private System.Windows.Forms.ToolStripButton tsbSpremi;
        private System.Windows.Forms.BindingSource mjestoBindingSource;
        private AutoskolaDataSetTableAdapters.MjestoTableAdapter mjestoTableAdapter;
        private System.Windows.Forms.CheckBox cibaOdrzano;
        private System.Windows.Forms.NumericUpDown numTrajanje;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource polaznikBindingSource;
        private AutoskolaDataSetTableAdapters.PolaznikTableAdapter polaznikTableAdapter;
        private System.Windows.Forms.ToolStripButton tsbNovaVoznja;
        private System.Windows.Forms.ToolStripButton tsbSpremiVozju;
        private System.Windows.Forms.ToolStripButton tsbObrisiVoznju;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private AutoskolaDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.ToolStripButton tsbIzlaz;
        private System.Windows.Forms.ToolStripButton tsbIzlaz2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource fKVoznjaInstruktorBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaposlenje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPolaznikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVoziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInstruktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPlaniranoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumStvarnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odrzanoDataGridViewCheckBoxColumn;
    }
}