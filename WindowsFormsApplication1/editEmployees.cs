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

namespace WindowsFormsApplication1
{
    public partial class editEmployees : Form
    {
        MySqlConnection conn = new MySqlConnection(Form1.dbString);
        DataTable dt = new DataTable();
        public string updateString = "";
        public editEmployees()
        {
            InitializeComponent();
            conn.Open();
            using (conn)
            {
                string query = "SELECT * FROM employees WHERE eid='" + viewEmployees.eidStatic.ToString() + "';";

                ImportTable(query);
                dt = GetTable(query);

                foreach (DataRow rdr in dt.Rows)
                {
                    eid.Text = rdr[0].ToString();
                    id.Text = rdr[1].ToString();
                    fname.Text = rdr[2].ToString();
                    lname.Text = rdr[3].ToString();
                    address.Text = rdr[6].ToString();
                    zip.Text = rdr[7].ToString();
                    city.Text = rdr[8].ToString();
                    country.Text = rdr[9].ToString();
                    cob.Text = rdr[10].ToString();
                    children.Text = rdr[13].ToString();

                    DateTime dob = DateTime.Parse(rdr[5].ToString());
                    dob_year.Text = dob.Year.ToString();
                    cmbBox(dob_day, fixDate(dob.Day));
                    cmbBox(dob_month, fixDate(dob.Month));

                    DateTime sdate = DateTime.Parse(rdr[14].ToString());
                    sdate_year.Text = sdate.Year.ToString();
                    cmbBox(sdate_day, fixDate(sdate.Day));
                    cmbBox(sdate_month, fixDate(sdate.Month));

                    cmbBox(gender, rdr[4].ToString());
                    cmbBox(marital, rdr[12].ToString());
                    cmbBox(departments, rdr[16].ToString());
                    cmbBox(wageClass, rdr[17].ToString());
                    
                }
                conn.Close();
            }

        }

        private string fixDate(int date)
        {
            if (date < 10)
            {
                return "0" + date.ToString(); 
            }
            else
            {
                return date.ToString(); 
            }
        }
        private void ImportTable(string query)
        {
            dt.Rows.Clear();

            using (var da = new MySqlDataAdapter(new MySqlCommand(query, conn)))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
        }

        public DataTable GetTable(string query)
        {
            ImportTable(query);
            return dt;
        }

        public void cmbBox(ComboBox cmbBoxName, string cmbBoxValue)
        {
            
            foreach (var item in cmbBoxName.Items)
            {
                if (item.ToString() == cmbBoxValue)
                {
                    cmbBoxName.SelectedItem = item;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (conn)
            {
                try
                {
                    updateString = "id = @id, fname = @fname";
                    string query = "UPDATE employees SET "+updateString+" WHERE eid='" + viewEmployees.eidStatic.ToString() + "';";
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@fname", fname.Text);
                        cmd.Parameters.AddWithValue("@lname", lname.Text);
                        cmd.ExecuteNonQuery();
                    }
                    DialogResult result = MessageBox.Show("Information updated successfully!", "Operation completed", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                       viewEmployees vE1 = new viewEmployees();
                        this.Close();
                        vE1.Show();
                    }
                    conn.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
