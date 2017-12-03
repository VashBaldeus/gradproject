using MySql.Data.MySqlClient;//You need to have MySQL.Data installed via NuGet.
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class DataHandler
    {
        private static string dbHost = "vps.vashbaldeus.pw";
        private static string dbUsername = "hr";
        private static string dbPassword = "3d1*M7dS4&Gy5f";
        /*
        private static string dbHost = "localhost";
        private static string dbUsername = "root";
        private static string dbPassword = "password";
        */
        private static string dbName = "hr";

        private static string dbString = $"Server={dbHost}; database={dbName}; UID={dbUsername}; password={dbPassword}";

        MySqlConnection connection = new MySqlConnection(dbString);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public string GetDBString()
        {
            return dbString;
        }

        private void ImportTable(string query)
        {
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
            ImportTable($"SELECT * FROM users where eid={username} or id={username}");

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["eid"].ToString() == username || dr["id"].ToString() == username)
                {
                    if (dr["password"].ToString() == password)
                        return true;
                    else return false;
                }
                else return false;
            }
            return false;
        }

    }
}
