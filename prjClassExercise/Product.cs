using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassExercise
{
    class Product
    {
        protected string productCode, productDespription, supplier;
        protected int quantity, reorderLevel;
        protected double price;
        protected const double BASE_DISCOUNT = 0.02;

        public Product()
        {

        }
        
        public Product( string productCode, string productDespription, string supplier, int quantity, int reorderLevel, double price)
        {
            this.productCode = productCode;
            this.productDespription = productDespription;
            this.supplier = supplier;
            this.quantity = quantity;
            this.reorderLevel = reorderLevel;
            this.price = price;
        }

        public virtual double getDiscount()
        {
            return BASE_DISCOUNT * price;
        }
    }
}
