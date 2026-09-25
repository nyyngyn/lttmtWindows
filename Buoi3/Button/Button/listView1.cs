using System;
using System.Windows.Forms;

namespace Button
{
    public partial class listView1 : Form
    {
        public listView1()
        {
            InitializeComponent();
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        // THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" ||
                txtFirstName.Text == "" ||
                txtPhone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ListViewItem item = new ListViewItem(txtLastName.Text);

            item.SubItems.Add(txtFirstName.Text);
            item.SubItems.Add(txtPhone.Text);

            lvDanhSach.Items.Add(item);

            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();

            txtLastName.Focus();
        }

        // CHỌN DÒNG
        private void lvDanhSach_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSach.SelectedItems[0];

                txtLastName.Text = item.SubItems[0].Text;
                txtFirstName.Text = item.SubItems[1].Text;
                txtPhone.Text = item.SubItems[2].Text;
            }
        }

        // SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (txtLastName.Text == "" ||
                txtFirstName.Text == "" ||
                txtPhone.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            ListViewItem item = lvDanhSach.SelectedItems[0];

            item.Text = txtLastName.Text.Trim();
            item.SubItems[1].Text = txtFirstName.Text.Trim();
            item.SubItems[2].Text = txtPhone.Text.Trim();

            // Xóa nội dung TextBoxSS
            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();

            txtLastName.Focus();

            MessageBox.Show("Sửa thành công!");
        }

        // XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lvDanhSach.Items.Remove(lvDanhSach.SelectedItems[0]);

                // Xóa nội dung TextBox
                txtLastName.Clear();
                txtFirstName.Clear();
                txtPhone.Clear();
            }
        }
    }
}