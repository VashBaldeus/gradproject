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
    public partial class Departments : Form
    {
        MainMenu main = new MainMenu();
        DataHandler dh = new DataHandler();

        public Departments()
        {
            InitializeComponent();

            LoadFormComboBox();
        }

        private void LoadFormComboBox()
        {
            comboBoxDptList.Items.Clear();
            comboBoxDptList.DisplayMember = "dname";
            comboBoxDptList.ValueMember = "dname";
            comboBoxDptList.DataSource = main.GetDepartments();
            comboBoxDptList.SelectedIndex = -1;
        }

        private void buttonDelDpt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show($"אתה בטוח שאתה רוצה למחור את {comboBoxDptList.Text}", "אישור", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dh.ExecuteServerQuery("DELETE FROM departments WHERE dname=?", comboBoxDptList.Text);
                    comboBoxDptList.SelectedIndex = -1;
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddDpt_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                    throw new Exception("השארת שדות ריקים"); //condition checks whether the form fields are not left empty, if true sends a pop up message;

                if (dh.CheckDuplicateDepartment(textBoxDptName.Text) != false)
                    throw new Exception("מחלקה קיימת, וודא תקינות הטופס ונסה שוב.");

                dh.ExecuteServerQuery("INSERT INTO departments (dname, dlocation, dmngr, dphone) VALUES(?,?,?,?)",
                    textBoxDptName.Text, textBoxDptLocation.Text, textBoxDptMngr.Text, textBoxDptPhone.Text);

                this.Close();
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

        private void ResetForm()
        {
            comboBoxDptList.SelectedIndex = -1;

            textBoxDptName.ResetText();
            textBoxDptLocation.ResetText();
            textBoxDptMngr.ResetText();
            textBoxDptPhone.ResetText();
        }
    }
}
