namespace GUI.Menus
{
    partial class SalarySheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalarySheet));
            this.reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hrDataSet = new GUI.hrDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryDataSet = new GUI.salaryDataSet();
            this.archived_reportsTableAdapter1 = new GUI.hrDataSetTableAdapters.archived_reportsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportsTableAdapter = new GUI.hrDataSetTableAdapters.reportsTableAdapter();
            this.employeesTableAdapter = new GUI.hrDataSetTableAdapters.employeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).BeginInit();
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
            // salaryDataTableBindingSource
            // 
            this.salaryDataTableBindingSource.DataMember = "salaryDataTable";
            this.salaryDataTableBindingSource.DataSource = this.salaryDataSet;
            // 
            // salaryDataSet
            // 
            this.salaryDataSet.DataSetName = "salaryDataSet";
            this.salaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archived_reportsTableAdapter1
            // 
            this.archived_reportsTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "reportsDataSet";
            reportDataSource1.Value = this.reportsBindingSource;
            reportDataSource2.Name = "employeesDataSet";
            reportDataSource2.Value = this.employeesBindingSource;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.salaryDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Reports.salaryReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(659, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportsTableAdapter
            // 
            this.reportsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // SalarySheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 749);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalarySheet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "דו\"ח שכר";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalarySheet_FormClosing);
            this.Load += new System.EventHandler(this.SalarySheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private hrDataSetTableAdapters.archived_reportsTableAdapter archived_reportsTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private hrDataSet hrDataSet;
        private System.Windows.Forms.BindingSource reportsBindingSource;
        private hrDataSetTableAdapters.reportsTableAdapter reportsTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private hrDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource salaryDataTableBindingSource;
        private salaryDataSet salaryDataSet;
    }
}