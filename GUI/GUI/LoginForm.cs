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
            this.Text = "";

            //MessageBox.Show("Username: 123456789\nPassword: 1234");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show($"Username: {textBoxUsername.Text}\nPass: {textBoxPassword.Text}\nHash512: {dh.Hash512(textBoxPassword.Text)}\nResult: {dh.LoginAuthentication(textBoxUsername.Text, dh.Hash512(textBoxPassword.Text)).ToString()}");
                if (dh.LoginAuthentication(textBoxUsername.Text, dh.Hash512(textBoxPassword.Text))){
                    MainMenu main = new MainMenu();
                    main.Show();
                    this.Hide();
                }
                else throw new Exception("שם משתמש או סיסמה שגויים, נסה שוב!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonTKEenter_Click(object sender, EventArgs e)
        {

        }

        private void buttonTKExit_Click(object sender, EventArgs e)
        {

        }
    }
}
