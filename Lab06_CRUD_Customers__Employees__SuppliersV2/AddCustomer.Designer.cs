namespace Lab06_CRUD_Customers__Employees__Suppliers
{
    partial class AddCustomer
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
            txtCustomerID = new TextBox();
            label1 = new Label();
            txtCompanyName = new TextBox();
            label2 = new Label();
            txtContactName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtContactTitle = new TextBox();
            txtAddress = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtCountry = new TextBox();
            label7 = new Label();
            btnSave = new Button();
            Cancle = new Button();
            textRegion = new TextBox();
            label8 = new Label();
            textPostalCode = new TextBox();
            label9 = new Label();
            textPhone = new TextBox();
            label10 = new Label();
            textFax = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // txtCustomerID
            // 
            txtCustomerID.Font = new Font("Segoe UI", 10F);
            txtCustomerID.Location = new Point(149, 24);
            txtCustomerID.Margin = new Padding(3, 2, 3, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(132, 25);
            txtCustomerID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Customer ID";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(517, 24);
            txtCompanyName.Margin = new Padding(3, 2, 3, 2);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(224, 23);
            txtCompanyName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 72);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(517, 64);
            txtContactName.Margin = new Padding(3, 2, 3, 2);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(222, 23);
            txtContactName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 29);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 5;
            label3.Text = "Company name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 72);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 7;
            label4.Text = "Contact name";
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(149, 69);
            txtContactTitle.Margin = new Padding(3, 2, 3, 2);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(99, 23);
            txtContactTitle.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(130, 116);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(249, 23);
            txtAddress.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 119);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "Address";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(517, 116);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(222, 23);
            txtCity.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(417, 119);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 12;
            label6.Text = "City";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(130, 166);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(176, 23);
            txtCountry.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 169);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 14;
            label7.Text = "Country";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(233, 352);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 38);
            btnSave.TabIndex = 15;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Cancle
            // 
            Cancle.Location = new Point(406, 352);
            Cancle.Margin = new Padding(3, 2, 3, 2);
            Cancle.Name = "Cancle";
            Cancle.Size = new Size(103, 38);
            Cancle.TabIndex = 16;
            Cancle.Text = "Cancle";
            Cancle.UseVisualStyleBackColor = true;
            Cancle.Click += Cancle_Click;
            // 
            // textRegion
            // 
            textRegion.Location = new Point(517, 166);
            textRegion.Margin = new Padding(3, 2, 3, 2);
            textRegion.Name = "textRegion";
            textRegion.Size = new Size(176, 23);
            textRegion.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(417, 169);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 18;
            label8.Text = "Region";
            // 
            // textPostalCode
            // 
            textPostalCode.Location = new Point(130, 209);
            textPostalCode.Margin = new Padding(3, 2, 3, 2);
            textPostalCode.Name = "textPostalCode";
            textPostalCode.Size = new Size(222, 23);
            textPostalCode.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 217);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 20;
            label9.Text = "Post";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(130, 262);
            textPhone.Margin = new Padding(3, 2, 3, 2);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(222, 23);
            textPhone.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(73, 265);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 22;
            label10.Text = "Phone";
            // 
            // textFax
            // 
            textFax.Location = new Point(480, 262);
            textFax.Margin = new Padding(3, 2, 3, 2);
            textFax.Name = "textFax";
            textFax.Size = new Size(176, 23);
            textFax.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(420, 265);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 24;
            label11.Text = "Fax";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(816, 410);
            Controls.Add(label11);
            Controls.Add(textFax);
            Controls.Add(label10);
            Controls.Add(textPhone);
            Controls.Add(label9);
            Controls.Add(textPostalCode);
            Controls.Add(label8);
            Controls.Add(textRegion);
            Controls.Add(Cancle);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(txtCountry);
            Controls.Add(label6);
            Controls.Add(txtCity);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(txtContactTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtContactName);
            Controls.Add(label2);
            Controls.Add(txtCompanyName);
            Controls.Add(label1);
            Controls.Add(txtCustomerID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCustomer";
            Text = "FormAddCustomer";
            Load += FormAddCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerID;
        private Label label1;
        private TextBox txtCompanyName;
        private Label label2;
        private TextBox txtContactName;
        private Label label3;
        private Label label4;
        private TextBox txtContactTitle;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtCountry;
        private Label label7;
        private Button btnSave;
        private Button Cancle;
        private TextBox textRegion;
        private Label label8;
        private TextBox textPostalCode;
        private Label label9;
        private TextBox textPhone;
        private Label label10;
        private TextBox textFax;
        private Label label11;
    }
}