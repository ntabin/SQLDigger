using CommonWin;
using DataGridViewAutoFilter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SQLDigger
{
    public partial class MainForm : Form
    {
        private struct StoredProcRequirement
        {
            public string StoredProcName;
            public string DBName;
            public Dictionary<string, object> ParameterByValue;
        }
        private int _ScrollVal = 0;
        #region "Public"
        public void SetConnectionTitle(string title)
        {
            this.lblConnection.Text = title;
        }
        #endregion
        public MainForm()
        {

            InitializeComponent();
        }
        #region "MainForm"
        private void MainForm_Load(object sender, EventArgs e)
        {

            lblQuery.Text = "";
            picBoxLoading.Visible = false;
            dgvResult.AutoGenerateColumns = true;
            lblTable.Text = "";
            this.Text = string.Format("SQLDigger v{0}", Application.ProductVersion);
            btnExec.Enabled = false;
            
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                btnExec.PerformClick();

        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.ShowDBLogin();
        }
        #endregion
        private void cmbDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbName = cmbDB.SelectedItem.ToString();
            dgvTables.DataSource = TableDetail.GetTables(dbName);
            this.PopulateTable(dbName);
            this.PopulateStoredProc(dbName);
        }
        private void btnExec_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvTables.CurrentCell.RowIndex;
            string dbName = cmbDB.SelectedItem.ToString();
            string tableName = dgvTables.Rows[rowIndex].Cells[0].Value.ToString();
            this.Exec(dbName, tableName);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvResult.Rows.Count == 0)
            {
                MessageBox.Show("No record to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((from DataGridViewRow row in dgvColumns.Rows
                      where Convert.ToBoolean(row.Cells["isPrimaryKeyDataGridViewCheckBoxColumn"].Value)
                      select row).ToList().Count() == 0)
            {
                MessageBox.Show("Cannot delete record without primary key", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(DialogResult.Yes == MessageBox.Show("Are you sure you want to delete rows?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                string dbName = this.GetDBName();
                string tableName = this.GetTableName();
                Dictionary<string, object> paramByValues = new Dictionary<string, object>();
                int count = 0;
                string whereQuery = "(";
                foreach (DataGridViewRow row in dgvResult.SelectedRows)
                {
                    string whereSubQuery = "";
                    foreach (ColumnDetail col in this.GetColumnDetails(true, row.Index).Where(x=>x.IsPrimaryKey))
                    {
                        string parameterName = string.Format("@{0}{1}", col.ColumnName, count.ToString());
                        if (whereSubQuery != "")
                            whereSubQuery = " AND ";
                        whereSubQuery = string.Format("{0}={1}",col.ColumnName,parameterName);
                        paramByValues.Add(parameterName,col.ColumnValue);

                    }
                    string a = "";
                    if (whereQuery != "(")
                        whereQuery = whereQuery + " OR (";
                    whereQuery = whereQuery + whereSubQuery + ")";
                    count++;
                }


                string deleteQuery = string.Format("use {0};DELETE FROM {1} WHERE {2};", dbName, tableName, whereQuery);

                try
                {
                    MSSQLBase.SQLBase s = new MSSQLBase.SQLBase(DBConnection.DbCon.Connection);
                    s.ExecuteNonQuery(deleteQuery, paramByValues);
                    btnExec.PerformClick();
                    MessageBox.Show(string.Format("{0} row/s deleted",count.ToString(),"Delete",MessageBoxButtons.OK,MessageBoxIcon.Information));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bsResult_ListChanged(object sender, ListChangedEventArgs e)
        {
            tbRow.Text = this.bsResult.List.Count.ToString();
        }
        #region "dgvTables"
        private void dgvTables_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvColumns.AutoFit();
        }
        private void dgvTables_SelectionChanged(object sender, EventArgs e)
        {
            tbWhere.Text = "";

            DataGridView dgv = sender as DataGridView;

            if (dgv.Rows.Count > 0 && cmbDB.SelectedItem != null)
            {
                int rowIndex = dgv.CurrentCell.RowIndex;
                string dbName = cmbDB.SelectedItem.ToString();
                string tableName = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                this.PopulateColumn(dbName, tableName);
                this.Exec(dbName, tableName);
            }

        }
        #endregion
        #region "dgvColumns"
        private void dgvColumns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgv.Columns["Chk"].Index)
                {
                    bool previousValue = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["Chk"].Value);
                    dgv.Rows[e.RowIndex].Cells["Chk"].Value = !previousValue;
                    string columnName = dgv.Rows[e.RowIndex].Cells["columnNameDataGridViewTextBoxColumn"].Value.ToString();
                    dgvResult.Columns[columnName].Visible = !previousValue;

                    //if (dgvResult.Rows.Count > 0)
                    //    dgvResult.Rows[0].Selected = false;


                }
                else if (e.ColumnIndex == dgv.Columns["columnNameDataGridViewTextBoxColumn"].Index)
                {
                    tbWhere.Text = tbWhere.Text + dgvColumns.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    tbWhere.Focus();
                }
            }
        }
        private void dgvColumns_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if(dgvColumns.Rows.Count > 0)
                dgvColumns.Rows[0].Selected = false;
        }
        #endregion
        #region "dgvResult"
        private void dgvResult_SortStringChanged(object sender, EventArgs e)
        {
            this.bsResult.Sort = this.dgvResult.SortString;
        }
        private void dgvResult_FilterStringChanged(object sender, EventArgs e)
        {
            this.bsResult.Filter = this.dgvResult.FilterString;
        }
        private void dgvResult_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dgvResult_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if(dgv.Rows.Count > 0)
            {
                //dgv.Rows[0].Selected = false;
                this.dgvResult.DoubleBuffered(true);
            }
             
        }
        private void dgvResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete.PerformClick();
            }
        }
        #endregion
        #region "dgvStoredProcs"
        private void dgvStoredProcs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvStoredProcs.Rows)
            {
                row.Cells["Execute"].Value = "Execute";
            }
            dgvStoredProcs.AutoFit();
            
        }
        private void dgvStoredProcs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if(e.RowIndex >= 0 && e.ColumnIndex == dgv.Columns["Execute"].Index)
            {
                if (this.bgTableQuery.IsBusy)
                {
                    if (DialogResult.Yes == MessageBox.Show("Cancel Table Query?", "StoredProcs", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        this.bgTableQuery.CancelAsync();
                    }
                    else
                    {
                        return;
                    }
                }
                string dbName = cmbDB.SelectedItem.ToString();
                string storedProcName = dgv.Rows[e.RowIndex].Cells["storedProcNameDataGridViewTextBoxColumn"].Value.ToString();

                List<StoredProcDetail.ParameterDetail> parameters = StoredProcDetail.GetParameters(dbName, storedProcName);
                Dictionary<string, object> parameterByValue = new Dictionary<string, object>();
                if (parameters.Count > 0)
                {
                    ExecStoredProcForm a = new ExecStoredProcForm(parameters);
                    a.ShowDialog();
                    if (!a.ContinueExecute)
                        return;
                    parameterByValue = a._ParameterByValue;
                }

                lblTable.Text = string.Format("StoredProc:{0}", storedProcName);
                picBoxLoading.Visible = true;
                bwExecStoredProc.RunWorkerAsync(new StoredProcRequirement {
                    StoredProcName = storedProcName,
                    DBName = dbName,
                    ParameterByValue = parameterByValue
                });
            }
        }
        #endregion
        #region "bgTableQuery"
        private void bgTableQuery_DoWork(object sender, DoWorkEventArgs e)
        {
            string query = e.Argument.ToString();
            using (SqlConnection con = new SqlConnection(DBConnection.DbCon.Connection))
            {
                SqlCommand com = new SqlCommand(query, con);

            }







                
            MSSQLBase.SQLBase b = new MSSQLBase.SQLBase(DBConnection.DbCon.Connection);
            e.Result = b.ExecuteQuery(query);
            if (bgTableQuery.CancellationPending)
            {
                e.Cancel = true;
            }
        }
        private void bgTableQuery_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picBoxLoading.Visible = false;
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "bgTableQuery", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblQuery.Text = "Error Occurred.";
            }

            if (!e.Cancelled)
            {
                this.bsResult.DataSource = e.Result;
                tbRow.Text = dgvResult.Rows.Count.ToString();
                lblQuery.Text = "Query Executed Successfully.";
            }
            else
            {
                btnExec.PerformClick();
            }
        }
        #endregion
        #region "Populate"
        private void SetCmbDB()
        {
            cmbDB.Items.Clear();
            MSSQLBase.SQLBase b = new MSSQLBase.SQLBase(DBConnection.DbCon.Connection);
            List<string> databases = b.GetDatabaseList();
            cmbDB.AddItems(databases.Cast<object>().ToList());
        }
        private void PopulateTable(string dbName)
        {
            dgvTables.DataSource = TableDetail.GetTables(dbName);
        }
        private void PopulateColumn(string dbName, string tableName)
        {
            dgvColumns.DataSource = ColumnDetail.GetColumns(dbName, tableName);
            
            foreach (DataGridViewRow row in dgvColumns.Rows)
            {
                row.Cells["Chk"].Value = true;
            }
        }
        private void PopulateStoredProc(string dbName)
        {
            dgvStoredProcs.DataSource = StoredProcDetail.GetStoredProcs(dbName);
        }
        #endregion
        #region "ModifyColumn" 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvTables.Rows.Count == 0)
            {
                MessageBox.Show("No Table Selected", "btnAdd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<ColumnDetail> columnDetails = this.GetColumnDetails(false);
            this.ShowUpdateForm(columnDetails, UpdateForm.SaveMode.Insert);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvResult.Rows.Count == 0)
            {
                MessageBox.Show("No record to update", "ModifyColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((from DataGridViewRow row in dgvColumns.Rows
                      where Convert.ToBoolean(row.Cells["isPrimaryKeyDataGridViewCheckBoxColumn"].Value)
                      select row).ToList().Count() == 0)
            {
                MessageBox.Show("Cannot update record without primary key", "ModifyColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(dgvResult.SelectedRows.Count > 1)
            {
                MessageBox.Show("Cannot update more than 1 record at once", "ModifyColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rowIndex = (from DataGridViewRow row in dgvResult.SelectedRows
                            select row.Index).FirstOrDefault();
            List<ColumnDetail> columnDetails = this.GetColumnDetails(true, rowIndex);
            this.ShowUpdateForm(columnDetails, UpdateForm.SaveMode.Update);
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (dgvResult.Rows.Count == 0)
            {
                MessageBox.Show("No record to copy", "ModifyColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dgvResult.SelectedRows.Count > 1)
            {
                MessageBox.Show("Cannot copy more than 1 record at once", "ModifyColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<ColumnDetail> columnDetails = this.GetColumnDetails(true, dgvResult.CurrentCell.RowIndex);
            this.ShowUpdateForm(columnDetails,UpdateForm.SaveMode.Clone);
        }
        private List<ColumnDetail> GetColumnDetails(bool includeSelectedValue, int rowIndex = 0)
        {
            return (from DataGridViewRow row in dgvColumns.Rows
                    select new ColumnDetail
                    {
                        ColumnName = row.Cells["columnNameDataGridViewTextBoxColumn"].Value.ToString(),
                        ColumnValue = (includeSelectedValue) ? dgvResult.Rows[rowIndex].Cells[row.Cells["columnNameDataGridViewTextBoxColumn"].Value.ToString()].Value.ToString() : "",
                        IsPrimaryKey = Convert.ToBoolean(row.Cells["isPrimaryKeyDataGridViewCheckBoxColumn"].Value),
                        DataType = row.Cells["dataTypeDataGridViewTextBoxColumn"].Value.ToString(),
                        IsIdentity = Convert.ToBoolean(row.Cells["isIdentityDataGridViewCheckBoxColumn"].Value)
                    }).ToList();
        }
        #endregion
        private void Exec(string dbName, string tableName)
        {
            if(this.bwExecStoredProc.IsBusy)
            {
                if(DialogResult.Yes == MessageBox.Show("Cancel Executing StoredProc?", "Exec",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    this.bwExecStoredProc.CancelAsync();
                }
                else
                {
                    return;
                }
            }
            lblTable.Text = tableName;
            if (dgvColumns.Rows.Count == 0)
                return;

            if (bgTableQuery.IsBusy)
            {
                bgTableQuery.CancelAsync();
                return;

            }
            string fields = string.Join(",", from DataGridViewRow row in dgvColumns.Rows
                                             where Convert.ToBoolean(row.Cells["Chk"].Value)
                                             select string.Format("[{0}]", row.Cells["columnNameDataGridViewTextBoxColumn"].Value.ToString()));
            string query = string.Format("use {0};SELECT * FROM [{2}] ", dbName, fields, tableName);

            if (tbWhere.Text.TrimEnd() != "")
            {
                query = query + string.Format("WHERE {0}", tbWhere.Text);
            }
            this.bsResult.Filter = "";
            lblQuery.Text = "Executing Query...";
            picBoxLoading.Visible = true;
            this.bsResult.DataSource = null;
            bgTableQuery.RunWorkerAsync(query);
        }
        private void ShowUpdateForm(List<ColumnDetail> columnDetails, UpdateForm.SaveMode saveMode)
        {
            string dbName = this.GetDBName();
            string tableName = this.GetTableName();
            UpdateForm u = new UpdateForm(columnDetails,this.GetTableName(), this.GetDBName(), saveMode);
            u.ShowDialog();

            if (u.SuccessSave)
            {
                this.Exec(dbName, tableName);
            }
        }
        private void sQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowDBLogin();
        }
        private void ShowDBLogin()
        {
            LoginForm l = new LoginForm(this);
            l.ShowDialog();
            if (l.SuccessConnect)
            {
                this.SetCmbDB();
                this.dgvColumns.DataSource = null;
                this.btnExec.Enabled = true;
                this.dgvTables.DataSource = null;
                this.bsResult.DataSource = null;
                this.dgvStoredProcs.DataSource = null;
            }
        }
        private string GetDBName()
        {
            return cmbDB.SelectedItem.ToString();
        }
        private string GetTableName()
        {
            int rowIndex = dgvTables.CurrentCell.RowIndex;
            return dgvTables.Rows[rowIndex].Cells[0].Value.ToString();
        }
        #region "RightClickOnResult"
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate.PerformClick();
        }
        private void MenuStripClone_Click(object sender, EventArgs e)
        {
            btnCopy.PerformClick();
        }
        #endregion
        #region "bwExecStoredProc"
        private void bwExecStoredProc_DoWork(object sender, DoWorkEventArgs e)
        {
            MainForm.StoredProcRequirement storedProcReq = (MainForm.StoredProcRequirement)e.Argument;
            MSSQLBase.SQLBase s = new MSSQLBase.SQLBase(DBConnection.DbCon.Connection);
            e.Result = s.ExecuteQuery(string.Format("[{0}].[dbo].[{1}]", storedProcReq.DBName, storedProcReq.StoredProcName), MSSQLBase.SQLBase.QueryType.StoredProc, storedProcReq.ParameterByValue);
            if (bwExecStoredProc.CancellationPending)
            {
                e.Cancel = true;
            }
        }
        private void bwExecStoredProc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picBoxLoading.Visible = false;
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "bwExecStoredProc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblQuery.Text = "Error Occurred.";
            }

            if (!e.Cancelled)
            {
                this.bsResult.DataSource = e.Result;
                tbRow.Text = dgvResult.Rows.Count.ToString();
                lblQuery.Text = "StoredProc Executed Successfully.";
            }
        }


        #endregion

        
    }
}
