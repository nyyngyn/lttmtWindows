namespace Button
{
    partial class listView1
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
            ListViewItem listViewItem2 = new ListViewItem("");
            lvDanhSach = new ListView();
            c = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lblLastName = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtPhone = new TextBox();
            lblFirstName = new Label();
            lblPhone = new Label();
            btnThem = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lvDanhSach
            // 
            lvDanhSach.Columns.AddRange(new ColumnHeader[] { c, columnHeader2, columnHeader3 });
            lvDanhSach.FullRowSelect = true;
            lvDanhSach.GridLines = true;
            lvDanhSach.Items.AddRange(new ListViewItem[] { listViewItem2 });
            lvDanhSach.Location = new Point(1, 1);
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(600, 318);
            lvDanhSach.TabIndex = 0;
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            // 
            // c
            // 
            c.Text = "Last Name";
            c.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First Name";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phone";
            columnHeader3.Width = 200;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(607, 37);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(168, 29);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(607, 57);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(607, 121);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(607, 191);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(607, 103);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(607, 173);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(607, 246);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(607, 275);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(607, 304);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblPhone);
            Controls.Add(lblFirstName);
            Controls.Add(txtPhone);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(lvDanhSach);
            Name = "listView1";
            Text = "frmListView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvDanhSach;
        private ColumnHeader c;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label lblLastName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtPhone;
        private Label lblFirstName;
        private Label lblPhone;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}