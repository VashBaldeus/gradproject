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
            /*DataSets.reportsDataSet db = new DataSets.reportsDataSet();
            reportsDataTableBindingSource.DataSource = db.reports.ToList();
            this.reportViewer1.RefreshReport();*/
        }
    }
}
