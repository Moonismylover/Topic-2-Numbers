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
        }

        public static void IntegerPrecisionAndLimits()
        {
            int a = 7;
            int b = 4; 
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

            int what = max + 3; 
            Console.WriteLine($"An example of overflow: {what}"); 
        }

        public static void DoubleType()
        {
            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;
            Console.WriteLine(d); //Prints the result as a decimal

            double max = double.MaxValue; //Maximum value of a double.
            double min = double.MinValue; //Minimum value of a double.
            Console.WriteLine($"The range of double is {min} to {max}");

            /*
            Double has more range than int, but less precision.
            It can store larger numbers, but it cannot store as
            many decimal places as int can.
            */

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        public static void DecimalType()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of decimal is {min} to {max}");

            /*
            Decimal has more precision than double, but less range.
            */

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b); //Prints the result as a decimal

            decimal c = 1.0M; 
            decimal d = 3.0M;
            Console.WriteLine(c / d); //Prints the result as a decimal

            // "M" represents Math. It is used to indicate that the number is a decimal.

        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 2 ~ Numbers";

            Console.WriteLine("Topic 2 ~ Numbers");
            Console.WriteLine();

            Integers();

            Console.WriteLine("______________________________");
            Console.WriteLine();

            OrderOfOperations();

            Console.WriteLine("______________________________");
            Console.WriteLine();

            IntegerPrecisionAndLimits();

            Console.WriteLine("______________________________");
            Console.WriteLine();

            DoubleType();

            Console.WriteLine("______________________________");
            Console.WriteLine();

            DecimalType();

            Console.WriteLine("______________________________");
            Console.WriteLine();

            double a = 18;
            double b = 19;
            double c = 23;
            double d = 24;
            double e = 3;
            double f = 10;

            Console.WriteLine(a / e);
            Console.WriteLine(b / e);
            Console.WriteLine(c / e);
            Console.WriteLine(d / e);
            Console.WriteLine(b / f);

            Console.WriteLine("______________________________");
            Console.WriteLine();

            Console.WriteLine("What numeric type is most commonly used to store value that may have decimals?");
            Console.WriteLine();
            Console.WriteLine("The numeric type 'double' is used commonly to store values with decimal-placed digits.");

            Console.WriteLine("_______________________________");

            Console.WriteLine();
            
            Console.WriteLine("Explain the difference between division using integers and doubles.");
            Console.WriteLine();
            Console.WriteLine("Division with integers does not produce any decimal-placed digits even if there are any. Division with double does do the former.");

            Console.WriteLine("_______________________________");

            Console.WriteLine("What will be the results of the following? \n\n1. 5/2 \n2. 5.0 / 2.0 \n3. 5.0 / 2 \n4. 5 2.0");

            double g = 5;
            double h = 5.0;
            double i = 2;
            double j = 2.0;

            Console.WriteLine();

            Console.WriteLine($"1. {g / i} \n2. {h / j} \n3. {h / i} \n4. {g / j}");

            Console.WriteLine("_______________________________");
        }
    }
}
