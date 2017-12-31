using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
                if (dh.ChkEID(textBoxID.Text) != true)//checks if employee types correct employee number or id;
                    throw new Exception("מספר עובד שגוי.");

                if (dh.ChkTKEnter(textBoxID.Text) != false)
                {
                    DateTime date = new DateTime();

                    date = DateTime.Now;

                    dh.ExecuteServerQuery($"INSERT INTO reports(eid,id,enter_time) values(?,?,?);",
                            textBoxID.Text, dh.GetID(textBoxID.Text), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    MessageBox.Show("ביצעת כניסה בהצלחה.", "אישור", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else throw new Exception("כניסה נדחתה, מהסיבות הבאות:\n1. אתה מנסה להכנס למערכת מוקדם מדי, חובה הפרש של מינימום 8 שעות בין משמרות.\n2. אתה כבר נכנסת.");

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
                if (dh.ChkEID(textBoxID.Text) != true)//checks if employee types correct employee number or id;
                    throw new Exception("מספר עובד שגוי.");

                if (dh.ChkTKExit(textBoxID.Text) != false)
                {
                    DateTime now = DateTime.Now;
                    dh.ExecuteServerQuery($"UPDATE reports SET exit_time=?, total_hours=? WHERE eid={textBoxID.Text} OR id={textBoxID.Text}",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), dh.TotalHours(now, textBoxID.Text));

                    MessageBox.Show("ביצעת יציאה בהצלחה.", "אישור", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else throw new Exception("ביצעת יציאה כבר.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
