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
        DataTable dtEditEmployee = new DataTable();

        public EditEmployee()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dtEditEmployee.PrimaryKey = null;
            dtEditEmployee.Rows.Clear();
            dtEditEmployee.Columns.Clear();

            //dtEditEmployee = dh.GetTable($"SELECT * FROM employees WHERE eid={textBoxSearchField.Text} OR id={textBoxSearchField.Text}");

            if (dtEditEmployee != null)
            {
                MessageBox.Show("עובד לא נמצא!", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("עובד נמצא!", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                EditEmployeeSubForm eesb = new EditEmployeeSubForm();
                eesb.Show();
                this.Hide();
            }
        }

        public DataTable GetEmployee()
        {
            return dtEditEmployee;
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
