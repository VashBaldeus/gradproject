namespace GUI.Menus
{
    partial class HourReportSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourReportSheet));
            this.reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hrDataSet = new GUI.hrDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsTableAdapter = new GUI.hrDataSetTableAdapters.reportsTableAdapter();
            this.employeesTableAdapter = new GUI.hrDataSetTableAdapters.employeesTableAdapter();
            this.archivedreportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archived_reportsTableAdapter = new GUI.hrDataSetTableAdapters.archived_reportsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivedreportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportsBindingSource
            // 
            this.reportsBindingSource.DataMember = "reports";
            this.reportsBindingSource.DataSource = this.hrDataSet;
            // 
            // hrDataSet
            // 
            this.hrDataSet.DataSetName = "hrDataSet";
            this.hrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.hrDataSet;
            // 
            // reportsTableAdapter
            // 
            this.reportsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // archivedreportsBindingSource
            // 
            this.archivedreportsBindingSource.DataMember = "archived_reports";
            this.archivedreportsBindingSource.DataSource = this.hrDataSet;
            // 
            // archived_reportsTableAdapter
            // 
            this.archived_reportsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "reports";
            reportDataSource1.Value = this.reportsBindingSource;
            reportDataSource2.Name = "employees";
            reportDataSource2.Value = this.employeesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Reports.hourReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(659, 861);
            this.reportViewer1.TabIndex = 1;
            // 
            // HourReportSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 861);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HourReportSheet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "דו\"ח שעות";
            this.Load += new System.EventHandler(this.HourReportSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivedreportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private hrDataSet hrDataSet;
        private System.Windows.Forms.BindingSource reportsBindingSource;
        private hrDataSetTableAdapters.reportsTableAdapter reportsTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private hrDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource archivedreportsBindingSource;
        private hrDataSetTableAdapters.archived_reportsTableAdapter archived_reportsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}