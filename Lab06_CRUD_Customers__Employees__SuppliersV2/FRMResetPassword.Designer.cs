namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class FRMResetPassword
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
            txtHomePhone = new TextBox();
            btnCancle = new Button();
            btnSubmit = new Button();
            txtcomfirmpass = new TextBox();
            txtpassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // txtHomePhone
            // 
            txtHomePhone.Font = new Font("Segoe UI", 12F);
            txtHomePhone.Location = new Point(152, 127);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(255, 29);
            txtHomePhone.TabIndex = 20;
            // 
            // btnCancle
            // 
            btnCancle.Font = new Font("Segoe UI", 12F);
            btnCancle.Location = new Point(333, 298);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(128, 38);
            btnCancle.TabIndex = 19;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F);
            btnSubmit.Location = new Point(116, 298);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(128, 38);
            btnSubmit.TabIndex = 18;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtcomfirmpass
            // 
            txtcomfirmpass.Font = new Font("Segoe UI", 12F);
            txtcomfirmpass.Location = new Point(206, 239);
            txtcomfirmpass.Name = "txtcomfirmpass";
            txtcomfirmpass.PasswordChar = '*';
            txtcomfirmpass.Size = new Size(255, 29);
            txtcomfirmpass.TabIndex = 17;
            txtcomfirmpass.MouseLeave += txtcomfirmpass_MouseLeave;
            txtcomfirmpass.MouseHover += txtcomfirmpass_MouseHover;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.Location = new Point(206, 187);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(255, 29);
            txtpassword.TabIndex = 16;
            txtpassword.MouseLeave += txtpassword_MouseLeave;
            txtpassword.MouseHover += txtpassword_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(41, 242);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 15;
            label4.Text = "Comfirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(41, 190);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 14;
            label3.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(41, 130);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 13;
            label2.Text = "Homephone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(41, 70);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 12;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(152, 67);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(255, 29);
            txtUsername.TabIndex = 11;
            // 
            // FRMResetPassword
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            CancelButton = btnCancle;
            ClientSize = new Size(522, 365);
            Controls.Add(txtHomePhone);
            Controls.Add(btnCancle);
            Controls.Add(btnSubmit);
            Controls.Add(txtcomfirmpass);
            Controls.Add(txtpassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Name = "FRMResetPassword";
            Text = "FRMResetPassword";
            Load += FRMResetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHomePhone;
        private Button btnCancle;
        private Button btnSubmit;
        private TextBox txtcomfirmpass;
        private TextBox txtpassword;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
    }
}