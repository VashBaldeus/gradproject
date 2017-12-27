using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Menus
{
    public partial class EditEmployeeSubForm : Form
    {
        MainMenu main = new MainMenu();
        DataHandler dh = new DataHandler();

        public EditEmployeeSubForm()
        {
            InitializeComponent();
            LoadComboBox();
            LoadFormData();

            if (dh.IsHRMember(Properties.Settings.Default.username) != true)
            {//checks whether user is part of Human Resources or not, if false then asigns controls to read-only mode;
                checkedListBoxPermissions.SelectionMode = SelectionMode.None;
                textBoxPASSWD.ReadOnly = true;
            }
        }

        private void LoadComboBox()//calls for data from MainMenu WinForm in order to fill the comboBox fields;
        {
            comboBoxCity.DisplayMember = "city_name";
            comboBoxCity.ValueMember = "city_name";
            comboBoxCity.DataSource = main.GetCity();

            comboBoxCountry.DisplayMember = "country_name";
            comboBoxCountry.ValueMember = "country_name";
            comboBoxCountry.DataSource = main.GetCountry();

            comboBoxCOB.DisplayMember = "country_name";
            comboBoxCOB.ValueMember = "country_name";
            comboBoxCOB.DataSource = main.GetBCountry();

            comboBoxDpt.DisplayMember = "dname";
            comboBoxDpt.ValueMember = "dname";
            comboBoxDpt.DataSource = main.GetDepartments();
        }

        private void LoadFormData()
        {
            using(EditEmployee ee = new EditEmployee())
            {
                string query = "";

                if (dh.IsHRMember(Properties.Settings.Default.username))//checks whether user is member of Human Resources, loading data accordingly;
                    query = $"SELECT * FROM employees WHERE eid={Properties.Settings.Default.temp} OR id={Properties.Settings.Default.temp}";
                else query = $"SELECT * FROM employees WHERE (eid={Properties.Settings.Default.temp} OR id={Properties.Settings.Default.temp}) AND dcode={dh.GetDepartmentCode(Properties.Settings.Default.username)}";

                using (DataTable dt = dh.GetTable(query))
                {//calls on DataHandler class to execute the query and pull data from the SQL server.
                    foreach(DataRow dr in dt.Rows)
                    {
                        this.Text = $"עריכת עובד - {dr["fname"].ToString()} {dr["lname"].ToString()}";

                        textBoxEID.Text = dr["eid"].ToString();
                        textBoxID.Text = dr["id"].ToString();
                        textBoxFName.Text = dr["fname"].ToString();
                        textBoxLName.Text = dr["lname"].ToString();
                        comboBoxGender.Text = dr["gender"].ToString();
                        textBoxStreet.Text = dr["address"].ToString();
                        textBoxZIP.Text = dr["zip"].ToString();

                        comboBoxCity.SelectedIndex = int.Parse(dr["city"].ToString()) - 1;
                        comboBoxCountry.SelectedIndex = int.Parse(dr["country"].ToString()) - 1;
                        comboBoxCOB.SelectedIndex = int.Parse(dr["cob"].ToString()) - 1;
                        comboBoxDpt.SelectedIndex = int.Parse(dr["dcode"].ToString()) - 1;
                        comboBoxKids.SelectedIndex = int.Parse(dr["children"].ToString());
                        comboBoxMarital.SelectedIndex = int.Parse(dr["married"].ToString());
                        comboBoxJType.SelectedIndex = int.Parse(dr["job_type"].ToString());
                        comboBoxSalary.SelectedIndex = int.Parse(dr["wage_class"].ToString());

                        if (dr["ishr"].ToString() != "0")
                            checkedListBoxPermissions.SetItemChecked(0, true);

                        if(dr["userprofile"].ToString() != "0")
                            checkedListBoxPermissions.SetItemChecked(1, true);

                        if (dr["userlogin"].ToString() != "0")
                            checkedListBoxPermissions.SetItemChecked(2, true);

                        if (dr["addp"].ToString() != "0")
                            checkedListBoxPermissions.SetItemChecked(3, true);

                        if (dr["alterp"].ToString() != "0")
                            checkedListBoxPermissions.SetItemChecked(4, true);

                        if (dr["hours"].ToString() != "0")
                            checkedListBoxPermissions.SetItemChecked(5, true);

                        dateTimePickerDOB.Value = DateTime.Parse(dr["dob"].ToString());
                        dateTimePickerMigration.Value = DateTime.Parse(dr["mdate"].ToString());
                        dateTimePickerJStart.Value = DateTime.Parse(dr["sdate"].ToString());
                        if (dr["endate"].ToString() != "")
                            dateTimePickerJEnd.Value = DateTime.Parse(dr["endate"].ToString());
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Controls.OfType<TextBox>().Where(t => t != textBoxPASSWD).Any(t => string.IsNullOrEmpty(t.Text)) || this.Controls.OfType<ComboBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                    throw new Exception("השארת שדות ריקים"); //condition checks whether the form fields are not left empty, if true sends a pop up message;

                foreach (DataRow dr in dh.GetTable("select eid,id,fname,lname from employees").Rows)
                    if (dr["id"].ToString() == textBoxID.Text && dr["fname"].ToString() == textBoxFName.Text && dr["lname"].ToString() == textBoxLName.Text && dr["eid"].ToString() != textBoxEID.Text)
                        throw new Exception("עובד תחת השם הזה קיים במסד נתונים");//function checks whether employee under said ID, Name, or Lastname exists in the database.

                #region Permissions Settings
                int[] perms = new int[6];

                for (int i = 0; i < 6; i++)
                    perms[i] = 0;

                foreach (int index in checkedListBoxPermissions.CheckedIndices)
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

                if (textBoxPASSWD.Text != "")//checks if password field left empty or not and performs a query accordingly;
                    dh.ExecuteServerQuery("UPDATE employees SET id=?,passwd=?,userlogin=?,userprofile=?,ishr=?,addp=?,alterp=?,hours=?,fname=?,lname=?,gender=?,dob=?,address=?,zip=?,city=?,country=?,cob=?,mdate=?,married=?,children=?,sdate=?,job_type=?,wage_class=?,dcode=? WHERE eid=?",
                        long.Parse(textBoxID.Text), dh.Hash512(textBoxPASSWD.Text), perms[2], perms[1], perms[0], perms[3], perms[4], perms[5],
                        textBoxFName.Text, textBoxLName.Text, comboBoxGender.Text, dateTimePickerDOB.Value.Date.ToString("yyyy-MM-dd"),
                        textBoxStreet.Text, textBoxZIP.Text, comboBoxCity.SelectedIndex + 1, comboBoxCountry.SelectedIndex + 1, comboBoxCOB.SelectedIndex + 1,
                        dateTimePickerMigration.Value.Date.ToString("yyyy-MM-dd"), comboBoxMarital.SelectedIndex, comboBoxKids.SelectedIndex, dateTimePickerJStart.Value.Date.ToString("yyyy-MM-dd"),
                        comboBoxJType.SelectedIndex, comboBoxSalary.SelectedIndex, comboBoxDpt.SelectedIndex + 1, long.Parse(textBoxEID.Text));
                else dh.ExecuteServerQuery("UPDATE employees SET id=?,userlogin=?,userprofile=?,ishr=?,addp=?,alterp=?,hours=?,fname=?,lname=?,gender=?,dob=?,address=?,zip=?,city=?,country=?,cob=?,mdate=?,married=?,children=?,sdate=?,job_type=?,wage_class=?,dcode=? WHERE eid=?",
                        long.Parse(textBoxID.Text), perms[2], perms[1], perms[0], perms[3], perms[4], perms[5],
                        textBoxFName.Text, textBoxLName.Text, comboBoxGender.Text, dateTimePickerDOB.Value.Date.ToString("yyyy-MM-dd"),
                        textBoxStreet.Text, textBoxZIP.Text, comboBoxCity.SelectedIndex + 1, comboBoxCountry.SelectedIndex + 1, comboBoxCOB.SelectedIndex + 1,
                        dateTimePickerMigration.Value.Date.ToString("yyyy-MM-dd"), comboBoxMarital.SelectedIndex, comboBoxKids.SelectedIndex, dateTimePickerJStart.Value.Date.ToString("yyyy-MM-dd"),
                        comboBoxJType.SelectedIndex, comboBoxSalary.SelectedIndex, comboBoxDpt.SelectedIndex + 1, long.Parse(textBoxEID.Text));

                DialogResult result = MessageBox.Show("השינויים נשמרו בהצלחה.", "אישור", MessageBoxButtons.OK);

                if (result == DialogResult.OK)
                    this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
