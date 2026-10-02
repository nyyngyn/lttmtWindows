using System;
using System.Data;
using System.Windows.Forms;

namespace BTbuoi3
{
    public partial class frmListNV : Form
    {
        // Khai báo DataTable lưu trữ dữ liệu
        private DataTable dtNhanVien;

        // Khai báo các Control
        private DataGridView gvNhanVien;
        private Button btnNut;  // Nút Thêm
        private Button btnSua;  // Nút Sửa
        private Button btnXoa;  // Nút Xóa
        private Button btnDong; // Nút Đóng

        public frmListNV()
        {
            InitializeComponentCustom();
            InitDataTable();
            AssignEvents();
        }

        // Khởi tạo giao diện các Control
        private void InitializeComponentCustom()
        {
            this.Text = "List View";
            this.Size = new System.Drawing.Size(520, 360);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Khởi tạo DataGridView
            gvNhanVien = new DataGridView();
            gvNhanVien.Name = "gvNhanVien";
            gvNhanVien.Location = new System.Drawing.Point(15, 15);
            gvNhanVien.Size = new System.Drawing.Size(370, 280);
            gvNhanVien.ReadOnly = true;
            gvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvNhanVien.MultiSelect = false;
            gvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Khởi tạo các Button
            btnNut = new Button { Name = "btnNut", Text = "Thêm", Location = new System.Drawing.Point(400, 15), Size = new System.Drawing.Size(85, 30) };
            btnSua = new Button { Name = "btnSua", Text = "Sửa", Location = new System.Drawing.Point(400, 55), Size = new System.Drawing.Size(85, 30) };
            btnXoa = new Button { Name = "btnXoa", Text = "Xóa", Location = new System.Drawing.Point(400, 95), Size = new System.Drawing.Size(85, 30) };
            btnDong = new Button { Name = "btnDong", Text = "Đóng", Location = new System.Drawing.Point(400, 135), Size = new System.Drawing.Size(85, 30) };

            // Đưa các Control vào Form
            this.Controls.Add(gvNhanVien);
            this.Controls.Add(btnNut);
            this.Controls.Add(btnSua);
            this.Controls.Add(btnXoa);
            this.Controls.Add(btnDong);
        }

        // Tạo cấu trúc DataTable và nạp dữ liệu ban đầu
        private void InitDataTable()
        {
            dtNhanVien = new DataTable();
            dtNhanVien.Columns.Add("MSNV", typeof(string));
            dtNhanVien.Columns.Add("Tên NV", typeof(string));
            dtNhanVien.Columns.Add("Lương CB", typeof(decimal));

            // Thêm bản ghi mẫu như giao diện
            dtNhanVien.Rows.Add("NV001", "Nguyễn Thị Thu Hiền", 8500000);

            // Gán nguồn dữ liệu cho DataGridView
            gvNhanVien.DataSource = dtNhanVien;
        }

        // Gán sự kiện bằng toán tử +=
        private void AssignEvents()
        {
            btnNut.Click += btnNut_Click;   // Sự kiện nút Thêm
            btnSua.Click += btnSua_Click;   // Sự kiện nút Sửa
            btnXoa.Click += btnXoa_Click;   // Sự kiện nút Xóa
            btnDong.Click += btnDong_Click; // Sự kiện nút Đóng
        }

        // Xử lý sự kiện nút Thêm
        private void btnNut_Click(object sender, EventArgs e)
        {
            frmNhanVien formNV = new frmNhanVien();
            if (formNV.ShowDialog() == DialogResult.OK)
            {
                DataRow dr = dtNhanVien.NewRow();
                dr["MSNV"] = formNV.MSNV;
                dr["Tên NV"] = formNV.TenNV;
                dr["Lương CB"] = formNV.LuongCB;
                dtNhanVien.Rows.Add(dr);
            }
        }

        // Xử lý sự kiện nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.CurrentRow != null && gvNhanVien.CurrentRow.Index >= 0 && gvNhanVien.CurrentRow.Index < dtNhanVien.Rows.Count)
            {
                DataRow dr = ((DataRowView)gvNhanVien.CurrentRow.DataBoundItem).Row;

                frmNhanVien formNV = new frmNhanVien();
                formNV.MSNV = dr["MSNV"].ToString();
                formNV.TenNV = dr["Tên NV"].ToString();
                formNV.LuongCB = Convert.ToDecimal(dr["Lương CB"]);

                if (formNV.ShowDialog() == DialogResult.OK)
                {
                    dr["MSNV"] = formNV.MSNV;
                    dr["Tên NV"] = formNV.TenNV;
                    dr["Lương CB"] = formNV.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xử lý sự kiện nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.CurrentRow != null && gvNhanVien.CurrentRow.Index >= 0 && gvNhanVien.CurrentRow.Index < dtNhanVien.Rows.Count)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRowView drv = (DataRowView)gvNhanVien.CurrentRow.DataBoundItem;
                    drv.Row.Delete();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xử lý sự kiện nút Đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}