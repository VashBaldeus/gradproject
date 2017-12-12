using MySql.Data.MySqlClient;//You need to have MySQL.Data installed via NuGet.
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    class DataHandler
    {
        #region Manual Connection Strings
        /*private static string dbHost = "vps.vashbaldeus.pw";
        private static string dbUsername = "hr";
        private static string dbPassword = "3d1*M7dS4&Gy5f";

        private static string dbHost = "localhost";
        private static string dbUsername = "root";
        private static string dbPassword = "password";

        private static string dbName = "hr";

        private static string dbString = $"Server={dbHost}; database={dbName}; UID={dbUsername}; password={dbPassword}";

        MySqlConnection connection = new MySqlConnection(dbString);*/
        #endregion
        HR dataset = new HR();
        DataTable datatable = new DataTable();

        /*private void ImportTable(string query)
        {
            //dt.PrimaryKey = null;
            dt.Rows.Clear();
            dt.Columns.Clear();

            using (var da = new MySqlDataAdapter(new MySqlCommand(query, connection)))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
        }

        public DataTable GetTable(string query)
        {
            ImportTable(query);

            return dt;
        }*/

        private void LoadUsers()
        {
            hrDataSetTableAdapters.usersTableAdapter usersTable = new hrDataSetTableAdapters.usersTableAdapter();
            datatable.Clear();
            datatable = usersTable.GetData();
        }

        private void LoadEmployees()
        {
            hrDataSetTableAdapters.employeesTableAdapter employeesTable = new hrDataSetTableAdapters.employeesTableAdapter();
            datatable.Clear();
            datatable = employeesTable.GetData();
        }

        public DataTable LoadCityCodes()
        {
            hrDataSetTableAdapters.city_codesTableAdapter city_codesTable = new hrDataSetTableAdapters.city_codesTableAdapter();
            datatable.Clear();
            return city_codesTable.GetData();
        }

        public DataTable LoadCountryCodes()
        {
            hrDataSetTableAdapters.country_codesTableAdapter country_codesTable = new hrDataSetTableAdapters.country_codesTableAdapter();
            datatable.Clear();
            return country_codesTable.GetData();
        }

        public string Hash512(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        public bool LoginAuthentication(string username, string password)
        {
            LoadUsers();
            foreach(DataRow dr in datatable.Rows)
            {
                if (dr["id"].ToString() == username)
                {
                    if (dr["passwd"].ToString() == password)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            return false;
        }

    }
}
