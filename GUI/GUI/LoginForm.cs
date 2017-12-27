using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        DataHandler dh = new DataHandler();

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Coeus Workforce Management";

            textBoxPassword.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.temp = textBoxUsername.Text;

                if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
                    throw new Exception("השארת שדות ריקים.");

                if (dh.UserLoginPermissionChk(textBoxUsername.Text, dh.Hash512(textBoxPassword.Text)) != true)
                    throw new Exception("אין לך הרשאה להתחבר למערכת.");

                if (dh.LoginAuthentication(textBoxUsername.Text, dh.Hash512(textBoxPassword.Text))){
                    Properties.Settings.Default.username = textBoxUsername.Text;
                    MainMenu main = new MainMenu();
                    main.Show();
                    this.Hide();
                }
                else throw new Exception("שם משתמש או סיסמה שגויים, נסה שוב.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTKEenter_Click(object sender, EventArgs e)
        {
            try
            {
                if (dh.ChkEID(textBoxID.Text) != true)
                    throw new Exception("מספר עובד שגוי.");


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTKExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dh.ChkEID(textBoxID.Text) != true)
                    throw new Exception("מספר עובד שגוי.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetName()
        {
            return Properties.Settings.Default.temp;
        }
    }
}
