namespace CaroGames
{
    partial class GameStart
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
            pnlChessBoard = new Panel();
            panel2 = new Panel();
            pctbAvatar = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            txtTime = new TextBox();
            txtNamePlayer = new TextBox();
            panel4 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Location = new Point(0, 0);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(602, 452);
            pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pctbAvatar);
            panel2.Location = new Point(608, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 180);
            panel2.TabIndex = 1;
            // 
            // pctbAvatar
            // 
            pctbAvatar.Location = new Point(0, 0);
            pctbAvatar.Name = "pctbAvatar";
            pctbAvatar.Size = new Size(177, 180);
            pctbAvatar.TabIndex = 0;
            pctbAvatar.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(txtTime);
            panel3.Controls.Add(txtNamePlayer);
            panel3.Location = new Point(608, 186);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 180);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(107, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 81);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(3, 32);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(100, 23);
            txtTime.TabIndex = 1;
            // 
            // txtNamePlayer
            // 
            txtNamePlayer.Location = new Point(3, 3);
            txtNamePlayer.Name = "txtNamePlayer";
            txtNamePlayer.Size = new Size(98, 23);
            txtNamePlayer.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Location = new Point(608, 372);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 80);
            panel4.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(3, 90);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 116);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 5;
            label1.Text = "5 IN A LINE TO WIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlChessBoard);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChessBoard;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pctbAvatar;
        private PictureBox pictureBox1;
        private TextBox txtTime;
        private TextBox txtNamePlayer;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}
