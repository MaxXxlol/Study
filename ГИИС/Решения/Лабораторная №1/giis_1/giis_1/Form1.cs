using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giis_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();
            pictureBox1.Image = DrawFilledRectangle(pictureBox1.Width, pictureBox1.Height);
            label4.Text = getHexColor();
        }
        private Bitmap DrawFilledRectangle(int x, int y)
        {
            Bitmap bmp = new Bitmap(x, y);
            using(Graphics gfx = Graphics.FromImage(bmp))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value)))
            {
                gfx.FillRectangle(brush, 0, 0, x, y);
            }
            return bmp;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = hScrollBar2.Value.ToString();
            pictureBox1.Image = DrawFilledRectangle(pictureBox1.Width, pictureBox1.Height);
            label4.Text = getHexColor();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = hScrollBar3.Value.ToString();
            pictureBox1.Image = DrawFilledRectangle(pictureBox1.Width, pictureBox1.Height);
            label4.Text = getHexColor();
        }
        private string getHexColor()
        {
            string red = Convert.ToString(Convert.ToInt32(label1.Text), 16);
            string green = Convert.ToString(Convert.ToInt32(label2.Text), 16);
            string blue = Convert.ToString(Convert.ToInt32(label3.Text), 16);
            return red + green + blue;
        }
    }
}
