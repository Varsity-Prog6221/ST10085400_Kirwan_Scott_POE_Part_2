using System;

namespace prjDeligates
{
    class Program
    {
        delegate void GreetingDelegate(string name);
        static void Main(string[] args)
        {
            GreetingDelegate first, second;
            first = new GreetingDelegate(Hello);
            second = new GreetingDelegate(Goodbye);

            GreetMethod(first, "Kirwan");
            GreetMethod(second, "Kirwan");

            Console.ReadKey();
        }
        static void Hello(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
        static void Goodbye(string name)
        {
            Console.WriteLine("Goodbye {0}", name);
        }
        static void GreetMethod(GreetingDelegate s, string name)
        {
            Console.WriteLine("The greeting is ");
            s(name);
        }
    }
}
