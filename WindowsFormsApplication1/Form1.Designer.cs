namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.eid = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.cob = new System.Windows.Forms.TextBox();
            this.children = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.marital = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dob_day = new System.Windows.Forms.ComboBox();
            this.dob_month = new System.Windows.Forms.ComboBox();
            this.dob_year = new System.Windows.Forms.TextBox();
            this.sdate_year = new System.Windows.Forms.TextBox();
            this.sdate_month = new System.Windows.Forms.ComboBox();
            this.sdate_day = new System.Windows.Forms.ComboBox();
            this.endate_year = new System.Windows.Forms.TextBox();
            this.endate_month = new System.Windows.Forms.ComboBox();
            this.endate_day = new System.Windows.Forms.ComboBox();
            this.emdate_year = new System.Windows.Forms.TextBox();
            this.emdate_month = new System.Windows.Forms.ComboBox();
            this.emdate_day = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.departments = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.wageClass = new System.Windows.Forms.ComboBox();
            this.wageInput = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(971, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eid
            // 
            this.eid.Location = new System.Drawing.Point(32, 56);
            this.eid.MaxLength = 5;
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(301, 20);
            this.eid.TabIndex = 1;
            this.eid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eid_KeyPress);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(32, 115);
            this.id.MaxLength = 9;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(301, 20);
            this.id.TabIndex = 2;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eid_KeyPress);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(32, 174);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(301, 20);
            this.fname.TabIndex = 3;
            this.fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(32, 235);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(301, 20);
            this.lname.TabIndex = 4;
            this.lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // cob
            // 
            this.cob.Location = new System.Drawing.Point(431, 115);
            this.cob.Name = "cob";
            this.cob.Size = new System.Drawing.Size(301, 20);
            this.cob.TabIndex = 7;
            this.cob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // children
            // 
            this.children.Location = new System.Drawing.Point(823, 356);
            this.children.Name = "children";
            this.children.Size = new System.Drawing.Size(301, 20);
            this.children.TabIndex = 15;
            this.children.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eid_KeyPress);
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(823, 230);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(301, 20);
            this.zip.TabIndex = 13;
            this.zip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eid_KeyPress);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(823, 115);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(301, 20);
            this.city.TabIndex = 12;
            this.city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(823, 56);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(301, 20);
            this.address.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID Number";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(41, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(41, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(41, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(438, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(438, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Country of Birth";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(438, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Emigration Date";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(438, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Start Date";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(438, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "End Date";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(829, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(829, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "City";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(829, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Zip Code";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(829, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Marital status";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(829, 328);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Ammount of children";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(829, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Country";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(823, 174);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(301, 20);
            this.country.TabIndex = 31;
            this.country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
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
            this.marital.Location = new System.Drawing.Point(823, 291);
            this.marital.Name = "marital";
            this.marital.Size = new System.Drawing.Size(301, 21);
            this.marital.TabIndex = 34;
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(32, 300);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(301, 21);
            this.gender.TabIndex = 35;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(500, 271);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(531, 150);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
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
            this.dob_day.Location = new System.Drawing.Point(441, 56);
            this.dob_day.Name = "dob_day";
            this.dob_day.Size = new System.Drawing.Size(66, 21);
            this.dob_day.TabIndex = 38;
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
            this.dob_month.Location = new System.Drawing.Point(522, 56);
            this.dob_month.Name = "dob_month";
            this.dob_month.Size = new System.Drawing.Size(66, 21);
            this.dob_month.TabIndex = 39;
            // 
            // dob_year
            // 
            this.dob_year.Location = new System.Drawing.Point(607, 58);
            this.dob_year.MaxLength = 4;
            this.dob_year.Name = "dob_year";
            this.dob_year.Size = new System.Drawing.Size(79, 20);
            this.dob_year.TabIndex = 40;
            this.dob_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eid_KeyPress);
            // 
            // sdate_year
            // 
            this.sdate_year.Location = new System.Drawing.Point(607, 237);
            this.sdate_year.MaxLength = 4;
            this.sdate_year.Name = "sdate_year";
            this.sdate_year.Size = new System.Drawing.Size(79, 20);
            this.sdate_year.TabIndex = 43;
            this.sdate_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eid_KeyPress);
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
            this.sdate_month.Location = new System.Drawing.Point(522, 235);
            this.sdate_month.Name = "sdate_month";
            this.sdate_month.Size = new System.Drawing.Size(66, 21);
            this.sdate_month.TabIndex = 42;
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
            this.sdate_day.Location = new System.Drawing.Point(441, 235);
            this.sdate_day.Name = "sdate_day";
            this.sdate_day.Size = new System.Drawing.Size(66, 21);
            this.sdate_day.TabIndex = 41;
            // 
            // endate_year
            // 
            this.endate_year.Enabled = false;
            this.endate_year.Location = new System.Drawing.Point(607, 293);
            this.endate_year.MaxLength = 4;
            this.endate_year.Name = "endate_year";
            this.endate_year.Size = new System.Drawing.Size(79, 20);
            this.endate_year.TabIndex = 46;
            this.endate_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eid_KeyPress);
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
            this.endate_month.Location = new System.Drawing.Point(522, 291);
            this.endate_month.Name = "endate_month";
            this.endate_month.Size = new System.Drawing.Size(66, 21);
            this.endate_month.TabIndex = 45;
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
            this.endate_day.Location = new System.Drawing.Point(441, 291);
            this.endate_day.Name = "endate_day";
            this.endate_day.Size = new System.Drawing.Size(66, 21);
            this.endate_day.TabIndex = 44;
            // 
            // emdate_year
            // 
            this.emdate_year.Enabled = false;
            this.emdate_year.Location = new System.Drawing.Point(607, 176);
            this.emdate_year.MaxLength = 4;
            this.emdate_year.Name = "emdate_year";
            this.emdate_year.Size = new System.Drawing.Size(79, 20);
            this.emdate_year.TabIndex = 49;
            this.emdate_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eid_KeyPress);
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
            this.emdate_month.Location = new System.Drawing.Point(522, 174);
            this.emdate_month.Name = "emdate_month";
            this.emdate_month.Size = new System.Drawing.Size(66, 21);
            this.emdate_month.TabIndex = 48;
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
            this.emdate_day.Location = new System.Drawing.Point(441, 174);
            this.emdate_day.Name = "emdate_day";
            this.emdate_day.Size = new System.Drawing.Size(66, 21);
            this.emdate_day.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(977, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 56);
            this.button2.TabIndex = 50;
            this.button2.Text = "Return to Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.departments.Location = new System.Drawing.Point(32, 370);
            this.departments.Name = "departments";
            this.departments.Size = new System.Drawing.Size(301, 21);
            this.departments.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 344);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Department";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 423);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Wage Class";
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
            this.wageClass.Location = new System.Drawing.Point(38, 453);
            this.wageClass.Name = "wageClass";
            this.wageClass.Size = new System.Drawing.Size(294, 21);
            this.wageClass.TabIndex = 54;
            this.wageClass.SelectedIndexChanged += new System.EventHandler(this.wageClass_SelectedIndexChanged);
            // 
            // wageInput
            // 
            this.wageInput.Enabled = false;
            this.wageInput.Location = new System.Drawing.Point(116, 490);
            this.wageInput.Name = "wageInput";
            this.wageInput.Size = new System.Drawing.Size(135, 20);
            this.wageInput.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 493);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "Global Wage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 604);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox eid;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox cob;
        private System.Windows.Forms.TextBox children;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.ComboBox marital;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox dob_day;
        private System.Windows.Forms.ComboBox dob_month;
        private System.Windows.Forms.TextBox dob_year;
        private System.Windows.Forms.TextBox sdate_year;
        private System.Windows.Forms.ComboBox sdate_month;
        private System.Windows.Forms.ComboBox sdate_day;
        private System.Windows.Forms.TextBox endate_year;
        private System.Windows.Forms.ComboBox endate_month;
        private System.Windows.Forms.ComboBox endate_day;
        private System.Windows.Forms.TextBox emdate_year;
        private System.Windows.Forms.ComboBox emdate_month;
        private System.Windows.Forms.ComboBox emdate_day;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox departments;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox wageClass;
        private System.Windows.Forms.TextBox wageInput;
        private System.Windows.Forms.Label label19;
    }
}

