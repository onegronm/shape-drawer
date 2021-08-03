using System;
using System.Collections.Generic;
using System.Text;

namespace shape_drawer
{
    public class ShapeSimpleFactory
    {
        public IShape GetShape(string shapeType)
        {
            switch(shapeType.ToLower())
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectangle();
                case "triangle":
                    return new Triangle();
                default:
                    throw new ArgumentException("Shape type not valid");
            }
        }
    }
}
