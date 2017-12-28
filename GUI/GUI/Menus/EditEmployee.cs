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

        public EditEmployee()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.temp = textBoxSearchField.Text;//saves textBoxSearchField to later use in EditEmployeeSubForm;

                using (DataTable dtEditEmployee = dh.GetTable($"SELECT * FROM employees WHERE eid={textBoxSearchField.Text} OR id={textBoxSearchField.Text}"))
                {
                    if (dtEditEmployee != null)//makes sure DataTable is not empty;
                    {
                        if (dtEditEmployee.Rows.Count > 0)//makes sure DataTable has Rows;
                        {
                            using (EditEmployeeSubForm eesf = new EditEmployeeSubForm())
                                eesf.ShowDialog();//opens the EditEmployeeSubForm in order to load the employee data for editing;
                        }
                    }
                    else throw new Exception("מספר עובד או תעודת זהות שגויים");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearchField_KeyPress(object sender, KeyPressEventArgs e)
        {//function keeps track that only digits are types into the search field;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
