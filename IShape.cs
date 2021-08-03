using System;
using System.Collections.Generic;
using System.Text;

namespace shape_drawer
{
    /// <summary>
    /// The Shape interface favoring composition over inheritance
    /// </summary>
    public interface IShape
    {
        void draw();
    }
}