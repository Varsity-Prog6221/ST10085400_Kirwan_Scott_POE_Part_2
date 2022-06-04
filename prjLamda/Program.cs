using System;
using System.Collections.Generic;
using System.Linq;

namespace prjLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Original list of integers: " );


            Console.WriteLine(string.Join(",",list));
            Console.WriteLine("\n");

            IEnumerable<int> Sqr = list.AsQueryable().Select(c => c * c);
            Console.WriteLine("Square every number of the said list:");
            Console.WriteLine(string.Join(",", Sqr));
            Console.WriteLine("\n");

            IEnumerable<int> Cube = list.AsQueryable().Select(c => c * c * c);
            Console.WriteLine("Cube every number of the said list: ");
            Console.Write(string.Join(",", Cube));
            Console.WriteLine("\n");


        }
    }
}
