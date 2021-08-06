using System;
using System.Collections.Generic;
using System.Text;

namespace shape_drawer
{
    public class Rectangle : IShape
    {
        int x, y, h, w;

        IDrawAPI drawApi;

        public Rectangle(int x, int y, int h, int w, IDrawAPI drawApi)
        {
            this.drawApi = drawApi;
            this.x = x;
            this.y = y;
            this.h = h;
            this.w = w;
        }

        public void draw()
        {
            drawApi.drawSquare(x, y, h, w);
        }
    }
}
