namespace Projekt
{
    partial class pozivni_brojevi_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pozivni_brojevi_Form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPolaznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInstruktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoskolaDataSet = new Projekt.AutoskolaDataSet();
            this.telefonTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.TelefonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.idPolaznikDataGridViewTextBoxColumn,
            this.idInstruktorDataGridViewTextBoxColumn,
            this.brojDataGridViewTextBoxColumn,
            this.idVrstaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.telefonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // idPolaznikDataGridViewTextBoxColumn
            // 
            this.idPolaznikDataGridViewTextBoxColumn.DataPropertyName = "idPolaznik";
            this.idPolaznikDataGridViewTextBoxColumn.HeaderText = "Polaznik";
            this.idPolaznikDataGridViewTextBoxColumn.Name = "idPolaznikDataGridViewTextBoxColumn";
            // 
            // idInstruktorDataGridViewTextBoxColumn
            // 
            this.idInstruktorDataGridViewTextBoxColumn.DataPropertyName = "idInstruktor";
            this.idInstruktorDataGridViewTextBoxColumn.HeaderText = "Instruktor";
            this.idInstruktorDataGridViewTextBoxColumn.Name = "idInstruktorDataGridViewTextBoxColumn";
            // 
            // brojDataGridViewTextBoxColumn
            // 
            this.brojDataGridViewTextBoxColumn.DataPropertyName = "Broj";
            this.brojDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.brojDataGridViewTextBoxColumn.Name = "brojDataGridViewTextBoxColumn";
            // 
            // idVrstaDataGridViewTextBoxColumn
            // 
            this.idVrstaDataGridViewTextBoxColumn.DataPropertyName = "idVrsta";
            this.idVrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.idVrstaDataGridViewTextBoxColumn.Name = "idVrstaDataGridViewTextBoxColumn";
            // 
            // telefonBindingSource
            // 
            this.telefonBindingSource.DataMember = "Telefon";
            this.telefonBindingSource.DataSource = this.autoskolaDataSet;
            // 
            // autoskolaDataSet
            // 
            this.autoskolaDataSet.DataSetName = "AutoskolaDataSet";
            this.autoskolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefonTableAdapter
            // 
            this.telefonTableAdapter.ClearBeforeFill = true;
            // 
            // pozivni_brojevi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 261);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pozivni_brojevi_Form";
            this.Text = "Pozivni brojevi telefon";
            this.Load += new System.EventHandler(this.pozivni_brojevi_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoskolaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AutoskolaDataSet autoskolaDataSet;
        private System.Windows.Forms.BindingSource telefonBindingSource;
        private AutoskolaDataSetTableAdapters.TelefonTableAdapter telefonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPolaznikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInstruktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVrstaDataGridViewTextBoxColumn;
    }
}