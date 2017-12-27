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
    public partial class EditEmployee : Form
    {
        DataHandler dh = new DataHandler();
        public DataTable dtEditEmployee = new DataTable();

        public string searchfield = "";

        public EditEmployee()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                searchfield = textBoxSearchField.Text;
                Properties.Settings.Default.temp = textBoxSearchField.Text;

                dtEditEmployee = dh.GetTable($"SELECT * FROM employees WHERE eid={textBoxSearchField.Text} OR id={textBoxSearchField.Text}");

                if (dtEditEmployee != null)
                {
                    if (dtEditEmployee.Rows.Count > 0)
                    {
                        EditEmployeeSubForm eesf = new EditEmployeeSubForm();
                        eesf.ShowDialog();
                    }
                }
                else throw new Exception("מספר עובד או תעודת זהות שגויים");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetEmployee()
        {
            return dtEditEmployee;
        }

        public string GetSearchData()
        {
            return searchfield;
        }

        private void textBoxSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
