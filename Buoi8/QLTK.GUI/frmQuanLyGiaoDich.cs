using QLTK.BLL;

namespace QLTK.GUI
{
    public partial class frmQuanLyGiaoDich : Form
    {
        private readonly GiaoDichBLL _gdBLL = new GiaoDichBLL();
        private readonly TaiKhoanBLL _tkBLL = new TaiKhoanBLL();
        public frmQuanLyGiaoDich()
        {
            InitializeComponent();
        }

        private void frmQuanLyGiaoDich_Load(object sender, EventArgs e)
        {
            LoadComboBoxTaiKhoan();
            LoadComboBoxLoaiGD();
            LoadDataGridView(_gdBLL.GetAllGiaoDich());
        }
        private void LoadComboBoxTaiKhoan()
        {
            cbbSTK.DataSource = _tkBLL.GetAllTaiKhoan();
            cbbSTK.DisplayMember = "STK";
            cbbSTK.ValueMember = "STK";
        }

        private void LoadComboBoxLoaiGD()
        {
            cbbGiaoDich.Items.Clear();
            cbbGiaoDich.Items.Add("Nhận tiền");
            cbbGiaoDich.Items.Add("Rút tiền");
            cbbGiaoDich.SelectedIndex = 0;
        }

        private void LoadDataGridView(object data)
        {
            var list = (data as System.Collections.Generic.List<QLTK.DAL.Models.GiaoDich>)
                .Select(g => new
                {
                    g.Id, // <-- Thêm dòng này để hiển thị cột ID lên DataGridView
                    LoaiGD = g.SoTien > 0 ? "Nhận tiền" : "Rút tiền",
                    SoTien = Math.Abs(g.SoTien), // Lấy giá trị dương
                    g.NoiDung,
                    g.STK
                }).ToList();

            dgvQLGD.DataSource = list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string stk = cbbSTK.SelectedValue.ToString();
            string loaiGD = cbbGiaoDich.SelectedItem.ToString();

            if (!int.TryParse(txtSoTien.Text.Trim(), out int soTien))
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ!");
                return;
            }

            string noiDung = txtNoiDung.Text;

            // Gọi BLL xử lý nghiệp vụ thêm[cite: 4]
            string message = _gdBLL.AddGiaoDich(stk, loaiGD, soTien, noiDung);
            MessageBox.Show(message);

            // Làm mới lại form sau khi thêm thành công
            if (message.Contains("thành công"))
            {
                LoadDataGridView(_gdBLL.GetAllGiaoDich());
                txtSoTien.Clear();
                txtNoiDung.Clear();
                cbbGiaoDich.SelectedIndex = 0;
            }
        }
        private void dgvQLGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQLGD.Rows[e.RowIndex];
                cbbSTK.SelectedValue = row.Cells["STK"].Value.ToString();
                cbbGiaoDich.SelectedItem = row.Cells["LoaiGD"].Value.ToString();
                txtSoTien.Text = row.Cells["SoTien"].Value.ToString();
                txtNoiDung.Text = row.Cells["NoiDung"].Value?.ToString();
            }
        }
        // Xử lý menu F1: Các giao dịch Gửi Tiền[cite: 4]
        private void menuGuiTien_Click(object sender, EventArgs e)
        {
            LoadDataGridView(_gdBLL.GetGiaoDichGuiTien());
        }
        // Xử lý menu F2: Số Dư Cuối Kỳ[cite: 4]
        private void menuSoDuCuoiKy_Click(object sender, EventArgs e)
        {
            var dsTaiKhoan = _tkBLL.GetAllTaiKhoan();
            string info = "Số dư cuối kỳ:\n";
            int stt = 1;
            foreach (var tk in dsTaiKhoan)
            {
                decimal sdck = _tkBLL.GetSoDuCuoiKy(tk.STK);
                info += $"{stt}. TK {tk.STK} - SDCK: {sdck}\n";
                stt++;
            }
            MessageBox.Show(info);
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaoKe frm = new frmSaoKe();
            frm.ShowDialog();
        }

        private void menuXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
                sfd.FileName = "SaoKe_" + cbbSTK.SelectedValue.ToString() + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string stk = cbbSTK.SelectedValue.ToString();
                        var tk = _tkBLL.GetAllTaiKhoan().FirstOrDefault(t => t.STK == stk);
                        var dsGiaoDich = _gdBLL.GetAllGiaoDich().Where(g => g.STK == stk).ToList();
                        decimal soDuCuoiKy = _tkBLL.GetSoDuCuoiKy(stk);

                        // Gọi lớp xuất Excel riêng biệt
                        ExcelExportHelper exporter = new ExcelExportHelper();
                        exporter.ExportSaoKe(sfd.FileName, tk, dsGiaoDich, soDuCuoiKy);

                        // Thông báo thành công và hỏi mở file[cite: 4]
                        if (MessageBox.Show("Xuất file Excel thành công! Bạn có muốn mở file không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                        }
                    }
                    catch (Exception ex)
                    {
                        // Bắt lỗi (ví dụ file đang mở bởi Excel)[cite: 4]
                        MessageBox.Show("Lỗi xuất file: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
