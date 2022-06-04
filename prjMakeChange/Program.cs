using System;

namespace prjMakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            int dollar = 113;
           
            int twenties = dollar / 20;
            int remainder = dollar % 20;

            int tens = remainder / 10;
            remainder = remainder % 10;

            int fives = remainder / 5;
            remainder = remainder % 5;

            int ones = remainder;


            Console.WriteLine("The change for ${0} is {1} twenties, {2} ten, {3} fives, {4} ones",dollar,twenties,tens,fives,ones );
        }
    }
}
