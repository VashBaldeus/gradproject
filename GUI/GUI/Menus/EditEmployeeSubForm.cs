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
    public partial class EditEmployeeSubForm : Form
    {
        DataHandler dh = new DataHandler();

        public EditEmployeeSubForm()
        {
            InitializeComponent();
            LoadFormData();
        }

        private void LoadFormData()
        {
            using(EditEmployee ee = new EditEmployee())
            {
                using(DataTable dt = dh.GetTable($"SELECT * FROM employees WHERE eid={Properties.Settings.Default.temp} OR id={Properties.Settings.Default.temp}"))
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        this.Text = $"עריכת עובד - {dr["fname"].ToString()} {dr["lname"].ToString()}";

                        textBoxEID.Text = dr["eid"].ToString();
                        textBoxID.Text = dr["id"].ToString();
                        textBoxFName.Text = dr["fname"].ToString();
                        textBoxLName.Text = dr["lname"].ToString();
                        comboBoxGender.Text = dr["gender"].ToString();
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //LoadFormData();
            EditEmployee ee = new EditEmployee();

            MessageBox.Show(Properties.Settings.Default.temp);
        }
    }
}
