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
        DataHandler dh = new DataHandler();

        public AddEmployee()
        {
            InitializeComponent();

            DataTable city = dh.GetTable("SELECT * FROM city_codes");
            DataTable country = dh.GetTable("SELECT * FROM country_codes");

            foreach (DataRow dr in city.Rows)
            {
                comboBoxCity.Items.Add(dr[1].ToString());
            }

            foreach(DataRow dr in country.Rows)
            {
                comboBoxCountry.Items.Add(dr["country_name"].ToString());
                comboBoxCOB.Items.Add(dr["country_name"].ToString());
            }

            city.Dispose();
            country.Dispose();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ResetForm()
        {
            textBoxFName.Clear();
            textBoxLName.Clear();
            textBoxID.Clear();
            textBoxStreet.Clear();
            textBoxZIP.Clear();
            comboBoxGender.ResetText();
            dateTimePickerDOB.ResetText();
            dateTimePickerJStart.ResetText();
            dateTimePickerJEnd.ResetText();
            dateTimePickerMigDate.ResetText();
            comboBoxChildren.ResetText();
            comboBoxCity.ResetText();
            comboBoxCOB.ResetText();
            comboBoxCountry.ResetText();
            comboBoxDept.ResetText();
            comboBoxGender.ResetText();
            comboBoxJType.ResetText();
            comboBoxMarital.ResetText();
            comboBoxSalary.ResetText();
        }
    }
}
