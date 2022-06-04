using System;
using System.Collections.Generic;
using System.Text;

namespace prjExrcise14
{
    class Square : Rectangle
    {
        public Square(double width, double height): base(width,height)
        {
            if (width != height)
            {
                if (width > height) 
                { 
                    Width = width;
                    Height = width;
                }
                else
                {
                    Width = height;
                    Height = width;
                }
            }
            else
            {
                Width = width;
                Height = height;
            }
            
        }
        public Square(double sidelenth) : base(sidelenth, sidelenth)
        {
            
        }
        


    }


}

