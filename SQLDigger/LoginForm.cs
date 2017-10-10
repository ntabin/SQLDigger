using CommonWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLDigger
{
    public partial class LoginForm : Form
    {
        public bool SuccessConnect = false;
        private MainForm _MainForm;
        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            this._MainForm = mainForm;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.LoadingMode(false);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (string.Equals(btn.Text, "Connect"))
            {
                btn.Text = "Cancel";
                this.LoadingMode(true);
                SqlConnection myConnection = new SqlConnection();
                SqlConnectionStringBuilder myBuilder = new SqlConnectionStringBuilder();
                myBuilder.UserID = tbLogin.Text;
                myBuilder.Password = tbPassword.Text;
                myBuilder.DataSource = tbServerName.Text;
                myBuilder.ConnectTimeout = Convert.ToInt32(tbTimeout.Text);
                bwConnect.RunWorkerAsync(myBuilder.ConnectionString);
            }
            else
            {
                btn.Text = "Cancelling...";
                btn.Enabled = false;
                bwConnect.CancelAsync();
            }
        }
        private void tbTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbTimeout.WholeNumbersOnly(e);
        }
        #region "bwConnect"
        private void bwConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            string connectionString = e.Argument.ToString();


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
            }



            e.Result = connectionString;
            if (bwConnect.CancellationPending)
            {
                e.Cancel = true;
            }




        }
        private void bwConnect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.LoadingMode(false);
            if (!e.Cancelled)
            {
                if (e.Error != null)
                {
                    MessageBox.Show(e.Error.Message, "bwConnect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DBConnection.DbCon.SetConnection(e.Result.ToString());
                this._MainForm.SetConnectionTitle(string.Format("Connected to {0}", tbServerName.Text));
                this.SuccessConnect = true;
                this.Close();
            }
            else
            {
                if (e.Error != null)
                {

                }
            }
        }
        #endregion
        private void LoadingMode(bool loading)
        {
            this.tbServerName.Enabled =
                this.tbLogin.Enabled =
                this.tbPassword.Enabled =
                this.tbTimeout.Enabled =
                !loading;
            this.pbLoading.Visible = loading;


            btnConnect.Text = (loading) ? "Cancel" : "Connect";

            if (!loading)
            {
                btnConnect.Enabled = true;
            }


        }


    }
}
