using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form2 : Form
    {
        public Form2(string imageFile)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Vinh\\source\\repos\\image.jpg");
            Text = imageFile.Substring(imageFile.LastIndexOf("\\") + 1);
        }
        public Form2()
        {
            InitializeComponent();
            
            //Text = imageFile.Substring(imageFile.LastIndexOf("\\") + 1);
        }

    }
}
