using System;
using System.Collections.Generic;
using System.Text;

namespace shape_drawer
{
    public class Triangle : IShape
    {
        IDrawAPI drawApi;

        public Triangle(IDrawAPI drawApi)
        {
            this.drawApi = drawApi;
        }

        public void draw()
        {
            drawApi.drawShape();
        }
    }
}
