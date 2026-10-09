namespace EFC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //await TaiDanhSach();
        }
        private async Task TaiDanhSach()
        {
            try
            {
                using var context = new AppDbContext();
                List<Student> danhSach = await context.LayDanhSachSinhVienAsync();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhSach;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btn1_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }
    }
}
