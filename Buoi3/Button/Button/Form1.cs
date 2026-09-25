namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHo_Click(object sender, EventArgs e)
        {

        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHo.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblTen.Text = txtTen.Text;
        }

        

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }
        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void lblHoTen_DoubleClick_1(object sender, EventArgs e)
        {
            lblHoTen.Text = string.Empty;
        }
    }
}
