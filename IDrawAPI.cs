using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace shape_drawer
{
    /// <summary>
    /// This interface acts as a bridge to decouple draw api implementation from shape class
    /// </summary>
    public interface IDrawAPI
    {
        void drawCircle(int x, int y, int h, int w);
        void drawSquare(int x, int y, int h, int w);
        void drawTriangle(List<Point> points);
    }
}
