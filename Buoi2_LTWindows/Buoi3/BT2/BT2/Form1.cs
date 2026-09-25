using System;
using System.Windows.Forms;

namespace hoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nhấn btnHo -> gán nội dung txtHo cho lblHoTen
        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        // Nhấn btnTen -> gán nội dung txtTen cho lblHoTen
        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        // Nhấn btnHoTen -> gán txtHo + " " + txtTen cho lblHoTen
        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        // Double click vào lblHoTen -> xoá nội dung
        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = string.Empty;
        }

        // Nhấn btnKetThuc -> hỏi xác nhận, Yes thì thoát, No thì ở lại
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}