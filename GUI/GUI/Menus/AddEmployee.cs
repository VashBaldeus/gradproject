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
    public partial class AddEmployee : Form
    {
        MainMenu main = new MainMenu();

        public AddEmployee()
        {
            InitializeComponent();

            DataTable city = main.GetCity();
            DataTable country = main.GetCountry();

            foreach(DataRow dr in city.Rows)
            {
                comboBoxCity.Items.Add(dr["name"].ToString());
            }

            foreach(DataRow dr in country.Rows)
            {
                comboBoxCountry.Items.Add(dr["name"].ToString());
                comboBoxCOB.Items.Add(dr["name"].ToString());
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetForm_Click(object sender, EventArgs e)
        {

        }
    }
}
