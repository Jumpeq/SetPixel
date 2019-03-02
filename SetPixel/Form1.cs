using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetPixel
{
    public partial class Form1 : Form
    {
        Bitmap bitmapArea = new Bitmap(400, 100);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int X = 0; X < 400; X++)
            {
                for (int Y = 49; Y < 50; Y++)
                {
                    bitmapArea.SetPixel(X, Y, Color.Black);
                }
            }

            pictureBox1.Image = bitmapArea;
        }
    }
}
