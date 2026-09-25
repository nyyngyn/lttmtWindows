namespace Form1
{
    partial class frmĐangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            SuspendLayout();
            // 
            // btnHo
            // 
            btnHo.Location = new Point(295, 187);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(112, 69);
            btnHo.TabIndex = 0;
            btnHo.Text = "Họ";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += button1_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(89, 187);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(112, 69);
            btnTen.TabIndex = 1;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(508, 187);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(112, 69);
            btnHoTen.TabIndex = 2;
            btnHoTen.Text = "Họ Và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(295, 296);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(152, 58);
            btnKetThuc.TabIndex = 3;
            btnKetThuc.Text = "Thoát Chương Trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // frmĐangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Name = "frmĐangKy";
            Text = "Đây là form Đăng Ký";
            FormClosing += frmĐangKy_FormClosing;
            Click += frmĐangKy_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
    }
}
