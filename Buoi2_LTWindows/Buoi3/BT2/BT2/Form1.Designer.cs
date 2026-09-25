using System.Drawing.Printing;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace hoc
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblHoTen = new Label();
            grpThongTin = new GroupBox();
            lblHo = new Label();
            txtHo = new TextBox();
            lblTen = new Label();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.FromArgb(0, 120, 215);
            lblHoTen.BorderStyle = BorderStyle.FixedSingle;
            lblHoTen.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHoTen.ForeColor = Color.White;
            lblHoTen.Location = new Point(23, 27);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(434, 73);
            lblHoTen.TabIndex = 0;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblHo);
            grpThongTin.Controls.Add(txtHo);
            grpThongTin.Controls.Add(lblTen);
            grpThongTin.Controls.Add(txtTen);
            grpThongTin.Font = new Font("Segoe UI", 10F);
            grpThongTin.Location = new Point(23, 117);
            grpThongTin.Margin = new Padding(3, 4, 3, 4);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(3, 4, 3, 4);
            grpThongTin.Size = new Size(434, 140);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin";
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new Point(17, 44);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(61, 23);
            lblHo.TabIndex = 0;
            lblHo.Text = "Họ lót:";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(97, 40);
            txtHo.Margin = new Padding(3, 4, 3, 4);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(314, 30);
            txtHo.TabIndex = 1;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(17, 91);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(40, 23);
            lblTen.TabIndex = 2;
            lblTen.Text = "Tên:";
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.HotPink;
            txtTen.Location = new Point(97, 87);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(314, 30);
            txtTen.TabIndex = 3;
            // 
            // btnHo
            // 
            btnHo.BackColor = Color.White;
            btnHo.FlatAppearance.BorderColor = Color.Black;
            btnHo.FlatStyle = FlatStyle.Flat;
            btnHo.Font = new Font("Segoe UI", 10F);
            btnHo.ForeColor = Color.Black;
            btnHo.Location = new Point(23, 277);
            btnHo.Margin = new Padding(3, 4, 3, 4);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(137, 48);
            btnHo.TabIndex = 2;
            btnHo.Text = "&Họ Lót";
            btnHo.UseVisualStyleBackColor = false;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.BackColor = Color.White;
            btnTen.FlatAppearance.BorderColor = Color.Black;
            btnTen.FlatStyle = FlatStyle.Flat;
            btnTen.Font = new Font("Segoe UI", 10F);
            btnTen.ForeColor = Color.Black;
            btnTen.Location = new Point(171, 277);
            btnTen.Margin = new Padding(3, 4, 3, 4);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(137, 48);
            btnTen.TabIndex = 3;
            btnTen.Text = "&Tên";
            btnTen.UseVisualStyleBackColor = false;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.BackColor = Color.White;
            btnHoTen.FlatAppearance.BorderColor = Color.Black;
            btnHoTen.FlatStyle = FlatStyle.Flat;
            btnHoTen.Font = new Font("Segoe UI", 10F);
            btnHoTen.ForeColor = Color.Black;
            btnHoTen.Location = new Point(320, 277);
            btnHoTen.Margin = new Padding(3, 4, 3, 4);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(137, 48);
            btnHoTen.TabIndex = 3;
            btnHoTen.Text = "Họ &và Tên";
            btnHoTen.UseVisualStyleBackColor = false;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.BackColor = Color.White;
            btnKetThuc.FlatAppearance.BorderColor = Color.Black;
            btnKetThuc.FlatStyle = FlatStyle.Flat;
            btnKetThuc.Font = new Font("Segoe UI", 10F);
            btnKetThuc.ForeColor = Color.Black;
            btnKetThuc.Location = new Point(139, 355);
            btnKetThuc.Margin = new Padding(3, 4, 3, 4);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(186, 48);
            btnKetThuc.TabIndex = 5;
            btnKetThuc.Text = "Thoát chương trình";
            btnKetThuc.UseVisualStyleBackColor = false;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(480, 416);
            Controls.Add(lblHoTen);
            Controls.Add(grpThongTin);
            Controls.Add(btnHo);
            Controls.Add(btnTen);
            Controls.Add(btnHoTen);
            Controls.Add(btnKetThuc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài Tập Họ Tên";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnKetThuc;
    }
}