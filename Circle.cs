using System;
using System.Collections.Generic;
using System.Text;

namespace shape_drawer
{
    public class Circle : IShape
    {
        int x, y, h, w;

        IDrawAPI drawApi;

        public Circle(int x, int y, int h, int w, IDrawAPI drawApi)
        {
            this.drawApi = drawApi;
            this.x = x;
            this.y = y;
            this.h = h;
            this.w = w;
        }

        public void draw()
        {
            drawApi.drawCircle(x, y, h, w);
        }
    }
}
