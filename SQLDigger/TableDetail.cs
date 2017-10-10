using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SQLDigger
{
    public sealed class TableDetail
    {
        public string TableName { get; set; }
        public static List<TableDetail> GetTables(string dbName)
        {
            string query = string.Format(@"SELECT TABLE_NAME AS 'Table'
                                          FROM {0}.INFORMATION_SCHEMA.TABLES
                                          WHERE TABLE_TYPE = 'BASE TABLE'
                                          ORDER BY TABLE_NAME", dbName);

            MSSQLBase.SQLBase b = new MSSQLBase.SQLBase(DBConnection.DbCon.Connection);
            DataTable dt = b.ExecuteQuery(query);
            return (from DataRow row in dt.Rows
                    select new TableDetail
                    {
                        TableName = row["Table"].ToString()
                    }).ToList();

        }

    }
}
