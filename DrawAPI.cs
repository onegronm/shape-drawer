using System.Collections.Generic;
using System.Drawing;

namespace shape_drawer
{
    internal class DrawAPI : IDrawAPI
    {
        Graphics graphics;
        Pen p;

        public DrawAPI(Graphics g)
        {
            graphics = g;
            p = new Pen(Color.Red, 3);
        }

        public void drawCircle(int x, int y, int h, int w)
        {
            System.Drawing.Rectangle shape = new System.Drawing.Rectangle(x, y, h, w);
            graphics.DrawEllipse(p, shape);
        }

        public void drawSquare(int x, int y, int h, int w)
        {
            System.Drawing.Rectangle shape = new System.Drawing.Rectangle(x, y, h, w);
            graphics.DrawRectangle(p, shape);
        }

        public void drawTriangle(List<Point> points)
        {
            SolidBrush brush = new SolidBrush(p.Color);
            graphics.FillPolygon(brush, points.ToArray());
        }
    }
}