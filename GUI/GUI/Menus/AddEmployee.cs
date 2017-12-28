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

        public AddEmployee()
        {
            InitializeComponent();

            LoadComboBox();
        }

        private void LoadComboBox()//function loads data from database and fills the comboBox's;
        {
            comboBoxCityCode.DisplayMember = "city_name";
            comboBoxCityCode.ValueMember = "city_name";
            comboBoxCityCode.DataSource = main.GetCity();//pulls CityCode DataTable from MainMenu form;
            comboBoxCityCode.SelectedIndex = -1;

            comboBoxCountry.DisplayMember = "country_name";
            comboBoxCountry.ValueMember = "country_name";
            comboBoxCountry.DataSource = main.GetCountry();//pulls CountryCode DataTable from MainMenu form;
            comboBoxCountry.SelectedIndex = -1;

            comboBoxCOB.DisplayMember = "country_name";
            comboBoxCOB.ValueMember = "country_name";
            comboBoxCOB.DataSource = main.GetCountry();//pulls CountryCode DataTable from MainMenu form;
            comboBoxCOB.SelectedIndex = -1;

            comboBoxDept.DisplayMember = "dname";
            comboBoxDept.ValueMember = "dname";
            comboBoxDept.DataSource = main.GetDepartments();//pulls DepartmentCode DataTable from MainMenu form;
            comboBoxDept.SelectedIndex = -1;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)) || this.Controls.OfType<ComboBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                    throw new Exception("השארת שדות ריקים"); //condition checks whether the form fields are not left empty, if true sends a pop up message;

                foreach (DataRow dr in dh.GetTable("select id,fname,lname from employees").Rows)
                    if (dr["id"].ToString() == textBoxID.Text && dr["fname"].ToString() == textBoxFName.Text && dr["lname"].ToString() == textBoxLName.Text)
                        throw new Exception("עובד תחת השם הזה קיים במסד נתונים");//function checks whether employee under said ID, Name, or Lastname exists in the database.

                #region Permissions Settings
                int[] perms = new int[6];

                for (int i = 0; i < 6; i++)
                    perms[i] = 0;//initiates the perms array with 0 values;

                foreach (int index in checkedListBoxUserPerms.CheckedIndices)
                {//checks each selection, assigns proper digit on 'perms' array;
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

                //dh.ExecuteServerQuery - pushes a query via DataHandler class;
                dh.ExecuteServerQuery("INSERT INTO employees(id,passwd,userlogin,userprofile,ishr,addp,alterp,hours,fname,lname,gender,dob,address,zip,city,country,cob,mdate,married,children,sdate,job_type,wage_class,dcode) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)",
                    long.Parse(textBoxID.Text), dh.Hash512(textBoxPASSWD.Text), perms[2], perms[1], perms[0], perms[3], perms[4], perms[5],
                    textBoxFName.Text, textBoxLName.Text, comboBoxGender.Text, dateTimePickerDOB.Value.Date.ToString("yyyy-MM-dd"),
                    textBoxStreet.Text, textBoxZIP.Text, comboBoxCityCode.SelectedIndex + 1, comboBoxCountry.SelectedIndex + 1, comboBoxCOB.SelectedIndex + 1, dateTimePickerMigDate.Value.Date.ToString("yyyy-MM-dd"),
                    comboBoxMarital.SelectedIndex, comboBoxChildren.SelectedIndex, dateTimePickerJStart.Value.Date.ToString("yyyy-MM-dd"), comboBoxJType.SelectedIndex, comboBoxSalary.SelectedIndex, comboBoxDept.SelectedIndex+1);

                DialogResult result = MessageBox.Show("הוספת עובד התבצעה בהצלחה, מעוניין להוסיף עוד עובד?", "אישור", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    ResetForm();//resets the form if user selected Yes on MessageBox;
                else this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();//calls the function that clears the form fields;
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)//function verifies that only digits are allowed in textBoxID field;
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {//makes sure that textBoxID field can not receive nothing except digits;
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
            comboBoxChildren.SelectedIndex = -1;
            comboBoxCityCode.SelectedIndex = -1;
            comboBoxCOB.SelectedIndex = -1;
            comboBoxCountry.SelectedIndex = -1;
            comboBoxDept.SelectedIndex = -1;
            comboBoxGender.SelectedIndex = -1;
            comboBoxJType.SelectedIndex = -1;
            comboBoxMarital.SelectedIndex = -1;
            comboBoxSalary.SelectedIndex = -1;

            textBoxPASSWD.Clear();
            for (int i = 0; i < checkedListBoxUserPerms.Items.Count; i++)
                checkedListBoxUserPerms.SetItemChecked(i, false);
        }

        private void textBoxPASSWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && char.IsPunctuation(e.KeyChar))
            {//function watches textBoxPASSWD field for non-english characters;
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
