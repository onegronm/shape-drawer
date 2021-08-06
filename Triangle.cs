using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace shape_drawer
{
    public class Triangle : IShape
    {
        IDrawAPI drawApi;

        List<Point> points;

        public Triangle(IDrawAPI drawApi, List<Point> points)
        {
            this.drawApi = drawApi;
            this.points = points;
        }

        public void draw()
        {
            this.drawApi.drawTriangle(points);
        }
    }
}
