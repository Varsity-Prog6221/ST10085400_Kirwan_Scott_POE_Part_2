using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassExercise
{
    class Perishable : Product
    {
        DateTime datePurchased, bestBefore;
        int shelfLife;
        const double PERISHABLE_DISCOUNT = 0.3;

        public Perishable(string productCode, string productDespription, string supplier, int quantity, int reorderLevel, double price, DateTime datePurchased, DateTime bestBefore, int shelfLife)
            : base(productCode, productDespription, supplier, quantity, reorderLevel, price)
        {
            this.datePurchased = datePurchased;
            this.bestBefore = bestBefore;
            this.shelfLife = shelfLife;



        }

        public override double getDiscount()
        {
            if (shelfLife < 3)
                return PERISHABLE_DISCOUNT * price;
            return base.getDiscount();
        }
    }
}
