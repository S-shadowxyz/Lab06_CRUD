namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class FRMMinimartMSi
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
            txtempID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtempname = new TextBox();
            groupBox1 = new GroupBox();
            lsvProducts = new ListView();
            label7 = new Label();
            txtptotal = new TextBox();
            label6 = new Label();
            txtpunitprice = new TextBox();
            label5 = new Label();
            txtpqty = new TextBox();
            label4 = new Label();
            txtpname = new TextBox();
            label3 = new Label();
            txtpid = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnadd = new Button();
            btnClear = new Button();
            btnSubmit = new Button();
            btnCancle = new Button();
            lblNetPrice = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtempID
            // 
            txtempID.Font = new Font("Segoe UI", 11F);
            txtempID.Location = new Point(98, 21);
            txtempID.Name = "txtempID";
            txtempID.Size = new Size(83, 27);
            txtempID.TabIndex = 0;
            txtempID.KeyDown += txtempID_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(198, 24);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 2;
            label2.Text = "ชื่อ - นามสกุล";
            // 
            // txtempname
            // 
            txtempname.Font = new Font("Segoe UI", 11F);
            txtempname.Location = new Point(305, 21);
            txtempname.Name = "txtempname";
            txtempname.ReadOnly = true;
            txtempname.Size = new Size(230, 27);
            txtempname.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvProducts);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtptotal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtpunitprice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtpqty);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtpname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtpid);
            groupBox1.Location = new Point(27, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 331);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lsvProducts
            // 
            lsvProducts.Location = new Point(6, 92);
            lsvProducts.Name = "lsvProducts";
            lsvProducts.Size = new Size(623, 229);
            lsvProducts.TabIndex = 13;
            lsvProducts.UseCompatibleStateImageBehavior = false;
            lsvProducts.DoubleClick += lsvProducts_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(539, 19);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 12;
            label7.Text = "รวมเป็นเงิน";
            // 
            // txtptotal
            // 
            txtptotal.Font = new Font("Segoe UI", 11F);
            txtptotal.Location = new Point(539, 45);
            txtptotal.Name = "txtptotal";
            txtptotal.ReadOnly = true;
            txtptotal.Size = new Size(90, 27);
            txtptotal.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(444, 19);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 10;
            label6.Text = "จำนวน";
            // 
            // txtpunitprice
            // 
            txtpunitprice.Font = new Font("Segoe UI", 11F);
            txtpunitprice.Location = new Point(343, 45);
            txtpunitprice.Name = "txtpunitprice";
            txtpunitprice.ReadOnly = true;
            txtpunitprice.Size = new Size(90, 27);
            txtpunitprice.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(344, 19);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 9;
            label5.Text = "ราคาขาย";
            // 
            // txtpqty
            // 
            txtpqty.Font = new Font("Segoe UI", 11F);
            txtpqty.Location = new Point(439, 45);
            txtpqty.Name = "txtpqty";
            txtpqty.Size = new Size(94, 27);
            txtpqty.TabIndex = 8;
            txtpqty.TextChanged += txtpqty_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(120, 19);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 7;
            label4.Text = "ชื่อสินค้า";
            // 
            // txtpname
            // 
            txtpname.Font = new Font("Segoe UI", 11F);
            txtpname.Location = new Point(120, 45);
            txtpname.Name = "txtpname";
            txtpname.ReadOnly = true;
            txtpname.Size = new Size(218, 27);
            txtpname.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "รหัสสินค้า";
            // 
            // txtpid
            // 
            txtpid.Font = new Font("Segoe UI", 11F);
            txtpid.Location = new Point(6, 45);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(108, 27);
            txtpid.TabIndex = 5;
            txtpid.KeyDown += txtpid_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(584, 28);
            label8.Name = "label8";
            label8.Size = new Size(0, 30);
            label8.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(629, 9);
            label9.Name = "label9";
            label9.Size = new Size(76, 21);
            label9.TabIndex = 13;
            label9.Text = "รวมเป็นเงิน";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(679, 106);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(99, 38);
            btnadd.TabIndex = 13;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(679, 164);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 38);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Enabled = false;
            btnSubmit.Location = new Point(668, 344);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(130, 38);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(668, 392);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(130, 38);
            btnCancle.TabIndex = 17;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // lblNetPrice
            // 
            lblNetPrice.AutoSize = true;
            lblNetPrice.Font = new Font("Segoe UI", 16F);
            lblNetPrice.Location = new Point(610, 40);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(123, 30);
            lblNetPrice.TabIndex = 18;
            lblNetPrice.Text = "IBINetPeice";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FRMMinimartMSi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(802, 450);
            Controls.Add(lblNetPrice);
            Controls.Add(btnCancle);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(btnadd);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(txtempname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtempID);
            Name = "FRMMinimartMSi";
            Text = "FRMMinimartMSi";
            Load += FRMMinimartMSi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtempID;
        private Label label1;
        private Label label2;
        private TextBox txtempname;
        private GroupBox groupBox1;
        private TextBox txtpid;
        private Label label7;
        private TextBox txtptotal;
        private Label label6;
        private TextBox txtpunitprice;
        private Label label5;
        private TextBox txtpqty;
        private Label label4;
        private TextBox txtpname;
        private Label label3;
        private Label label8;
        private Label label9;
        private Button btnadd;
        private Button btnClear;
        private Button btnSubmit;
        private Button btnCancle;
        private ListView lsvProducts;
        private Label lblNetPrice;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}