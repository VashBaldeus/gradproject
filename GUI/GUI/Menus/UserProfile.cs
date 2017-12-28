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
    public partial class UserProfile : Form
    {
        DataHandler dh = new DataHandler();

        public UserProfile()
        {
            InitializeComponent();

            textBoxCurPW.PasswordChar = '*';//hides the text of the textBox;
            textBoxNewPW.PasswordChar = '*';
            textBoxNewPWV.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dh.LoginAuthentication(Properties.Settings.Default.username, dh.Hash512(textBoxCurPW.Text)) != true)
                    throw new Exception("סיסמה נוכחית שגוייה, נסה שוב.");//checks whether current password if correct before changing it;

                if (textBoxNewPW.Text != textBoxNewPWV.Text)//checks new password fields are the same;
                    throw new Exception("סיסמאות אינן תואמות, נסה שוב.");

                DialogResult result = MessageBox.Show("אתה בטוח שאתה רוצה לשנות סיסמה?", "אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(result == DialogResult.Yes)//uses a MessageBox to verify the user wants to replace their password before actually doing that;
                {
                    dh.ExecuteServerQuery("UPDATE employees SET passwd=? WHERE id=?",dh.Hash512(textBoxNewPW.Text),Properties.Settings.Default.username);

                    textBoxCurPW.ResetText();
                    textBoxNewPW.ResetText();
                    textBoxNewPWV.ResetText();
                    MessageBox.Show("סיסמה הוחלפה בהצלחה", "אישור", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
