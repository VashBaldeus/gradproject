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
            this.Text = "Coeus Workforce Management";//renames form title text;

            textBoxPassword.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text == "" || textBoxPassword.Text == "")//checks whether fields are left empty;
                    throw new Exception("השארת שדות ריקים.");

                if (dh.UserLoginPermissionChk(textBoxUsername.Text, dh.Hash512(textBoxPassword.Text)) != true)
                    throw new Exception("אין לך הרשאה להתחבר למערכת.");//checks whether the user has permission to login;

                if (dh.LoginAuthentication(textBoxUsername.Text, dh.Hash512(textBoxPassword.Text))){
                    //^ condition checks username and password are correct, comparing them to database data;
                    Properties.Settings.Default.username = textBoxUsername.Text;//saves input of user for later use within the program;
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
