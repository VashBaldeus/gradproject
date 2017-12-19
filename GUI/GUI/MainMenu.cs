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
        LoadCityCountry lcc = new LoadCityCountry();
        public DataTable city = new DataTable();
        public DataTable country = new DataTable();

        public MainMenu()
        {
            InitializeComponent();

            /*tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage1);*/

            city = dh.LoadCityCodes();//lcc.exceldata("city.xlsx");
            country = dh.LoadCountryCodes();//lcc.exceldata("country.xlsx");


        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public DataTable GetCity()
        {
            return city;
        }

        public DataTable GetCountry()
        {
            return country;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.ShowDialog();
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
