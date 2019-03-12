namespace Projekt
{
    partial class IzvjestajiForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InstruktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AutoskolaDataSet = new Projekt.AutoskolaDataSet();
            this.VoznjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PredavanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VoziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UplataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InstruktorTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.InstruktorTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VoznjaTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.VoznjaTableAdapter();
            this.PolaznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PolaznikTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.PolaznikTableAdapter();
            this.UplataTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.UplataTableAdapter();
            this.PredavanjeTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.PredavanjeTableAdapter();
            this.VoziloTableAdapter = new Projekt.AutoskolaDataSetTableAdapters.VoziloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InstruktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoskolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoznjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredavanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UplataBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PolaznikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InstruktorBindingSource
            // 
            this.InstruktorBindingSource.DataMember = "Instruktor";
            this.InstruktorBindingSource.DataSource = this.AutoskolaDataSet;
            // 
            // AutoskolaDataSet
            // 
            this.AutoskolaDataSet.DataSetName = "AutoskolaDataSet";
            this.AutoskolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VoznjaBindingSource
            // 
            this.VoznjaBindingSource.DataMember = "Voznja";
            this.VoznjaBindingSource.DataSource = this.AutoskolaDataSet;
            // 
            // PredavanjeBindingSource
            // 
            this.PredavanjeBindingSource.DataMember = "Predavanje";
            this.PredavanjeBindingSource.DataSource = this.AutoskolaDataSet;
            // 
            // VoziloBindingSource
            // 
            this.VoziloBindingSource.DataMember = "Vozilo";
            this.VoziloBindingSource.DataSource = this.AutoskolaDataSet;
            // 
            // UplataBindingSource
            // 
            this.UplataBindingSource.DataMember = "Uplata";
            this.UplataBindingSource.DataSource = this.AutoskolaDataSet;
            // 
            // InstruktorTableAdapter
            // 
            this.InstruktorTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 740);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 714);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Instruktori";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "InstruktorDataSet";
            reportDataSource1.Value = this.InstruktorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projekt.Instruktori.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1016, 679);
            this.reportViewer1.TabIndex = 0;
           
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 714);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statistika o vožnji";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "VoznjaDataSet";
            reportDataSource2.Value = this.VoznjaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Projekt.Voznje.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1013, 631);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1012, 714);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Polaznici";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "PolaznikDataSet";
            reportDataSource3.Value = this.PredavanjeBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Projekt.Polaznici.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(1012, 617);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1012, 714);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vozila";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource4.Name = "Vozila";
            reportDataSource4.Value = this.VoziloBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Projekt.Vozila.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(-4, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(1013, 730);
            this.reportViewer4.TabIndex = 0;
            // 
            // VoznjaTableAdapter
            // 
            this.VoznjaTableAdapter.ClearBeforeFill = true;
            // 
            // PolaznikBindingSource
            // 
            this.PolaznikBindingSource.DataMember = "Polaznik";
            this.PolaznikBindingSource.DataSource = this.AutoskolaDataSet;
            // 
            // PolaznikTableAdapter
            // 
            this.PolaznikTableAdapter.ClearBeforeFill = true;
            // 
            // UplataTableAdapter
            // 
            this.UplataTableAdapter.ClearBeforeFill = true;
            // 
            // PredavanjeTableAdapter
            // 
            this.PredavanjeTableAdapter.ClearBeforeFill = true;
            // 
            // VoziloTableAdapter
            // 
            this.VoziloTableAdapter.ClearBeforeFill = true;
            // 
            // IzvjestajiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 736);
            this.Controls.Add(this.tabControl1);
            this.Name = "IzvjestajiForm";
            this.Text = "Izvjestaji";
            this.Load += new System.EventHandler(this.IzvjestajiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InstruktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoskolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoznjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredavanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UplataBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PolaznikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource InstruktorBindingSource;
        private AutoskolaDataSet AutoskolaDataSet;
        private AutoskolaDataSetTableAdapters.InstruktorTableAdapter InstruktorTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource VoznjaBindingSource;
        private AutoskolaDataSetTableAdapters.VoznjaTableAdapter VoznjaTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource PolaznikBindingSource;
        private AutoskolaDataSetTableAdapters.PolaznikTableAdapter PolaznikTableAdapter;
        private System.Windows.Forms.BindingSource UplataBindingSource;
        private AutoskolaDataSetTableAdapters.UplataTableAdapter UplataTableAdapter;
        private System.Windows.Forms.BindingSource PredavanjeBindingSource;
        private AutoskolaDataSetTableAdapters.PredavanjeTableAdapter PredavanjeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource VoziloBindingSource;
        private AutoskolaDataSetTableAdapters.VoziloTableAdapter VoziloTableAdapter;
    }
}