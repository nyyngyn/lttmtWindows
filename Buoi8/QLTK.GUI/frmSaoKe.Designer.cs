namespace QLTK.GUI
{
    partial class frmSaoKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSTK = new Label();
            cbbSTK = new ComboBox();
            btnXem = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            lblTitle = new Label();
            lblThongBaoSTK = new Label();
            lblTenNH = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblSTK
            // 
            lblSTK.AutoSize = true;
            lblSTK.Location = new Point(88, 17);
            lblSTK.Name = "lblSTK";
            lblSTK.Size = new Size(27, 15);
            lblSTK.TabIndex = 0;
            lblSTK.Text = "STK";
            // 
            // cbbSTK
            // 
            cbbSTK.FormattingEnabled = true;
            cbbSTK.Location = new Point(139, 14);
            cbbSTK.Name = "cbbSTK";
            cbbSTK.Size = new Size(198, 23);
            cbbSTK.TabIndex = 1;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(371, 14);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(75, 23);
            btnXem.TabIndex = 2;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbSTK);
            panel1.Controls.Add(btnXem);
            panel1.Controls.Add(lblSTK);
            panel1.Location = new Point(129, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 48);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(lblThongBaoSTK);
            panel2.Controls.Add(lblTenNH);
            panel2.Location = new Point(65, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(630, 267);
            panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(229, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(248, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 21);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Chi tiết các giao dịch";
            // 
            // lblThongBaoSTK
            // 
            lblThongBaoSTK.AutoSize = true;
            lblThongBaoSTK.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblThongBaoSTK.Location = new Point(248, 81);
            lblThongBaoSTK.Name = "lblThongBaoSTK";
            lblThongBaoSTK.Size = new Size(82, 21);
            lblThongBaoSTK.TabIndex = 1;
            lblThongBaoSTK.Text = "Tài khoản:";
            // 
            // lblTenNH
            // 
            lblTenNH.AutoSize = true;
            lblTenNH.Location = new Point(16, 16);
            lblTenNH.Name = "lblTenNH";
            lblTenNH.Size = new Size(38, 15);
            lblTenNH.TabIndex = 0;
            lblTenNH.Text = "label1";
            // 
            // frmSaoKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmSaoKe";
            Text = "frmSaoKe";
            Load += frmSaoKe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSTK;
        private ComboBox cbbSTK;
        private Button btnXem;
        private Panel panel1;
        private Panel panel2;
        private Label lblTitle;
        private Label lblThongBaoSTK;
        private Label lblTenNH;
        private DataGridView dataGridView1;
    }
}