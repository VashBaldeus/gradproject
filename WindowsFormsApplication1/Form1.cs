using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web.Security;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static string dbHost = "vps.vashbaldeus.pw";
        public static string dbName = "hr";
        public static string dbUsername = "hr";
        public static string dbPassword = "3d1*M7dS4&Gy5f";

        public static string dbString = $"Server={dbHost}; database={dbName}; UID={dbUsername}; password={dbPassword}";

        MySqlConnection connection = new MySqlConnection(dbString);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DateTime dob_date, sdate, emdate, endate;

        public Form1()
        {
            InitializeComponent();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            using (connection)
            {
                try
                {
                  //string query = "INSERT INTO testing (id, fname, lname) VALUES ('" + eid.Text + "', '" + id.Text + "', '" + fname.Text + "');";
                    //string query = "INSERT INTO employees (eid, id, fname, lname, gender, dob, address, zip, city, country, cob, mdate, married, children, sdate, endate) VALUES ('" + eid.Text + "', '" + id.Text + "','" + fname.Text + "', '" + lname.Text+"', '" + gender.Text.ToString() + "', '" + dob.Text + "', '" + cob.Text + "', '" + emdate.Text + "', '" + sdate.Text + "', '" + endate.Text + "', '" + address.Text + "', '" + city.Text + "', '" + country.Text + "', '" + zip.Text + "', '" + marital.Text.ToString() + "', '" + children.Text + "'); ";
                    string query = "INSERT INTO employees (eid, id, fname, lname, gender, dob, address, zip, city, country, cob, mdate, married, children, sdate, endate, department, wageClass) VALUES (@eid, @id, @fname, @lname, @gender, @dob, @address, @zip, @city, @country, @cob, @mdate, @married, @children, @sdate, @endate, @department, @wageClass);";
                    string queryUsers = "INSERT INTO users (eid, id, passwd) VALUES (@eidu, @idu, @passwd);";
                    connection.Open();
                        
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (checkBox1.Checked == false)
                            cmd.Parameters.AddWithValue("@endate", DBNull.Value); 
                        else
                            cmd.Parameters.AddWithValue("@endate", endate_year.Text + "-" + endate_month.Text + "-" + endate_day.Text);

                        if (checkBox2.Checked == false)
                            cmd.Parameters.AddWithValue("@mdate", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@mdate", emdate_year.Text + "-" + emdate_month.Text + "-" + emdate_day.Text);
                            
                        cmd.Parameters.AddWithValue("@eid", eid.Text);
                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@fname", fname.Text);
                        cmd.Parameters.AddWithValue("@lname", lname.Text);
                        cmd.Parameters.AddWithValue("@gender", gender.Text.ToString());
                        cmd.Parameters.AddWithValue("@dob", dob_year.Text + "-" + dob_month.Text + "-" + dob_day.Text);
                        cmd.Parameters.AddWithValue("@address", address.Text);
                        cmd.Parameters.AddWithValue("@zip", zip.Text);
                        cmd.Parameters.AddWithValue("@city", city.Text);
                        cmd.Parameters.AddWithValue("@country", country.Text);
                        cmd.Parameters.AddWithValue("@cob", cob.Text);
                        cmd.Parameters.AddWithValue("@married", marital.Text.ToString());
                        cmd.Parameters.AddWithValue("@children", children.Text);
                        cmd.Parameters.AddWithValue("@sdate", sdate_year.Text + "-" + sdate_month.Text + "-" + sdate_day.Text);
                        cmd.Parameters.AddWithValue("@department", departments.Text.ToString());
                        cmd.Parameters.AddWithValue("@wageClass", wageClass.Text.ToString());

                        using (MySqlCommand cmdu = new MySqlCommand(queryUsers, connection))
                        {
                            cmdu.Parameters.AddWithValue("@eidu", eid.Text);
                            cmdu.Parameters.AddWithValue("@idu", id.Text);
                            cmdu.Parameters.AddWithValue("@passwd", Membership.GeneratePassword(7, 2));

                            if (!checkEmptyFields())
                                throw new Exception("Some required fields are empty.");

                            if (checkDates())
                            {
                                cmdu.ExecuteNonQuery();
                                cmd.ExecuteNonQuery();
                            }

                            else
                                throw new Exception("Dates don't match!");
                        }
                    }
                    DialogResult result = MessageBox.Show("Employee added successfully!", "Operation completed", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        ClearText();
                    }

                    connection.Close();
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool checkDates()
        {
          dob_date = DateTime.Parse(dob_year.Text+"-" + dob_month.Text + "-" + dob_day.Text);
          sdate = DateTime.Parse(sdate_year.Text + "-" + sdate_month.Text + "-" + sdate_day.Text);
                    
            //DOB Year > Current year OR older than 70 OR younger than 18
            if (dob_date.Date > sdate.Date ||
                dob_date.Date > DateTime.Today ||
                dob_date.Date < DateTime.Today.AddYears(-70) ||
                sdate.Date > DateTime.Today ||
                dob_date.AddYears(18) > DateTime.Today) 
                    return false;

            if (checkBox1.Checked) //endate.Enabled
            {
                endate = DateTime.Parse(endate_year.Text + "-" + endate_month.Text + "-" + endate_day.Text);
                if (endate.Date > dob_date.Date ||
                    endate.Date < sdate.Date ||
                    endate.Date > DateTime.Today)
                    return false;
                if (checkBox2.Checked) //emdate.Enabled
                {
                    if (emdate > endate)
                        return false;
                }
            }
            if (checkBox2.Checked) //emdate >? stdate
            {
                emdate = DateTime.Parse(emdate_year.Text + "-" + emdate_month.Text + "-" + emdate_day.Text);
                if (emdate.Date < dob_date.Date)
                    return false;
            }
            return true;
        
        }

        private bool checkEmptyFields()
        {
            foreach (var tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Enabled==true && tb.Text == "")
                   return false;
            }
            foreach (var cb in this.Controls.OfType<ComboBox>())
            {
                if (cb.Enabled == true && cb.SelectedIndex == -1)
                    return false;
            }
            return true;
        }

        private void ClearText()
        {
            foreach (var textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = "";
            }

            foreach (var combobox in this.Controls.OfType<ComboBox>())
            {
                combobox.SelectedIndex = -1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
              endate_day.Enabled = checkBox1.Checked;
              endate_month.Enabled = checkBox1.Checked;
              endate_year.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            emdate_day.Enabled = checkBox2.Checked;
            emdate_month.Enabled = checkBox2.Checked;
            emdate_year.Enabled = checkBox2.Checked;
        }

        private void eid_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only digits allowed
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only letters and spacebar allowed
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu m1 = new menu();
            this.Close();
            m1.Show();
        }

        private void wageClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wageClass.SelectedIndex == 4) //Global Scale
                wageInput.Enabled = true;
            else
                wageInput.Enabled = false;
        }
    }
}
