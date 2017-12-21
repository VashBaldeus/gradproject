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
        private static string dbHost = "vps.vashbaldeus.pw";
        private static string dbUsername = "hr";
        private static string dbPassword = "3d1*M7dS4&Gy5f";

        /*private static string dbHost = "localhost";
        private static string dbUsername = "root";
        private static string dbPassword = "password";*/
        
        private static string dbName = "hr";

        private static string dbString = $"Server={dbHost}; database={dbName}; UID={dbUsername}; password={dbPassword}";
    
        MySqlConnection connection = new MySqlConnection(dbString);
        #endregion

        DataTable dt = new DataTable();
        DataTable datatable = new DataTable();

        #region Manual Table Loading
        private void ImportTable(string query)
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

        public DataTable GetTable(string query)
        {
            ImportTable(query);
            return dt;
        }
        #endregion

        public string GetCurTime()
        {
            return DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        public string GetCurDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

        #region Old DataSet Code
        /*private DataTable LoadEmployees()
        {
            hrDataSetTableAdapters.employeesTableAdapter employeesTable = new hrDataSetTableAdapters.employeesTableAdapter();
            return employeesTable.GetData();
        }

        public DataTable LoadCityCodes()
        {
            hrDataSetTableAdapters.city_codesTableAdapter city_codesTable = new hrDataSetTableAdapters.city_codesTableAdapter();
            return city_codesTable.GetData();
        }

        public DataTable LoadCountryCodes()
        {
            hrDataSetTableAdapters.country_codesTableAdapter country_codesTable = new hrDataSetTableAdapters.country_codesTableAdapter();
            return country_codesTable.GetData();
        }

        public DataTable LoadReports()
        {
            hrDataSetTableAdapters.reportsTableAdapter reportsTable = new hrDataSetTableAdapters.reportsTableAdapter();
            return reportsTable.GetData();
        }*/
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

    }
}
