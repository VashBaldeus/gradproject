namespace GUI
{
    partial class LoginMenu
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.tabTimeKeeper = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLogin);
            this.tabControl.Controls.Add(this.tabTimeKeeper);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(284, 261);
            this.tabControl.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(276, 235);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            // 
            // tabTimeKeeper
            // 
            this.tabTimeKeeper.BackColor = System.Drawing.SystemColors.Control;
            this.tabTimeKeeper.Location = new System.Drawing.Point(4, 22);
            this.tabTimeKeeper.Name = "tabTimeKeeper";
            this.tabTimeKeeper.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeKeeper.Size = new System.Drawing.Size(276, 235);
            this.tabTimeKeeper.TabIndex = 1;
            this.tabTimeKeeper.Text = "Time Keeper";
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabTimeKeeper;
    }
}

