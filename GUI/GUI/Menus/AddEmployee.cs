using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Menus
{
    public partial class AddEmployee : Form
    {
        MainMenu main = new MainMenu();
        DataHandler dh = new DataHandler();

        DataTable city_codes = new DataTable();
        DataTable country = new DataTable();
        DataTable department = new DataTable();

        public AddEmployee()
        {
            InitializeComponent();


            
            LoadComboBox();
        }

        private void LoadComboBox()//function loads data from database and filld teh combo boxs;
        {
            city_codes = dh.GetTable("SELECT * FROM city_codes");
            foreach (DataRow dr in city_codes.Rows)
            {
                comboBoxCityCode.Items.Add(dr[1].ToString());
            }

            country = dh.GetTable("SELECT * FROM country_codes");
            foreach (DataRow dr in country.Rows)
            {
                comboBoxCountry.Items.Add(dr["country_name"].ToString());
                comboBoxCOB.Items.Add(dr["country_name"].ToString());
            }

            department = dh.GetTable("select * from departments");
            foreach (DataRow dr in department.Rows)
            {
                comboBoxDept.Items.Add(dr[1].ToString());
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)) || this.Controls.OfType<ComboBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                    throw new Exception("השארת שדות ריקים"); //condition checks whether the form fields are not left empty, if true sends a pop up message;

                foreach (DataRow dr in dh.GetTable("select id,fname,lname from employees").Rows)
                    if (dr["id"].ToString() == textBoxID.Text && dr["fname"].ToString() == textBoxFName.Text && dr["lname"].ToString() == textBoxLName.Text)
                        throw new Exception("עובד תחת השם הזה קיים במסד נתונים");//function checks whether employee under said ID, Name, or Lastname exists in the database.

                int jtype=-1, wtype=-1, dcode=-1, marital=-1, child=-1, cityn=0, countryn=0, cobn=0;

                #region Permissions Settings
                int[] perms = new int[6];

                for (int i = 0; i < 6; i++)
                    perms[i] = 0;

                foreach (int index in checkedListBoxUserPerms.CheckedIndices)
                {
                    switch (index)
                    {
                        case 0://חלק מכח אדם
                            perms[0]++;
                            break;
                        case 1://יכול לשנות סיסמה
                            perms[1]++;
                            break;
                        case 2://יכול להתחבר למערכת
                            perms[2]++;
                            break;
                        case 3://יכול להוסיף עובדים
                            perms[3]++;
                            break;
                        case 4://יכול לעשות שינויים לעובדים קיימים
                            perms[4]++;
                            break;
                        case 5://יכול לצפות בדו"ח שעות
                            perms[5]++;
                            break;
                    }
                }
                #endregion

                #region Data Covertion
                if (comboBoxJType.Text == "מלאה")
                    jtype = 1;
                else jtype = 0;

                if (comboBoxSalary.Text == "שעתי")
                    wtype = 1;
                else wtype = 0;

                switch (comboBoxMarital.Text)
                {
                    case "רווק/ה":
                        marital = 0;
                        break;
                    case "נשוי/אה":
                        marital = 1;
                        break;
                    case "גרוש/ה":
                        marital = 2;
                        break;
                    case "עלמנ/ה":
                        marital = 3;
                        break;
                }

                foreach(DataRow dr in city_codes.Rows)
                {
                    if (dr[1].ToString() == comboBoxCityCode.Text)
                        cityn = int.Parse(dr[0].ToString());
                }

                foreach(DataRow dr in country.Rows)
                {
                    if (dr[1].ToString() == comboBoxCountry.Text)
                        countryn = int.Parse(dr[0].ToString());

                    if (dr[1].ToString() == comboBoxCOB.Text)
                        cobn = int.Parse(dr[0].ToString());
                }

                foreach(DataRow dr in department.Rows)
                {
                    if (dr[1].ToString() == comboBoxDept.Text)
                        dcode = int.Parse(dr[0].ToString());
                }
            #endregion

            /*string insert = "INSERT INTO employees(id,passwd,userlogin,userprofile,ishr,addp,alterp,hours,fname,lname,gender,dob,address,zip,city,country,cob,mdate,married,children,sdate,job_type,wage_class,dcode)";
            string values = $"VALUES({long.Parse(textBoxID.Text)},'{dh.Hash512(textBoxPASSWD.Text)}', {perms[2]}, {perms[1]}, {perms[0]}, {perms[3]}, {perms[4]}, {perms[5]}, '{textBoxFName.Text}', '{textBoxLName.Text}', '{comboBoxGender.Text}', '{dateTimePickerDOB.Value.Date.ToString("yyyy-MM-dd")}',";
            string values2 = $"'{textBoxStreet.Text}', {long.Parse(textBoxZIP.Text)}, {cityn}, {countryn}, {cobn}, '{dateTimePickerMigDate.Value.Date.ToString("yyyy-MM-dd")}', {marital}, {child}, '{dateTimePickerJStart.Value.Date.ToString("yyyy-MM-dd")}', {jtype}, {wtype}, {dcode})";

            dh.ExecuteServerQuery($"{insert} {values}{values2}");*/

            var time = dateTimePickerDOB.Value.Date.Millisecond * 1000;

            dh.ExecuteServerQuery("INSERT INTO employees(id,passwd,userlogin,userprofile,ishr,addp,alterp,hours,fname,lname,gender,dob,address,zip,city,country,cob,mdate,married,children,sdate,job_type,wage_class,dcode) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", 
                long.Parse(textBoxID.Text), dh.Hash512(textBoxPASSWD.Text), perms[2], perms[1], perms[0], perms[3], perms[4], perms[5], textBoxFName.Text, textBoxLName.Text, comboBoxGender.Text, dateTimePickerDOB.Value.Date.ToString("yyyy-MM-dd"), textBoxStreet.Text, long.Parse(textBoxZIP.Text), cityn, countryn, cobn, dateTimePickerMigDate.Value.Date.ToString("yyyy-MM-dd"), marital, child, dateTimePickerJStart.Value.Date.ToString("yyyy-MM-dd"), jtype, wtype, dcode);
                
                ResetForm();
            /*}
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void buttonResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)//function verifies that only digits are allowed in textBoxID field;
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ResetForm()//function resets WinForm Text fields;
        {
            textBoxFName.Clear();
            textBoxLName.Clear();
            textBoxID.Clear();
            textBoxStreet.Clear();
            textBoxZIP.Clear();
            comboBoxGender.ResetText();
            dateTimePickerDOB.ResetText();
            dateTimePickerJStart.ResetText();
            dateTimePickerMigDate.ResetText();
            comboBoxChildren.ResetText();
            comboBoxCityCode.ResetText();
            comboBoxCOB.ResetText();
            comboBoxCountry.ResetText();
            comboBoxDept.ResetText();
            comboBoxGender.ResetText();
            comboBoxJType.ResetText();
            comboBoxMarital.ResetText();
            comboBoxSalary.ResetText();

            textBoxPASSWD.Clear();
            for (int i = 0; i < checkedListBoxUserPerms.Items.Count; i++)
               checkedListBoxUserPerms.SetItemChecked(i, false);
        }

        private void textBoxPASSWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
    }
}
