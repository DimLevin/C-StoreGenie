using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace StoreGenie
{
    /*
     General model class
    */
    public class ModelGeneral : Model
    {
        // PRIVATE PROPERTIES
        private static ModelGeneral _instance;

        // CONSTR.
        private ModelGeneral() { }
        
        // Singleton initiator
        public static ModelGeneral Init()
        {
            if (ModelGeneral._instance == null)
            {
                ModelGeneral._instance = new ModelGeneral();
            }

            return ModelGeneral._instance;
        }

        // METHODS

        // Check password
        public bool CheckPassword(int userId, string password)
        {
            bool res = false;

            if (password.Length >= 1 && userId >= 0)
            {
                string cmdStr = "SELECT user_id FROM Users WHERE user_id=" + userId + " AND user_psw='" + password + "'";

                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    res = userId == ExecuteScalarIntQuery(command);
                }
            }

            return res;
        }

        // Find user by username
        public int FindUser(string username)
        {
            int userId = -1;

            if (username.Length >= 1)
            {
                string cmdStr = "SELECT user_id FROM Users Where user_name='" + username + "'";

                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    userId = ExecuteScalarIntQuery(command);
                }
            }

            return userId;
        }

        // Load User
        public DclassUser LoadUser(int userId)
        {
            DclassUser tUser = null;

            DataSet ds = new DataSet();

            string rows = "user_name, first_name, last_name, user_type, status, employment_date";
            string cmdStr = "SELECT " + rows + " FROM Users WHERE user_id = " + userId;

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();

            try
            {
                dt = ds.Tables[0];
            }
            catch { }

            DataRow row = dt.Rows[0];

            if (row != null)
            {
                tUser = new DclassUser();

                // fill user data
                tUser.UserName = row["user_name"].ToString();
                tUser.FirstName = row["first_name"].ToString();
                tUser.LastName = row["last_name"].ToString();
                tUser.UserType = row["user_type"].ToString();
                tUser.EmployDate = DateTime.Parse(row["employment_date"].ToString());
                tUser.Status = bool.Parse(row["status"].ToString());
            }

            return tUser;
        }
    }
}
