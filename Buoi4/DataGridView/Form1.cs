namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gvNhanVienC2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadData()
        {
            // Create a DataTable to hold the data
            //DataTable dt = new DataTable();
            // Add columns to the DataTable
            gvNhanVienC2.Columns.Add("Mã NV", "Mã NV");
            gvNhanVienC2.Columns.Add("Tên NV", "Tên NV");
            gvNhanVienC2.Columns.Add("Tuổi", "Tuổi");
            // Add rows to the DataTable
            gvNhanVienC2.Rows.Add(1, "John Doe", 30);
            gvNhanVienC2.Rows.Add(2, "Jane Smith", 25);
            gvNhanVienC2.Rows.Add(3, "Bob Johnson", 40);
            // Bind the DataTable to the DataGridView
            //gvNhanVienC2.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvNhanVienC1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(txtBNhap.Text);
            frm.Show();
        }
    }
}
