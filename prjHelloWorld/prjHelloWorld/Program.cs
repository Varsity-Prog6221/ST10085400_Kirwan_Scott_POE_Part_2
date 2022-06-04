using System;

namespace prjHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");

            String strname = Console.ReadLine();

            Console.WriteLine("Oh is that your name :" + strname);

            Console.WriteLine("What is your age: ");
            int iAge = Convert.ToInt32(Console.ReadLine());
            
            Test(strname, iAge);

            ClassMe cm = new ClassMe();
            cm.ClassMethod();

            String[] arrName = { "Jack", "Tim", "bob", "lana" };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Name " + (i+1) + " :" + arrName[i]);
            }
        }

        public static void Test(String strname, int iAge)
        {
            Console.WriteLine("Name : "+strname+ "\n"
                + "Age is "+iAge);
        }
    }
    
}
