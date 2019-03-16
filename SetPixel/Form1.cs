using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetPixel
{
    public partial class Form1 : Form
    {
        Point initialDDA, finalDDA, initialB, finalB;
        Bitmap bmpDDA;
        Bitmap bmpBresenham;
        public Form1()
        {
            initialDDA = new Point(-1, -1);
            finalDDA = new Point(-1, -1);
            bmpDDA = new Bitmap(500, 500);
            initialB = new Point(-1, -1);
            finalB = new Point(-1, -1);
            bmpBresenham = new Bitmap(500, 500);
            InitializeComponent();
            SetCartesianDDA();
            SetCartesianBresenham();
        }
        private void SetCartesianDDA()
        {
            //ustawia osie dla DDA
            Point from = new Point();
            from.X = 250;
            from.Y = 0;
            Point to = new Point();
            to.X = 250;
            to.Y = 499;
            DDA(from, to, Color.Black);
            from.X = 0;
            from.Y = 250;
            to.X = 499;
            to.Y = 250;
            DDA(from, to, Color.Black);
        }
        private void SetCartesianBresenham()
        {
            //ustawia osie dla Bresenham
            Point from = new Point();
            from.X = 250;
            from.Y = 0;
            Point to = new Point();
            to.X = 250;
            to.Y = 499;
            Bresenham(to, from, Color.Black);
            from.X = 0;
            from.Y = 250;
            to.X = 499;
            to.Y = 250;
            Bresenham(from, to, Color.Black);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Czyści obszar algorytmu DDA
            initialDDA.X = initialDDA.Y = -1;
            finalDDA.X = finalDDA.Y = -1;

            Graphics g = Graphics.FromImage(bmpDDA);
            g.FillRectangle(Brushes.Wheat, 0, 0, 500, 500);
            pictureBox1.Image = bmpDDA;
            SetCartesianDDA();
        }
        private void DDA(Point initialDDA, Point finalDDA, Color color)
        {
            int X0 = initialDDA.X;
            int Y0 = initialDDA.Y;
            int X1 = finalDDA.X;
            int Y1 = finalDDA.Y;
            int dx = X1 - X0;
            int dy = Y1 - Y0;
            int steps = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);
            float Xinc = dx / (float)steps;
            float Yinc = dy / (float)steps;
            float X = X0;
            float Y = Y0;
            for (int i = 0; i <= steps; i++)
            {
                bmpDDA.SetPixel(Convert.ToInt32(X), Convert.ToInt32(Y), color);
                X += Xinc;
                Y += Yinc;
            }
            pictureBox1.Image = bmpDDA;
        }
        private void Bresenham(Point initialB, Point finalB, Color color)
        {
            int d, dx, dy, ai, bi, xi, yi;
            int x1 = initialB.X;
            int y1 = initialB.Y;
            int x2 = finalB.X;
            int y2 = finalB.Y;
            int x = x1, y = y1;
            if (x1 < x2)
            {
                xi = 1;
                dx = x2 - x1;
            }
            else
            {
                xi = -1;
                dx = x1 - x2;
            }
            if (y1 < y2)
            {
                yi = 1;
                dy = y1 - y2;
            }
            else
            {
                yi = -1;
                dy = y1 - y2;
            }
            bmpBresenham.SetPixel(x, y, color);
            if (dx > dy)
            {
                ai = (dy - dx) * 2;
                bi = dy * 2;
                d = bi - dx;
                while (x != x2)
                {
                    if (d >= 0)
                    {
                        x += xi;
                        y += yi;
                        d += ai;
                    }
                    else
                    {
                        d += bi;
                        x += xi;
                    }
                    bmpBresenham.SetPixel(x, y, color);
                }
            }
            else
            {
                ai = (dx - dy) * 2;
                bi = dx * 2;
                d = bi - dy;
                while (y != y2)
                {
                    if (d >= 0)
                    {
                        x += xi;
                        y += yi;
                        d += ai;
                    }
                    else
                    {
                        d += bi;
                        y += yi;
                    }
                    bmpBresenham.SetPixel(x, y, color);
                }
            }
            pictureBoxBresenham.Image = bmpBresenham;
        }
        private List<Point> SetCoordinate(int x1, int y1, int x2, int y2)
        {
            if (x1 > 0 && y1 > 0)
            {
                x1 = 250 + Math.Abs(x1);
                y1 = 250 - Math.Abs(y1);
            }
            else if (x1 < 0 && y1 > 0)
            {
                x1 = 250 - Math.Abs(x1);
                y1 = 250 - Math.Abs(y1);
            }
            else if (x1 > 0 && y1 < 0)
            {
                x1 = 250 + Math.Abs(x1);
                y1 = 250 + Math.Abs(y1);
            }
            else if (x1 < 0 && y1 < 0)
            {
                x1 = 250 - Math.Abs(x1);
                y1 = 250 + Math.Abs(y1);
            }
            if (x2 > 0 && y2 > 0)
            {
                x2 = 250 + Math.Abs(x2);
                y2 = 250 - Math.Abs(y2);
            }
            else if (x2 < 0 && y2 > 0)
            {
                x2 = 250 - Math.Abs(x2);
                y2 = 250 - Math.Abs(y2);
            }
            else if (x2 > 0 && y2 < 0)
            {
                x2 = 250 + Math.Abs(x2);
                y2 = 250 + Math.Abs(y2);
            }
            else if (x2 < 0 && y2 < 0)
            {
                x2 = 250 - Math.Abs(x2);
                y2 = 250 + Math.Abs(y2);
            }

            if (x1 == 0)
            {
                x1 = 250;
            }
            if (y1 == 0)
            {
                y1 = 250;
            }
            if (x2 == 0)
            {
                x2 = 250;
            }
            if (y2 == 0)
            {
                y2 = 250;
            }
            Point from = new Point();
            from.X = x1;
            from.Y = y1;
            Point to = new Point();
            to.X = x2;
            to.Y = y2;
            List<Point> points = new List<Point>();
            points.Add(from);
            points.Add(to);
            return points;
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text != "" || textBoxY2.Text != "" || textBoxX2.Text != "" || textBoxY2.Text != "")
            {
                Regex regex = new Regex("[0-9]");
                if (regex.IsMatch(textBoxX1.Text) &&
                    regex.IsMatch(textBoxY1.Text) &&
                    regex.IsMatch(textBoxX2.Text) &&
                    regex.IsMatch(textBoxY2.Text) &&
                    !String.IsNullOrEmpty(textBoxX1.Text) &&
                    !String.IsNullOrEmpty(textBoxY1.Text) &&
                    !String.IsNullOrEmpty(textBoxX2.Text) &&
                    !String.IsNullOrEmpty(textBoxY2.Text))
                {

                    int x1 = Convert.ToInt32(textBoxX1.Text);
                    int y1 = Convert.ToInt32(textBoxY1.Text);
                    int x2 = Convert.ToInt32(textBoxX2.Text);
                    int y2 = Convert.ToInt32(textBoxY2.Text);
                    if (Math.Abs(x1) >= 250 || Math.Abs(y1) >= 250 || Math.Abs(x2) >= 250 || Math.Abs(y2) >= 250)
                    {
                        MessageBox.Show("Wprowadzono wartości przekraczające obszar rysowania, proszę wprowadź wartości mniejsze niż 250!");
                    }
                    else
                    {
                        List<Point> points = new List<Point>();
                        points = SetCoordinate(x1, y1, x2, y2);
                        DDA(points[0], points[1], Color.Blue);
                    }
                }
                else
                {
                    MessageBox.Show("Proszę podaj wartość inną niż pustą lub inną niż literkę/znak specjalny!");
                }
            }
        }
        private void DrawBresenham_Click(object sender, EventArgs e)
        {
            if (textBoxX1B.Text != "" || textBoxY2B.Text != "" || textBoxX2B.Text != "" || textBoxY2B.Text != "")
            {
                Regex regex = new Regex("[0-9]");
                if (regex.IsMatch(textBoxX1B.Text) &&
                    regex.IsMatch(textBoxY1B.Text) &&
                    regex.IsMatch(textBoxX2B.Text) &&
                    regex.IsMatch(textBoxY2B.Text) &&
                    !String.IsNullOrEmpty(textBoxX1B.Text) &&
                    !String.IsNullOrEmpty(textBoxY1B.Text) &&
                    !String.IsNullOrEmpty(textBoxX2B.Text) &&
                    !String.IsNullOrEmpty(textBoxY2B.Text))
                {

                    int x1 = Convert.ToInt32(textBoxX1B.Text);
                    int y1 = Convert.ToInt32(textBoxY1B.Text);
                    int x2 = Convert.ToInt32(textBoxX2B.Text);
                    int y2 = Convert.ToInt32(textBoxY2B.Text);
                    if (Math.Abs(x1) >= 250 || Math.Abs(y1) >= 250 || Math.Abs(x2) >= 250 || Math.Abs(y2) >= 250)
                    {
                        MessageBox.Show("Wprowadzono wartości przekraczające obszar rysowania, proszę wprowadź wartości mniejsze niż 250!");
                    }
                    else
                    {
                        List<Point> points = new List<Point>();
                        points = SetCoordinate(x1, y1, x2, y2);
                        if (points[1].Y >= points[0].Y)
                        {
                            Bresenham(points[1], points[0], Color.Blue);
                        }
                        else
                        {
                            Bresenham(points[0], points[1], Color.Blue);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Proszę podaj wartość inną niż pustą lub inną niż literkę/znak specjalny!");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Czyści obszar algorytmu Bresenham
            initialB.X = initialB.Y = -1;
            finalB.X = finalB.Y = -1;

            Graphics g = Graphics.FromImage(bmpBresenham);
            g.FillRectangle(Brushes.Wheat, 0, 0, 500, 500);
            pictureBoxBresenham.Image = bmpBresenham;
            SetCartesianBresenham();
        }
        private void pictureBoxBresenham_MouseClick(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 3);

            if (initialB.X == -1)
            {
                initialB.X = e.X;
                initialB.Y = e.Y;
                pictureBoxBresenham.CreateGraphics().DrawEllipse(pen, initialB.X, initialB.Y, 3, 3);
            }
            else
            {
                finalB.X = e.X;
                finalB.Y = e.Y;
                pictureBoxBresenham.CreateGraphics().DrawEllipse(pen, finalB.X, finalB.Y, 3, 3);

                if (finalB.Y >= initialB.Y)
                {
                    Bresenham(finalB, initialB, Color.Blue);
                }
                else
                {
                    Bresenham(initialB, finalB, Color.Blue);
                }
                initialB.X = initialB.Y = -1;
                finalB.X = finalB.Y = -1;
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 3);

            if (initialDDA.X == -1)
            {
                initialDDA.X = e.X;
                initialDDA.Y = e.Y;
                pictureBox1.CreateGraphics().DrawEllipse(pen, initialDDA.X, initialDDA.Y, 3, 3);
            }
            else
            {
                finalDDA.X = e.X;
                finalDDA.Y = e.Y;
                pictureBox1.CreateGraphics().DrawEllipse(pen, finalDDA.X, finalDDA.Y, 3, 3);

                DDA(initialDDA, finalDDA, Color.Blue);
                initialDDA.X = initialDDA.Y = -1;
                finalDDA.X = finalDDA.Y = -1;
            }
        }
    }
}