namespace BTBuoi6
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
            dgvSinhVien = new DataGridView();
            lblKhung = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            lblHoTen = new Label();
            lblDiem = new Label();
            btnLoc = new Button();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(26, 176);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.Size = new Size(740, 248);
            dgvSinhVien.TabIndex = 0;
            // 
            // lblKhung
            // 
            lblKhung.AutoSize = true;
            lblKhung.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKhung.Location = new Point(26, 19);
            lblKhung.Name = "lblKhung";
            lblKhung.Size = new Size(734, 31);
            lblKhung.TabIndex = 1;
            lblKhung.Text = "QUẢN LÝ SINH VIÊN - EF CORE ( CRUD ĐẦY ĐỦ)";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(64, 142);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "THÊM +";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(201, 142);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(338, 142);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(475, 142);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(75, 23);
            btnTaiLai.TabIndex = 5;
            btnTaiLai.Text = "Tải lại DS";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(115, 96);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(149, 23);
            txtHoTen.TabIndex = 6;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(415, 96);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(100, 23);
            txtDiem.TabIndex = 7;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(60, 100);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(49, 15);
            lblHoTen.TabIndex = 8;
            lblHoTen.Text = "Họ tên :";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(338, 99);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(41, 15);
            lblDiem.TabIndex = 9;
            lblDiem.Text = "Điểm :";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(604, 141);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(75, 23);
            btnLoc.TabIndex = 10;
            btnLoc.Text = "Lọc SV đạt (LINIQ)";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLocDat_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(64, 60);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(13, 15);
            lblTrangThai.TabIndex = 11;
            lblTrangThai.Text = "..";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrangThai);
            Controls.Add(btnLoc);
            Controls.Add(lblDiem);
            Controls.Add(lblHoTen);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblKhung);
            Controls.Add(dgvSinhVien);
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSinhVien;
        private Label lblKhung;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTaiLai;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Label lblHoTen;
        private Label lblDiem;
        private Button btnLoc;
        private Label lblTrangThai;
    }
}
