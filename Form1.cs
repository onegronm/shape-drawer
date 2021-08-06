using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace shape_drawer
{
    // patterns:

    // bridge pattern for the draw api
    // https://www.tutorialspoint.com/design_pattern/bridge_pattern.htm

    // decorator for shape color
    // https://www.tutorialspoint.com/design_pattern/decorator_pattern.htm

    public partial class Form1 : Form
    {
        int x, y;

        List<Point> trianglePoints = new List<Point>();

        IDrawAPI api;

        public Form1()
        {
            InitializeComponent();
            api = new DrawAPI(this.CreateGraphics());
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            IShape shape;

            int h = e.X - x;
            int w = e.Y - y;

            if (SquareRadioButton.Checked)
            {                
                shape = new Rectangle(x, y, h, w, api);
                shape.draw();
            }
            else if (CircleRadioButton.Checked)
            {
                shape = new Circle(x, y, h, w, api);
                shape.draw();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (TriangleRadioButton.Checked)
            {
                if (trianglePoints.Count == 2)
                {
                    Point p = new Point(e.X, e.Y);
                    trianglePoints.Add(p);

                    IShape triangle = new Triangle(api, trianglePoints);
                    triangle.draw();

                    trianglePoints.Clear();
                }
                else
                {
                    Point p = new Point(e.X, e.Y);
                    trianglePoints.Add(p);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnPenColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnPenColor.BackColor = colorDialog1.Color;
        }
    }
}
