namespace GUI.Menus
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchField = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "הקש ת\"ז או מספר עובד:";
            // 
            // textBoxSearchField
            // 
            this.textBoxSearchField.Location = new System.Drawing.Point(9, 13);
            this.textBoxSearchField.MaxLength = 9;
            this.textBoxSearchField.Name = "textBoxSearchField";
            this.textBoxSearchField.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchField.TabIndex = 1;
            this.textBoxSearchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchField_KeyPress);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(9, 39);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(231, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "חפש";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 75);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchField);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "שינוי פרטי עובד";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchField;
        private System.Windows.Forms.Button buttonSearch;
    }
}