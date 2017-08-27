namespace WindowsFormsApplication1
{
    partial class editEmployees
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
            this.label19 = new System.Windows.Forms.Label();
            this.wageInput = new System.Windows.Forms.TextBox();
            this.wageClass = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.departments = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.emdate_year = new System.Windows.Forms.TextBox();
            this.emdate_month = new System.Windows.Forms.ComboBox();
            this.emdate_day = new System.Windows.Forms.ComboBox();
            this.endate_year = new System.Windows.Forms.TextBox();
            this.endate_month = new System.Windows.Forms.ComboBox();
            this.endate_day = new System.Windows.Forms.ComboBox();
            this.sdate_year = new System.Windows.Forms.TextBox();
            this.sdate_month = new System.Windows.Forms.ComboBox();
            this.sdate_day = new System.Windows.Forms.ComboBox();
            this.dob_year = new System.Windows.Forms.TextBox();
            this.dob_month = new System.Windows.Forms.ComboBox();
            this.dob_day = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.marital = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.children = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.cob = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.eid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 469);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 106;
            this.label19.Text = "Global Wage";
            // 
            // wageInput
            // 
            this.wageInput.Enabled = false;
            this.wageInput.Location = new System.Drawing.Point(107, 466);
            this.wageInput.Name = "wageInput";
            this.wageInput.Size = new System.Drawing.Size(135, 20);
            this.wageInput.TabIndex = 105;
            // 
            // wageClass
            // 
            this.wageClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wageClass.FormattingEnabled = true;
            this.wageClass.Items.AddRange(new object[] {
            "Class D",
            "Class C",
            "Class B",
            "Class A",
            "Global"});
            this.wageClass.Location = new System.Drawing.Point(23, 424);
            this.wageClass.Name = "wageClass";
            this.wageClass.Size = new System.Drawing.Size(294, 21);
            this.wageClass.TabIndex = 104;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 399);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 103;
            this.label18.Text = "Wage Class";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 102;
            this.label17.Text = "Department";
            // 
            // departments
            // 
            this.departments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departments.FormattingEnabled = true;
            this.departments.Items.AddRange(new object[] {
            "Production",
            "Sales",
            "Human Resources",
            "Tech Support",
            "Administrative Assistant",
            "Director"});
            this.departments.Location = new System.Drawing.Point(23, 346);
            this.departments.Name = "departments";
            this.departments.Size = new System.Drawing.Size(301, 21);
            this.departments.TabIndex = 101;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(860, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 56);
            this.button2.TabIndex = 100;
            this.button2.Text = "Return to Menu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // emdate_year
            // 
            this.emdate_year.Enabled = false;
            this.emdate_year.Location = new System.Drawing.Point(598, 152);
            this.emdate_year.MaxLength = 4;
            this.emdate_year.Name = "emdate_year";
            this.emdate_year.Size = new System.Drawing.Size(79, 20);
            this.emdate_year.TabIndex = 99;
            // 
            // emdate_month
            // 
            this.emdate_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emdate_month.Enabled = false;
            this.emdate_month.FormattingEnabled = true;
            this.emdate_month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.emdate_month.Location = new System.Drawing.Point(513, 150);
            this.emdate_month.Name = "emdate_month";
            this.emdate_month.Size = new System.Drawing.Size(66, 21);
            this.emdate_month.TabIndex = 98;
            // 
            // emdate_day
            // 
            this.emdate_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emdate_day.Enabled = false;
            this.emdate_day.FormattingEnabled = true;
            this.emdate_day.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.emdate_day.Location = new System.Drawing.Point(432, 150);
            this.emdate_day.Name = "emdate_day";
            this.emdate_day.Size = new System.Drawing.Size(66, 21);
            this.emdate_day.TabIndex = 97;
            // 
            // endate_year
            // 
            this.endate_year.Enabled = false;
            this.endate_year.Location = new System.Drawing.Point(598, 269);
            this.endate_year.MaxLength = 4;
            this.endate_year.Name = "endate_year";
            this.endate_year.Size = new System.Drawing.Size(79, 20);
            this.endate_year.TabIndex = 96;
            // 
            // endate_month
            // 
            this.endate_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endate_month.Enabled = false;
            this.endate_month.FormattingEnabled = true;
            this.endate_month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.endate_month.Location = new System.Drawing.Point(513, 267);
            this.endate_month.Name = "endate_month";
            this.endate_month.Size = new System.Drawing.Size(66, 21);
            this.endate_month.TabIndex = 95;
            // 
            // endate_day
            // 
            this.endate_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endate_day.Enabled = false;
            this.endate_day.FormattingEnabled = true;
            this.endate_day.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.endate_day.Location = new System.Drawing.Point(432, 267);
            this.endate_day.Name = "endate_day";
            this.endate_day.Size = new System.Drawing.Size(66, 21);
            this.endate_day.TabIndex = 94;
            // 
            // sdate_year
            // 
            this.sdate_year.Location = new System.Drawing.Point(598, 213);
            this.sdate_year.MaxLength = 4;
            this.sdate_year.Name = "sdate_year";
            this.sdate_year.Size = new System.Drawing.Size(79, 20);
            this.sdate_year.TabIndex = 93;
            // 
            // sdate_month
            // 
            this.sdate_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sdate_month.FormattingEnabled = true;
            this.sdate_month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.sdate_month.Location = new System.Drawing.Point(513, 211);
            this.sdate_month.Name = "sdate_month";
            this.sdate_month.Size = new System.Drawing.Size(66, 21);
            this.sdate_month.TabIndex = 92;
            // 
            // sdate_day
            // 
            this.sdate_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sdate_day.FormattingEnabled = true;
            this.sdate_day.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.sdate_day.Location = new System.Drawing.Point(432, 211);
            this.sdate_day.Name = "sdate_day";
            this.sdate_day.Size = new System.Drawing.Size(66, 21);
            this.sdate_day.TabIndex = 91;
            // 
            // dob_year
            // 
            this.dob_year.Location = new System.Drawing.Point(598, 34);
            this.dob_year.MaxLength = 4;
            this.dob_year.Name = "dob_year";
            this.dob_year.Size = new System.Drawing.Size(79, 20);
            this.dob_year.TabIndex = 90;
            // 
            // dob_month
            // 
            this.dob_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dob_month.FormattingEnabled = true;
            this.dob_month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.dob_month.Location = new System.Drawing.Point(513, 32);
            this.dob_month.Name = "dob_month";
            this.dob_month.Size = new System.Drawing.Size(66, 21);
            this.dob_month.TabIndex = 89;
            // 
            // dob_day
            // 
            this.dob_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dob_day.FormattingEnabled = true;
            this.dob_day.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dob_day.Location = new System.Drawing.Point(432, 32);
            this.dob_day.Name = "dob_day";
            this.dob_day.Size = new System.Drawing.Size(66, 21);
            this.dob_day.TabIndex = 88;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(522, 126);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 87;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(491, 247);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 86;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(23, 276);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(301, 21);
            this.gender.TabIndex = 85;
            // 
            // marital
            // 
            this.marital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marital.FormattingEnabled = true;
            this.marital.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widowed"});
            this.marital.Location = new System.Drawing.Point(814, 267);
            this.marital.Name = "marital";
            this.marital.Size = new System.Drawing.Size(301, 21);
            this.marital.TabIndex = 84;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(820, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 83;
            this.label16.Text = "Country";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(814, 150);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(301, 20);
            this.country.TabIndex = 82;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(820, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 20);
            this.label15.TabIndex = 81;
            this.label15.Text = "Ammount of children";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(820, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 80;
            this.label14.Text = "Marital status";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(820, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 79;
            this.label13.Text = "Zip Code";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(820, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 78;
            this.label12.Text = "City";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(820, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 77;
            this.label11.Text = "Address";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(429, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 76;
            this.label10.Text = "End Date";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(429, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(429, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 74;
            this.label8.Text = "Emigration Date";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(429, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Country of Birth";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(429, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "ID Number";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Employee ID";
            // 
            // children
            // 
            this.children.Location = new System.Drawing.Point(814, 332);
            this.children.Name = "children";
            this.children.Size = new System.Drawing.Size(301, 20);
            this.children.TabIndex = 66;
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(814, 206);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(301, 20);
            this.zip.TabIndex = 65;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(814, 91);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(301, 20);
            this.city.TabIndex = 64;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(814, 32);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(301, 20);
            this.address.TabIndex = 63;
            // 
            // cob
            // 
            this.cob.Location = new System.Drawing.Point(422, 91);
            this.cob.Name = "cob";
            this.cob.Size = new System.Drawing.Size(301, 20);
            this.cob.TabIndex = 62;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(23, 211);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(301, 20);
            this.lname.TabIndex = 61;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(23, 150);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(301, 20);
            this.fname.TabIndex = 60;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(23, 91);
            this.id.MaxLength = 9;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(301, 20);
            this.id.TabIndex = 59;
            // 
            // eid
            // 
            this.eid.Location = new System.Drawing.Point(23, 32);
            this.eid.MaxLength = 5;
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(301, 20);
            this.eid.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 58);
            this.button1.TabIndex = 57;
            this.button1.Text = "Update User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 578);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.wageInput);
            this.Controls.Add(this.wageClass);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.departments);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.emdate_year);
            this.Controls.Add(this.emdate_month);
            this.Controls.Add(this.emdate_day);
            this.Controls.Add(this.endate_year);
            this.Controls.Add(this.endate_month);
            this.Controls.Add(this.endate_day);
            this.Controls.Add(this.sdate_year);
            this.Controls.Add(this.sdate_month);
            this.Controls.Add(this.sdate_day);
            this.Controls.Add(this.dob_year);
            this.Controls.Add(this.dob_month);
            this.Controls.Add(this.dob_day);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.marital);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.children);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.city);
            this.Controls.Add(this.address);
            this.Controls.Add(this.cob);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.id);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.button1);
            this.Name = "editEmployees";
            this.Text = "editEmployees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox wageInput;
        private System.Windows.Forms.ComboBox wageClass;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox departments;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox emdate_year;
        private System.Windows.Forms.ComboBox emdate_month;
        private System.Windows.Forms.ComboBox emdate_day;
        private System.Windows.Forms.TextBox endate_year;
        private System.Windows.Forms.ComboBox endate_month;
        private System.Windows.Forms.ComboBox endate_day;
        private System.Windows.Forms.TextBox sdate_year;
        private System.Windows.Forms.ComboBox sdate_month;
        private System.Windows.Forms.ComboBox sdate_day;
        private System.Windows.Forms.TextBox dob_year;
        private System.Windows.Forms.ComboBox dob_month;
        private System.Windows.Forms.ComboBox dob_day;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox marital;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox children;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox cob;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox eid;
        private System.Windows.Forms.Button button1;
    }
}