using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SQLDigger
{
    public class StoredProcDetail
    {
        public struct ParameterDetail
        {
            public string ParameterName;
            public string DataType;
        }
        public string StoredProcName { get; set; }
        public List<ParameterDetail> Parameters;

        public StoredProcDetail()
        {
            this.Parameters = new List<ParameterDetail>();
        }

        public static List<StoredProcDetail.ParameterDetail> GetParameters(string dbName,string storedProcName)
        {
            string query = string.Format(@"SELECT PARAMETER_NAME as 'Parameter'
                                            	,DATA_TYPE as 'DataType'
                                            FROM {0}.information_schema.parameters
                                            WHERE specific_name = '{1}'", dbName, storedProcName);

            MSSQLBase.SQLBase b = new MSSQLBase.SQLBase(DBConnection.DbCon.Connection);
            DataTable dt = b.ExecuteQuery(query);
            List<ParameterDetail> parameters = (from DataRow row in dt.Rows
                                                select new StoredProcDetail.ParameterDetail
                                                {
                                                    ParameterName = row["Parameter"].ToString(),
                                                    DataType = row["DataType"].ToString()
                                                }).ToList();
            return parameters;
        }

        public static List<StoredProcDetail> GetStoredProcs(string dbName)
        {
            string query = string.Format(@"SELECT SPECIFIC_NAME AS 'StoredProcedure'
                                           FROM {0}.information_schema.routines
                                           WHERE routine_type = 'PROCEDURE'
                                           ORDER BY SPECIFIC_NAME", dbName);
            MSSQLBase.SQLBase b = new MSSQLBase.SQLBase(DBConnection.DbCon.Connection);
            DataTable dt = b.ExecuteQuery(query);
            List<StoredProcDetail> storedProcs = (from DataRow row in dt.Rows
                                                  select new StoredProcDetail
                                                  {
                                                      StoredProcName = row["StoredProcedure"].ToString()
                                                  }).ToList();
            return storedProcs;
        }
    }
}
