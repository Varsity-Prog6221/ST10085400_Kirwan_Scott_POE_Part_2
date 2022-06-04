using System;
using System.Collections.Generic;
using System.Text;

namespace ST10085400_ICE_Task_1
{
    class Item : Cart
    {
        private string Items;
        
        
        public Items(string Items)
        {
            this.Items = Items;
        }



        public double Total(double Total)
        {
             
            Total = itemPrice + vat;
            return Total;
        }



        public override string ToString()
        {
            return  "{$} R{0} ",Items, Total;
        }


    }
}
