using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection connection;
        public string loginstatus { get; set; }
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string employeePosition { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string sql = " select EmployeeID,TitleOfCourtesy+FirstName +' '+ LastName [Employee name],title from Employees where username = @username and Password = @Password";
            cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count == 1)
            {

                this.loginstatus = "pass";
                this.employeeID = Convert.ToInt16(ds.Tables[0].Rows[0]["employeeID"]);
                this.employeeName = ds.Tables[0].Rows[0]["employeeName"].ToString();
                this.employeePosition = ds.Tables[0].Rows[0]["title"].ToString();
            }
            else
            {
                MessageBox.Show("username and password incorrect");
            }
            this.Close();
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void FRMLogin_Load(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMResetPassword FPassword = new FRMResetPassword();
            FPassword.ShowDialog();
        }
    }
}
