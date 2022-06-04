using System;

namespace prjExrcise14
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
             {
                Console.WriteLine("What kind of shape (R - Rectangle, T - triangle,  S - Square): ");
                string shape = Console.ReadLine();
                Console.WriteLine("What is the height: ");
                double height = Double.Parse(Console.ReadLine());
                Console.WriteLine("What is the width: ");
                double width = Double.Parse(Console.ReadLine());

                GemoetricFigure shapeObject = null;


                switch (shape)
                {
                    case "R":
                        {
                            shapeObject = new Rectangle(height, width);
                            break;
                        }
                    case "T":
                        {
                            shapeObject = new Triangle(height, width);
                            break;
                        }
                    case "S":
                        {
                            shapeObject = new Square(height, width);
                            break;
                        }
                    default: System.Environment.Exit(0);
                        break;
                }
                displayInformation(shapeObject);
            }
            



        }
        static void displayInformation(GemoetricFigure shape)
        {
            Type objectType = shape.GetType();

            Console.WriteLine();
            Console.WriteLine("The area of thr {0} is {1}",objectType.Name, shape.ComputerArea());
        }
    }
}


