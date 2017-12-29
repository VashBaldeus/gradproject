using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Menus
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.temp = textBoxID.Text;//saves user input for further select query in SalarySheet class;

            using (SalarySheet sals = new SalarySheet())
                sals.ShowDialog();//opens the SalarySheet class using the data to display according the query;
        }
    }
}
