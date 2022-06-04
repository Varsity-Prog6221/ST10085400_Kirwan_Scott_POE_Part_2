using System;
using System.Collections.Generic;
using System.Text;

namespace prjExrcise14
{
    abstract class GemoetricFigure
    {
        double height;
        double width; 
        protected double area;

        
        
        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }
        public double Area { get => area; set => area = value; }

        public abstract double ComputerArea();
        

    }
}
