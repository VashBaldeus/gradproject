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
    public partial class HourReportSheet : Form
    {
        public HourReportSheet()
        {
            InitializeComponent();
        }

        private void HourReportSheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hrDataSet.archived_reports' table. You can move, or remove it, as needed.
            this.archived_reportsTableAdapter.Fill(this.hrDataSet.archived_reports);
            // TODO: This line of code loads data into the 'hrDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hrDataSet.employees);
            // TODO: This line of code loads data into the 'hrDataSet.reports' table. You can move, or remove it, as needed.
            this.reportsTableAdapter.Fill(this.hrDataSet.reports);


            if (Properties.Settings.Default.archive != false)//checks if user wants to search Archive or not;
            {
                using (hrDataSetTableAdapters.reportsTableAdapter db = new hrDataSetTableAdapters.reportsTableAdapter())
                {//pulls the data of the reports table from the database;
                    using (DataTable dt = db.GetData())
                    {
                        reportsBindingSource.DataSource = dt.Select(Properties.Settings.Default.temp).ToList();//filters the data according to previous sent query;
                    }
                }
            }
            else
            {
                using(hrDataSetTableAdapters.archived_reportsTableAdapter db = new hrDataSetTableAdapters.archived_reportsTableAdapter())
                {//pulls the data of archived_reports table from the databasel
                    using (DataTable dt = db.GetData())
                    {
                        reportsBindingSource.DataSource = dt.Select(Properties.Settings.Default.temp).ToList();//filters the data according to previous sent query;
                    }
                }
            }

            using (hrDataSetTableAdapters.employeesTableAdapter db = new hrDataSetTableAdapters.employeesTableAdapter())
            {
                using (DataTable dt = db.GetData())
                {//pulls the data of the employees table from database;
                    employeesBindingSource.DataSource = dt.Select($"eid={Properties.Settings.Default.tempid} OR id={Properties.Settings.Default.tempid}").ToList();//filters the data according to previous sent query;
                }
            }

            this.reportViewer1.RefreshReport();//reload the report form with pulled data;
        }

        private void HourReportSheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.archive = false;//reset the statement of the variables for repeat use;
            Properties.Settings.Default.tempid = "";
            Properties.Settings.Default.temp = "";
        }
    }
}
