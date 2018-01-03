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

            ToolTip toolTip = new ToolTip();//adds a note on hover for the button explaining what it does;
            toolTip.SetToolTip(dateTimePickerArchiveDate, "בחירת חודש ושנה רצויים");
            toolTip.SetToolTip(checkBoxArchive, "הפעל סימון ובחר תאריך");
        }

        private void buttonRunReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text == "")//checks if ID field left empty, sends error message accordingly;
                    throw new Exception("השארת שדות ריקים");

                Properties.Settings.Default.tempid = textBoxID.Text;//saves the id for use in HourReportSheet class;

                if (checkBoxArchive.Checked != false)
                {//checks if user wants to access the Archive table or not;
                    Properties.Settings.Default.temp = $"enter_time LIKE '{dateTimePickerArchiveDate.Value.Year.ToString()}-{dateTimePickerArchiveDate.Value.Month.ToString()}-%' AND (eid={textBoxID.Text} OR id={textBoxID.Text})";//saves the search query parameters for the report;
                    Properties.Settings.Default.archive = true;
                }
                else Properties.Settings.Default.temp = $"eid={textBoxID.Text} OR id={textBoxID.Text}";//saves the search query parameters for the report;

                using (HourReportSheet hrs = new HourReportSheet())
                    hrs.ShowDialog();//opens the report window with menu to print the report;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
