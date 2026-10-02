using System;
using System.ComponentModel; // Thêm thư viện này để dùng DesignerSerializationVisibility
using System.Windows.Forms;

namespace BTbuoi3
{
    public partial class frmNhanVien : Form
    {
        private Label lblMSNV, lblTenNV, lblLuongCB;
        private TextBox txtMSNV, txtTenNV, txtLuongCB;
        private Button btnDongY;
        private Button btnBoQua;

        // Thêm attribute ẩn thuộc tính khỏi WinForms Designer
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MSNV
        {
            get { return txtMSNV.Text.Trim(); }
            set { txtMSNV.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TenNV
        {
            get { return txtTenNV.Text.Trim(); }
            set { txtTenNV.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal LuongCB
        {
            get
            {
                decimal.TryParse(txtLuongCB.Text.Trim(), out decimal luong);
                return luong;
            }
            set { txtLuongCB.Text = value.ToString(); }
        }

        public frmNhanVien()
        {
            InitializeComponentCustom();
            AssignEvents();
        }

        private void InitializeComponentCustom()
        {
            this.Text = "Nhân viên";
            this.Size = new System.Drawing.Size(360, 200);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Label
            lblMSNV = new Label { Text = "MSNV:", Location = new System.Drawing.Point(20, 20), AutoSize = true };
            lblTenNV = new Label { Text = "Tên nhân viên:", Location = new System.Drawing.Point(20, 50), AutoSize = true };
            lblLuongCB = new Label { Text = "Lương căn bản:", Location = new System.Drawing.Point(20, 80), AutoSize = true };

            // TextBox
            txtMSNV = new TextBox { Location = new System.Drawing.Point(120, 17), Width = 200 };
            txtTenNV = new TextBox { Location = new System.Drawing.Point(120, 47), Width = 200 };
            txtLuongCB = new TextBox { Location = new System.Drawing.Point(120, 77), Width = 200 };

            // Button
            btnDongY = new Button { Name = "btnDongY", Text = "Đồng ý", Location = new System.Drawing.Point(60, 118), Size = new System.Drawing.Size(90, 30) };
            btnBoQua = new Button { Name = "btnBoQua", Text = "Bỏ qua", Location = new System.Drawing.Point(180, 118), Size = new System.Drawing.Size(90, 30) };

            this.Controls.Add(lblMSNV);
            this.Controls.Add(lblTenNV);
            this.Controls.Add(lblLuongCB);
            this.Controls.Add(txtMSNV);
            this.Controls.Add(txtTenNV);
            this.Controls.Add(txtLuongCB);
            this.Controls.Add(btnDongY);
            this.Controls.Add(btnBoQua);
        }

        private void AssignEvents()
        {
            btnDongY.Click += btnDongY_Click;
            btnBoQua.Click += btnBoQua_Click;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}