using System;

namespace prjMoveEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            int move = 200;
            int perHour = 150;
            int perMile = 2;


            Console.WriteLine("MALCOM MOVERS \n The base rate is ${0} \n Please press ENTER to Accept", move);
            Console.ReadLine();
            Console.WriteLine("Please enter the amount of times You are going to move : ");
            int nMove = Int32.Parse(Console.ReadLine());
            int totalMove = move * nMove;
            Console.WriteLine("please enter th amount of hours that will be spent moving: ");
            int nPerHour = Int32.Parse(Console.ReadLine());
            int totalHour = perHour * nPerHour;
            Console.WriteLine("PLease enter the amount of miles that will be traveled: ");
            int nPerMile = Int32.Parse(Console.ReadLine());
            int totalMile = nPerMile * perMile;
            int totalAmount = totalMove + totalHour + totalMile;
            Console.WriteLine("The total of the move will be = ${0} " +
                "\nThe total of the Hours will be = ${1} " +
                "\nThe total of the miles per hour will be = ${2}" +
                "\nThe total amount will be = ${3}",totalMove, totalHour, totalMile, totalAmount);

        }
    }
}
