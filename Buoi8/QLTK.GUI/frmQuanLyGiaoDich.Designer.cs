namespace QLTK.GUI
{
    partial class frmQuanLyGiaoDich
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
            dgvQLGD = new DataGridView();
            lblTitle = new Label();
            lblTitle1 = new Label();
            lblSTK = new Label();
            lblGD = new Label();
            lblSoTien = new Label();
            lblNoiDung = new Label();
            txtNoiDung = new TextBox();
            cbbGiaoDich = new ComboBox();
            cbbSTK = new ComboBox();
            txtSoTien = new TextBox();
            btnThem = new Button();
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            menuGuiTien = new ToolStripMenuItem();
            menuSoDuCuoiKy = new ToolStripMenuItem();
            xuấtBáoCáoToolStripMenuItem = new ToolStripMenuItem();
            menuXuatExcel = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvQLGD).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvQLGD
            // 
            dgvQLGD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLGD.Location = new Point(333, 75);
            dgvQLGD.Name = "dgvQLGD";
            dgvQLGD.Size = new Size(455, 315);
            dgvQLGD.TabIndex = 0;
            dgvQLGD.CellClick += dgvQLGD_CellClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(304, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(116, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Thông Tin Giao Dịch";
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.Location = new Point(30, 75);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Size = new Size(116, 15);
            lblTitle1.TabIndex = 2;
            lblTitle1.Text = "Thông Tin Giao Dịch";
            // 
            // lblSTK
            // 
            lblSTK.AutoSize = true;
            lblSTK.Location = new Point(12, 122);
            lblSTK.Name = "lblSTK";
            lblSTK.Size = new Size(27, 15);
            lblSTK.TabIndex = 3;
            lblSTK.Text = "STK";
            // 
            // lblGD
            // 
            lblGD.AutoSize = true;
            lblGD.Location = new Point(12, 153);
            lblGD.Name = "lblGD";
            lblGD.Size = new Size(23, 15);
            lblGD.TabIndex = 4;
            lblGD.Text = "GD";
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new Point(12, 195);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(46, 15);
            lblSoTien.TabIndex = 5;
            lblSoTien.Text = "Số Tiền";
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(12, 248);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(58, 15);
            lblNoiDung.TabIndex = 6;
            lblNoiDung.Text = "Nội Dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(94, 248);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(221, 98);
            txtNoiDung.TabIndex = 7;
            // 
            // cbbGiaoDich
            // 
            cbbGiaoDich.FormattingEnabled = true;
            cbbGiaoDich.Location = new Point(94, 153);
            cbbGiaoDich.Name = "cbbGiaoDich";
            cbbGiaoDich.Size = new Size(221, 23);
            cbbGiaoDich.TabIndex = 8;
            // 
            // cbbSTK
            // 
            cbbSTK.FormattingEnabled = true;
            cbbSTK.Location = new Point(94, 119);
            cbbSTK.Name = "cbbSTK";
            cbbSTK.Size = new Size(221, 23);
            cbbSTK.TabIndex = 9;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(94, 195);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(221, 23);
            txtSoTien.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(157, 367);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuGuiTien, menuSoDuCuoiKy, xuấtBáoCáoToolStripMenuItem, menuXuatExcel });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(79, 20);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // menuGuiTien
            // 
            menuGuiTien.Name = "menuGuiTien";
            menuGuiTien.ShortcutKeys = Keys.F1;
            menuGuiTien.Size = new Size(214, 22);
            menuGuiTien.Text = "Các Giao Dịch Gửi Tiền";
            menuGuiTien.Click += menuGuiTien_Click;
            // 
            // menuSoDuCuoiKy
            // 
            menuSoDuCuoiKy.Name = "menuSoDuCuoiKy";
            menuSoDuCuoiKy.ShortcutKeys = Keys.F2;
            menuSoDuCuoiKy.Size = new Size(214, 22);
            menuSoDuCuoiKy.Text = "Số Dư Cuối Kỳ";
            menuSoDuCuoiKy.Click += menuSoDuCuoiKy_Click;
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            xuấtBáoCáoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            xuấtBáoCáoToolStripMenuItem.Size = new Size(214, 22);
            xuấtBáoCáoToolStripMenuItem.Text = "Xuất Báo Cáo";
            xuấtBáoCáoToolStripMenuItem.Click += xuấtBáoCáoToolStripMenuItem_Click;
            // 
            // menuXuatExcel
            // 
            menuXuatExcel.Name = "menuXuatExcel";
            menuXuatExcel.ShortcutKeys = Keys.Control | Keys.E;
            menuXuatExcel.Size = new Size(214, 22);
            menuXuatExcel.Text = "Xuất Excel";
            menuXuatExcel.Click += menuXuatExcel_Click;
            // 
            // frmQuanLyGiaoDich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThem);
            Controls.Add(txtSoTien);
            Controls.Add(cbbSTK);
            Controls.Add(cbbGiaoDich);
            Controls.Add(txtNoiDung);
            Controls.Add(lblNoiDung);
            Controls.Add(lblSoTien);
            Controls.Add(lblGD);
            Controls.Add(lblSTK);
            Controls.Add(lblTitle1);
            Controls.Add(lblTitle);
            Controls.Add(dgvQLGD);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmQuanLyGiaoDich";
            Text = "Form1";
            Load += frmQuanLyGiaoDich_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLGD).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQLGD;
        private Label lblTitle;
        private Label lblTitle1;
        private Label lblSTK;
        private Label lblGD;
        private Label lblSoTien;
        private Label lblNoiDung;
        private TextBox txtNoiDung;
        private ComboBox cbbGiaoDich;
        private ComboBox cbbSTK;
        private TextBox txtSoTien;
        private Button btnThem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem menuGuiTien;
        private ToolStripMenuItem menuSoDuCuoiKy;
        private ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private ToolStripMenuItem menuXuatExcel;
    }
}
