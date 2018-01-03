namespace GUI.Menus
{
    partial class HourReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourReport));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.hrDataSet = new GUI.hrDataSet();
            this.reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsTableAdapter = new GUI.hrDataSetTableAdapters.reportsTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new GUI.hrDataSetTableAdapters.employeesTableAdapter();
            this.checkBoxArchive = new System.Windows.Forms.CheckBox();
            this.dateTimePickerArchiveDate = new System.Windows.Forms.DateTimePicker();
            this.buttonRunReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "מספר עובד או ת\"ז:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(14, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 1;
            // 
            // hrDataSet
            // 
            this.hrDataSet.DataSetName = "hrDataSet";
            this.hrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportsBindingSource
            // 
            this.reportsBindingSource.DataMember = "reports";
            this.reportsBindingSource.DataSource = this.hrDataSet;
            // 
            // reportsTableAdapter
            // 
            this.reportsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.hrDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // checkBoxArchive
            // 
            this.checkBoxArchive.AutoSize = true;
            this.checkBoxArchive.Location = new System.Drawing.Point(133, 41);
            this.checkBoxArchive.Name = "checkBoxArchive";
            this.checkBoxArchive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxArchive.Size = new System.Drawing.Size(76, 17);
            this.checkBoxArchive.TabIndex = 2;
            this.checkBoxArchive.Text = "מהארכיון";
            this.checkBoxArchive.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerArchiveDate
            // 
            this.dateTimePickerArchiveDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerArchiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerArchiveDate.Location = new System.Drawing.Point(27, 38);
            this.dateTimePickerArchiveDate.Name = "dateTimePickerArchiveDate";
            this.dateTimePickerArchiveDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerArchiveDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerArchiveDate.TabIndex = 3;
            // 
            // buttonRunReport
            // 
            this.buttonRunReport.Location = new System.Drawing.Point(16, 64);
            this.buttonRunReport.Name = "buttonRunReport";
            this.buttonRunReport.Size = new System.Drawing.Size(205, 23);
            this.buttonRunReport.TabIndex = 4;
            this.buttonRunReport.Text = "הצג דו\"ח שעות";
            this.buttonRunReport.UseVisualStyleBackColor = true;
            this.buttonRunReport.Click += new System.EventHandler(this.buttonRunReport_Click);
            // 
            // HourReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 98);
            this.Controls.Add(this.buttonRunReport);
            this.Controls.Add(this.dateTimePickerArchiveDate);
            this.Controls.Add(this.checkBoxArchive);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HourReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "דו\"ח שעות";
            this.Load += new System.EventHandler(this.HourReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private hrDataSet hrDataSet;
        private System.Windows.Forms.BindingSource reportsBindingSource;
        private hrDataSetTableAdapters.reportsTableAdapter reportsTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private hrDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.CheckBox checkBoxArchive;
        private System.Windows.Forms.DateTimePicker dateTimePickerArchiveDate;
        private System.Windows.Forms.Button buttonRunReport;
    }
}