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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();

            DataSets.reportsDataSet rds = new DataSets.reportsDataSet();

            DataTable test = dh.GetTable("select * from reports");

            rds.Tables["reports"].Merge(test);

            HourReport hr = new HourReport();

            hr.ShowDialog();
        }
    }
}
