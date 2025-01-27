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
    public partial class AddSuppliers : Form
    {
        public AddSuppliers()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlDataAdapter da;
        SqlCommand cmd;

        public string SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string statusss { get; set; }

        private void AddSuppliers_Load(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind();

            // กำหนดค่าเริ่มต้นใน TextBox
            txtSupplierID.Text = SupplierID ?? string.Empty;
            txtCompanyName.Text = CompanyName ?? string.Empty;
            txtContactName.Text = ContactName ?? string.Empty;
            txtContactTitle.Text = ContactTitle ?? string.Empty;
            txtAddress.Text = Address ?? string.Empty;
            txtCity.Text = City ?? string.Empty;
            txtRegion.Text = Region ?? string.Empty;
            txtPostalCode.Text = PostalCode ?? string.Empty;
            txtCountry.Text = Country ?? string.Empty;
            txtPhone.Text = Phone ?? string.Empty;
            txtFax.Text = Fax ?? string.Empty;

            // ตั้ง Focus ไปที่ TextBox ชื่อบริษัท
            txtCompanyName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (statusss == "insert")
            {
                InsertSuppliers();
            }
            else if (statusss == "update")
            {
                UpdateSuppliers();
            }
            this.Close();
        }
        private void InsertSuppliers()
        {
            MessageBox.Show("เพิ่มข้อมูลใหม่");

            if (string.IsNullOrEmpty(txtCompanyName.Text) || string.IsNullOrEmpty(txtContactName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อผู้จัดส่งและชื่อผู้ติดต่อ", "Error");
                return;
            }

            string sql = @"INSERT INTO Suppliers 
                   (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) 
                   VALUES 
                   (@CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)";

            cmd = new SqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactTitle", txtContactTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
            cmd.Parameters.AddWithValue("@Region", txtRegion.Text.Trim());
            cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text.Trim());
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Fax", txtFax.Text.Trim());

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
        private void UpdateSuppliers()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");

            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อผู้จัดส่ง", "Error");
                return;
            }

            string sql = @"UPDATE Suppliers 
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
                   WHERE SupplierID = @SupplierID";

            cmd = new SqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactTitle", txtContactTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
            cmd.Parameters.AddWithValue("@Region", txtRegion.Text.Trim());
            cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text.Trim());
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Fax", txtFax.Text.Trim());
            cmd.Parameters.AddWithValue("@SupplierID", txtSupplierID.Text.Trim());

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

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
