using System;
using System.Collections.Generic;
using System.Text;

namespace prjExercise10
{
    class Employee
    {
        string employee { get; set; }
        double salary;

        public Employee(string employee, double salary)
        {
            this.employee = employee;
            this.salary = salary;
        }
        
        public double CalSalary()
        {
            return salary * 0.4;
        }

        
    }
}
