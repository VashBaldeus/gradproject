using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Subfolder links:
using GUI.Employee_Menus;
using GUI.Salary_Menus;

namespace GUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            LoginMenu LM = new LoginMenu();
            LM.Close();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonNewEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee AE = new Employee_Menus.AddEmployee();

            AE.ShowDialog();
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrintHourLog_Click(object sender, EventArgs e)
        {

        }
    }
}
