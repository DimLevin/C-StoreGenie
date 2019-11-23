using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace StoreGenie
{
    /*
     DbAccess Class

     Managing Connection to the database
    */
    public class DbAccess
    {
        #region Constructor + Members
        protected OleDbConnection _conn = null;

        public DbAccess(string connectionString)
        {
            _conn = new OleDbConnection(connectionString);
        }
        #endregion

        #region Protected Methods

        // Connect
        protected void Connect()
        {
            if (_conn.State != ConnectionState.Open)
                _conn.Open();
        }

        // Disconnect
        protected void Disconnect()
        {
            _conn.Close();
        }

        // Execute Simple Query
        protected void ExecuteSimpleQuery(OleDbCommand command)
        {
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;

                try
                {
                    command.ExecuteNonQuery();
                }
                finally
                {
                    Disconnect();
                }
            }
        }

        // Execute Scalar Int Query
        protected int ExecuteScalarIntQuery(OleDbCommand command)
        {
            int ret = -1;

            lock (_conn)
            {
                Connect();
                command.Connection = _conn;

                try
                {
                    var tVar = command.ExecuteScalar();

                    // result returned
                    if (tVar != null)
                    {
                        ret = (int)tVar;
                    }
                    
                }
                finally
                {
                    Disconnect();
                }
            }
            return ret;
        }

        // Execute multiple query
        protected DataSet GetMultipleQuery(OleDbCommand command)
        {
            DataSet dataSet = new DataSet();

            lock (_conn)
            {
                Connect();
                command.Connection = _conn;

                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet);
                }
                finally
                {
                    Disconnect();
                }
            }
            return dataSet;
        }

        #endregion
    }
}
