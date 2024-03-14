using System;

namespace ConsoleSintaxis
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Calculate the area of a circle ");
            const double PI = 3.1415;

            Console.WriteLine("Please, enter the radio: ");

            double radio = double.Parse(Console.ReadLine());

            Console.WriteLine("This is the area of your circle: " + (PI * radio * radio) + " unidades al cuadrado.");
        }
    }
}