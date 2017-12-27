using GUI.Menus;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainMenu : Form
    {
        DataHandler dh = new DataHandler();

        public DataTable cityCodes = new DataTable();
        public DataTable countryCodes = new DataTable();
        public DataTable bcountryCodes = new DataTable();
        public DataTable deptCodes = new DataTable();

        public MainMenu()
        {
            InitializeComponent();

            #region Menu Tab Selection Check
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            
            if (dh.IsHRMember(Properties.Settings.Default.temp))
                tabControl1.TabPages.Add(tabPage1);
            else tabControl1.TabPages.Add(tabPage2);
            #endregion

            LoadDataTables();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region DataTable Load and Get Functions
        private void LoadDataTables()
        {
            cityCodes = dh.GetTable("SELECT city_name FROM city_codes");
            countryCodes = dh.GetTable("SELECT country_name FROM country_codes");
            bcountryCodes = dh.GetTable("SELECT country_name FROM country_codes");
            deptCodes = dh.GetTable("SELECT dname FROM departments");
        }

        public DataTable GetCity()
        {
            return cityCodes;
        }

        public DataTable GetCountry()
        {
            return countryCodes;
        }

        public DataTable GetBCountry()
        {
            return bcountryCodes;
        }

        public DataTable GetDepartments()
        {
            return deptCodes;
        }
    #endregion

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dh.GetPermAdd() != true)
                    throw new Exception("אין לך הרשאה להוסיף עובדים");

                using (var addemp = new AddEmployee())
                    addemp.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dh.GetPermAlter() != true)
                    throw new Exception("אין לך הרשאה לערוך עובדים");
                    
                using (EditEmployee ee = new EditEmployee())
                    ee.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonHourReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dh.GetPermAlter() != true)
                    throw new Exception("אין לך הרשאה לערוך עובדים");

                using (HourReport hr = new HourReport())
                    hr.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDepartments_Click(object sender, EventArgs e)
        {
            try
            {
                if (dh.GetPermAlter() != true)
                    throw new Exception("אין לך הרשאה לערוך עובדים");

                using (Departments dpt = new Departments())
                    dpt.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalary_Click(object sender, EventArgs e)
        {
            try
            {
                using (Salary sal = new Salary())
                    sal.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUserProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (dh.GetPermUserPrpfile() != true)
                    throw new Exception("אין לך הרשאה לערוך את הפרופיל משתמש שלך");

                using (UserProfile up = new UserProfile())
                    up.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
