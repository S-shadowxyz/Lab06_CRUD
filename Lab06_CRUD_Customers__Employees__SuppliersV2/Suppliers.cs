using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlDataAdapter da;
        SqlCommand cmd;

        // โหลดข้อมูลจากตาราง Suppliers ลง DataGridView
        private void showdata()
        {
            try
            {
                string sql = "SELECT * FROM Suppliers";
                cmd = new SqlCommand(sql, connection);
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาดในการโหลดข้อมูล: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // กำหนดการทำงานเมื่อโหลดฟอร์ม
        private void Suppliers_Load(object sender, EventArgs e)
        {
            try
            {
                connection = connectDB.ConnectNortwind(); // ฟังก์ชันสำหรับเชื่อมต่อฐานข้อมูล
                showdata(); // แสดงข้อมูลเมื่อโหลดฟอร์ม
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ปุ่ม Home สำหรับกลับไปยังฟอร์มหลัก
        private void Home_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        // ปุ่ม Reset สำหรับโหลดข้อมูลใหม่
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                showdata(); // โหลดข้อมูลใหม่
                MessageBox.Show("รีเซ็ตข้อมูลสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ปุ่ม Insert สำหรับเพิ่มข้อมูลใหม่
        private void btninsertSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                AddSuppliers addSuppliers = new AddSuppliers(); // ฟอร์มสำหรับเพิ่มข้อมูล
                addSuppliers.statusss = "insert"; // กำหนดสถานะเป็น "insert"
                addSuppliers.ShowDialog(); // แสดงฟอร์มแบบ Modal
                showdata(); // โหลดข้อมูลใหม่หลังเพิ่ม
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // การคลิกที่ DataGridView
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showdata(); // รีเฟรชข้อมูลเมื่อมีการคลิกใน DataGridView
        }

        private void txtDeleteSuppliers_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีแถวที่ถูกเลือกหรือไม่
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลผู้จัดส่งที่ต้องการลบ", "Error");
                return;
            }

            // ดึงค่าจากแถวที่เลือก
            DataGridViewRow row = dataGridView3.SelectedRows[0];

            // ตรวจสอบว่า SupplierID มีค่าอยู่หรือไม่
            if (row.Cells["SupplierID"].Value == null)
            {
                MessageBox.Show("ไม่สามารถลบข้อมูลที่ไม่มี SupplierID ได้", "Error");
                return;
            }

            // ดึงค่า SupplierID จากแถวที่เลือก
            string supplierID = row.Cells["SupplierID"].Value.ToString();

            // ยืนยันการลบข้อมูล
            DialogResult result = MessageBox.Show($"คุณต้องการลบผู้จัดส่ง ID: {supplierID} ใช่หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // SQL สำหรับลบข้อมูล
                    string sql = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";

                    // สร้างคำสั่ง SQL
                    cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);

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
                        MessageBox.Show("ลบข้อมูลผู้จัดส่งสำเร็จ", "สำเร็จ");
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

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลผู้จัดส่งที่ต้องการแก้ไข", "Error");
                return;
            }

            // ดึงค่าจากแถวที่เลือก
            DataGridViewRow row = dataGridView3.SelectedRows[0];

            // ตรวจสอบว่า SupplierID มีค่าอยู่หรือไม่
            if (row.Cells["SupplierID"].Value == null)
            {
                MessageBox.Show("ไม่สามารถแก้ไขข้อมูลที่ไม่มี SupplierID ได้", "Error");
                return;
            }

            // สร้างฟอร์ม AddSupplier สำหรับการแก้ไข
            AddSuppliers s = new AddSuppliers();
            s.statusss = "update";  // ตั้งค่าเป็น "update" เพื่อระบุว่าเป็นการแก้ไข

            // ส่งค่าจาก DataGridView ไปยังฟอร์ม AddSupplier
            s.SupplierID = row.Cells["SupplierID"].Value.ToString();
            s.CompanyName = row.Cells["CompanyName"].Value?.ToString();
            s.ContactName = row.Cells["ContactName"].Value?.ToString();
            s.ContactTitle = row.Cells["ContactTitle"].Value?.ToString();
            s.Address = row.Cells["Address"].Value?.ToString();
            s.City = row.Cells["City"].Value?.ToString();
            s.Region = row.Cells["Region"].Value?.ToString();
            s.PostalCode = row.Cells["PostalCode"].Value?.ToString();
            s.Country = row.Cells["Country"].Value?.ToString();
            s.Phone = row.Cells["Phone"].Value?.ToString();
            s.Fax = row.Cells["Fax"].Value?.ToString();


            // แสดงฟอร์ม AddSupplier
            s.ShowDialog();

            // โหลดข้อมูลใหม่
            showdata();
        }

        private void dataGridView3_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            if (e.RowIndex >= 0)  // ตรวจสอบว่าแถวที่ถูกคลิกอยู่ในขอบเขตของ DataGridView
            {
                // ดึงค่าจากแถวที่เลือก
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                // ตรวจสอบว่า SupplierID มีค่าอยู่หรือไม่
                if (row.Cells["SupplierID"].Value == null)
                {
                    MessageBox.Show("ไม่สามารถแก้ไขข้อมูลที่ไม่มี SupplierID ได้", "Error");
                    return;
                }

                AddSuppliers s = new AddSuppliers();
                s.statusss = "update";  // ตั้งค่าเป็น "update" เพื่อระบุว่าเป็นการแก้ไข

                // ส่งค่าจาก DataGridView ไปยังฟอร์ม AddSupplier
                s.SupplierID = row.Cells["SupplierID"].Value.ToString();
                s.CompanyName = row.Cells["CompanyName"].Value?.ToString();
                s.ContactName = row.Cells["ContactName"].Value?.ToString();
                s.ContactTitle = row.Cells["ContactTitle"].Value?.ToString();
                s.Address = row.Cells["Address"].Value?.ToString();
                s.City = row.Cells["City"].Value?.ToString();
                s.Region = row.Cells["Region"].Value?.ToString();
                s.PostalCode = row.Cells["PostalCode"].Value?.ToString();
                s.Country = row.Cells["Country"].Value?.ToString();
                s.Phone = row.Cells["Phone"].Value?.ToString();
                s.Fax = row.Cells["Fax"].Value?.ToString();


                // แสดงฟอร์ม AddSupplier
                s.ShowDialog();

                // โหลดข้อมูลใหม่หากมีการปรับปรุง
                // showdata();  // หากต้องการโหลดข้อมูลใหม่จากฐานข้อมูล
            }
        }
    }
}
