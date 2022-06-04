using System;
using System.Collections.Generic;
using System.Text;

namespace prjSalesPersonDemo
{
    abstract class Salesperson 
    {

        string firstName, lastName;

        public Salesperson(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string getName()
        {
            return firstName + " " + lastName;
        }

            
        
    }
}
