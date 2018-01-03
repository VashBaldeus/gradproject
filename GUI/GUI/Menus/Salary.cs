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
        DataHandler dh = new DataHandler();

        public Salary()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();//adds a note on hover for the button explaining what it does;
            toolTip.SetToolTip(buttonMoveToArchive, "מעביר כל דוחות לחודש נוכחי לארכיון,\nלחץ על זה לאחר ביצוע כל חישובי שכר.");
            toolTip.SetToolTip(dateTimePickerArchiveDate, "בחירת חודש ושנה רצויים");
            toolTip.SetToolTip(checkBoxArchive, "הפעל סימון ובחר תאריך");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMoveToArchive_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("האם ביצעת את כל החישובי שכר לחודש נוכחי?\nאם כן לחץ על אישור.", "אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {//checks if user clicked "Yes";
                    dh.ExecuteServerQuery("INSERT INTO archived_reports SELECT * FROM reports; DELETE FROM reports;");
                    //executes query that copies current month data to archive table, clearing current month table;

                    MessageBox.Show("הפעולה התבצעה בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox sends a confirmation message to the user;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
