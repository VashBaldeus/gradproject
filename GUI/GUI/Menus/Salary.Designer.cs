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
            this.buttonMoveToArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "חפש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(14, 10);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 13);
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
            this.dateTimePickerArchiveDate.Location = new System.Drawing.Point(27, 36);
            this.dateTimePickerArchiveDate.Name = "dateTimePickerArchiveDate";
            this.dateTimePickerArchiveDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerArchiveDate.RightToLeftLayout = true;
            this.dateTimePickerArchiveDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerArchiveDate.TabIndex = 7;
            // 
            // checkBoxArchive
            // 
            this.checkBoxArchive.AutoSize = true;
            this.checkBoxArchive.Location = new System.Drawing.Point(133, 39);
            this.checkBoxArchive.Name = "checkBoxArchive";
            this.checkBoxArchive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxArchive.Size = new System.Drawing.Size(76, 17);
            this.checkBoxArchive.TabIndex = 6;
            this.checkBoxArchive.Text = "מהארכיון";
            this.checkBoxArchive.UseVisualStyleBackColor = true;
            // 
            // buttonMoveToArchive
            // 
            this.buttonMoveToArchive.Location = new System.Drawing.Point(16, 92);
            this.buttonMoveToArchive.Name = "buttonMoveToArchive";
            this.buttonMoveToArchive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonMoveToArchive.Size = new System.Drawing.Size(203, 23);
            this.buttonMoveToArchive.TabIndex = 8;
            this.buttonMoveToArchive.Text = "הפעל תהליך ארכיון";
            this.buttonMoveToArchive.UseVisualStyleBackColor = true;
            this.buttonMoveToArchive.Click += new System.EventHandler(this.buttonMoveToArchive_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 124);
            this.Controls.Add(this.buttonMoveToArchive);
            this.Controls.Add(this.dateTimePickerArchiveDate);
            this.Controls.Add(this.checkBoxArchive);
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
        private System.Windows.Forms.Button buttonMoveToArchive;
    }
}