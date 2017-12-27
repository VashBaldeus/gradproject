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
        #region MySQL Connection String
        private static string dbHost = "vps.vashbaldeus.pw";
        private static string dbUsername = "hr";
        private static string dbPassword = "3d1*M7dS4&Gy5f";

        /*private static string dbHost = "localhost";
        private static string dbUsername = "root";
        private static string dbPassword = "password";*/
        
        private static string dbName = "hr";

        private static string dbString = $"Server={dbHost}; database={dbName}; UID={dbUsername}; password={dbPassword}; charset=hebrew;";
    
        MySqlConnection connection = new MySqlConnection(dbString);
        #endregion

        DataTable dt = new DataTable();

        #region MySQL Query Processing
        private void ImportTable(string query)//function recieves a query string using that to pull data into a DataTable;
        {
            dt.PrimaryKey = null;
            dt.Rows.Clear();
            dt.Columns.Clear();

            using (var da = new MySqlDataAdapter(new MySqlCommand(query, connection)))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

        }

        public DataTable GetTable(string query)//function returns a DataTable full of data that was pulled using the query;
        {
            ImportTable(query);
            return dt.Copy();
        }

        public void ExecuteServerQuery(string query)//function recieves a string containing a query, and performs the query to the server;
        {
            using (MySqlConnection connection = new MySqlConnection(dbString))
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = query;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                cmd.Dispose();
            }
        }

        public void ExecuteServerQuery(string query, params object[] parameters)//function recieves a string containing a query, and performs the query to the server;
        {
            using (MySqlConnection connection = new MySqlConnection(dbString))
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = query;

                for (var i = 0; i != parameters.Length; ++i)
                    cmd.Parameters.AddWithValue(i.ToString(), parameters[i]);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                cmd.Dispose();
            }
        }
        #endregion

        #region DateTime
        public string GetCurTime()
        {
            return DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        public string GetCurDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
        #endregion

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

        #region LoginAuth
        public bool IsHRMember(string name)
        {
            foreach (DataRow dr in GetTable($"SELECT id, ishr FROM employees WHERE id='{name}'").Rows)
            {
                if (dr["id"].ToString() == name && dr["ishr"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }

        public bool UserLoginPermissionChk(string username, string password)
        {
            foreach (DataRow dr in GetTable($"SELECT id, userlogin FROM employees WHERE id='{username}'").Rows)
            {
                if (dr["id"].ToString() == username && dr["userlogin"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }

        public bool LoginAuthentication(string username, string password)
        {
            foreach (DataRow dr in GetTable($"SELECT id, passwd FROM employees WHERE id='{username}'").Rows)//LoadEmployees().Rows)
            {
                if (dr["id"].ToString() == username && dr["passwd"].ToString() == password)
                    return true;
                else return false;
            }

            return false;
        }
        #endregion

        #region TimeKeeper
        public bool ChkEID(string id)
        {
            foreach (DataRow dr in GetTable($"SELECT eid FROM employees WHERE eid='{id}'").Rows)
            {
                if (dr["eid"].ToString() == id)
                    return true;
                else return false;
            }

            return false;
        }

        public bool ChkTKEnter(string id)
        {
            DateTime now = DateTime.Now;

            foreach(DataRow dr in GetTable($"SELECT eid, enter_time FROM reports WHERE eid='{id}'").Rows)
            {
                if (dr["eid"].ToString() == id)
                {
                    return true;
                }
                else return false;
            }

            return false;
        }

        public bool ChkTKExit(string id)
        {
            return false;
        }
        #endregion

        #region Permissions
        public bool GetPermAdd()
        {
            foreach(DataRow dr in GetTable($"SELECT id, addp FROM employees WHERE id={Properties.Settings.Default.username}").Rows)
            {
                if (dr["id"].ToString() == Properties.Settings.Default.username && dr["addp"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }

        public bool GetPermAlter()
        {
            foreach (DataRow dr in GetTable($"SELECT id, alterp FROM employees WHERE id={Properties.Settings.Default.username}").Rows)
            {
                if (dr["alterp"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }

        public bool GetPermHours()
        {
            foreach (DataRow dr in GetTable($"SELECT id, hours FROM employees WHERE id={Properties.Settings.Default.username}").Rows)
            {
                if (dr["id"].ToString() == Properties.Settings.Default.username && dr["hours"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }

        public bool GetPermUserPrpfile()
        {
            foreach (DataRow dr in GetTable($"SELECT id, userprofile FROM employees WHERE id={Properties.Settings.Default.username}").Rows)
            {
                if (dr["id"].ToString() == Properties.Settings.Default.username && dr["userprofile"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }
        #endregion

        public int GetDepartmentCode(string username)
        {
            foreach (DataRow dr in GetTable($"SELECT id, dcode FROM employees WHERE id={username}").Rows)
                if (dr["id"].ToString() == username)
                    return int.Parse(dr["dcode"].ToString());
                else return -1;

            return -1;
        }
    }
}
