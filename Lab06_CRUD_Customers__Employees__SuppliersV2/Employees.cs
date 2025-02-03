using Lab06_CRUD_Customers__Employees__Suppliers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlDataAdapter da;
        SqlCommand cmd;




        private void Home_Click(object sender, EventArgs e)
        {
            HOME HOME = new HOME();
            HOME.loginstatus = "pass";
            HOME.Show();
            this.Hide();
        }

        //DATA
        private void showdata()
        {
            string sql = " select * from Employees";
            cmd = new SqlCommand(sql, connection);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        private void Employees_Load(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind();
            showdata();
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
            //Reset
        }

        private void btninsertCustomer_Click(object sender, EventArgs e)
        {
            AddEmployee c = new AddEmployee();
            c.statuss = "insert";
            c.ShowDialog();
            showdata();
        }

        private void btnDeleteCustomerID_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีแถวที่ถูกเลือกหรือไม่
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลพนักงานที่ต้องการลบ", "Error");
                return;
            }

            // ดึงค่าจากแถวที่เลือก
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            // ตรวจสอบว่า EmployeeID มีค่าอยู่หรือไม่
            if (row.Cells["EmployeeID"].Value == null)
            {
                MessageBox.Show("ไม่สามารถลบข้อมูลที่ไม่มี EmployeeID ได้", "Error");
                return;
            }

            // ดึงค่า EmployeeID จากแถวที่เลือก
            string employeeID = row.Cells["EmployeeID"].Value.ToString();

            // ยืนยันการลบข้อมูล
            DialogResult result = MessageBox.Show($"คุณต้องการลบพนักงาน ID: {employeeID} ใช่หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // SQL สำหรับลบข้อมูล
                    string sql = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";

                    // สร้างคำสั่ง SQL
                    cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

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
                        MessageBox.Show("ลบข้อมูลพนักงานสำเร็จ", "สำเร็จ");
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



        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลพนักงานที่ต้องการแก้ไข", "Error");
                return;
            }

            // ดึงค่าจากแถวที่เลือก
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            // ตรวจสอบว่า EmployeeID มีค่าอยู่หรือไม่
            if (row.Cells["EmployeeID"].Value == null)
            {
                MessageBox.Show("ไม่สามารถแก้ไขข้อมูลที่ไม่มี EmployeeID ได้", "Error");
                return;
            }

            // สร้างฟอร์ม AddCustomer สำหรับการแก้ไข
            AddEmployee c = new AddEmployee();
            c.statuss = "update";  // ตั้งค่าเป็น "update" เพื่อระบุว่าเป็นการแก้ไข

            // ส่งค่าจาก DataGridView ไปยังฟอร์ม AddCustomer
            c.EmployeeID = row.Cells["EmployeeID"].Value.ToString();
            c.LastName = row.Cells["LastName"].Value?.ToString();
            c.FirstName = row.Cells["FirstName"].Value?.ToString();
            c.Title = row.Cells["Title"].Value?.ToString();
            c.TitleOfCourtesy = row.Cells["TitleOfCourtesy"].Value?.ToString();
            c.BirthDate = row.Cells["BirthDate"].Value as DateTime?;
            c.HireDate = row.Cells["HireDate"].Value as DateTime?;
            c.Address = row.Cells["Address"].Value?.ToString();
            c.City = row.Cells["City"].Value?.ToString();
            c.Region = row.Cells["Region"].Value?.ToString();
            c.PostalCode = row.Cells["PostalCode"].Value?.ToString();
            c.Country = row.Cells["Country"].Value?.ToString();
            c.HomePhone = row.Cells["HomePhone"].Value?.ToString();
            c.Extension = row.Cells["Extension"].Value?.ToString();
            c.Extension = row.Cells["PhotoPath"].Value?.ToString();

            // แสดงฟอร์ม AddCustomer
            c.ShowDialog();

            // โหลดข้อมูลใหม่
            showdata();
        }

        private void dataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)  // ตรวจสอบว่าแถวที่ถูกคลิกอยู่ในขอบเขตของ DataGridView
            {
                // ดึงค่าจากแถวที่เลือก
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // ตรวจสอบว่า SupplierID มีค่าอยู่หรือไม่
                if (row.Cells["EmployeeID"].Value == null)
                {
                    MessageBox.Show("ไม่สามารถแก้ไขข้อมูลที่ไม่มี SupplierID ได้", "Error");
                    return;
                }

                AddEmployee c = new AddEmployee();
                c.statuss = "update"; 

                // ส่งค่าจาก DataGridView ไปยังฟอร์ม AddSupplier
                c.EmployeeID = row.Cells["EmployeeID"].Value.ToString();
                c.LastName = row.Cells["LastName"].Value?.ToString();
                c.FirstName = row.Cells["FirstName"].Value?.ToString();
                c.Title = row.Cells["Title"].Value?.ToString();
                c.TitleOfCourtesy = row.Cells["TitleOfCourtesy"].Value?.ToString();
                c.BirthDate = row.Cells["BirthDate"].Value as DateTime?;
                c.HireDate = row.Cells["HireDate"].Value as DateTime?;
                c.Address = row.Cells["Address"].Value?.ToString();
                c.City = row.Cells["City"].Value?.ToString();
                c.Region = row.Cells["Region"].Value?.ToString();
                c.PostalCode = row.Cells["PostalCode"].Value?.ToString();
                c.Country = row.Cells["Country"].Value?.ToString();
                c.HomePhone = row.Cells["HomePhone"].Value?.ToString();
                c.Extension = row.Cells["Extension"].Value?.ToString();


                // แสดงฟอร์ม AddSupplier
                c.ShowDialog();

                // โหลดข้อมูลใหม่หากมีการปรับปรุง
                // showdata();  // หากต้องการโหลดข้อมูลใหม่จากฐานข้อมูล
            }
        }
    }
}
