using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_2___Numbers
{
    internal class Program
    {
        public static void Integers()
        {
            // Integers
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c); //Prints the sum of a and b.
            Console.WriteLine();

            // Operations
            c = a + b; //addition
            Console.WriteLine(c);
            c = a - b; //subtraction
            Console.WriteLine(c);
            c = a * b; //multiplication
            Console.WriteLine(c);
            c = a / b; //division
            Console.WriteLine(c);

            Console.WriteLine();
        }

        public static void OrderOfOperations()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d); //Order of operations is implemented

            d = (a + b) * c; //Order of operations is implemented again.
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d); //It did not produce a decimal bcause its stored in an integer.
            
            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);

            Console.WriteLine();
        }

        public static void IntegerPrecisionAndLimits()
        {
            int a = 7;
            int b = 4; ;
            int c = 3;
            int d = (a + b / c);
            int e = (a + b) % c;
            Console.WriteLine($"Quotient: {d}");
            Console.WriteLine($"Remainder: {e}");
            Console.WriteLine();

            int max = int.MaxValue; //Maximum value of an integer.
            int min = int.MinValue; //Minimum value of an integer.
            Console.WriteLine($"The range of integers is {min} to {max}");
            Console.WriteLine();

            int what = max + 3; // this show
            Console.WriteLine($"An example of overflow: {what}"); 
            Console.WriteLine();
        }

        public static void DoubleType()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);


        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 2 ~ Numbers";

            Console.WriteLine("Topic 2 ~ Numbers");
            Console.WriteLine();

            Integers();

            OrderOfOperations();

            IntegerPrecisionAndLimits();

            DoubleType();
        }
    }
}
