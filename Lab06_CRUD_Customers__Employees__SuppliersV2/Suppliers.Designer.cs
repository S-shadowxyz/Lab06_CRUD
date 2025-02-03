namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class Suppliers
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
            dataGridView3 = new DataGridView();
            btnSuppliers = new Button();
            btnReset = new Button();
            txtDeleteSuppliers = new Button();
            btninsertSuppliers = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 63);
            dataGridView3.Margin = new Padding(3, 2, 3, 2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(1095, 328);
            dataGridView3.TabIndex = 14;
            dataGridView3.CellMouseUp += dataGridView3_CellMouseUp;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(174, 441);
            btnSuppliers.Margin = new Padding(3, 2, 3, 2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(94, 40);
            btnSuppliers.TabIndex = 24;
            btnSuppliers.Text = "Edit";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnReset.Location = new Point(530, 441);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 40);
            btnReset.TabIndex = 23;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtDeleteSuppliers
            // 
            txtDeleteSuppliers.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtDeleteSuppliers.Location = new Point(349, 440);
            txtDeleteSuppliers.Name = "txtDeleteSuppliers";
            txtDeleteSuppliers.Size = new Size(94, 40);
            txtDeleteSuppliers.TabIndex = 22;
            txtDeleteSuppliers.Text = "Delete";
            txtDeleteSuppliers.UseVisualStyleBackColor = true;
            txtDeleteSuppliers.Click += txtDeleteSuppliers_Click;
            // 
            // btninsertSuppliers
            // 
            btninsertSuppliers.Location = new Point(12, 441);
            btninsertSuppliers.Margin = new Padding(3, 2, 3, 2);
            btninsertSuppliers.Name = "btninsertSuppliers";
            btninsertSuppliers.Size = new Size(94, 40);
            btninsertSuppliers.TabIndex = 21;
            btninsertSuppliers.Text = "Add";
            btninsertSuppliers.UseVisualStyleBackColor = true;
            btninsertSuppliers.Click += btninsertSuppliers_Click;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1143, 492);
            Controls.Add(btnSuppliers);
            Controls.Add(btnReset);
            Controls.Add(txtDeleteSuppliers);
            Controls.Add(btninsertSuppliers);
            Controls.Add(dataGridView3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Suppliers";
            Text = "Suppliers";
            Load += Suppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView3;
        private Button btnSuppliers;
        private Button btnReset;
        private Button txtDeleteSuppliers;
        private Button btninsertSuppliers;
    }
}