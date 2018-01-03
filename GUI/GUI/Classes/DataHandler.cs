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

        /*private static string dbHost = "localhost";//kept here just in case there's internet issues to easily switch to local mysql server;
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
        public string GetCurTime()//returns current time in the following format HH:mm:ss i.e. 14:13:45;
        {
            return DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        public string GetCurDate()//returns current date in the following format yyyy-MM-dd i.e. 2017-12-31;
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
        #endregion

        public string Hash512(string password)//recieves a string, encrypts it in SHA512 and returns it back;
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
        public bool IsHRMember(string name)//checks whether a use is member of Human Resources;
        {
            foreach (DataRow dr in GetTable($"SELECT id, ishr FROM employees WHERE id='{name}'").Rows)
            {
                if (dr["id"].ToString() == name && dr["ishr"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }

        public bool UserLoginPermissionChk(string username, string password)//recieves user data to check whether he has a permission to login into sytstem;
        {
            foreach (DataRow dr in GetTable($"SELECT id, userlogin FROM employees WHERE id='{username}'").Rows)
            {
                if (dr["id"].ToString() == username && dr["userlogin"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }

        public bool LoginAuthentication(string username, string password)//checks user credentials in order to approve a login or deny it;
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

        #region TimeKeeper & Data Verification
        public bool ChkEID(string id)//verifies employee id exists in the database;
        {
            foreach (DataRow dr in GetTable($"SELECT eid,id FROM employees WHERE eid={id} OR id={id}").Rows)
            {
                if (dr["eid"].ToString() == id || dr["id"].ToString() == id)
                    return true;
                else return false;
            }

            return false;
        }

        public bool ChkTKEnter(string id)//checks employee enter time, to prevent duplicates;
        {
            using(DataTable dt = GetTable($"SELECT * FROM reports WHERE eid={id}"))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[dt.Rows.Count - 1];//select last row from DataTable;
                    DateTime exitTime = new DateTime();

                    if (dr["exit_time"].ToString() != "")
                    {
                        exitTime = Convert.ToDateTime(dr["exit_time"].ToString());

                        if (DateTime.Now.Subtract(exitTime).TotalHours > 8)
                        {
                            return true;
                        }
                        else return false;
                    }
                    else
                    {
                        if(dr["enter_time"].ToString() != "")
                        {
                            return false;
                        }
                    }
                }
                else return true;//in case table empty so person can perform entry at TimeKeeper;
            }
            return false;
        }

        public bool ChkTKExit(string id)//checks empoloyee exit time to prevent duplicates;
        {
            using (DataTable dt = GetTable($"SELECT * FROM reports WHERE eid={id} OR id={id}"))
            {
                if(dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[dt.Rows.Count - 1];//select last row from DataTable;

                    if (dr["exit_time"].ToString() != "" && dr["enter_time"].ToString() != "")
                    {
                        return false;
                    }
                    else return true;
                }
            }
            return false;
        }

        public double TotalHours(DateTime date, string id)
        {
            using(DataTable dt = GetTable($"SELECT enter_time FROM reports WHERE eid={id} OR id={id}"))
            {
                DataRow dr = dt.Rows[dt.Rows.Count - 1];//selects last row in DataTable;

                DateTime enterDate = Convert.ToDateTime(dr["enter_time"].ToString());//converts the enter_time string into DateTime;
                double temp = date.Subtract(enterDate).TotalHours;
                return temp;//calculates 
            }
        }

        public long GetID(string id)
        {
            foreach(DataRow dr in GetTable($"SELECT eid,id FROM employees WHERE eid={id}").Rows)
            {
                if (dr["eid"].ToString() == id)
                    return long.Parse(dr["id"].ToString());//return the id of the user according to employee id;
            }

            return 0;
        }

        public int GetDepartmentCode(string username)//pulls department code in order to allow a user who is not HR to view only his department employees;
        {
            foreach (DataRow dr in GetTable($"SELECT id, dcode FROM employees WHERE id={username}").Rows)
                if (dr["id"].ToString() == username)
                    return int.Parse(dr["dcode"].ToString());
                else return -1;

            return -1;
        }

        public bool CheckDuplicateDepartment(string dname)//checks whether there is a duplicate department;
        {
            using (DataTable d = GetTable($"SELECT dname FROM departments WHERE dname='{dname}'"))
            {
                if (d.Rows != null)
                    foreach (DataRow dr in d.Rows)
                    {
                        if (dr["dname"].ToString() == dname)
                            return true;
                    }
                else return false;
            }

            return false;
        }
        #endregion

        #region Permissions
        public bool GetPermAdd()//performs a check if user has AddEmployee permissions;
        {
            foreach(DataRow dr in GetTable($"SELECT id, addp FROM employees WHERE id={Properties.Settings.Default.username}").Rows)
            {
                if (dr["id"].ToString() == Properties.Settings.Default.username && dr["addp"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }

        public bool GetPermAlter()//performs a check if user has EditEmployee permissions;
        {
            foreach (DataRow dr in GetTable($"SELECT id, alterp FROM employees WHERE id={Properties.Settings.Default.username}").Rows)
            {
                if (dr["alterp"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }

        public bool GetPermHours()//performs a check if user has Hour Reports permissions;
        {
            foreach (DataRow dr in GetTable($"SELECT id, hours FROM employees WHERE id={Properties.Settings.Default.username}").Rows)
            {
                if (dr["id"].ToString() == Properties.Settings.Default.username && dr["hours"].ToString() == "1")
                    return true;
                else return false;
            }

            return false;
        }

        public bool GetPermUserPrpfile()//performs a check if user has permissions to change his own password;
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
        
    }
}
