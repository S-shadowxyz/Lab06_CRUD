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
            SuspendLayout();
            // 
            // customer
            // 
            customer.Location = new Point(118, 112);
            customer.Name = "customer";
            customer.Size = new Size(134, 59);
            customer.TabIndex = 0;
            customer.Text = "customer";
            customer.UseVisualStyleBackColor = true;
            customer.Click += customer_Click;
            // 
            // Employees
            // 
            Employees.Location = new Point(258, 112);
            Employees.Name = "Employees";
            Employees.Size = new Size(134, 59);
            Employees.TabIndex = 1;
            Employees.Text = "Employees";
            Employees.UseVisualStyleBackColor = true;
            Employees.Click += Employees_Click;
            // 
            // Suppliers
            // 
            Suppliers.Location = new Point(398, 112);
            Suppliers.Name = "Suppliers";
            Suppliers.Size = new Size(134, 59);
            Suppliers.TabIndex = 2;
            Suppliers.Text = "Suppliers";
            Suppliers.UseVisualStyleBackColor = true;
            Suppliers.Click += Suppliers_Click;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(676, 279);
            Controls.Add(Suppliers);
            Controls.Add(Employees);
            Controls.Add(customer);
            Name = "HOME";
            Text = "HOME";
            Load += HOME_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button customer;
        private Button Employees;
        private Button Suppliers;
    }
}