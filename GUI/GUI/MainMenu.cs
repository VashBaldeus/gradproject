using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Menus;

namespace GUI
{
    public partial class MainMenu : Form
    {
        DataHandler dh = new DataHandler();

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
            
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            using (var addemp = new AddEmployee())
                addemp.ShowDialog();
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee ee = new EditEmployee();
            ee.ShowDialog();
        }

        private void buttonHourReport_Click(object sender, EventArgs e)
        {
            HourReport hr = new HourReport();
            hr.ShowDialog();
        }

        private void buttonDepartments_Click(object sender, EventArgs e)
        {
            Departments dpt = new Departments();
            dpt.ShowDialog();
        }

        private void buttonSalary_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.ShowDialog();
        }

        private void buttonUserProfile_Click(object sender, EventArgs e)
        {
            UserProfile up = new UserProfile();
            up.ShowDialog();
        }
    }
}
