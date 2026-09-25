namespace Button
{
    partial class Form1
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
            lblHo = new Label();
            lblTen = new Label();
            lblHoTen = new Label();
            btnHo = new System.Windows.Forms.Button();
            btnTen = new System.Windows.Forms.Button();
            btnHoTen = new System.Windows.Forms.Button();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnThoat = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblHo
            // 
            lblHo.Location = new Point(244, 123);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(23, 15);
            lblHo.TabIndex = 0;
            lblHo.Text = "Họ";
            lblHo.Click += lblHo_Click;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(241, 169);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(26, 15);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";
            lblTen.Click += lblTen_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.ActiveCaption;
            lblHoTen.Location = new Point(3, 9);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(794, 100);
            lblHoTen.TabIndex = 2;
            lblHoTen.Click += lblHoTen_Click;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick_1;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(166, 229);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(75, 23);
            btnHo.TabIndex = 3;
            btnHo.Text = "Họ";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(304, 233);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(75, 23);
            btnTen.TabIndex = 4;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(491, 235);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(75, 23);
            btnHoTen.TabIndex = 5;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(340, 115);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(100, 23);
            txtHo.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(340, 166);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(100, 23);
            txtTen.TabIndex = 7;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(304, 292);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(139, 37);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát chương trình";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(lblHoTen);
            Controls.Add(lblTen);
            Controls.Add(lblHo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHo;
        private Label lblTen;
        private Label lblHoTen;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private System.Windows.Forms.Button btnThoat;
    }
}
