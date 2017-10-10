using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonWin;
namespace SQLDigger
{

    public partial class UpdateForm : Form
    {
        public bool SuccessSave = false;
        public enum SaveMode
        {
            Update, Insert, Clone
        }

        private SaveMode _SaveMode;
        private List<ColumnDetail> _ColumnDetails;
        private string _TableName;
        private string _DBName;
        private List<string> _TypesNotEditable = new List<string>()
        {
            "timestamp"
        };

        public UpdateForm(List<ColumnDetail> columnDetails,string tableName,string dbName, SaveMode saveMode)
        {
            InitializeComponent();
            this._ColumnDetails = columnDetails;
            this._TableName = tableName;
            this._DBName = dbName;
            this._SaveMode = saveMode;

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            int currentRow = 0;
            foreach (ColumnDetail col in from t in this._ColumnDetails
                                         where !t.IsIdentity && !this._TypesNotEditable.Contains(t.DataType)
                                         select t)
            {
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle { SizeType = SizeType.AutoSize });
                tableLayoutPanel1.Controls.Add(new Label() { Text = col.ColumnName, Anchor = AnchorStyles.Right}, 0, tableLayoutPanel1.RowCount - 1);

                TextBox tb = new TextBox();
                tb.Name = string.Format("tb{0}", col.ColumnName);
                tb.Anchor = AnchorStyles.Right | AnchorStyles.Left;
                tb.Text = col.ColumnValue.ToString();
                tableLayoutPanel1.Controls.Add(tb, 1, tableLayoutPanel1.RowCount - 1);

                tableLayoutPanel1.Controls.Add(new Label() { Text = col.DataType, Anchor = AnchorStyles.Left, ForeColor = Color.DarkBlue }, 2, tableLayoutPanel1.RowCount - 1);
                currentRow++;
            }
            tableLayoutPanel1.RowCount++;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.AutoSize;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 1;
            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.AutoSize;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "";

            if(this._SaveMode == SaveMode.Insert || this._SaveMode == SaveMode.Clone)
            {
                query = this.GetQueryForInsert();
            }
            else
            {
                query = this.GetQueryForUpdate();
            }

            this.ExecuteUpdate(query);
            this.Close();
        }

        #region "ExecuteQuery"
        private void ExecuteUpdate(string query)
        {
            Dictionary<string, object> columnByValues = new Dictionary<string, object>();
            foreach (ColumnDetail col in from t in this._ColumnDetails
                                         where !t.IsIdentity && !this._TypesNotEditable.Contains(t.DataType)
                                         select t)
            {
                columnByValues.Add(string.Format("@{0}", col.ColumnName), GetNewValue(col.ColumnName));
            }
            try
            {
                MSSQLBase.SQLBase s = new MSSQLBase.SQLBase(DBConnection.DbCon.Connection);
                s.ExecuteNonQuery(query, columnByValues);
                MessageBox.Show("Successfully Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.SuccessSave = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "btnSave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetQueryForInsert()
        {
            string query = string.Format("use {0};", this._DBName);
            string fields = string.Join(",", from t in this._ColumnDetails
                                             where !t.IsIdentity && !this._TypesNotEditable.Contains(t.DataType)
                                             select t.ColumnName);
            string values = string.Join(",", from t in this._ColumnDetails
                                             where !t.IsIdentity && !this._TypesNotEditable.Contains(t.DataType)
                                             select string.Format("@{0}", t.ColumnName));
            query = query + string.Format("INSERT INTO {0} ({1}) VALUES ({2})", this._TableName, fields, values);
            return query;
        }
        private string GetQueryForUpdate()
        {
            string query = string.Format("use {0};", this._DBName);
            string fields = string.Join(",", from t in this._ColumnDetails
                                             where !t.IsIdentity && !this._TypesNotEditable.Contains(t.DataType)
                                             select string.Format("{0}=@{0}", t.ColumnName));
            string where = string.Join("AND", from t in this._ColumnDetails
                                              where t.IsPrimaryKey
                                              select string.Format("{0}={1}", t.ColumnName, t.ColumnValue));
            query = query + string.Format("UPDATE {0} SET {1} WHERE {2}", this._TableName, fields, where);
            return query;
        }
        #endregion
        #region "DynamicTextBox"
        private object GetNewValue(string columnName)
        {
            TextBox txtBox = this.GetCreatedTextBox(columnName);
            return txtBox.Text;
        }
        private TextBox GetCreatedTextBox(string columnName)
        {
            string txtBoxName = string.Format("tb{0}", columnName);
            return (TextBox)this.tableLayoutPanel1.Controls[txtBoxName];
        }
        #endregion
        public void SetTitle(string title)
        {
            this.Text = title;
        }
    }
}
