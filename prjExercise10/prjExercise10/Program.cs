using System;

namespace prjExercise10
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of employees");
            int noEmploy = Convert.ToInt32(Console.ReadLine());

            Employee[] employees = new Employee[noEmploy];

            for (int i = 0; i < noEmploy; i++)
            {
                Console.Write("Enter employee name: ");
                string employee = Console.ReadLine();
                Console.Write("Enter the salary of " + employee + ": R" );
                double salary = Convert.ToDouble(Console.ReadLine());
               

                Employee obj = new Employee(employee, salary);
                employees[i] = obj;

                Console.WriteLine("Next year's raise will be: " + obj.CalSalary());
                Console.WriteLine("New salary will be : R" + (salary + obj.CalSalary()));
                Console.WriteLine("\n");

            }
            
        }
        
    }
    

}
