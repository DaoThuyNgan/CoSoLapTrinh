using System;
using System.Collections.Generic;
using System.Text;

namespace CoSoLapTrinh.session02
{
    internal class ex01
    {
        public static void Main(string[] args)
        {
            // 1.Add / Sum Two Numbers
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The answer is: {num1 + num2}");

            // 2. Swap Values of Two Variables
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After swaping: = a = {a}, b = {b}\n");

            // 3. Multiply Two Floating Point Number
            Console.Write("Enter first float number: ");
            float f1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter second float number: ");
            float f2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Multiply two floating point number is: {f1 * f2}\n");

            // 4. Convert feet to meter
            Console.Write("Enter distance in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {meter} meters\n");

            // 5 Convert Celsius to Fahrenheit and Vice Versa
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"{celsius} C = {fahrenheit} F");

            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit2 = Convert.ToDouble(Console.ReadLine());
            double celsius2 = (fahrenheit2 - 32) / 1.8;
            Console.WriteLine($"{fahrenheit2} F = {celsius2} C");

            // 6. Find the Size of data types
            Console.WriteLine($"Size of double data type is {sizeof(double)}");
            Console.WriteLine($"Size of int data type is {sizeof(int)}");

            // 7. Print ASCII Value(tip: read character, print number of this char)
            Console.Write("Enter a character: ");
            int ch = Console.Read();
            Console.WriteLine($"ASCII code of{(char)ch} is {ch}");

            // 8. Calculate Area of Circle
            double r = 2.5;
            double circleArea = Math.PI * r * r;
            Console.WriteLine($"The area of circle: {circleArea}\n ");

            // 9. Calculate area of square 
            double m = 11.4;
            double squareArea = m * m;
            Console.WriteLine($"The area of square: {squareArea}\n");

            //10. Convert Days to Years, Week, and Days
            int totalDay = 1374;
            int years = totalDay / 365;
            int weeks = (totalDay % 365) / 7;
            int days = (totalDay % 365) % 7;

            Console.WriteLine($"Total Day: {totalDay}");
            Console.WriteLine($"{totalDay} days = {years} year(s), {weeks} week(s), and {days} ");


        }
    }
}
