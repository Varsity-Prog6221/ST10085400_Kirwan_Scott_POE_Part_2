using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intList = new int[] { 5, 6, 8, 9, 3 };

            Array.Sort(intList);
            for (int x = 0; x < intList.Length; x++)
            {args`
                Console.WriteLine("The number is: "+intList[x]);
            }
            Console.ReadLine();

            Student[] studList = new Student[2];

            studList[0] = new Student("sdfsdf", "fdfdf", "vbghj", 59);
            studList[0] = new Student("sddddfss", "sdsd", "gjuy", 59);
            studList[0] = new Student("ffffff", "asas", "ghgh", 59);

            for (int f = 0; f < studList.Length; f++)
            {
                Console.WriteLine(studList[f].ToString());
            }



        }
    }
}
