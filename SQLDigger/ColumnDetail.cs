using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SQLDigger
{
    public class ColumnDetail
    {
        public string ColumnName { get; set; }
        public bool IsPrimaryKey { get; set; }
        public string DataType { get; set; }
        public bool IsIdentity { get; set; }
        public string ColumnValue { get; set; }

        public static List<ColumnDetail> GetColumns(string dbName,string tableName)
        {
            string query = string.Format(@"use {0};
                                           SELECT col.COLUMN_NAME AS 'ColumnName'
                                            	,col.IS_NULLABLE AS 'IsNullable'
                                            	,col.DATA_TYPE AS 'DataType'
                                            	,ISNULL(CAST(CHARACTER_MAXIMUM_LENGTH AS NVARCHAR), 'Not Applicable') AS 'MaxLength'
                                            	,CASE COLUMNPROPERTY(OBJECT_ID(col.TABLE_NAME), col.COLUMN_NAME, 'IsIdentity')
                                            		WHEN 1
                                            			THEN CAST(1 AS BIT)
                                            		WHEN 0
                                            			THEN CAST(0 AS BIT)
                                            		ELSE 'W'
                                            		END AS 'IsIdentity'
                                            	,CASE 
                                            		WHEN colUsage.COLUMN_NAME IS NULL
                                            			THEN CAST(0 AS BIT)
                                            		ELSE CAST(1 AS BIT)
                                            		END AS 'IsPrimaryKey'
                                            FROM {0}.INFORMATION_SCHEMA.COLUMNS col
                                            LEFT JOIN {0}.INFORMATION_SCHEMA.KEY_COLUMN_USAGE colUsage ON OBJECTPROPERTY(OBJECT_ID(colUsage.constraint_name), 'IsPrimaryKey') = 1
                                            	AND colUsage.COLUMN_NAME = col.COLUMN_NAME
                                            	AND colUsage.TABLE_NAME = col.TABLE_NAME
                                            WHERE col.TABLE_NAME = '{1}'", dbName, tableName);
            MSSQLBase.SQLBase b = new MSSQLBase.SQLBase(DBConnection.DbCon.Connection);
            DataTable dt = b.ExecuteQuery(query);

            return (from DataRow row in dt.Rows
                    select new ColumnDetail
                    {
                        ColumnName = row["ColumnName"].ToString(),
                        IsPrimaryKey = Convert.ToBoolean(row["IsPrimaryKey"]),
                        DataType = row["DataType"].ToString(),
                        IsIdentity = Convert.ToBoolean(row["IsIdentity"]),
                        ColumnValue = ""
                    }).ToList();
        }


    }
}
