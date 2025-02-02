namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class FRMLogin
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
            linkLabel1 = new LinkLabel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            btnlogout = new Button();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11F);
            linkLabel1.LinkColor = Color.Navy;
            linkLabel1.Location = new Point(183, 297);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(160, 20);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot your password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 16F);
            txtPassword.Location = new Point(183, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(287, 36);
            txtPassword.TabIndex = 17;
            txtPassword.MouseLeave += txtPassword_MouseLeave;
            txtPassword.MouseHover += txtPassword_MouseHover;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 16F);
            txtUsername.Location = new Point(183, 77);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(287, 36);
            txtUsername.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(59, 152);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(307, 224);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(163, 41);
            btnlogout.TabIndex = 14;
            btnlogout.Text = "Cancle";
            btnlogout.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(59, 224);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 41);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Submit";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(55, 77);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 12;
            label1.Text = "Username";
            // 
            // FRMLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            CancelButton = btnlogout;
            ClientSize = new Size(522, 384);
            Controls.Add(linkLabel1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(btnlogout);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "FRMLogin";
            Text = "Login";
            Load += FRMLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Button btnlogout;
        private Button btnLogin;
        private Label label1;
    }
}