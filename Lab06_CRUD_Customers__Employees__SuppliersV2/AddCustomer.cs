using Lab06_CRUD_Customers__Employees__SuppliersV2;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab06_CRUD_Customers__Employees__Suppliers
{
    public partial class AddCustomer : Form
    {
       
        
        
        public AddCustomer()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlDataAdapter da;
        SqlCommand cmd;

        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public string status { get; set; }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind();

            // ตรวจสอบการกำหนดค่า Default ของ TextBox
            txtCustomerID.Text = CustomerID ?? string.Empty;
            txtCompanyName.Text = CustomerName ?? string.Empty; // ตรงนี้ให้ใช้ค่า CustomerName
            txtContactName.Text = ContactName ?? string.Empty;
            txtContactTitle.Text = ContactTitle ?? string.Empty;
            txtAddress.Text = Address ?? string.Empty;
            txtCity.Text = City ?? string.Empty;
            textRegion.Text = Region ?? string.Empty;
            textPostalCode.Text = PostalCode ?? string.Empty;
            txtCountry.Text = Country ?? string.Empty;
            textPhone.Text = Phone ?? string.Empty;
            textFax.Text = Fax ?? string.Empty;

            // ตั้ง Focus ไปยัง TextBox
            txtCompanyName.Focus();


        }
          private void Cancle_Click(object sender, EventArgs e)
        {
            // ยกเลิกการเพิ่มข้อมูลและปิดฟอร์ม
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "insert")
            {
                insertShippers();
            }
            else if (status == "update")
            {
                UpdateShippers();
            }
            this.Close();
        }
        private void UpdateShippers()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");

            // ตรวจสอบว่า CompanyName ไม่เป็นค่าว่าง
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อบริษัท", "Error");
                return;
            }

            string sql = @"UPDATE Customers 
                   SET CompanyName = @CompanyName, 
                       ContactName = @ContactName, 
                       ContactTitle = @ContactTitle, 
                       Address = @Address, 
                       City = @City, 
                       Region = @Region, 
                       PostalCode = @PostalCode, 
                       Country = @Country, 
                       Phone = @Phone, 
                       Fax = @Fax 
                   WHERE CustomerID = @CustomerID";

            cmd = new SqlCommand(sql, connection);

            // เพิ่มค่าพารามิเตอร์
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactTitle", txtContactTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
            cmd.Parameters.AddWithValue("@Region", textRegion.Text.Trim());
            cmd.Parameters.AddWithValue("@PostalCode", textPostalCode.Text.Trim());
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", textPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Fax", textFax.Text.Trim());
            cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim());

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


        private void insertShippers()
        {
            MessageBox.Show("เพิ่มข้อมูลใหม่");

            // ตรวจสอบว่า Company Name ได้รับการกรอกหรือไม่
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อบริษัท", "Error");
                return;
            }

            string sql = @"INSERT INTO Customers 
                   (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) 
                   VALUES 
                   (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)";

            cmd = new SqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim());
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactTitle", txtContactTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
            cmd.Parameters.AddWithValue("@Region", textRegion.Text.Trim());
            cmd.Parameters.AddWithValue("@PostalCode", textPostalCode.Text.Trim());
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", textPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Fax", textFax.Text.Trim());

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
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error");
            }
        }
    }
}
