using QLTK.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTK.GUI
{
    public partial class frmSaoKe : Form
    {
        private readonly TaiKhoanBLL _tkBLL = new TaiKhoanBLL();
        private readonly GiaoDichBLL _gdBLL = new GiaoDichBLL();

        public frmSaoKe()
        {
            InitializeComponent();
        }

        private void frmSaoKe_Load(object sender, EventArgs e)
        {
            // 1. Nạp tất cả các tài khoản vào ComboBox khi load form[cite: 4]
            var dsTaiKhoan = _tkBLL.GetAllTaiKhoan();
            cbbSTK.DataSource = dsTaiKhoan;
            cbbSTK.DisplayMember = "STK";
            cbbSTK.ValueMember = "STK";

            // Nếu có tài khoản, tự động load dữ liệu cho tài khoản đầu tiên
            if (dsTaiKhoan.Count > 0)
            {
                HienThiBaoKe(dsTaiKhoan[0].STK);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbbSTK.SelectedValue != null)
            {
                string stk = cbbSTK.SelectedValue.ToString();
                HienThiBaoKe(stk);
            }
        }

        // Hàm xử lý đổ dữ liệu lên các Label và DataGridView giống báo cáo
        private void HienThiBaoKe(string stk)
        {
            // Lấy thông tin tài khoản để hiển thị Tên Ngân Hàng[cite: 4]
            var tk = _tkBLL.GetAllTaiKhoan().FirstOrDefault(t => t.STK == stk);
            if (tk != null)
            {
                lblTenNH.Text = tk.TenNH; // Hiển thị tên ngân hàng ở góc trên
            }

            // Hiển thị dòng thông tin tài khoản[cite: 4]
            lblThongBaoSTK.Text = "Tài khoản: " + stk;

            // Lấy danh sách giao dịch của tài khoản đó[cite: 4]
            var dsGiaoDich = _gdBLL.GetAllGiaoDich()
                                   .Where(g => g.STK == stk)
                                   .Select(g => new {
                                       g.Id,
                                       g.SoTien, // Giữ nguyên số âm/dương theo yêu cầu bảng giao dịch[cite: 4]
                                       g.NoiDung
                                   })
                                   .ToList();

            // Đưa lên DataGridView
            dataGridView1.DataSource = dsGiaoDich;

            // Tùy chỉnh tiêu đề cột cho đẹp mắt (nếu muốn)
            if (dataGridView1.Columns["Id"] != null) dataGridView1.Columns["Id"].HeaderText = "Id";
            if (dataGridView1.Columns["SoTien"] != null) dataGridView1.Columns["SoTien"].HeaderText = "Số tiền";
            if (dataGridView1.Columns["NoiDung"] != null) dataGridView1.Columns["NoiDung"].HeaderText = "Nội dung";
        }
    }
}
