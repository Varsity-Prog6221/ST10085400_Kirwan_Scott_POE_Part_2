using System;
using System.Collections.Generic;
using System.Text;

namespace prjSalesPersonDemo
{
    internal class GirlScout : Salesperson, ISellable
    {
        string firstName, lastName;
        int numOfCookies = 0;

        public GirlScout(string firstName, string lastName, int numOfCookies) : base(firstName, lastName)
        {

        }
        public double MakeSale(int value)
        {
            numOfCookies = value;

            return numOfCookies;
        }

        public string SalesSpeech()
        {
            return "The number of boxes of cookies sold is " + numOfCookies;
        }
    }
}
