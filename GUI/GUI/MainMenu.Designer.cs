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
            this.buttonNewEmployee = new System.Windows.Forms.Button();
            this.buttonCalcSalary = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonPrintHourLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewEmployee
            // 
            resources.ApplyResources(this.buttonNewEmployee, "buttonNewEmployee");
            this.buttonNewEmployee.Name = "buttonNewEmployee";
            this.buttonNewEmployee.UseVisualStyleBackColor = true;
            this.buttonNewEmployee.Click += new System.EventHandler(this.buttonNewEmployee_Click);
            // 
            // buttonCalcSalary
            // 
            resources.ApplyResources(this.buttonCalcSalary, "buttonCalcSalary");
            this.buttonCalcSalary.Name = "buttonCalcSalary";
            this.buttonCalcSalary.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonEditEmployee
            // 
            resources.ApplyResources(this.buttonEditEmployee, "buttonEditEmployee");
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // buttonEditUser
            // 
            resources.ApplyResources(this.buttonEditUser, "buttonEditUser");
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // buttonPrintHourLog
            // 
            resources.ApplyResources(this.buttonPrintHourLog, "buttonPrintHourLog");
            this.buttonPrintHourLog.Name = "buttonPrintHourLog";
            this.buttonPrintHourLog.UseVisualStyleBackColor = true;
            this.buttonPrintHourLog.Click += new System.EventHandler(this.buttonPrintHourLog_Click);
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonPrintHourLog);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonCalcSalary);
            this.Controls.Add(this.buttonNewEmployee);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewEmployee;
        private System.Windows.Forms.Button buttonCalcSalary;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonPrintHourLog;
    }
}