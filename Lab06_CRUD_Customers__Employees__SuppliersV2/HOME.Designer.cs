namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class HOME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customer = new Button();
            Employees = new Button();
            Suppliers = new Button();
            groupBox1 = new GroupBox();
            txtshowposition = new TextBox();
            txtshowID = new TextBox();
            login = new Button();
            logout = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // customer
            // 
            customer.Font = new Font("Segoe UI", 12F);
            customer.Location = new Point(19, 246);
            customer.Margin = new Padding(3, 2, 3, 2);
            customer.Name = "customer";
            customer.Size = new Size(218, 66);
            customer.TabIndex = 0;
            customer.Text = "Customer";
            customer.UseVisualStyleBackColor = true;
            customer.Click += customer_Click;
            // 
            // Employees
            // 
            Employees.Font = new Font("Segoe UI", 12F);
            Employees.Location = new Point(19, 157);
            Employees.Margin = new Padding(3, 2, 3, 2);
            Employees.Name = "Employees";
            Employees.Size = new Size(218, 66);
            Employees.TabIndex = 1;
            Employees.Text = "Employees";
            Employees.UseVisualStyleBackColor = true;
            Employees.Click += Employees_Click;
            // 
            // Suppliers
            // 
            Suppliers.Font = new Font("Segoe UI", 12F);
            Suppliers.Location = new Point(19, 339);
            Suppliers.Margin = new Padding(3, 2, 3, 2);
            Suppliers.Name = "Suppliers";
            Suppliers.Size = new Size(218, 66);
            Suppliers.TabIndex = 2;
            Suppliers.Text = "Suppliers";
            Suppliers.UseVisualStyleBackColor = true;
            Suppliers.Click += Suppliers_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtshowposition);
            groupBox1.Controls.Add(txtshowID);
            groupBox1.Controls.Add(Suppliers);
            groupBox1.Controls.Add(Employees);
            groupBox1.Controls.Add(customer);
            groupBox1.Location = new Point(39, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 422);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // txtshowposition
            // 
            txtshowposition.BackColor = SystemColors.InactiveCaption;
            txtshowposition.BorderStyle = BorderStyle.None;
            txtshowposition.Font = new Font("Segoe UI", 11F);
            txtshowposition.Location = new Point(6, 123);
            txtshowposition.Name = "txtshowposition";
            txtshowposition.Size = new Size(254, 20);
            txtshowposition.TabIndex = 8;
            txtshowposition.TextChanged += txtshowposition_TextChanged;
            // 
            // txtshowID
            // 
            txtshowID.BackColor = SystemColors.InactiveCaption;
            txtshowID.BorderStyle = BorderStyle.None;
            txtshowID.Font = new Font("Segoe UI", 11F);
            txtshowID.Location = new Point(6, 84);
            txtshowID.Name = "txtshowID";
            txtshowID.Size = new Size(254, 20);
            txtshowID.TabIndex = 6;
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 12F);
            login.Location = new Point(39, 14);
            login.Name = "login";
            login.Size = new Size(115, 35);
            login.TabIndex = 4;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // logout
            // 
            logout.Font = new Font("Segoe UI", 12F);
            logout.Location = new Point(178, 14);
            logout.Name = "logout";
            logout.Size = new Size(115, 35);
            logout.TabIndex = 7;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Visible = false;
            logout.Click += logout_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(247, 44);
            button1.TabIndex = 8;
            button1.Text = "ขายสินค้า";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(338, 510);
            Controls.Add(logout);
            Controls.Add(login);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HOME";
            Text = "HOME";
            Load += HOME_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button customer;
        private Button Employees;
        private Button Suppliers;
        private GroupBox groupBox1;
        private Button login;
        private TextBox txtshowID;
        private Button logout;
        private TextBox txtshowposition;
        private Button button1;
    }
}