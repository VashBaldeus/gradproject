namespace GUI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDepartments = new System.Windows.Forms.Button();
            this.buttonUserProfile = new System.Windows.Forms.Button();
            this.buttonSalary = new System.Windows.Forms.Button();
            this.buttonHourReport = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonUsrProfile = new System.Windows.Forms.Button();
            this.buttonHourRep = new System.Windows.Forms.Button();
            this.buttonEEmployee = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(318, 196);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.buttonDepartments);
            this.tabPage1.Controls.Add(this.buttonUserProfile);
            this.tabPage1.Controls.Add(this.buttonSalary);
            this.tabPage1.Controls.Add(this.buttonHourReport);
            this.tabPage1.Controls.Add(this.buttonEditEmployee);
            this.tabPage1.Controls.Add(this.buttonAddEmployee);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(310, 170);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "כח אדם";
            // 
            // buttonDepartments
            // 
            this.buttonDepartments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDepartments.Image = global::GUI.Properties.Resources._1471083___general_g;
            this.buttonDepartments.Location = new System.Drawing.Point(209, 88);
            this.buttonDepartments.Name = "buttonDepartments";
            this.buttonDepartments.Size = new System.Drawing.Size(95, 75);
            this.buttonDepartments.TabIndex = 9;
            this.buttonDepartments.Text = "מחלקות";
            this.buttonDepartments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDepartments.UseVisualStyleBackColor = true;
            this.buttonDepartments.Click += new System.EventHandler(this.buttonDepartments_Click);
            // 
            // buttonUserProfile
            // 
            this.buttonUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUserProfile.Image = global::GUI.Properties.Resources._1471084___avatar_ge;
            this.buttonUserProfile.Location = new System.Drawing.Point(7, 88);
            this.buttonUserProfile.Name = "buttonUserProfile";
            this.buttonUserProfile.Size = new System.Drawing.Size(95, 75);
            this.buttonUserProfile.TabIndex = 11;
            this.buttonUserProfile.Text = "פורפיל משתמש";
            this.buttonUserProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUserProfile.UseVisualStyleBackColor = true;
            this.buttonUserProfile.Click += new System.EventHandler(this.buttonUserProfile_Click);
            // 
            // buttonSalary
            // 
            this.buttonSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSalary.Image = global::GUI.Properties.Resources._1471077___accountin;
            this.buttonSalary.Location = new System.Drawing.Point(108, 88);
            this.buttonSalary.Name = "buttonSalary";
            this.buttonSalary.Size = new System.Drawing.Size(95, 75);
            this.buttonSalary.TabIndex = 10;
            this.buttonSalary.Text = "חישוב שכר";
            this.buttonSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalary.UseVisualStyleBackColor = true;
            this.buttonSalary.Click += new System.EventHandler(this.buttonSalary_Click);
            // 
            // buttonHourReport
            // 
            this.buttonHourReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHourReport.Image = global::GUI.Properties.Resources._1471089___alarm_ala;
            this.buttonHourReport.Location = new System.Drawing.Point(7, 7);
            this.buttonHourReport.Name = "buttonHourReport";
            this.buttonHourReport.Size = new System.Drawing.Size(95, 75);
            this.buttonHourReport.TabIndex = 8;
            this.buttonHourReport.Text = "דו\"ח שעות";
            this.buttonHourReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHourReport.UseVisualStyleBackColor = true;
            this.buttonHourReport.Click += new System.EventHandler(this.buttonHourReport_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditEmployee.Image = global::GUI.Properties.Resources._1471081___compose_c;
            this.buttonEditEmployee.Location = new System.Drawing.Point(108, 7);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(95, 75);
            this.buttonEditEmployee.TabIndex = 7;
            this.buttonEditEmployee.Text = "עריכת עובד";
            this.buttonEditEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddEmployee.Image = global::GUI.Properties.Resources._1471085___add_user_;
            this.buttonAddEmployee.Location = new System.Drawing.Point(209, 7);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(95, 75);
            this.buttonAddEmployee.TabIndex = 6;
            this.buttonAddEmployee.Text = "הוספת עובד";
            this.buttonAddEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.buttonUsrProfile);
            this.tabPage2.Controls.Add(this.buttonHourRep);
            this.tabPage2.Controls.Add(this.buttonEEmployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(310, 170);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "מנהלים";
            // 
            // buttonUsrProfile
            // 
            this.buttonUsrProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUsrProfile.Image = global::GUI.Properties.Resources._1471084___avatar_ge;
            this.buttonUsrProfile.Location = new System.Drawing.Point(7, 48);
            this.buttonUsrProfile.Name = "buttonUsrProfile";
            this.buttonUsrProfile.Size = new System.Drawing.Size(95, 75);
            this.buttonUsrProfile.TabIndex = 14;
            this.buttonUsrProfile.Text = "פורפיל משתמש";
            this.buttonUsrProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUsrProfile.UseVisualStyleBackColor = true;
            this.buttonUsrProfile.Click += new System.EventHandler(this.buttonUserProfile_Click);
            // 
            // buttonHourRep
            // 
            this.buttonHourRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHourRep.Image = global::GUI.Properties.Resources._1471089___alarm_ala;
            this.buttonHourRep.Location = new System.Drawing.Point(108, 48);
            this.buttonHourRep.Name = "buttonHourRep";
            this.buttonHourRep.Size = new System.Drawing.Size(95, 75);
            this.buttonHourRep.TabIndex = 13;
            this.buttonHourRep.Text = "דו\"ח שעות";
            this.buttonHourRep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHourRep.UseVisualStyleBackColor = true;
            this.buttonHourRep.Click += new System.EventHandler(this.buttonHourReport_Click);
            // 
            // buttonEEmployee
            // 
            this.buttonEEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEEmployee.Image = global::GUI.Properties.Resources._1471081___compose_c;
            this.buttonEEmployee.Location = new System.Drawing.Point(209, 48);
            this.buttonEEmployee.Name = "buttonEEmployee";
            this.buttonEEmployee.Size = new System.Drawing.Size(95, 75);
            this.buttonEEmployee.TabIndex = 12;
            this.buttonEEmployee.Text = "עריכת עובד";
            this.buttonEEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEEmployee.UseVisualStyleBackColor = true;
            this.buttonEEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 196);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "תפריט ראשי";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDepartments;
        private System.Windows.Forms.Button buttonUserProfile;
        private System.Windows.Forms.Button buttonSalary;
        private System.Windows.Forms.Button buttonHourReport;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonUsrProfile;
        private System.Windows.Forms.Button buttonHourRep;
        private System.Windows.Forms.Button buttonEEmployee;
    }
}