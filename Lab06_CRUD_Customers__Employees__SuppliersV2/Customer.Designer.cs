namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class Customer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btninsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 52);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1104, 338);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseUp += dataGridView1_CellMouseUp;
            // 
            // btninsert
            // 
            btninsert.Location = new Point(22, 430);
            btninsert.Margin = new Padding(3, 2, 3, 2);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(94, 40);
            btninsert.TabIndex = 1;
            btninsert.Text = "Add";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnEdit.Location = new Point(201, 430);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 40);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnDelete.Location = new Point(395, 430);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 40);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnReset.Location = new Point(582, 430);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 40);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1141, 499);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btninsert);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Customer";
            Text = "Customer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btninsert;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnReset;
    }
}
