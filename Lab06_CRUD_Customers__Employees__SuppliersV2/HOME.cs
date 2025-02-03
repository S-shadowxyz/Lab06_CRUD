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

        public string loginstatus { get; set; }

        private void customer_Click(object sender, EventArgs e)
        {
            Customer form1 = new Customer();
            form1.ShowDialog();
            
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.ShowDialog();
            
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.ShowDialog();
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            FRMLogin f = new FRMLogin();
            f.ShowDialog();
            if (f.loginstatus == "pass" || loginstatus == "pass" )
            {
                this.Text = "Northwind Program";
                txtshowID.Text += "Id : " + f.employeeID.ToString() + " name :" + f.employeeName;
                txtshowposition.Text += " position :" + f.employeePosition;
                //this.Text = "Northwind Id : " + f.employeeID.ToString();
                //this.Text += " name :" + f.employeeName + " position :" + f.employeePosition;
                groupBox1.Visible = true;
                logout.Visible = true;
                login.Visible = false;
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            logout.Visible = false;
            login.Visible = true;
            loginstatus = null;
        }
    }
}
