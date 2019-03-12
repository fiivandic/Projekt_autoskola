namespace Projekt
{
    partial class UcionaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcionaForm));
            this.autoskolaDataSet = new Projekt.AutoskolaDataSet();
            this.dgvUciona = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLokacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojMjestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucionicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucionicaTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.UcionicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUciona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucionicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autoskolaDataSet
            // 
            this.autoskolaDataSet.DataSetName = "AutoskolaDataSet";
            this.autoskolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvUciona
            // 
            this.dgvUciona.AllowUserToAddRows = false;
            this.dgvUciona.AutoGenerateColumns = false;
            this.dgvUciona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUciona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.idLokacijaDataGridViewTextBoxColumn,
            this.brojMjestaDataGridViewTextBoxColumn});
            this.dgvUciona.DataSource = this.ucionicaBindingSource;
            this.dgvUciona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUciona.Location = new System.Drawing.Point(0, 0);
            this.dgvUciona.Name = "dgvUciona";
            this.dgvUciona.Size = new System.Drawing.Size(466, 435);
            this.dgvUciona.TabIndex = 0;
            this.dgvUciona.DoubleClick += new System.EventHandler(this.dgvUciona_DoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // idLokacijaDataGridViewTextBoxColumn
            // 
            this.idLokacijaDataGridViewTextBoxColumn.DataPropertyName = "idLokacija";
            this.idLokacijaDataGridViewTextBoxColumn.HeaderText = "Lokacija";
            this.idLokacijaDataGridViewTextBoxColumn.Name = "idLokacijaDataGridViewTextBoxColumn";
            // 
            // brojMjestaDataGridViewTextBoxColumn
            // 
            this.brojMjestaDataGridViewTextBoxColumn.DataPropertyName = "BrojMjesta";
            this.brojMjestaDataGridViewTextBoxColumn.HeaderText = "Broj Mjesta";
            this.brojMjestaDataGridViewTextBoxColumn.Name = "brojMjestaDataGridViewTextBoxColumn";
            // 
            // ucionicaBindingSource
            // 
            this.ucionicaBindingSource.DataMember = "Ucionica";
            this.ucionicaBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // ucionicaTableAdapter
            // 
            this.ucionicaTableAdapter.ClearBeforeFill = true;
            // 
            // UcionaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 435);
            this.Controls.Add(this.dgvUciona);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UcionaForm";
            this.Text = "Uciona";
            this.Load += new System.EventHandler(this.UcionaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUciona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucionicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AutoskolaDataSet autoskolaDataSet;
        private System.Windows.Forms.DataGridView dgvUciona;
        private System.Windows.Forms.BindingSource ucionicaBindingSource;
        private AutoskolaDataSetTableAdapters.UcionicaTableAdapter ucionicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLokacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojMjestaDataGridViewTextBoxColumn;
    }
}