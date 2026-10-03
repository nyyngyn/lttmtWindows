using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace BTTuan5
{
    public partial class Form1 : Form
    {
        // Biến lưu đường dẫn của tập tin đang mở hoặc lưu
        private string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();
            // Cho phép Form nhận sự kiện bàn phím (Ctrl+N, Ctrl+S) trước khi chuyển tới control con
            this.KeyPreview = true;
        }

        // 2.1 Mở Form: Khởi tạo danh sách Font và Size
        private void Form1_Load(object sender, EventArgs e)
        {
            // Tải danh sách Font
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }

            // Tải danh sách Kích thước
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
            {
                toolStripComboBox2.Items.Add(size.ToString());
            }

            // Giá trị mặc định: Font Tahoma, Size 14
            TaoVanBanMoi();
        }

        #region 2.2 Tạo văn bản mới
        private void TaoVanBanMoi()
        {
            richTextBox1.Clear();
            currentFilePath = "";

            toolStripComboBox1.SelectedItem = "Tahoma";
            toolStripComboBox2.SelectedItem = "14";

            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoVanBanMoi();
        }

        // Click vào nút Icon Paper (Tạo mới)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TaoVanBanMoi();
        }
        #endregion

        #region 2.3 Mở tập tin
        private void MoTapTin()
        {
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                openDlg.Filter = "Tập tin văn bản (*.rtf;*.txt)|*.rtf;*.txt|Rich Text Format (*.rtf)|*.rtf|Text File (*.txt)|*.txt";
                openDlg.Title = "Mở tập tin văn bản";

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentFilePath = openDlg.FileName;
                        if (Path.GetExtension(currentFilePath).ToLower() == ".rtf")
                        {
                            richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.PlainText);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoTapTin();
        }
        #endregion

        #region 2.4 Lưu nội dung văn bản
        private void LuuTapTin()
        {
            // Nếu là văn bản mới chưa lưu lần nào
            if (string.IsNullOrEmpty(currentFilePath))
            {
                using (SaveFileDialog saveDlg = new SaveFileDialog())
                {
                    saveDlg.Filter = "Rich Text Format (*.rtf)|*.rtf";
                    saveDlg.DefaultExt = "rtf";
                    saveDlg.Title = "Lưu văn bản";

                    if (saveDlg.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            currentFilePath = saveDlg.FileName;
                            richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                            MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            // Nếu là văn bản đã được mở hoặc lưu trước đó
            else
            {
                try
                {
                    if (Path.GetExtension(currentFilePath).ToLower() == ".txt")
                    {
                        richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    }
                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuuTapTin();
        }

        // Click vào nút Icon Save (Đĩa mềm)
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LuuTapTin();
        }
        #endregion

        #region 2.5 Định dạng B, I, U
        private void ChangeFontStyle(FontStyle style)
        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            FontStyle newStyle;

            // Kiểm tra trạng thái thuộc tính để bật/tắt
            if (currentFont.Style.HasFlag(style))
            {
                newStyle = currentFont.Style & ~style; // Tắt kiểu
            }
            else
            {
                newStyle = currentFont.Style | style;  // Bật kiểu
            }

            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
            else
            {
                richTextBox1.Font = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        // Nút In đậm (B)
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Bold);
        }

        // Nút In nghiêng (I)
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic);
        }

        // Nút Gạch dưới (U)
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline);
        }
        #endregion

        #region Thay đổi Font và Size từ ComboBox
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem == null) return;
            string fontName = toolStripComboBox1.SelectedItem.ToString();

            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            Font newFont = new Font(fontName, currentFont.Size, currentFont.Style);

            if (richTextBox1.SelectionLength > 0)
                richTextBox1.SelectionFont = newFont;
            else
                richTextBox1.Font = newFont;
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox2.SelectedItem == null) return;
            if (float.TryParse(toolStripComboBox2.SelectedItem.ToString(), out float fontSize))
            {
                Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
                Font newFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);

                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.SelectionFont = newFont;
                else
                    richTextBox1.Font = newFont;
            }
        }
        #endregion

        #region Xử lý Phím tắt (Ctrl+N, Ctrl+S)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                TaoVanBanMoi();
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                LuuTapTin();
                e.Handled = true;
            }
        }
        #endregion

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontDlg.Color;
                richTextBox1.Font = fontDlg.Font;
            }
        }
    }
}