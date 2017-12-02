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
        
        public MainMenu()
        {
            InitializeComponent();

            /*tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage1);*/
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
