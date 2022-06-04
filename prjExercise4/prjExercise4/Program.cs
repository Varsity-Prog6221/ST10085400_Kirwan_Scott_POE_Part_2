using System;

namespace prjExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pDrome, rev;
            Console.WriteLine("Please enter A word: ");
            pDrome = Console.ReadLine();
            char[] ch = pDrome.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = pDrome.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine(pDrome + " is a palindrome");
            }
            else
            {
                Console.WriteLine(pDrome + " is not a palindrome");
            }
        }
    }
}
