using System.Diagnostics;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 FormCon = new Form2();
            FormCon.MdiParent = this;
            FormCon.Show();
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                Form2 FormCon = new Form2(oFile.FileName);
                FormCon.MdiParent = this;
                FormCon.Show();
            }

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizonableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "iexplore.exe";
            psi.Arguments = "https://www.hutech.edu.vn";
            Process.Start(psi);
        }
    }
}
