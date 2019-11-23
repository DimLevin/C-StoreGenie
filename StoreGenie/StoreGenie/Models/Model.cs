using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace StoreGenie
{
    /*
     Model class
    */
    public abstract class Model : DbAccess
    {
        //PRIVATE PROPERTIES
        private static string _dbPath = "StoreGenie.accdb";
        private static string _conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _dbPath + ";Persist Security Info=False";


        //CONSTR.
        protected Model() : base(_conString) { }


        // METHODS
       
        // Get table data table
        public DataTable GetTableDT(string command)
        {
            DataSet ds = null;

            string cmdStr = command;

            using (OleDbCommand cmd = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(cmd);
            }

            return ds?.Tables[0];
        }
    }
}
