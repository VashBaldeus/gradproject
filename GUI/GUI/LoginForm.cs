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
        public LoginForm()
        {
            InitializeComponent();
            this.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //for obvious reasons I did not require a login for now.
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void buttonTKEenter_Click(object sender, EventArgs e)
        {

        }

        private void buttonTKExit_Click(object sender, EventArgs e)
        {

        }
    }
}
