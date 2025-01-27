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
            // ��Ǩ�ͺ����ա�����͡��� DataGridView �������
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("��س����͡�������١��ҷ���ͧ������", "Error");
                return;
            }

            // �֧��Ҩҡ�Ƿ�����͡
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // ��Ǩ�ͺ��� CustomerID �դ�������������
            if (row.Cells["CustomerID"].Value == null)
            {
                MessageBox.Show("�������ö��䢢����ŷ������� CustomerID ��", "Error");
                return;
            }

            // ���ҧ��������
            AddCustomer f = new AddCustomer();
            f.status = "update";

            // �觤�Ҩҡ DataGridView ��ѧ�����
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

            // �ʴ���������
            f.ShowDialog();

            // ��Ŵ����������
            showdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ��Ǩ�ͺ������Ƿ��١���͡�������
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("��س����͡�������١��ҷ���ͧ���ź", "Error");
                return;
            }

            // �֧��Ҩҡ�Ƿ�����͡
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // ��Ǩ�ͺ��� CustomerID �դ�������������
            if (row.Cells["CustomerID"].Value == null)
            {
                MessageBox.Show("�������öź�����ŷ������� CustomerID ��", "Error");
                return;
            }

            string customerID = row.Cells["CustomerID"].Value.ToString();

            // �׹�ѹ���ź������
            DialogResult result = MessageBox.Show($"�س��ͧ���ź�١��� ID: {customerID} ���������?", "�׹�ѹ���ź", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // SQL ����Ѻź������
                    string sql = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                    // ���ҧ����� SQL
                    cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    // �Դ�����������
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    // ź������
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // �ʴ����Ѿ��
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("ź�����������", "�����");
                        showdata(); // ��Ŵ����������
                    }
                    else
                    {
                        MessageBox.Show("��辺�����ŷ���ͧ���ź", "��ͼԴ��Ҵ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�Դ��ͼԴ��Ҵ: {ex.Message}", "��ͼԴ��Ҵ");
                }
                finally
                {
                    // �Դ�����������
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
                // ���絢������ DataGridView ����Ŵ����������ҡ�ҹ������
                showdata();

                // �ʴ���ͤ�������͹��������������
                MessageBox.Show("���絢����������", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // �ʴ���ͤ�����ͼԴ��Ҵ�ҡ�Դ�ѭ��
                MessageBox.Show($"�Դ��ͼԴ��Ҵ: {ex.Message}", "��ͼԴ��Ҵ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (e.RowIndex >= 0)  // ��Ǩ�ͺ����Ƿ��١��ԡ����㹢ͺࢵ�ͧ DataGridView
            {
                // �֧��Ҩҡ�Ƿ�����͡
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // ��Ǩ�ͺ��� SupplierID �դ�������������
                if (row.Cells["CustomerID"].Value == null)
                {
                    MessageBox.Show("�������ö��䢢����ŷ������� SupplierID ��", "Error");
                    return;
                }

                AddCustomer f = new AddCustomer();
                f.status = "update";

                // �觤�Ҩҡ DataGridView ��ѧ�����
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

                // �ʴ���������
                f.ShowDialog();
            }

        }
        
    }

 }

