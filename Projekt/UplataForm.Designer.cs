namespace Projekt
{
    partial class UplataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UplataForm));
            this.dgvUplata = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPolaznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoskolaDataSet = new Projekt.AutoskolaDataSet();
            this.uplataTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.UplataTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbUplata = new System.Windows.Forms.ToolStripButton();
            this.tsbSpremi = new System.Windows.Forms.ToolStripButton();
            this.tsbObirši = new System.Windows.Forms.ToolStripButton();
            this.tsbIzlaz = new System.Windows.Forms.ToolStripButton();
            this.tsbNovi = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.polaznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polaznikTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.PolaznikTableAdapter();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uplataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUplata
            // 
            this.dgvUplata.AllowUserToAddRows = false;
            this.dgvUplata.AutoGenerateColumns = false;
            this.dgvUplata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUplata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.idPolaznikDataGridViewTextBoxColumn,
            this.brojRateDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn});
            this.dgvUplata.DataSource = this.uplataBindingSource;
            this.dgvUplata.Location = new System.Drawing.Point(300, 28);
            this.dgvUplata.Name = "dgvUplata";
            this.dgvUplata.Size = new System.Drawing.Size(546, 426);
            this.dgvUplata.TabIndex = 0;
            this.dgvUplata.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvUplata_RowsAdded);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPolaznikDataGridViewTextBoxColumn
            // 
            this.idPolaznikDataGridViewTextBoxColumn.DataPropertyName = "idPolaznik";
            this.idPolaznikDataGridViewTextBoxColumn.HeaderText = "Polaznik";
            this.idPolaznikDataGridViewTextBoxColumn.Name = "idPolaznikDataGridViewTextBoxColumn";
            // 
            // brojRateDataGridViewTextBoxColumn
            // 
            this.brojRateDataGridViewTextBoxColumn.DataPropertyName = "BrojRate";
            this.brojRateDataGridViewTextBoxColumn.HeaderText = "Broj Rate";
            this.brojRateDataGridViewTextBoxColumn.Name = "brojRateDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "Iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "Iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            // 
            // uplataBindingSource
            // 
            this.uplataBindingSource.DataMember = "Uplata";
            this.uplataBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // autoskolaDataSet
            // 
            this.autoskolaDataSet.DataSetName = "AutoskolaDataSet";
            this.autoskolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uplataTableAdapter
            // 
            this.uplataTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUplata,
            this.tsbSpremi,
            this.tsbObirši,
            this.tsbIzlaz,
            this.tsbNovi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 48;
            // 
            // tsbUplata
            // 
            this.tsbUplata.Image = ((System.Drawing.Image)(resources.GetObject("tsbUplata.Image")));
            this.tsbUplata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUplata.Name = "tsbUplata";
            this.tsbUplata.Size = new System.Drawing.Size(125, 22);
            this.tsbUplata.Text = "Dodaj novu uplatu";
            this.tsbUplata.Click += new System.EventHandler(this.tsbUplata_Click);
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
            // tsbObirši
            // 
            this.tsbObirši.Image = ((System.Drawing.Image)(resources.GetObject("tsbObirši.Image")));
            this.tsbObirši.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbObirši.Name = "tsbObirši";
            this.tsbObirši.Size = new System.Drawing.Size(95, 22);
            this.tsbObirši.Text = "Obriši uplatu";
            this.tsbObirši.Click += new System.EventHandler(this.tsbObirši_Click);
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
            // tsbNovi
            // 
            this.tsbNovi.Name = "tsbNovi";
            this.tsbNovi.Size = new System.Drawing.Size(23, 22);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Broj rata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Odabir";
            // 
            // txtIznos
            // 
            this.txtIznos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uplataBindingSource, "Iznos", true));
            this.txtIznos.Location = new System.Drawing.Point(94, 267);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(200, 20);
            this.txtIznos.TabIndex = 52;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uplataBindingSource, "Datum", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uplataBindingSource, "BrojRate", true));
            this.numericUpDown1.Location = new System.Drawing.Point(94, 180);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 50;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uplataBindingSource, "idPolaznik", true));
            this.comboBox1.DataSource = this.polaznikBindingSource;
            this.comboBox1.DisplayMember = "ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.ValueMember = "ID";
            // 
            // polaznikBindingSource
            // 
            this.polaznikBindingSource.DataMember = "Polaznik";
            this.polaznikBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // polaznikTableAdapter
            // 
            this.polaznikTableAdapter.ClearBeforeFill = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(122, 366);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(99, 33);
            this.btnExport.TabIndex = 57;
            this.btnExport.Text = "Export u Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // UplataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 466);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvUplata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UplataForm";
            this.Text = "Uplata";
            this.Load += new System.EventHandler(this.UplataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uplataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUplata;
        private AutoskolaDataSet autoskolaDataSet;
        private System.Windows.Forms.BindingSource uplataBindingSource;
        private AutoskolaDataSetTableAdapters.UplataTableAdapter uplataTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovi;
        private System.Windows.Forms.ToolStripButton tsbSpremi;
        private System.Windows.Forms.ToolStripButton tsbObirši;
        private System.Windows.Forms.ToolStripButton tsbIzlaz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource polaznikBindingSource;
        private AutoskolaDataSetTableAdapters.PolaznikTableAdapter polaznikTableAdapter;
        private System.Windows.Forms.ToolStripButton tsbUplata;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPolaznikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
    }
}