using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassExercise
{
    class Magazine : Product
    {
        string type;
        DateTime published;
        const double PUBLISHED_DISCOUNT = 0.1;

        public Magazine(string productCode, string productDespription, string supplier, int quantity, int reorderLevel, double price, string type, DateTime published)
            : base(productCode, productDespription, supplier, quantity, reorderLevel, price)
        {
            this.type = type;
            this.published = published;

        }

        public override double getDiscount()
        {
            if (published.Year < 2013)
                return PUBLISHED_DISCOUNT*this.getDiscount();
            return base.getDiscount();
        }
    }

   
}
