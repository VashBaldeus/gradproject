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
    public partial class viewEmployees : Form
    {
        MySqlConnection conn = new MySqlConnection(Form1.dbString);
        private string columnName = "";
        private string searchParametrString = "";
        private string query = "";
        DataTable dt = new DataTable();
       
        public viewEmployees()
        {
            InitializeComponent();
            comboBox1.Visible = false;
            textBox1.Visible = false;
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

        private void searchPar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchPar.SelectedIndex == 2 || searchPar.SelectedIndex == 3 || searchPar.SelectedIndex == 7 || searchPar.SelectedIndex == 8)
                {
                    comboBox1.Visible = true;
                    textBox1.Visible = false;
                }
            else
                {
                    comboBox1.Visible = false;
                    textBox1.Visible = true;
                }

           
            switch (searchPar.SelectedIndex)
            {
                case 0:
                    {
                        columnName = "eid";
                        label2.Text = columnName;
                        searchParametrString = textBox1.Text;
                        break;
                    }
                case 1:
                    {
                        columnName = "id";
                        label2.Text = columnName;
                        searchParametrString = textBox1.Text;
                        break;
                    }

                case 2: 
                    {
                        columnName = "department";
                        label2.Text = columnName;
                        comboBox1.Visible = true;
                        comboBox1.Items.Clear();
                        comboBox1.Items.AddRange(new object[] {
                                                "Production",
                                                "Sales",
                                                "Human Resources",
                                                "Tech Support",
                                                "Administrative Assistant",
                                                "Director"});
                        break;
                    }
                case 3: 
                    {
                        columnName = "wageClass";
                        label2.Text = columnName;
                        comboBox1.Visible = true;
                        comboBox1.Items.Clear();
                        comboBox1.Items.AddRange(new object[] {
                                                    "Class D",
                                                    "Class C",
                                                    "Class B",
                                                    "Class A",
                                                    "Global"});
                        break;
                    }
                case 4:
                    {
                        columnName = "city";
                        label2.Text = columnName;
                        searchParametrString = textBox1.Text;
                        break;
                    }
                case 5:
                    {
                        columnName = "country";
                        label2.Text = columnName;
                        searchParametrString = textBox1.Text;
                        break;
                    }
                case 6:
                    {
                        columnName = "cob";
                        label2.Text = columnName;
                        searchParametrString = textBox1.Text;
                        break;
                    }
                case 7: 
                    {
                        columnName = "gender";
                        label2.Text = columnName;
                        comboBox1.Visible = true;
                        comboBox1.Items.Clear();
                        comboBox1.Items.AddRange(new object[] {
                                                     "Male",
                                                     "Female"});
                        break;
                    }
                case 8: 
                    {
                        columnName = "married";
                        label2.Text = columnName;
                        comboBox1.Visible = true;
                        comboBox1.Items.Clear();
                        comboBox1.Items.AddRange(new object[] {
                                                    "Single",
                                                    "Married",
                                                    "Divorced",
                                                    "Widowed"});
                        break;
                    }
                case 9:
                    {
                        textBox1.Visible = false;
                        break;
                    }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchParametrString = comboBox1.Text.ToString();
            label3.Text = searchParametrString;
        }

        public DataTable GetTable(string query)
        {
            ImportTable(query);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            using (conn)
            {
                dataGridView1.Rows.Clear();
                if (searchPar.Text.ToString() == "Load All")
                    query = "SELECT * FROM employees;";
                else
                    query = "SELECT * FROM employees where " + columnName + "='" + searchParametrString + "';";
                
                ImportTable(query);
                dt = GetTable(query);

                foreach (DataRow rdr in dt.Rows)
                {
                  dataGridView1.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(), rdr[8].ToString(), rdr[9].ToString(), rdr[10].ToString(), rdr[11].ToString(), rdr[12].ToString(), rdr[13].ToString(), rdr[14].ToString(), rdr[15].ToString(), rdr[16].ToString(), rdr[17].ToString());
                }
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchParametrString = textBox1.Text;
            label3.Text = searchParametrString;
        }
    }
}
