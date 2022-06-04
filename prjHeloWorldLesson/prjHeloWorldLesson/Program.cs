using System;

namespace prjHeloWorldLesson
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Console.WriteLine("Please enter your name");
            //String strname = Console.ReadLine();
            //Console.WriteLine("Hello " + strname);
            //Console.WriteLine("Please enter a word: ");
            //string a = Console.ReadLine();
            //Console.WriteLine("Please enter a String");
            //string M = Console.ReadLine();
            //int Lnt = M.Length - 1;

            //for (int i = 0; i < M.Length; i++)
            //{
            // Console.WriteLine(M[Lnt]);
            //--Lnt;
            // }
            //Console.WriteLine("Please enter a string: ");
            //Console.Write("Enter here: ");
            //String text = Console.ReadLine();
            //string reversed = "";

            //for (int i = text.Length; i <= 0; i--)
            //{
            //    reversed = reversed + text[i];
            //}

            //Console.WriteLine(reversed);
            Console.WriteLine("Please enter the height :");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width :");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The perimeter is : " + h*w );
        }
    }
}
