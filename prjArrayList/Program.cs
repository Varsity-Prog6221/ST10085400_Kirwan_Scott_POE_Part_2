using System;
using System.Collections;

namespace prjArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
             ArrayList employees = new ArrayList();

            bool keepgoing = true;

            while (keepgoing)
            {
                Console.Write("Enter employee name: ");
                string employee = Console.ReadLine();
                Console.Write("Enter the salary of " + employee + ": R");
                double salary = Convert.ToDouble(Console.ReadLine());


                Employee employee1 = new Employee(employee, salary);
                employees.Add(employee1);

                Console.WriteLine("Do you have another employee? y or n");
                keepgoing = Console.ReadLine() == "y";
            }

            for (int i = 0; i < employees.Count; i++)
            {

                
            }
        }
    }
}
