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
            if (textBoxID.Text == "")
                throw new Exception("השארת שדות ריקים");

            Properties.Settings.Default.tempid = textBoxID.Text;//saves user input for further select query in SalarySheet class;

            if (checkBoxArchive.Checked == true)
            {//checks if user wants to access the Archive table or not;
                Properties.Settings.Default.temp = $"enter_time LIKE '{dateTimePickerArchiveDate.Value.Year.ToString()}-{dateTimePickerArchiveDate.Value.Month.ToString()}-%' AND (eid={textBoxID.Text} OR id={textBoxID.Text})";//saves the search query parameters for the report;
                Properties.Settings.Default.archive = true;
            }
            else Properties.Settings.Default.temp = $"eid={textBoxID.Text} OR id={textBoxID.Text}";//saves the search query parameters for the report;

            using (SalarySheet sals = new SalarySheet())
                sals.ShowDialog();//opens the SalarySheet class using the data to display according the query;
        }
    }
}
