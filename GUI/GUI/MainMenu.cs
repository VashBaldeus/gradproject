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

            city = lcc.exceldata("city.xlsx");
            country = lcc.exceldata("country.xlsx");
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

        }

        private void buttonHourReport_Click(object sender, EventArgs e)
        {

        }

        private void buttonDepartments_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalary_Click(object sender, EventArgs e)
        {

        }

        private void buttonUserProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
