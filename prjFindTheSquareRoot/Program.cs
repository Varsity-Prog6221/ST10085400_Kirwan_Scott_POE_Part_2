using System;

namespace prjFindTheSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculateSqrt();
            //double value = 0;
            //double sqrt;
            //try
            //{
            //    Console.WriteLine("Please enter a value: ");
            //    value = Double.Parse(Console.ReadLine());
            //    sqrt = Math.Sqrt(value);
            //    Console.WriteLine("The square root of " + value + " = " + sqrt);

            //}
            //catch(Exception e)
            //{

            //    value < 0;
            //    sqrt = 0;
            //    Console.WriteLine("The input value should be a positive number");
            //}
            //catch()

        }
        static void CalculateSqrt()
        {
            double number = 0;
            double sqrt = 0;
            try
            {
                Console.WriteLine("Please enter a number: ");
                 number = Double.Parse(Console.ReadLine());
                
                if(number < 0)
                
                    throw new ApplicationException("That should have been a positive number");

                sqrt = Math.Sqrt(number);
                Console.WriteLine("The square root of {0} = {1} ", number, sqrt);

            }
            catch(FormatException e)
            {
                Console.WriteLine("Value is not a double");
            }
            catch(ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
