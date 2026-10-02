namespace DataGridView
{
    partial class Form1
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
            gvNhanVienC1 = new System.Windows.Forms.DataGridView();
            clMaNV = new DataGridViewTextBoxColumn();
            clTenNV = new DataGridViewTextBoxColumn();
            clGioiTinh = new DataGridViewTextBoxColumn();
            gvNhanVienC2 = new System.Windows.Forms.DataGridView();
            txtBNhap = new TextBox();
            btnNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)gvNhanVienC1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvNhanVienC2).BeginInit();
            SuspendLayout();
            // 
            // gvNhanVienC1
            // 
            gvNhanVienC1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvNhanVienC1.Columns.AddRange(new DataGridViewColumn[] { clMaNV, clTenNV, clGioiTinh });
            gvNhanVienC1.Location = new Point(337, 202);
            gvNhanVienC1.Name = "gvNhanVienC1";
            gvNhanVienC1.Size = new Size(344, 141);
            gvNhanVienC1.TabIndex = 0;
            gvNhanVienC1.CellContentClick += gvNhanVienC1_CellContentClick;
            // 
            // clMaNV
            // 
            clMaNV.HeaderText = "Mã NV";
            clMaNV.Name = "clMaNV";
            // 
            // clTenNV
            // 
            clTenNV.HeaderText = "Tên NV";
            clTenNV.Name = "clTenNV";
            // 
            // clGioiTinh
            // 
            clGioiTinh.HeaderText = "Giới Tính";
            clGioiTinh.Name = "clGioiTinh";
            // 
            // gvNhanVienC2
            // 
            gvNhanVienC2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvNhanVienC2.Location = new Point(33, 12);
            gvNhanVienC2.Name = "gvNhanVienC2";
            gvNhanVienC2.Size = new Size(237, 224);
            gvNhanVienC2.TabIndex = 1;
            gvNhanVienC2.CellContentClick += gvNhanVienC2_CellContentClick;
            // 
            // txtBNhap
            // 
            txtBNhap.Location = new Point(322, 99);
            txtBNhap.Name = "txtBNhap";
            txtBNhap.Size = new Size(100, 23);
            txtBNhap.TabIndex = 2;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(449, 98);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 3;
            btnNhap.Text = "Gửi dữ liệu sang form 2";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNhap);
            Controls.Add(txtBNhap);
            Controls.Add(gvNhanVienC2);
            Controls.Add(gvNhanVienC1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gvNhanVienC1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvNhanVienC2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView gvNhanVienC1;
        private DataGridViewTextBoxColumn clMaNV;
        private DataGridViewTextBoxColumn clTenNV;
        private DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridView gvNhanVienC2;
        private TextBox txtBNhap;
        private Button btnNhap;
    }
}
