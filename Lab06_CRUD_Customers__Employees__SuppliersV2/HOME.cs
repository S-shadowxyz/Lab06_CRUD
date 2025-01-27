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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            Customer form1 = new Customer();
            form1.ShowDialog();
            this.Hide();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.ShowDialog();
            this.Hide();
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.ShowDialog();
            this.Hide();
        }
    }
}
