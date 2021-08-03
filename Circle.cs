using System;
using System.Collections.Generic;
using System.Text;

namespace shape_drawer
{
    public class Circle : IShape
    {
        IDrawAPI drawApi;

        public Circle(IDrawAPI drawApi)
        {
            this.drawApi = drawApi;
        }

        public void draw()
        {
            drawApi.drawShape();
        }
    }
}
