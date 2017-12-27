namespace GUI.Menus
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.textBoxZIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCityCode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCOB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxMarital = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerMigDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxChildren = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerJStart = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxJType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxSalary = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonResetForm = new System.Windows.Forms.Button();
            this.checkedListBoxUserPerms = new System.Windows.Forms.CheckedListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxPASSWD = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "תעודת זהות:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(258, 8);
            this.textBoxID.MaxLength = 9;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(121, 20);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(258, 34);
            this.textBoxFName.MaxLength = 35;
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(121, 20);
            this.textBoxFName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "שם פרטי:";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(258, 60);
            this.textBoxLName.MaxLength = 35;
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(121, 20);
            this.textBoxLName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "שם מפשחה:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "מין:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "תאריך לידה:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(48, 8);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(121, 20);
            this.textBoxStreet.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "רחוב:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "זכר",
            "נקבה"});
            this.comboBoxGender.Location = new System.Drawing.Point(258, 85);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGender.TabIndex = 3;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(258, 112);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.RightToLeftLayout = true;
            this.dateTimePickerDOB.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDOB.TabIndex = 4;
            // 
            // textBoxZIP
            // 
            this.textBoxZIP.Location = new System.Drawing.Point(48, 34);
            this.textBoxZIP.Name = "textBoxZIP";
            this.textBoxZIP.Size = new System.Drawing.Size(121, 20);
            this.textBoxZIP.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "מיקוד:";
            // 
            // comboBoxCityCode
            // 
            this.comboBoxCityCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxCityCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCityCode.FormattingEnabled = true;
            this.comboBoxCityCode.Location = new System.Drawing.Point(48, 60);
            this.comboBoxCityCode.Name = "comboBoxCityCode";
            this.comboBoxCityCode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCityCode.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "עיר:";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(48, 87);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "ארץ:";
            // 
            // comboBoxCOB
            // 
            this.comboBoxCOB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxCOB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCOB.FormattingEnabled = true;
            this.comboBoxCOB.Location = new System.Drawing.Point(48, 115);
            this.comboBoxCOB.Name = "comboBoxCOB";
            this.comboBoxCOB.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOB.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "ארץ מוצא:";
            // 
            // comboBoxMarital
            // 
            this.comboBoxMarital.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxMarital.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMarital.FormattingEnabled = true;
            this.comboBoxMarital.Items.AddRange(new object[] {
            "רווק/ה",
            "נשוי/אה",
            "גרוש/ה",
            "עלמנ/ה"});
            this.comboBoxMarital.Location = new System.Drawing.Point(258, 138);
            this.comboBoxMarital.Name = "comboBoxMarital";
            this.comboBoxMarital.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarital.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(394, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "מצב משפחתי:";
            // 
            // dateTimePickerMigDate
            // 
            this.dateTimePickerMigDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerMigDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMigDate.Location = new System.Drawing.Point(48, 142);
            this.dateTimePickerMigDate.Name = "dateTimePickerMigDate";
            this.dateTimePickerMigDate.RightToLeftLayout = true;
            this.dateTimePickerMigDate.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerMigDate.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "תאריך עלייה:";
            // 
            // comboBoxChildren
            // 
            this.comboBoxChildren.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxChildren.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxChildren.FormattingEnabled = true;
            this.comboBoxChildren.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxChildren.Location = new System.Drawing.Point(258, 165);
            this.comboBoxChildren.Name = "comboBoxChildren";
            this.comboBoxChildren.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChildren.TabIndex = 6;
            this.comboBoxChildren.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(429, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "ילדים:";
            // 
            // dateTimePickerJStart
            // 
            this.dateTimePickerJStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerJStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerJStart.Location = new System.Drawing.Point(48, 168);
            this.dateTimePickerJStart.Name = "dateTimePickerJStart";
            this.dateTimePickerJStart.RightToLeftLayout = true;
            this.dateTimePickerJStart.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerJStart.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(172, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "תחילת עבודה:";
            // 
            // comboBoxJType
            // 
            this.comboBoxJType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxJType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxJType.FormattingEnabled = true;
            this.comboBoxJType.Items.AddRange(new object[] {
            "מלאה",
            "חלקית"});
            this.comboBoxJType.Location = new System.Drawing.Point(258, 192);
            this.comboBoxJType.Name = "comboBoxJType";
            this.comboBoxJType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJType.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(410, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "סוג משרה:";
            // 
            // comboBoxSalary
            // 
            this.comboBoxSalary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxSalary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSalary.FormattingEnabled = true;
            this.comboBoxSalary.Items.AddRange(new object[] {
            "שעתי",
            "גלובאלי"});
            this.comboBoxSalary.Location = new System.Drawing.Point(48, 194);
            this.comboBoxSalary.Name = "comboBoxSalary";
            this.comboBoxSalary.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSalary.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(198, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "סוג שכר:";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(258, 219);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDept.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(425, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "מחלקה:";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(339, 294);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEmployee.TabIndex = 19;
            this.buttonAddEmployee.Text = "הוסף עובד";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonResetForm
            // 
            this.buttonResetForm.Location = new System.Drawing.Point(258, 294);
            this.buttonResetForm.Name = "buttonResetForm";
            this.buttonResetForm.Size = new System.Drawing.Size(75, 23);
            this.buttonResetForm.TabIndex = 20;
            this.buttonResetForm.Text = "אפס טופס";
            this.buttonResetForm.UseVisualStyleBackColor = true;
            this.buttonResetForm.Click += new System.EventHandler(this.buttonResetForm_Click);
            // 
            // checkedListBoxUserPerms
            // 
            this.checkedListBoxUserPerms.FormattingEnabled = true;
            this.checkedListBoxUserPerms.Items.AddRange(new object[] {
            "חלק מכח אדם",
            "יכול לשנות סיסמה",
            "יכול להתחבר למערכת",
            "יכול להוסיף עובדים",
            "יכול לעשות שינויים לעובדים קיימים",
            "יכול לצפות בדו\"ח שעות"});
            this.checkedListBoxUserPerms.Location = new System.Drawing.Point(27, 238);
            this.checkedListBoxUserPerms.Name = "checkedListBoxUserPerms";
            this.checkedListBoxUserPerms.Size = new System.Drawing.Size(221, 94);
            this.checkedListBoxUserPerms.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(385, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "סיסמת משתמש:";
            // 
            // textBoxPASSWD
            // 
            this.textBoxPASSWD.Location = new System.Drawing.Point(258, 249);
            this.textBoxPASSWD.MaxLength = 32;
            this.textBoxPASSWD.Name = "textBoxPASSWD";
            this.textBoxPASSWD.Size = new System.Drawing.Size(121, 20);
            this.textBoxPASSWD.TabIndex = 17;
            this.textBoxPASSWD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPASSWD_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(157, 222);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "הרשאות משתמש:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 341);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxPASSWD);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.checkedListBoxUserPerms);
            this.Controls.Add(this.buttonResetForm);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboBoxSalary);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBoxJType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePickerJStart);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxChildren);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePickerMigDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxMarital);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxCOB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxCityCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxZIP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת עובד";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox textBoxZIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCityCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxMarital;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerMigDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxChildren;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerJStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxJType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxSalary;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonResetForm;
        private System.Windows.Forms.CheckedListBox checkedListBoxUserPerms;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxPASSWD;
        private System.Windows.Forms.Label label19;
    }
}