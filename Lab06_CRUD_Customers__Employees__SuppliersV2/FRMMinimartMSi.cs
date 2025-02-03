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
    public partial class FRMMinimartMSi : Form
    {
        public FRMMinimartMSi()
        {
            InitializeComponent();
        }

        public int empID { get; set; }
        public string empName { get; set; }
        public string position { get; set; }
        public string userName { get; set; }

        SqlConnection conn;
        SqlTransaction tr;

        private void FRMMinimartMSi_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectNortwind();
            ListViewFormat();
            ClearProductData();
            txtempID.Text = this.empID.ToString();
            txtempname.Text = this.empName;
        }
        private void ClearProductData() //เคลียร์ข ้อมูลใน Textbox รายการสนิ คา้
        {
            txtpid.Text = "";
            txtpname.Text = "";
            txtpunitprice.Text = "0";
            txtpqty.Text = "1";
            txtptotal.Text = "0";
        }
        private void ListViewFormat() //ส าหรับจัดรูปแบบ ListView
        {
            lsvProducts.Columns.Add("รหัสสินค้า", 120, HorizontalAlignment.Left);
            lsvProducts.Columns.Add("สินค้า", 170, HorizontalAlignment.Left);
            lsvProducts.Columns.Add("ราคา", 120, HorizontalAlignment.Right);
            lsvProducts.Columns.Add("จำนวน", 75, HorizontalAlignment.Right);
            lsvProducts.Columns.Add("รวมเป็นเงิน", 100, HorizontalAlignment.Right);
            lsvProducts.View = View.Details;
            lsvProducts.GridLines = true;
            lsvProducts.FullRowSelect = true;
        }
        private void ClearEmployeeData() //เคลยี รช์ อื่ และรหัสพนักงาน
        {
            txtempID.Text = "";
            txtempname.Text = "";
        }
        private void CalculateTotal() //เอาไว้ค านวณราคารวมของแต่ละรายการ
        {
            double total = Convert.ToDouble(txtpunitprice.Text) * Convert.ToDouble(txtpqty.Text);
            txtptotal.Text = total.ToString("#,##0.00");
            txtpid.Focus();
            txtpid.SelectAll();
        }
        private void CalculateNetPrice() //เอาไว้ค านวณราคารวมทั้งหมด
        {
            double tmpNetPeice = 0.0;
            for (int i = 0; i <= lsvProducts.Items.Count - 1; i++)
            {
                tmpNetPeice += Convert.ToDouble(lsvProducts.Items[i].SubItems[4].Text);
            }
            lblNetPrice.Text = tmpNetPeice.ToString("#,##0.00");
        }

        private void txtempID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "Select EmployeeID,TitleOfCourtesy+FirstName+ SPACE(2)+ LastName as empName"
                + " , Title from employees where employeeID = @employeeID";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@employeeID", txtempID.Text);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    txtempID.Text = dt.Rows[0][0].ToString();
                    txtempname.Text = dt.Rows[0][1].ToString();
                    txtpid.Focus();
                }
                else
                {
                    ClearEmployeeData();
                    txtempname.Focus();
                }
                dr.Close();
                conn.Close();
            }
        }

        private void txtpid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "Select ProductID, ProductName,UnitPrice,UnitsInStock"
                + " from Products where productID = @ProductID";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@ProductID", txtpid.Text);
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    txtpid.Text = dt.Rows[0][0].ToString();
                    txtpname.Text = dt.Rows[0][1].ToString();
                    txtpunitprice.Text = dt.Rows[0][2].ToString();
                    CalculateTotal();
                    txtpid.Focus();
                    txtpid.SelectAll();
                }
                else
                {
                    MessageBox.Show("ไมพ่ บสนิ คา้รหัสนี้", "ผิดพลาด");
                    ClearProductData();
                }
                txtpid.Focus();
                txtpid.SelectAll();
                dr.Close();
                conn.Close();
            }
        }

        private void txtpqty_TextChanged(object sender, EventArgs e)
        {
            if (txtpqty.Text.Trim() == "") txtpqty.Text = "1";
            if (Convert.ToInt16(txtpqty.Text) == 0) txtpqty.Text = "1";
            CalculateTotal();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtpid.Text.Trim() == "" || txtpname.Text.Trim() == "")
            {
                txtpid.Focus();
                txtpid.SelectAll();
                return;
            }
            if (Convert.ToInt16(txtpqty.Text) == 0)
            {
                txtpid.Focus();
                txtpid.SelectAll();
                return;
            }
            ListViewItem lvi;
            string tmpProductID = "";
            for (int i = 0; i <= lsvProducts.Items.Count - 1; i++)
            {
                tmpProductID = lsvProducts.Items[i].SubItems[0].Text;
                if (txtpid.Text == tmpProductID)
                {
                    int qty = Convert.ToInt16(lsvProducts.Items[i].SubItems[3].Text)
                    + Convert.ToInt16(txtpqty.Text);
                    double newTotal = Convert.ToDouble(lsvProducts.Items[i].SubItems[4].Text)
                    + Convert.ToDouble(txtptotal.Text);
                    lsvProducts.Items[i].SubItems[3].Text = qty.ToString();
                    lsvProducts.Items[i].SubItems[4].Text = newTotal.ToString("#,##0.00");
                    ClearProductData();
                    CalculateTotal();
                    CalculateNetPrice();
                    return;
                }
            }
            string[] anyData;
            anyData = new string[] { txtpid.Text , txtpname.Text,txtpunitprice.Text,
            txtpqty.Text , txtptotal.Text};
            lvi = new ListViewItem(anyData);
            lsvProducts.Items.Add(lvi);
            CalculateNetPrice(); ClearProductData(); btnSubmit.Enabled = true;
            txtpid.Focus(); txtpid.SelectAll();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            lsvProducts.Clear();
            ClearProductData();
            ListViewFormat();
            lblNetPrice.Text = "0.00";
            txtpid.Focus();
            txtpid.SelectAll();
        }

        private void lsvProducts_DoubleClick(object sender, EventArgs e)
        {
            //เมื่อ Double click บนขอ้มลู สนิ คา้จะลบสนิ คา้ออกจากรายการ
            for (int i = 0; i <= lsvProducts.SelectedItems.Count - 1; i++)
            {
                ListViewItem lvi = lsvProducts.SelectedItems[i];
                lsvProducts.Items.Remove(lvi);
            }
            CalculateNetPrice();
            txtpid.Focus();
            txtpid.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearProductData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int lastOrderID = 0; //จะเอําไว้เก็บรหัสที่ใหม่ที่สุดตอนที่ insert order แล ้ว
            if (txtempID.Text.Trim() == "")
            {
                MessageBox.Show("โปรดระบุข้อมูลสินค้า", "มีข้อผิดพลําด");
                txtempID.Focus();
                return;
            }
            if (lsvProducts.Items.Count > 0) //ตรวจสอบวํา่ เลอื กสนิคํา้ไวห้ รอื ยัง
            {
                if (MessageBox.Show("ต้องการบันทึกรายการสั่งซื้อหรือไม่" , "กรุณายืนยัน", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
                {
                    //ประกําศเริ่ม Transaction
                    conn.Open();
                    tr = conn.BeginTransaction();
                    string sql = "insert into Orders(OrderDate,EmployeeID)"
                    + " values (getdate(),@EmployeeID)";
                    SqlCommand comm = new SqlCommand(sql, conn, tr);
                    comm.Parameters.AddWithValue("@EmployeeID", txtempID.Text.Trim());
                    comm.ExecuteNonQuery();
                    //อ่ําน OrderID ลํา่ สดุ ใสไ่ วใ้นตัวแปร lastOrderID
                    string sql1 = "select top 1 OrderID from Orders order by OrderID desc";
                    SqlCommand comm1 = new SqlCommand(sql1, conn, tr);
                    SqlDataReader dr = comm1.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        lastOrderID = dr.GetInt32(dr.GetOrdinal("OrderID"));
                    }
                    dr.Close();
                    //เพมิ่ ขอ้มลู รํายกํารสนิคํา้ OrderDetail ที่ตรงกับ lastOrderID
                    for (int i = 0; i <= lsvProducts.Items.Count - 1; i++)
                    {
                        string sql2 = "insert into [Order Details](OrderID,ProductID,UnitPrice,Quantity)"
                        + " values(@OrderID,@ProductID,@UnitPrice,@Quantity)";
                        SqlCommand comm3 = new SqlCommand(sql2, conn, tr);
                        comm3.Parameters.AddWithValue("@OrderID", lastOrderID);
                        comm3.Parameters.AddWithValue("@ProductID", lsvProducts.Items[i].SubItems[0].Text);
                        comm3.Parameters.AddWithValue("@UnitPrice", lsvProducts.Items[i].SubItems[2].Text);
                        comm3.Parameters.AddWithValue("@Quantity", lsvProducts.Items[i].SubItems[3].Text);
                        comm3.ExecuteNonQuery();
                    }
                    tr.Commit();
                    conn.Close();
                    MessageBox.Show("บันทึกรํายกํารขํายเรียบร้อยแล้ว", "ผลกํารท ํางําน");
                }
                btnCancle.PerformClick(); //สั่งใหไ้ปกดป่ม ุ cancel เคลีย์หน้ําจอทั้งหมดใหม่เพื่อเริ่มรํายกํารใหม่
            }
        }
    }
    
}
