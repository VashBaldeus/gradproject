namespace GUI.Menus
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCurPW = new System.Windows.Forms.TextBox();
            this.textBoxNewPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewPWV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "סיסמה נוכחית:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCurPW
            // 
            this.textBoxCurPW.Location = new System.Drawing.Point(12, 12);
            this.textBoxCurPW.Name = "textBoxCurPW";
            this.textBoxCurPW.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurPW.TabIndex = 1;
            // 
            // textBoxNewPW
            // 
            this.textBoxNewPW.Location = new System.Drawing.Point(12, 38);
            this.textBoxNewPW.Name = "textBoxNewPW";
            this.textBoxNewPW.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewPW.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 41);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "סיסמה חדשה:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNewPWV
            // 
            this.textBoxNewPWV.Location = new System.Drawing.Point(12, 64);
            this.textBoxNewPWV.Name = "textBoxNewPWV";
            this.textBoxNewPWV.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewPWV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 67);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "סיסמה חדשה שוב:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "החלף סיסמה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNewPWV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCurPW);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserProfile";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "פרופיל משתמש";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCurPW;
        private System.Windows.Forms.TextBox textBoxNewPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewPWV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}