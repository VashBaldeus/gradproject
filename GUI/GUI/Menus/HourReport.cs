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
    public partial class HourReport : Form
    {
        public HourReport()
        {
            InitializeComponent();
        }

        private void HourReport_Load(object sender, EventArgs e)
        {
            /*// TODO: This line of code loads data into the 'hrDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hrDataSet.employees);
            // TODO: This line of code loads data into the 'hrDataSet.reports' table. You can move, or remove it, as needed.
            this.reportsTableAdapter.Fill(this.hrDataSet.reports);
            using (hrDataSetTableAdapters.reportsTableAdapter db = new hrDataSetTableAdapters.reportsTableAdapter())
            {
                using (DataTable dt = db.GetData())
                {
                    reportsBindingSource.DataSource = dt.Select("eid='1' or id='1'").ToList();
                }
            }

            using(hrDataSetTableAdapters.employeesTableAdapter db = new hrDataSetTableAdapters.employeesTableAdapter())
            {
                using(DataTable dt = db.GetData())
                {
                    employeesBindingSource.DataSource = dt.Select("eid='1' or id='1'").ToList();
                }
            }
            this.reportViewer1.RefreshReport();*/
        }

        private void buttonRunReport_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.temp = $"eid={textBoxID.Text} OR id={textBoxID.Text}";//saves the search query parameters for the report;
                using (HourReportSheet hrs = new HourReportSheet())
                    hrs.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
