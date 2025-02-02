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
    public partial class FRMResetPassword : Form
    {
        public FRMResetPassword()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection connection;


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPassword = txtpassword.Text;
            string confirmPass = txtcomfirmpass.Text;
            string HomePhone = txtHomePhone.Text;

            if (newPassword != confirmPass)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "UPDATE employees SET Password = @Password WHERE username = @username AND HomePhone = @HomePhone";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@HomePhone", HomePhone);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or birthdate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void FRMResetPassword_Load(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind();
        }

        private void txtpassword_MouseHover(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '\0';
        }

        private void txtpassword_MouseLeave(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }

        private void txtcomfirmpass_MouseHover(object sender, EventArgs e)
        {
            txtcomfirmpass.PasswordChar = '\0';
        }

        private void txtcomfirmpass_MouseLeave(object sender, EventArgs e)
        {
            txtcomfirmpass.PasswordChar = '*';
        }
    }
}
