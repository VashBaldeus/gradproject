namespace GUI.Menus
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerArchiveDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxArchive = new System.Windows.Forms.CheckBox();
            this.checkBoxThisMonth = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "חפש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(32, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "מספר עובד או ת\"ז:";
            // 
            // dateTimePickerArchiveDate
            // 
            this.dateTimePickerArchiveDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerArchiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerArchiveDate.Location = new System.Drawing.Point(9, 38);
            this.dateTimePickerArchiveDate.Name = "dateTimePickerArchiveDate";
            this.dateTimePickerArchiveDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerArchiveDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerArchiveDate.TabIndex = 7;
            // 
            // checkBoxArchive
            // 
            this.checkBoxArchive.AutoSize = true;
            this.checkBoxArchive.Location = new System.Drawing.Point(115, 41);
            this.checkBoxArchive.Name = "checkBoxArchive";
            this.checkBoxArchive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxArchive.Size = new System.Drawing.Size(76, 17);
            this.checkBoxArchive.TabIndex = 6;
            this.checkBoxArchive.Text = "מהארכיון";
            this.checkBoxArchive.UseVisualStyleBackColor = true;
            // 
            // checkBoxThisMonth
            // 
            this.checkBoxThisMonth.AutoSize = true;
            this.checkBoxThisMonth.Location = new System.Drawing.Point(197, 41);
            this.checkBoxThisMonth.Name = "checkBoxThisMonth";
            this.checkBoxThisMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxThisMonth.Size = new System.Drawing.Size(68, 17);
            this.checkBoxThisMonth.TabIndex = 5;
            this.checkBoxThisMonth.Text = "מהחודש";
            this.checkBoxThisMonth.UseVisualStyleBackColor = true;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 98);
            this.Controls.Add(this.dateTimePickerArchiveDate);
            this.Controls.Add(this.checkBoxArchive);
            this.Controls.Add(this.checkBoxThisMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Salary";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "חישוב שכר";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerArchiveDate;
        private System.Windows.Forms.CheckBox checkBoxArchive;
        private System.Windows.Forms.CheckBox checkBoxThisMonth;
    }
}