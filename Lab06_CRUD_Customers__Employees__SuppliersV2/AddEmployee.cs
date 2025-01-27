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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlDataAdapter da;
        SqlCommand cmd;

        public string EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }

        public string PhotoPath { get; set; }
        public string statuss { get; set; }


        private void AddCustomer_Load(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind();

            // กำหนดค่าเริ่มต้นใน TextBox
            txtEmployeeID.Text = EmployeeID ?? string.Empty;
            txtLastName.Text = LastName ?? string.Empty;
            txtFirstName.Text = FirstName ?? string.Empty;
            txtTitle.Text = Title ?? string.Empty;
            txtTitleOfCourtesy.Text = TitleOfCourtesy ?? string.Empty;
            dateBirthDate.Value = BirthDate ?? DateTime.Now;
            dateHireDate.Value = HireDate ?? DateTime.Now;
            txtAddress.Text = Address ?? string.Empty;
            txtCity.Text = City ?? string.Empty;
            txtRegion.Text = Region ?? string.Empty;
            txtPostalCode.Text = PostalCode ?? string.Empty;
            txtCountry.Text = Country ?? string.Empty;
            txtHomePhone.Text = HomePhone ?? string.Empty;
            txtExtension.Text = Extension ?? string.Empty;
            txtPhotoPath.Text = PhotoPath ?? string.Empty;

            // ตั้ง Focus ไปที่ TextBox ชื่อ
            txtLastName.Focus();
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (statuss == "insert")
            {
                InsertEmployee();
            }
            else if (statuss == "update")
            {
                UpdateEmployee();
            }
            this.Close();
        }

        private void UpdateEmployee()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("กรุณากรอกนามสกุล", "Error");
                return;
            }

            string sql = @"UPDATE Employees 
                           SET LastName = @LastName, 
                               FirstName = @FirstName, 
                               Title = @Title, 
                               TitleOfCourtesy = @TitleOfCourtesy, 
                               BirthDate = @BirthDate, 
                               HireDate = @HireDate, 
                               Address = @Address, 
                               City = @City, 
                               Region = @Region, 
                               PostalCode = @PostalCode, 
                               Country = @Country, 
                               HomePhone = @HomePhone, 
                               Extension = @Extension, 
                               PhotoPath = @PhotoPath
                           WHERE EmployeeID = @EmployeeID";

            cmd = new SqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@TitleOfCourtesy", txtTitleOfCourtesy.Text.Trim());
            cmd.Parameters.AddWithValue("@BirthDate", dateBirthDate.Value);
            cmd.Parameters.AddWithValue("@HireDate", dateHireDate.Value);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
            cmd.Parameters.AddWithValue("@Region", txtRegion.Text.Trim());
            cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text.Trim());
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
            cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Extension", txtExtension.Text.Trim());
            cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim());
            cmd.Parameters.AddWithValue("@PhotoPath", txtPhotoPath.Text.Trim());

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("ปรับปรุงข้อมูลสำเร็จ");
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลที่ต้องการปรับปรุง");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error");
            }
        }

        private void InsertEmployee()
        {
            MessageBox.Show("เพิ่มข้อมูลใหม่");

            if (string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("กรุณากรอกนามสกุลและชื่อ", "Error");
                return;
            }


            string sql = @"INSERT INTO Employees 
                           (LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension) 
                           VALUES 
                           (@LastName, @FirstName, @Title, @TitleOfCourtesy, @BirthDate, @HireDate, @Address, @City, @Region, @PostalCode, @Country, @HomePhone, @Extension)";

            cmd = new SqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@TitleOfCourtesy", txtTitleOfCourtesy.Text.Trim());
            cmd.Parameters.AddWithValue("@BirthDate", dateBirthDate.Value);
            cmd.Parameters.AddWithValue("@HireDate", dateHireDate.Value);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
            cmd.Parameters.AddWithValue("@Region", txtRegion.Text.Trim());
            cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text.Trim());
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
            cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Extension", txtExtension.Text.Trim());
            cmd.Parameters.AddWithValue("@PhotoPath", txtPhotoPath.Text.Trim());

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                }
                else
                {
                    MessageBox.Show("เพิ่มข้อมูลไม่สำเร็จ");
                }
            }
            catch (Exception ex)
            {
                
            }
        }

    }
}
