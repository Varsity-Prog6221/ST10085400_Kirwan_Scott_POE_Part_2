using System;
using System.Collections.Generic;
using System.Text;

namespace prjSalesPersonDemo
{
    class RealEstateSalesperson : Salesperson, ISellable
    {

        double totalDollars = 0;
        double totalCommision = 0;
        string firstName, lastName;

        public RealEstateSalesperson(string firstName, string lastName, double totalDollars, double totalCommision):base(firstName, lastName)
        {

        }
        public double MakeSale(int value)
        {
            totalCommision = totalDollars + value;

            return totalCommision;
        }

        public string SalesSpeech()
        {
            return "Your Total Commision: $" + totalCommision;
        }
    }
}
