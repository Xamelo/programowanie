using System;

namespace FirtstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!");
            Console.WriteLine("Hello World!");

            int number = 57;
            Console.Write("Wartość zmiennej to ");
            Console.WriteLine(number);

            Console.WriteLine("Wartość zmiennej to " + number);

            Console.WriteLine("Wartość zmiennej to {number} lol");
            Console.WriteLine($"Wartość zmiennej to {number} lol");

            Console.WriteLine("Predkość to km\\h");
            Console.WriteLine(@"Predkość to km\h");

            //> , <, >=, <=, ==, !=
            if (number == 5)
            {
                Console.WriteLine("Równe");
            }
            else
            {
                Console.WriteLine("Nie równe");
            }

            var number2 = number + 6.0;

            
        }
    }
}