namespace Projekt
{
    partial class StudentiNaPredavanju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentiNaPredavanju));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnObriši = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbDostupan = new System.Windows.Forms.CheckBox();
            this.polaznikPredavanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoskolaDataSet = new Projekt.AutoskolaDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.predavanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.polaznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPolaznikPredavanje = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPolaznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPredavanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisutanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.polaznikPredavanjeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.polaznikPredavanjeTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.PolaznikPredavanjeTableAdapter();
            this.polaznikTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.PolaznikTableAdapter();
            this.predavanjeTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.PredavanjeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikPredavanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predavanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolaznikPredavanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikPredavanjeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnObriši);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ckbDostupan);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSpremi);
            this.splitContainer1.Panel1.Controls.Add(this.btnDodaj);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPolaznikPredavanje);
            this.splitContainer1.Size = new System.Drawing.Size(876, 464);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnObriši
            // 
            this.btnObriši.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnObriši.Location = new System.Drawing.Point(72, 412);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(120, 40);
            this.btnObriši.TabIndex = 9;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = false;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odaberi prisutnost";
            // 
            // ckbDostupan
            // 
            this.ckbDostupan.AutoSize = true;
            this.ckbDostupan.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.polaznikPredavanjeBindingSource, "Prisutan", true));
            this.ckbDostupan.Location = new System.Drawing.Point(153, 204);
            this.ckbDostupan.Name = "ckbDostupan";
            this.ckbDostupan.Size = new System.Drawing.Size(78, 17);
            this.ckbDostupan.TabIndex = 7;
            this.ckbDostupan.Text = "Dostuapan";
            this.ckbDostupan.UseVisualStyleBackColor = true;
            // 
            // polaznikPredavanjeBindingSource
            // 
            this.polaznikPredavanjeBindingSource.DataMember = "PolaznikPredavanje";
            this.polaznikPredavanjeBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // autoskolaDataSet
            // 
            this.autoskolaDataSet.DataSetName = "AutoskolaDataSet";
            this.autoskolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odaberi predavanje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Biraj polaznika";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.polaznikPredavanjeBindingSource, "idPredavanje", true));
            this.comboBox2.DataSource = this.predavanjeBindingSource;
            this.comboBox2.DisplayMember = "ID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(153, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "ID";
            // 
            // predavanjeBindingSource
            // 
            this.predavanjeBindingSource.DataMember = "Predavanje";
            this.predavanjeBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.polaznikPredavanjeBindingSource, "idPolaznik", true));
            this.comboBox1.DataSource = this.polaznikBindingSource;
            this.comboBox1.DisplayMember = "ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ID";
            // 
            // polaznikBindingSource
            // 
            this.polaznikBindingSource.DataMember = "Polaznik";
            this.polaznikBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnSpremi.Location = new System.Drawing.Point(72, 352);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(120, 40);
            this.BtnSpremi.TabIndex = 2;
            this.BtnSpremi.Text = "Spremi";
            this.BtnSpremi.UseVisualStyleBackColor = false;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDodaj.Location = new System.Drawing.Point(72, 284);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 42);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Novi";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPolaznikPredavanje
            // 
            this.dgvPolaznikPredavanje.AllowUserToAddRows = false;
            this.dgvPolaznikPredavanje.AutoGenerateColumns = false;
            this.dgvPolaznikPredavanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolaznikPredavanje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.idPolaznikDataGridViewTextBoxColumn,
            this.idPredavanjeDataGridViewTextBoxColumn,
            this.prisutanDataGridViewCheckBoxColumn});
            this.dgvPolaznikPredavanje.DataSource = this.polaznikPredavanjeBindingSource;
            this.dgvPolaznikPredavanje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPolaznikPredavanje.Location = new System.Drawing.Point(0, 0);
            this.dgvPolaznikPredavanje.Name = "dgvPolaznikPredavanje";
            this.dgvPolaznikPredavanje.Size = new System.Drawing.Size(581, 464);
            this.dgvPolaznikPredavanje.TabIndex = 0;
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
            this.idPolaznikDataGridViewTextBoxColumn.Width = 150;
            // 
            // idPredavanjeDataGridViewTextBoxColumn
            // 
            this.idPredavanjeDataGridViewTextBoxColumn.DataPropertyName = "idPredavanje";
            this.idPredavanjeDataGridViewTextBoxColumn.HeaderText = "Predavanje";
            this.idPredavanjeDataGridViewTextBoxColumn.Name = "idPredavanjeDataGridViewTextBoxColumn";
            this.idPredavanjeDataGridViewTextBoxColumn.Width = 150;
            // 
            // prisutanDataGridViewCheckBoxColumn
            // 
            this.prisutanDataGridViewCheckBoxColumn.DataPropertyName = "Prisutan";
            this.prisutanDataGridViewCheckBoxColumn.HeaderText = "Prisutan";
            this.prisutanDataGridViewCheckBoxColumn.Name = "prisutanDataGridViewCheckBoxColumn";
            this.prisutanDataGridViewCheckBoxColumn.Width = 150;
            // 
            // polaznikPredavanjeBindingSource1
            // 
            this.polaznikPredavanjeBindingSource1.DataMember = "PolaznikPredavanje";
            this.polaznikPredavanjeBindingSource1.DataSource = this.autoskolaDataSet;
            // 
            // polaznikPredavanjeTableAdapter
            // 
            this.polaznikPredavanjeTableAdapter.ClearBeforeFill = true;
            // 
            // polaznikTableAdapter
            // 
            this.polaznikTableAdapter.ClearBeforeFill = true;
            // 
            // predavanjeTableAdapter
            // 
            this.predavanjeTableAdapter.ClearBeforeFill = true;
            // 
            // StudentiNaPredavanju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 464);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentiNaPredavanju";
            this.Text = "Studenti Na Predavanju";
            this.Load += new System.EventHandler(this.StudentiNaPredavanju_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.polaznikPredavanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predavanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolaznikPredavanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polaznikPredavanjeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPolaznikPredavanje;
        private AutoskolaDataSet autoskolaDataSet;
        private System.Windows.Forms.BindingSource polaznikPredavanjeBindingSource;
        private AutoskolaDataSetTableAdapters.PolaznikPredavanjeTableAdapter polaznikPredavanjeTableAdapter;
        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbDostupan;
        private System.Windows.Forms.BindingSource polaznikBindingSource;
        private AutoskolaDataSetTableAdapters.PolaznikTableAdapter polaznikTableAdapter;
        private System.Windows.Forms.BindingSource polaznikPredavanjeBindingSource1;
        private System.Windows.Forms.BindingSource predavanjeBindingSource;
        private AutoskolaDataSetTableAdapters.PredavanjeTableAdapter predavanjeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPolaznikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPredavanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prisutanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnObriši;
    }
}