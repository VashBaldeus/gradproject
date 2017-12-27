namespace GUI.Menus
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDptName = new System.Windows.Forms.TextBox();
            this.textBoxDptLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDptMngr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDptPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddDpt = new System.Windows.Forms.Button();
            this.buttonResetForm = new System.Windows.Forms.Button();
            this.comboBoxDptList = new System.Windows.Forms.ComboBox();
            this.buttonDelDpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 73);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "שם מחלקה:";
            // 
            // textBoxDptName
            // 
            this.textBoxDptName.Location = new System.Drawing.Point(12, 70);
            this.textBoxDptName.Name = "textBoxDptName";
            this.textBoxDptName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDptName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDptName.TabIndex = 2;
            // 
            // textBoxDptLocation
            // 
            this.textBoxDptLocation.Location = new System.Drawing.Point(12, 96);
            this.textBoxDptLocation.Name = "textBoxDptLocation";
            this.textBoxDptLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDptLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxDptLocation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 99);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "מיקום מחלקה:";
            // 
            // textBoxDptMngr
            // 
            this.textBoxDptMngr.Location = new System.Drawing.Point(12, 122);
            this.textBoxDptMngr.Name = "textBoxDptMngr";
            this.textBoxDptMngr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDptMngr.Size = new System.Drawing.Size(100, 20);
            this.textBoxDptMngr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 125);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "מנהל מחלקה:";
            // 
            // textBoxDptPhone
            // 
            this.textBoxDptPhone.Location = new System.Drawing.Point(12, 148);
            this.textBoxDptPhone.Name = "textBoxDptPhone";
            this.textBoxDptPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDptPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxDptPhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 151);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "טלפון מחלקה:";
            // 
            // buttonAddDpt
            // 
            this.buttonAddDpt.Location = new System.Drawing.Point(103, 174);
            this.buttonAddDpt.Name = "buttonAddDpt";
            this.buttonAddDpt.Size = new System.Drawing.Size(91, 23);
            this.buttonAddDpt.TabIndex = 6;
            this.buttonAddDpt.Text = "הוסף מחלקה";
            this.buttonAddDpt.UseVisualStyleBackColor = true;
            this.buttonAddDpt.Click += new System.EventHandler(this.buttonAddDpt_Click);
            // 
            // buttonResetForm
            // 
            this.buttonResetForm.Location = new System.Drawing.Point(12, 174);
            this.buttonResetForm.Name = "buttonResetForm";
            this.buttonResetForm.Size = new System.Drawing.Size(91, 23);
            this.buttonResetForm.TabIndex = 7;
            this.buttonResetForm.Text = "אפס טופס";
            this.buttonResetForm.UseVisualStyleBackColor = true;
            this.buttonResetForm.Click += new System.EventHandler(this.buttonResetForm_Click);
            // 
            // comboBoxDptList
            // 
            this.comboBoxDptList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDptList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDptList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDptList.FormattingEnabled = true;
            this.comboBoxDptList.Location = new System.Drawing.Point(13, 14);
            this.comboBoxDptList.Name = "comboBoxDptList";
            this.comboBoxDptList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDptList.Size = new System.Drawing.Size(182, 21);
            this.comboBoxDptList.TabIndex = 0;
            // 
            // buttonDelDpt
            // 
            this.buttonDelDpt.Location = new System.Drawing.Point(13, 41);
            this.buttonDelDpt.Name = "buttonDelDpt";
            this.buttonDelDpt.Size = new System.Drawing.Size(182, 23);
            this.buttonDelDpt.TabIndex = 1;
            this.buttonDelDpt.Text = "מחק מחלקה";
            this.buttonDelDpt.UseVisualStyleBackColor = true;
            this.buttonDelDpt.Click += new System.EventHandler(this.buttonDelDpt_Click);
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 210);
            this.Controls.Add(this.buttonDelDpt);
            this.Controls.Add(this.comboBoxDptList);
            this.Controls.Add(this.buttonResetForm);
            this.Controls.Add(this.buttonAddDpt);
            this.Controls.Add(this.textBoxDptPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDptMngr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDptLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDptName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Departments";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מחלקות";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDptName;
        private System.Windows.Forms.TextBox textBoxDptLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDptMngr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDptPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddDpt;
        private System.Windows.Forms.Button buttonResetForm;
        private System.Windows.Forms.ComboBox comboBoxDptList;
        private System.Windows.Forms.Button buttonDelDpt;
    }
}