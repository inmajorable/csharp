using System;
{
    class Program
    {
        static public void Main()
        {
            Console.WriteLine("Calculate the area of a circle");
            Console.WriteLine("Please, enter the radio :");

            var double radio = Console.ReadLine();
            const float pi = 3.1415;

            Console.WriteLine("This is the area of your circle: " + (pi * (radio^2)));
        }
    }
}