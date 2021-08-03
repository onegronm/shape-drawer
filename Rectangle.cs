using System;
using System.Collections.Generic;
using System.Text;

namespace shape_drawer
{
    public class Rectangle : IShape
    {
        IDrawAPI drawApi;

        public Rectangle(IDrawAPI drawApi)
        {
            this.drawApi = drawApi;
        }

        public void draw()
        {
            drawApi.drawShape();
        }
    }
}
