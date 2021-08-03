using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shape_drawer
{
    public partial class Form1 : Form
    {
        // patterns
        // factory for shape creation
        // https://www.tutorialspoint.com/design_pattern/factory_pattern.htm

        // bridge pattern for the draw api
        // https://www.tutorialspoint.com/design_pattern/bridge_pattern.htm

        // decorator for shape color
        // https://www.tutorialspoint.com/design_pattern/decorator_pattern.htm

        // store multiple shapes

        // clarify the requirements with a mock UI

        int x, y, height, width;
        ShapeSimpleFactory factory;
        // Pen pen = new Pen(Color.Red, 3);
        
        // only one triangle can be drawn at a time
        // temp list to keep track of added points
        List<Point> trianglePoints = new List<Point>();

        public Form1()
        {
            InitializeComponent();
            factory = new ShapeSimpleFactory();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // height = e.X - x;
            // width = e.Y - y;
            if (SquareRadioButton.Checked)
            {
                var shape = factory.GetShape("rectangle");
                shape.draw();
            }
            else if (CircleRadioButton.Checked)
            {
                var shape = factory.GetShape("circle");
                shape.draw();
                //g.DrawRectangle(pen, shape);
            }

            //Graphics g = this.CreateGraphics();
            //Rectangle shape = new Rectangle(x, y, height, width);


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (TriangleRadioButton.Checked)
            {
                if (trianglePoints.Count == 2)
                {
                    Point p = new Point(e.X, e.Y);
                    trianglePoints.Add(p);

                    Triangle triangle = factory.GetShape("triangle");
                    //Graphics g = this.CreateGraphics();
                    //SolidBrush brush = new SolidBrush(colorDialog1.Color);
                    //g.FillPolygon(brush, trianglePoints.ToArray());

                    trianglePoints.Clear();
                }
                else
                {
                    Point p = new Point(e.X, e.Y);
                    trianglePoints.Add(p);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button1.BackColor = colorDialog1.Color;
            //pen.Color = colorDialog1.Color;
        }
    }
}
