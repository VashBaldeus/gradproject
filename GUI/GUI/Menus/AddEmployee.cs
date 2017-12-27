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

        private void LoadComboBox()//function loads data from database and filld teh combo boxs;
        {
            comboBoxCityCode.DisplayMember = "city_name";
            comboBoxCityCode.ValueMember = "city_name";
            comboBoxCityCode.DataSource = main.GetCity();
            comboBoxCityCode.SelectedIndex = -1;

            comboBoxCountry.DisplayMember = "country_name";
            comboBoxCountry.ValueMember = "country_name";
            comboBoxCountry.DataSource = main.GetCountry();
            comboBoxCountry.SelectedIndex = -1;

            comboBoxCOB.DisplayMember = "country_name";
            comboBoxCOB.ValueMember = "country_name";
            comboBoxCOB.DataSource = main.GetCountry();
            comboBoxCOB.SelectedIndex = -1;

            comboBoxDept.DisplayMember = "dname";
            comboBoxDept.ValueMember = "dname";
            comboBoxDept.DataSource = main.GetDepartments();
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

                dh.ExecuteServerQuery("INSERT INTO employees(id,passwd,userlogin,userprofile,ishr,addp,alterp,hours,fname,lname,gender,dob,address,zip,city,country,cob,mdate,married,children,sdate,job_type,wage_class,dcode) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)",
                    long.Parse(textBoxID.Text), dh.Hash512(textBoxPASSWD.Text), perms[2], perms[1], perms[0], perms[3], perms[4], perms[5],
                    textBoxFName.Text, textBoxLName.Text, comboBoxGender.Text, dateTimePickerDOB.Value.Date.ToString("yyyy-MM-dd"),
                    textBoxStreet.Text, textBoxZIP.Text, comboBoxCityCode.SelectedIndex + 1, comboBoxCountry.SelectedIndex + 1, comboBoxCOB.SelectedIndex + 1, dateTimePickerMigDate.Value.Date.ToString("yyyy-MM-dd"),
                    comboBoxMarital.SelectedIndex, comboBoxChildren.SelectedIndex, dateTimePickerJStart.Value.Date.ToString("yyyy-MM-dd"), comboBoxJType.SelectedIndex, comboBoxSalary.SelectedIndex, comboBoxDept.SelectedIndex+1);

                DialogResult result = MessageBox.Show("הוספת עובד התבצעה בהצלחה, מעוניין להוסיף עוד עובד?", "אישור", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    ResetForm();
                else this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            {
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
