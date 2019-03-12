namespace Projekt
{
    partial class PolazniciForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolazniciForm1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovi = new System.Windows.Forms.ToolStripButton();
            this.tsbSpremi = new System.Windows.Forms.ToolStripButton();
            this.tsbUplate = new System.Windows.Forms.ToolStripButton();
            this.tsbIsključi = new System.Windows.Forms.ToolStripButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.polaznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoskolaDataSet = new Projekt.AutoskolaDataSet();
            this.dtpdatum = new System.Windows.Forms.DateTimePicker();
            this.txtBrojOsobne = new System.Windows.Forms.TextBox();
            this.cmbIDMJESTO = new System.Windows.Forms.ComboBox();
            this.mjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbImeMjesta = new System.Windows.Forms.ComboBox();
            this.txtadresa = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPolaznicifoma = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojosobneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbZamjenik = new System.Windows.Forms.ComboBox();
            this.predavanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instruktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbInstruktor = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cmbUciona = new System.Windows.Forms.ComboBox();
            this.ucionicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDatumPredavanja = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbNoviTermin = new System.Windows.Forms.ToolStripButton();
            this.tsbSpremiPredavanje = new System.Windows.Forms.ToolStripButton();
            this.tsbPrikazUčiona = new System.Windows.Forms.ToolStripButton();
            this.tsbPredavanje = new System.Windows.Forms.ToolStripButton();
            this.tsbIzlaz = new System.Windows.Forms.ToolStripButton();
            this.dgvPredavanja = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUcionicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redniBrojSataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInstruktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZamjenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polaznikTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.PolaznikTableAdapter();
            this.mjestoTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.MjestoTableAdapter();
            this.predavanjeTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.PredavanjeTableAdapter();
            this.ucionicaTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.UcionicaTableAdapter();
            this.fKPolaznikPredavanjePredavanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polaznikPredavanjeTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.PolaznikPredavanjeTableAdapter();
            this.lokacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokacijaTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.LokacijaTableAdapter();
            this.instruktorTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.InstruktorTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolaznicifoma)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predavanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucionicaBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredavanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPolaznikPredavanjePredavanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1440, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.dtpdatum);
            this.tabPage1.Controls.Add(this.txtBrojOsobne);
            this.tabPage1.Controls.Add(this.cmbIDMJESTO);
            this.tabPage1.Controls.Add(this.cmbImeMjesta);
            this.tabPage1.Controls.Add(this.txtadresa);
            this.tabPage1.Controls.Add(this.txtOIB);
            this.tabPage1.Controls.Add(this.txtPrezime);
            this.tabPage1.Controls.Add(this.txtIme);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvPolaznicifoma);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1432, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Polaznici";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovi,
            this.tsbSpremi,
            this.tsbUplate,
            this.tsbIsključi});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1426, 25);
            this.toolStrip1.TabIndex = 52;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovi
            // 
            this.tsbNovi.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovi.Image")));
            this.tsbNovi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovi.Name = "tsbNovi";
            this.tsbNovi.Size = new System.Drawing.Size(99, 22);
            this.tsbNovi.Text = "Novi polaznik";
            this.tsbNovi.Click += new System.EventHandler(this.tsbNovi_Click);
            // 
            // tsbSpremi
            // 
            this.tsbSpremi.Image = ((System.Drawing.Image)(resources.GetObject("tsbSpremi.Image")));
            this.tsbSpremi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSpremi.Name = "tsbSpremi";
            this.tsbSpremi.Size = new System.Drawing.Size(64, 22);
            this.tsbSpremi.Text = "Spremi";
            this.tsbSpremi.Click += new System.EventHandler(this.tsbSpremi_Click);
            // 
            // tsbUplate
            // 
            this.tsbUplate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUplate.Image")));
            this.tsbUplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUplate.Name = "tsbUplate";
            this.tsbUplate.Size = new System.Drawing.Size(61, 22);
            this.tsbUplate.Text = "Uplate";
            this.tsbUplate.Click += new System.EventHandler(this.tsbUplate_Click);
            // 
            // tsbIsključi
            // 
            this.tsbIsključi.Image = ((System.Drawing.Image)(resources.GetObject("tsbIsključi.Image")));
            this.tsbIsključi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIsključi.Name = "tsbIsključi";
            this.tsbIsključi.Size = new System.Drawing.Size(51, 22);
            this.tsbIsključi.Text = "Izađi";
            this.tsbIsključi.Click += new System.EventHandler(this.tsbIsključi_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.polaznikBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(202, 368);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 51;
            // 
            // polaznikBindingSource
            // 
            this.polaznikBindingSource.DataMember = "Polaznik";
            this.polaznikBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // autoskolaDataSet
            // 
            this.autoskolaDataSet.DataSetName = "AutoskolaDataSet";
            this.autoskolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpdatum
            // 
            this.dtpdatum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.polaznikBindingSource, "DatumRodenja", true));
            this.dtpdatum.Location = new System.Drawing.Point(202, 325);
            this.dtpdatum.Name = "dtpdatum";
            this.dtpdatum.Size = new System.Drawing.Size(200, 20);
            this.dtpdatum.TabIndex = 50;
            // 
            // txtBrojOsobne
            // 
            this.txtBrojOsobne.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.polaznikBindingSource, "Brojosobne", true));
            this.txtBrojOsobne.Location = new System.Drawing.Point(202, 292);
            this.txtBrojOsobne.Name = "txtBrojOsobne";
            this.txtBrojOsobne.Size = new System.Drawing.Size(200, 20);
            this.txtBrojOsobne.TabIndex = 49;
            this.txtBrojOsobne.TextChanged += new System.EventHandler(this.txtBrojOsobne_TextChanged);
            // 
            // cmbIDMJESTO
            // 
            this.cmbIDMJESTO.DataSource = this.mjestoBindingSource;
            this.cmbIDMJESTO.DisplayMember = "ID";
            this.cmbIDMJESTO.Enabled = false;
            this.cmbIDMJESTO.FormattingEnabled = true;
            this.cmbIDMJESTO.Location = new System.Drawing.Point(322, 244);
            this.cmbIDMJESTO.Name = "cmbIDMJESTO";
            this.cmbIDMJESTO.Size = new System.Drawing.Size(80, 21);
            this.cmbIDMJESTO.TabIndex = 48;
            this.cmbIDMJESTO.ValueMember = "ID";
            // 
            // mjestoBindingSource
            // 
            this.mjestoBindingSource.DataMember = "Mjesto";
            this.mjestoBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // cmbImeMjesta
            // 
            this.cmbImeMjesta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.polaznikBindingSource, "idMjesto", true));
            this.cmbImeMjesta.DataSource = this.mjestoBindingSource;
            this.cmbImeMjesta.DisplayMember = "naziv";
            this.cmbImeMjesta.FormattingEnabled = true;
            this.cmbImeMjesta.Location = new System.Drawing.Point(202, 244);
            this.cmbImeMjesta.Name = "cmbImeMjesta";
            this.cmbImeMjesta.Size = new System.Drawing.Size(114, 21);
            this.cmbImeMjesta.TabIndex = 47;
            this.cmbImeMjesta.ValueMember = "ID";
            // 
            // txtadresa
            // 
            this.txtadresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.polaznikBindingSource, "adresa", true));
            this.txtadresa.Location = new System.Drawing.Point(202, 205);
            this.txtadresa.Name = "txtadresa";
            this.txtadresa.Size = new System.Drawing.Size(200, 20);
            this.txtadresa.TabIndex = 46;
            // 
            // txtOIB
            // 
            this.txtOIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.polaznikBindingSource, "OIB", true));
            this.txtOIB.Location = new System.Drawing.Point(202, 157);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(200, 20);
            this.txtOIB.TabIndex = 45;
            this.txtOIB.TextChanged += new System.EventHandler(this.txtOIB_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.polaznikBindingSource, "Prezime", true));
            this.txtPrezime.Location = new System.Drawing.Point(202, 111);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtPrezime.TabIndex = 44;
            // 
            // txtIme
            // 
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.polaznikBindingSource, "Ime", true));
            this.txtIme.Location = new System.Drawing.Point(202, 59);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 43;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(28, 370);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 18);
            this.label22.TabIndex = 42;
            this.label22.Text = "Email";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(28, 328);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 18);
            this.label21.TabIndex = 41;
            this.label21.Text = "Datum rođenja";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(28, 291);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 18);
            this.label20.TabIndex = 40;
            this.label20.Text = "Broj osobne";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(28, 248);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 18);
            this.label19.TabIndex = 39;
            this.label19.Text = "Mjesto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(27, 204);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 18);
            this.label18.TabIndex = 38;
            this.label18.Text = "Adresa";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 18);
            this.label16.TabIndex = 37;
            this.label16.Text = "OIB polaznika";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "Prezime polaznika";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ime polaznika";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 27;
            // 
            // dgvPolaznicifoma
            // 
            this.dgvPolaznicifoma.AllowUserToAddRows = false;
            this.dgvPolaznicifoma.AutoGenerateColumns = false;
            this.dgvPolaznicifoma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolaznicifoma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.brojosobneDataGridViewTextBoxColumn,
            this.datumRodenjaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvPolaznicifoma.DataSource = this.polaznikBindingSource;
            this.dgvPolaznicifoma.Location = new System.Drawing.Point(411, 36);
            this.dgvPolaznicifoma.Name = "dgvPolaznicifoma";
            this.dgvPolaznicifoma.Size = new System.Drawing.Size(1006, 429);
            this.dgvPolaznicifoma.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // brojosobneDataGridViewTextBoxColumn
            // 
            this.brojosobneDataGridViewTextBoxColumn.DataPropertyName = "Brojosobne";
            this.brojosobneDataGridViewTextBoxColumn.HeaderText = "Broj osobne";
            this.brojosobneDataGridViewTextBoxColumn.Name = "brojosobneDataGridViewTextBoxColumn";
            // 
            // datumRodenjaDataGridViewTextBoxColumn
            // 
            this.datumRodenjaDataGridViewTextBoxColumn.DataPropertyName = "DatumRodenja";
            this.datumRodenjaDataGridViewTextBoxColumn.HeaderText = "Datum Rodenja";
            this.datumRodenjaDataGridViewTextBoxColumn.Name = "datumRodenjaDataGridViewTextBoxColumn";
            this.datumRodenjaDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbZamjenik);
            this.tabPage2.Controls.Add(this.cmbInstruktor);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.txtOpis);
            this.tabPage2.Controls.Add(this.cmbUciona);
            this.tabPage2.Controls.Add(this.dtpDatumPredavanja);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Controls.Add(this.dgvPredavanja);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1432, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Predavanja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbZamjenik
            // 
            this.cmbZamjenik.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.predavanjeBindingSource, "idZamjenik", true));
            this.cmbZamjenik.DataSource = this.instruktorBindingSource;
            this.cmbZamjenik.DisplayMember = "ID";
            this.cmbZamjenik.FormattingEnabled = true;
            this.cmbZamjenik.Location = new System.Drawing.Point(167, 286);
            this.cmbZamjenik.Name = "cmbZamjenik";
            this.cmbZamjenik.Size = new System.Drawing.Size(200, 21);
            this.cmbZamjenik.TabIndex = 49;
            this.cmbZamjenik.ValueMember = "ID";
            // 
            // predavanjeBindingSource
            // 
            this.predavanjeBindingSource.DataMember = "Predavanje";
            this.predavanjeBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // instruktorBindingSource
            // 
            this.instruktorBindingSource.DataMember = "Instruktor";
            this.instruktorBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // cmbInstruktor
            // 
            this.cmbInstruktor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.predavanjeBindingSource, "idInstruktor", true));
            this.cmbInstruktor.DataSource = this.instruktorBindingSource;
            this.cmbInstruktor.DisplayMember = "ID";
            this.cmbInstruktor.FormattingEnabled = true;
            this.cmbInstruktor.Location = new System.Drawing.Point(167, 241);
            this.cmbInstruktor.Name = "cmbInstruktor";
            this.cmbInstruktor.Size = new System.Drawing.Size(200, 21);
            this.cmbInstruktor.TabIndex = 48;
            this.cmbInstruktor.ValueMember = "ID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.predavanjeBindingSource, "RedniBrojSata", true));
            this.numericUpDown1.InterceptArrowKeys = false;
            this.numericUpDown1.Location = new System.Drawing.Point(167, 202);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 47;
            this.numericUpDown1.TabStop = false;
            // 
            // txtOpis
            // 
            this.txtOpis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.predavanjeBindingSource, "Opis", true));
            this.txtOpis.Location = new System.Drawing.Point(167, 163);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(200, 20);
            this.txtOpis.TabIndex = 46;
            this.txtOpis.TextChanged += new System.EventHandler(this.txtOpis_TextChanged);
            // 
            // cmbUciona
            // 
            this.cmbUciona.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.predavanjeBindingSource, "idUcionica", true));
            this.cmbUciona.DataSource = this.ucionicaBindingSource;
            this.cmbUciona.DisplayMember = "Naziv";
            this.cmbUciona.FormattingEnabled = true;
            this.cmbUciona.Location = new System.Drawing.Point(167, 119);
            this.cmbUciona.Name = "cmbUciona";
            this.cmbUciona.Size = new System.Drawing.Size(200, 21);
            this.cmbUciona.TabIndex = 45;
            this.cmbUciona.ValueMember = "ID";
            // 
            // ucionicaBindingSource
            // 
            this.ucionicaBindingSource.DataMember = "Ucionica";
            this.ucionicaBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // dtpDatumPredavanja
            // 
            this.dtpDatumPredavanja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.predavanjeBindingSource, "Datum", true));
            this.dtpDatumPredavanja.Location = new System.Drawing.Point(167, 78);
            this.dtpDatumPredavanja.Name = "dtpDatumPredavanja";
            this.dtpDatumPredavanja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumPredavanja.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 18);
            this.label13.TabIndex = 43;
            this.label13.Text = "Zamjenik";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 42;
            this.label14.Text = "Instruktor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 18);
            this.label17.TabIndex = 41;
            this.label17.Text = "Trajanje";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Datum predavanja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 18);
            this.label12.TabIndex = 39;
            this.label12.Text = "Učiona";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 18);
            this.label15.TabIndex = 38;
            this.label15.Text = "Opis predavanja";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNoviTermin,
            this.tsbSpremiPredavanje,
            this.tsbPrikazUčiona,
            this.tsbPredavanje,
            this.tsbIzlaz});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1426, 25);
            this.toolStrip2.TabIndex = 17;
            // 
            // tsbNoviTermin
            // 
            this.tsbNoviTermin.Image = ((System.Drawing.Image)(resources.GetObject("tsbNoviTermin.Image")));
            this.tsbNoviTermin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNoviTermin.Name = "tsbNoviTermin";
            this.tsbNoviTermin.Size = new System.Drawing.Size(151, 22);
            this.tsbNoviTermin.Text = "Novi termin predavanja";
            this.tsbNoviTermin.Click += new System.EventHandler(this.tsbNoviTermin_Click);
            // 
            // tsbSpremiPredavanje
            // 
            this.tsbSpremiPredavanje.Image = ((System.Drawing.Image)(resources.GetObject("tsbSpremiPredavanje.Image")));
            this.tsbSpremiPredavanje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSpremiPredavanje.Name = "tsbSpremiPredavanje";
            this.tsbSpremiPredavanje.Size = new System.Drawing.Size(118, 22);
            this.tsbSpremiPredavanje.Text = "Spremi promjene";
            this.tsbSpremiPredavanje.Click += new System.EventHandler(this.tsbSpremiPredavanje_Click);
            // 
            // tsbPrikazUčiona
            // 
            this.tsbPrikazUčiona.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrikazUčiona.Image")));
            this.tsbPrikazUčiona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrikazUčiona.Name = "tsbPrikazUčiona";
            this.tsbPrikazUčiona.Size = new System.Drawing.Size(95, 22);
            this.tsbPrikazUčiona.Text = "Popis učiona";
            this.tsbPrikazUčiona.Click += new System.EventHandler(this.tsbPrikazUčiona_Click);
            // 
            // tsbPredavanje
            // 
            this.tsbPredavanje.Image = ((System.Drawing.Image)(resources.GetObject("tsbPredavanje.Image")));
            this.tsbPredavanje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPredavanje.Name = "tsbPredavanje";
            this.tsbPredavanje.Size = new System.Drawing.Size(184, 22);
            this.tsbPredavanje.Text = "Dodaj studenta na predavanje";
            this.tsbPredavanje.Click += new System.EventHandler(this.tsbPredavanje_Click);
            // 
            // tsbIzlaz
            // 
            this.tsbIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("tsbIzlaz.Image")));
            this.tsbIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIzlaz.Name = "tsbIzlaz";
            this.tsbIzlaz.Size = new System.Drawing.Size(49, 22);
            this.tsbIzlaz.Text = "Izlaz";
            this.tsbIzlaz.Click += new System.EventHandler(this.tsbIzlaz_Click);
            // 
            // dgvPredavanja
            // 
            this.dgvPredavanja.AllowUserToAddRows = false;
            this.dgvPredavanja.AutoGenerateColumns = false;
            this.dgvPredavanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredavanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.datumDataGridViewTextBoxColumn,
            this.idUcionicaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.redniBrojSataDataGridViewTextBoxColumn,
            this.idInstruktorDataGridViewTextBoxColumn,
            this.idZamjenikDataGridViewTextBoxColumn});
            this.dgvPredavanja.DataSource = this.predavanjeBindingSource;
            this.dgvPredavanja.Location = new System.Drawing.Point(389, 40);
            this.dgvPredavanja.Name = "dgvPredavanja";
            this.dgvPredavanja.Size = new System.Drawing.Size(1009, 452);
            this.dgvPredavanja.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 150;
            // 
            // idUcionicaDataGridViewTextBoxColumn
            // 
            this.idUcionicaDataGridViewTextBoxColumn.DataPropertyName = "idUcionica";
            this.idUcionicaDataGridViewTextBoxColumn.HeaderText = "Ucionica";
            this.idUcionicaDataGridViewTextBoxColumn.Name = "idUcionicaDataGridViewTextBoxColumn";
            this.idUcionicaDataGridViewTextBoxColumn.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 200;
            // 
            // redniBrojSataDataGridViewTextBoxColumn
            // 
            this.redniBrojSataDataGridViewTextBoxColumn.DataPropertyName = "RedniBrojSata";
            this.redniBrojSataDataGridViewTextBoxColumn.HeaderText = "Redni Broj Sata";
            this.redniBrojSataDataGridViewTextBoxColumn.Name = "redniBrojSataDataGridViewTextBoxColumn";
            this.redniBrojSataDataGridViewTextBoxColumn.Width = 150;
            // 
            // idInstruktorDataGridViewTextBoxColumn
            // 
            this.idInstruktorDataGridViewTextBoxColumn.DataPropertyName = "idInstruktor";
            this.idInstruktorDataGridViewTextBoxColumn.HeaderText = "Instruktor";
            this.idInstruktorDataGridViewTextBoxColumn.Name = "idInstruktorDataGridViewTextBoxColumn";
            // 
            // idZamjenikDataGridViewTextBoxColumn
            // 
            this.idZamjenikDataGridViewTextBoxColumn.DataPropertyName = "idZamjenik";
            this.idZamjenikDataGridViewTextBoxColumn.HeaderText = "Zamjenik";
            this.idZamjenikDataGridViewTextBoxColumn.Name = "idZamjenikDataGridViewTextBoxColumn";
            // 
            // polaznikTableAdapter
            // 
            this.polaznikTableAdapter.ClearBeforeFill = true;
            // 
            // mjestoTableAdapter
            // 
            this.mjestoTableAdapter.ClearBeforeFill = true;
            // 
            // predavanjeTableAdapter
            // 
            this.predavanjeTableAdapter.ClearBeforeFill = true;
            // 
            // ucionicaTableAdapter
            // 
            this.ucionicaTableAdapter.ClearBeforeFill = true;
            // 
            // fKPolaznikPredavanjePredavanjeBindingSource
            // 
            this.fKPolaznikPredavanjePredavanjeBindingSource.DataMember = "FK_PolaznikPredavanje_Predavanje";
            this.fKPolaznikPredavanjePredavanjeBindingSource.DataSource = this.predavanjeBindingSource;
            // 
            // polaznikPredavanjeTableAdapter
            // 
            this.polaznikPredavanjeTableAdapter.ClearBeforeFill = true;
            // 
            // lokacijaBindingSource
            // 
            this.lokacijaBindingSource.DataMember = "Lokacija";
            this.lokacijaBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // lokacijaTableAdapter
            // 
            this.lokacijaTableAdapter.ClearBeforeFill = true;
            // 
            // instruktorTableAdapter
            // 
            this.instruktorTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // PolazniciForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 534);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PolazniciForm1";
            this.Text = "Polaznici podaci";
            this.Load += new System.EventHandler(this.PolazniciForm1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolaznicifoma)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predavanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucionicaBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredavanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPolaznikPredavanjePredavanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPolaznicifoma;
        private AutoskolaDataSet autoskolaDataSet;
        private System.Windows.Forms.BindingSource polaznikBindingSource;
        private AutoskolaDataSetTableAdapters.PolaznikTableAdapter polaznikTableAdapter;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpdatum;
        private System.Windows.Forms.TextBox txtBrojOsobne;
        private System.Windows.Forms.ComboBox cmbIDMJESTO;
        private System.Windows.Forms.ComboBox cmbImeMjesta;
        private System.Windows.Forms.TextBox txtadresa;
        private System.Windows.Forms.BindingSource mjestoBindingSource;
        private AutoskolaDataSetTableAdapters.MjestoTableAdapter mjestoTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovi;
        private System.Windows.Forms.ToolStripButton tsbSpremi;
        private System.Windows.Forms.ToolStripButton tsbIsključi;
        private System.Windows.Forms.DataGridView dgvPredavanja;
        private System.Windows.Forms.BindingSource predavanjeBindingSource;
        private AutoskolaDataSetTableAdapters.PredavanjeTableAdapter predavanjeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUcionicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn redniBrojSataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInstruktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZamjenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbNoviTermin;
        private System.Windows.Forms.ToolStripButton tsbSpremiPredavanje;
        private System.Windows.Forms.ToolStripButton tsbPrikazUčiona;
        private System.Windows.Forms.ToolStripButton tsbPredavanje;
        private System.Windows.Forms.ToolStripButton tsbIzlaz;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cmbUciona;
        private System.Windows.Forms.DateTimePicker dtpDatumPredavanja;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbZamjenik;
        private System.Windows.Forms.ComboBox cmbInstruktor;
        private System.Windows.Forms.BindingSource ucionicaBindingSource;
        private AutoskolaDataSetTableAdapters.UcionicaTableAdapter ucionicaTableAdapter;
        private System.Windows.Forms.BindingSource fKPolaznikPredavanjePredavanjeBindingSource;
        private AutoskolaDataSetTableAdapters.PolaznikPredavanjeTableAdapter polaznikPredavanjeTableAdapter;
        private System.Windows.Forms.BindingSource lokacijaBindingSource;
        private AutoskolaDataSetTableAdapters.LokacijaTableAdapter lokacijaTableAdapter;
        private System.Windows.Forms.BindingSource instruktorBindingSource;
        private AutoskolaDataSetTableAdapters.InstruktorTableAdapter instruktorTableAdapter;
        private System.Windows.Forms.ToolStripButton tsbUplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojosobneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRodenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}