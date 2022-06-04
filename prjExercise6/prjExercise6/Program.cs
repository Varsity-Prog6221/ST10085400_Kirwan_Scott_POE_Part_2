using System;

namespace prjExercise6
{
    class Program
    {
        enum months {JANUARY, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER }

        static void Main(string[] args)
        {
            
            Console.Write("Please enter a month integer: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(months.JANUARY - 1 + m);

            //if (m == 1)
            //{
            //    Console.WriteLine(Enum.Parse(typeof(months), "JANUARY"));

            //}
            //else if (m == 2)
            //{
            //    Console.WriteLine(Enum.Parse(typeof(months), "FEBRUARY"));
            //}
            //else if (m == 3)
            //{
            //    Console.WriteLine(Enum.Parse(typeof(months), "MARCH"));
            //}
            //else if (m == 4)
            //{
            //    Console.WriteLine(Enum.Parse(typeof(months), "APRIL"));
            //}
            //else if(m == 5)
            //{
            //    Console.WriteLine(Enum.Parse(typeof(months), "MAY"));
            //}
            //else if (m == 6)
            //{
            //    Console.WriteLine(Enum.Parse(typeof(months), "JUNE"));
            //}
            //else
            //{
            //    Console.WriteLine("Restart console");
            //}



        }
        //static string getAllChar(string sen) 
        //{
        //    string allChar = "";

        //    for (int i = 0; i < sen.Length; i++)
        //    {
        //        if (allChar.Contains(sen[i]))
        //            allChar = allChar + sen[i];
        //    }
        //    return allChar;
        //}
        //static int[] countChar(string sent, string characters)
        //{
        //    int[] count = new int[characters.Length];

        //}

    }
}
