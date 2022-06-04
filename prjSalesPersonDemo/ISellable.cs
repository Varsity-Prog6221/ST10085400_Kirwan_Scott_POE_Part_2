using System;
using System.Collections.Generic;
using System.Text;

namespace prjSalesPersonDemo
{
    interface ISellable
    {
        public double MakeSale(int value);

        public string SalesSpeech();
        
    }
}
