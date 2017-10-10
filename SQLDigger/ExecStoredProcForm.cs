using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLDigger
{
    public partial class ExecStoredProcForm : Form
    {
        public bool ContinueExecute = false;
        public Dictionary<string, object> _ParameterByValue = new Dictionary<string, object>();
        private List<StoredProcDetail.ParameterDetail> _Parameters;
        public ExecStoredProcForm(List<StoredProcDetail.ParameterDetail> parameters)
        {
            InitializeComponent();
            this._Parameters = parameters;
        }

        private void ExecStoredProcForm_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            int currentRow = 0;

            foreach (StoredProcDetail.ParameterDetail param in this._Parameters)
            {
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle { SizeType = SizeType.AutoSize });
                tableLayoutPanel1.Controls.Add(new Label() { Text = param.ParameterName, Anchor = AnchorStyles.Right}, 0, tableLayoutPanel1.RowCount - 1);

                TextBox tb = new TextBox();
                tb.Name = string.Format("tb{0}", param.ParameterName);
                tb.Anchor = AnchorStyles.Right | AnchorStyles.Left;
                tableLayoutPanel1.Controls.Add(tb, 1, tableLayoutPanel1.RowCount - 1);

                tableLayoutPanel1.Controls.Add(new Label() { Text = param.DataType, Anchor = AnchorStyles.Left, ForeColor = Color.DarkBlue }, 2, tableLayoutPanel1.RowCount - 1);
                currentRow++;
            }
            tableLayoutPanel1.RowCount++;
            //tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.AutoSize;
            //tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            //tableLayoutPanel1.ColumnStyles[1].Width = 1;
            //tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.AutoSize;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            this.ContinueExecute = true;
            foreach (StoredProcDetail.ParameterDetail param in this._Parameters)
            {
                this._ParameterByValue.Add(param.ParameterName,this.GetNewValue(param.ParameterName));
            }
            this.Close();
        }

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
    }
}
