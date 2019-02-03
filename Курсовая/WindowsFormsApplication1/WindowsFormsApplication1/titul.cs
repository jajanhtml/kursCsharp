using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class titul : Form
    {
        public titul()
        {
            InitializeComponent();
        }

        private void titul_Load(object sender, EventArgs e)
        {
           
            this.Width = 0;
            this.Height = 0;
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Width = this.Width + 50;
            this.Height = this.Height + 50;
            if ((this.Width == 520) && (this.Height == 550))
            {
                this.timer1.Enabled = false;
            }
            
        }

        private void titul_Paint(object sender, PaintEventArgs e)
        {
            Image newImage = Image.FromFile("1.jpg");
            e.Graphics.DrawImage(newImage, 50, 50, 400, 300);
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
