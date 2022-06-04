using System;

namespace prjSubscriptExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 87, 16, 88, 98, 43, 56, 7, 12, 200, 220 };

            try
            {
                Console.WriteLine("Enter an array index > 0: ");
                int pos = Int32.Parse(Console.ReadLine());

                Console.WriteLine("The value at {0} is {1}", pos, numbers[pos - 1]);
                Console.Read();

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("That is an invalid index");

            }
                
        }
    }
}
