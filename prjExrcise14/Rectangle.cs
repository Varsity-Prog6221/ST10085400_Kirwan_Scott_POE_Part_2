using System;
using System.Collections.Generic;
using System.Text;

namespace prjExrcise14
{

    class Rectangle : GemoetricFigure
    {
        public Rectangle(double width, double height)
        {
            Height = height;
            Width = width;
        }
        
        public override double ComputerArea()
        {
            area = Width * Height;
            return area;
        }
    }
}
