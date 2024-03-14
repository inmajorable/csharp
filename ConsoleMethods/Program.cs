using System;
using System.Runtime.Intrinsics;
using System.Threading.Channels;

namespace ConsoleMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            messageOnScreen();

            Console.WriteLine("Main message");

            addNumbersA(3,8);

            Console.WriteLine(addNumbersB(4,9));

            Console.WriteLine(divideNumbers(8,5));

            Console.WriteLine(Addition(3.8,7));
        }

        static void messageOnScreen()
        {
            Console.WriteLine("Screen message");
        }

        static void addNumbersA(int num1, int num2)
        {
            Console.WriteLine("The addition is: " + (num1 + num2));
            Console.WriteLine($"Addition is: {num1+num2}");
        }

        static int addNumbersB(int num3, int num4) /* Return with one line code*/
        {
            return num3 + num4;
        }

        static double divideNumbers(int num5, double num6) => num5 / num6; /* Alternative Return with one line code*/


        /* Console Methods - ámbito local*/

        void firstMethod()
        {
            Console.WriteLine(numb1 + numb2);
        }

        void secondMethod()
        {
            Console.WriteLine(numb1 + numb2);
        }

        static void Addition(int num7, int num8)
        {
            return num7 + num8;
        }

        static void Addition(int num9, int num10, int num11) => num9 + num10;

        static void Addition(double num12, int num13) => num12 + num13; /*Taken this option due to parameters with decimals*/

    }

    class Parameters
    {
        static void Main()
        {
            Console.WriteLine(Suma(3, 4.4));
        }

        static double Suma(int v1, double v2)
        {
            return v1 + v2; 
        }
    }
}