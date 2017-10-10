using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MSSQLBase
{
    public class SQLBase
    {
        public SqlConnection _SqlConnection;

        public enum QueryType
        {
            Text,StoredProc
        }
        public SQLBase(string connection)
        {
            this._SqlConnection = new SqlConnection(connection);
            this._SqlConnection.Open();
        }
        #region "ExecuteQuery"
        public DataTable ExecuteQuery(string query,Dictionary<string,object> parameterByValue = null)
        {
            SqlCommand com = this.MakeCommand(query,QueryType.Text, parameterByValue);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this._SqlConnection.Close();
            return dt;
        }
        public DataTable ExecuteQuery(string query,QueryType queryType, Dictionary<string, object> parameterByValue = null)
        {
            SqlCommand com = this.MakeCommand(query, queryType, parameterByValue);
            return this.GetDataCommand(com);
        }
        private DataTable GetDataCommand(SqlCommand com)
        {
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this._SqlConnection.Close();
            return dt;
        }
        #endregion
        #region "ExecuteNonQuery"
        public int ExecuteNonQuery(string query, Dictionary<string, object> parameterByValue = null)
        {
            SqlCommand com = this.MakeCommand(query, QueryType.Text, parameterByValue);
            return this.ExecuteCommand(com);
        }
        public int ExecuteNonQuery(string query,QueryType queryType, Dictionary<string, object> parameterByValue = null)
        {
            SqlCommand com = this.MakeCommand(query, queryType, parameterByValue);
            return this.ExecuteCommand(com);
        }

        public int ExecuteCommand(SqlCommand com)
        {
            int affectedRows = com.ExecuteNonQuery();
            this.CloseConnection();
            return affectedRows;
        }


        #endregion
        public List<string> GetDatabaseList()
        {
            string query = "SELECT [name] FROM master.dbo.sysdatabases WHERE dbid > 6 ORDER BY [name]";
            return (from DataRow row in this.ExecuteQuery(query).Rows
                    select row[0].ToString()).ToList();
        }
        public void CloseConnection()
        {
            this._SqlConnection.Close();
        }
        private SqlCommand MakeCommand(string query, QueryType queryType, Dictionary<string, object> parameterByValue)
        {
            SqlCommand com = new SqlCommand(query, this._SqlConnection);
            if(queryType == QueryType.StoredProc)
            {
                com.CommandType = CommandType.StoredProcedure;
            }


            if(parameterByValue != null)
            {
                foreach(KeyValuePair<string,object> param in parameterByValue)
                {
                    com.Parameters.Add(new SqlParameter(param.Key, param.Value));
                }
            }
            return com;
        }

        
    }
}
