using Lab06_CRUD_Customers__Employees__Suppliers;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlDataAdapter da;
        SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind();
            showdata();
        }
        
        private void showdata()
        {
            string sql = " select * from Customers";
            cmd = new SqlCommand(sql, connection);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btninsert_Click_Click(object sender, EventArgs e)
        {
            AddCustomer f = new AddCustomer();
            f.status = "insert";
            f.ShowDialog();
            showdata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลลูกค้าที่ต้องการแก้ไข", "Error");
                return;
            }

            // ดึงค่าจากแถวที่เลือก
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // ตรวจสอบว่า CustomerID มีค่าอยู่หรือไม่
            if (row.Cells["CustomerID"].Value == null)
            {
                MessageBox.Show("ไม่สามารถแก้ไขข้อมูลที่ไม่มี CustomerID ได้", "Error");
                return;
            }

            // สร้างฟอร์มแก้ไข
            AddCustomer f = new AddCustomer();
            f.status = "update";

            // ส่งค่าจาก DataGridView ไปยังฟอร์ม
            f.CustomerID = row.Cells["CustomerID"].Value.ToString();
            f.CustomerName = row.Cells["CompanyName"].Value?.ToString();
            f.ContactName = row.Cells["ContactName"].Value?.ToString();
            f.ContactTitle = row.Cells["ContactTitle"].Value?.ToString();
            f.Address = row.Cells["Address"].Value?.ToString();
            f.City = row.Cells["City"].Value?.ToString();
            f.Region = row.Cells["Region"].Value?.ToString();
            f.PostalCode = row.Cells["PostalCode"].Value?.ToString();
            f.Country = row.Cells["Country"].Value?.ToString();
            f.Phone = row.Cells["Phone"].Value?.ToString();
            f.Fax = row.Cells["Fax"].Value?.ToString();

            // แสดงฟอร์มแก้ไข
            f.ShowDialog();

            // โหลดข้อมูลใหม่
            showdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีแถวที่ถูกเลือกหรือไม่
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลลูกค้าที่ต้องการลบ", "Error");
                return;
            }

            // ดึงค่าจากแถวที่เลือก
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // ตรวจสอบว่า CustomerID มีค่าอยู่หรือไม่
            if (row.Cells["CustomerID"].Value == null)
            {
                MessageBox.Show("ไม่สามารถลบข้อมูลที่ไม่มี CustomerID ได้", "Error");
                return;
            }

            string customerID = row.Cells["CustomerID"].Value.ToString();

            // ยืนยันการลบข้อมูล
            DialogResult result = MessageBox.Show($"คุณต้องการลบลูกค้า ID: {customerID} ใช่หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // SQL สำหรับลบข้อมูล
                    string sql = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                    // สร้างคำสั่ง SQL
                    cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    // เปิดการเชื่อมต่อ
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    // ลบข้อมูล
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // แสดงผลลัพธ์
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("ลบข้อมูลสำเร็จ", "สำเร็จ");
                        showdata(); // โหลดข้อมูลใหม่
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลที่ต้องการลบ", "ข้อผิดพลาด");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "ข้อผิดพลาด");
                }
                finally
                {
                    // ปิดการเชื่อมต่อ
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
        //Reset

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                // รีเซ็ตข้อมูลใน DataGridView โดยโหลดข้อมูลใหม่จากฐานข้อมูล
                showdata();

                // แสดงข้อความแจ้งเตือนเมื่อรีเซ็ตสำเร็จ
                MessageBox.Show("รีเซ็ตข้อมูลสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // แสดงข้อความข้อผิดพลาดหากเกิดปัญหา
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //home
        private void Home_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            hOME.Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)  // ตรวจสอบว่าแถวที่ถูกคลิกอยู่ในขอบเขตของ DataGridView
            {
                // ดึงค่าจากแถวที่เลือก
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // ตรวจสอบว่า SupplierID มีค่าอยู่หรือไม่
                if (row.Cells["CustomerID"].Value == null)
                {
                    MessageBox.Show("ไม่สามารถแก้ไขข้อมูลที่ไม่มี SupplierID ได้", "Error");
                    return;
                }

                AddCustomer f = new AddCustomer();
                f.status = "update";

                // ส่งค่าจาก DataGridView ไปยังฟอร์ม
                f.CustomerID = row.Cells["CustomerID"].Value.ToString();
                f.CustomerName = row.Cells["CompanyName"].Value?.ToString();
                f.ContactName = row.Cells["ContactName"].Value?.ToString();
                f.ContactTitle = row.Cells["ContactTitle"].Value?.ToString();
                f.Address = row.Cells["Address"].Value?.ToString();
                f.City = row.Cells["City"].Value?.ToString();
                f.Region = row.Cells["Region"].Value?.ToString();
                f.PostalCode = row.Cells["PostalCode"].Value?.ToString();
                f.Country = row.Cells["Country"].Value?.ToString();
                f.Phone = row.Cells["Phone"].Value?.ToString();
                f.Fax = row.Cells["Fax"].Value?.ToString();

                // แสดงฟอร์มแก้ไข
                f.ShowDialog();
            }

        }
        
    }

 }

