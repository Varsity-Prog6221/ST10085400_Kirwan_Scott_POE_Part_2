using System;
using System.Collections.Generic;
using System.Text;

namespace prjExrcise14
{
    class Triangle : GemoetricFigure
    {
        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double ComputerArea()
        {
            area = 0.5 * Width * Height;

            return area;
        }
    }
}
