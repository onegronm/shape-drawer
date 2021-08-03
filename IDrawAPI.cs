using System;
using System.Collections.Generic;
using System.Text;

namespace shape_drawer
{
    /// <summary>
    /// This interface acts as a bridge to decouple draw api implementation from shape class
    /// </summary>
    public interface IDrawAPI
    {
        void drawShape();
    }
}
