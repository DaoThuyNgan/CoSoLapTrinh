using System;
using System.Collections.Generic;
using System.Text;

namespace CoSoLapTrinh.session04
{
    internal class ex01
    {
        static void GiaiPTBacHai(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    Console.WriteLine($"Phương trình có một nghiệm: x = {-c / b}");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    Console.WriteLine($"Phương trình có một nghiệm kép: x = {-b / (2 * a)}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                }
            }
        }

        static void CheckNumber(int number)
        { 
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{number} là số lẻ.");
            }
        }

        static void FindMaxNumber(double num1, double num2, double num3)
        {
            double max;
            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            Console.WriteLine($"Số lớn nhất trong ba số {num1}, {num2}, {num3} là: {max}");
        }

        static void CheckTriangleType(double x, double y, double z)
        {
            if (x + y > z && x + z > y && y + z > x)
            {
                if (x == y && y == z)
                {
                    Console.WriteLine("Tam giác đều (Equilateral).");
                }
                else if (x == y || x == z || y == z)
                {
                    Console.WriteLine("Tam giác cân (Isosceles).");
                }
                else
                {
                    Console.WriteLine("Tam giác thường (Scalene).");
                }
            }
            else
            {
                Console.WriteLine("Ba cạnh trên không tạo thành một tam giác");
            }
        }

        static void DetermineQuadrant(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Điểm nằm ở góc phần tư thứ nhất.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Điểm nằm ở góc phần tư thứ hai.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Điểm nằm ở góc phần tư thứ ba.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Điểm nằm ở góc phần tư thứ tư.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Điểm nằm trên trục tung.");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine("Điểm nằm trên trục hoành.");
            }
            else
            {
                Console.WriteLine("Điểm nằm tại gốc tọa độ.");
            }
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            // Bài 1: Giải phương trình bậc hai
            Console.WriteLine("Giải phương trình bậc hai ax^2 + bx + c = 0");
            Console.Write("Nhập hệ số a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập hệ số b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập hệ số c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            GiaiPTBacHai(a, b, c);

            // Bài 2: Kiểm tra số chẵn hay lẻ
            Console.Write("Nhập một số nguyên: ");
            int number = int.Parse(Console.ReadLine());
            CheckNumber(number);

            // Bài 3: Tìm số lớn nhất trong ba số
            Console.Write("Nhấp số thứ nhất: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            double num3 = double.Parse(Console.ReadLine());
            FindMaxNumber(num1, num2, num3);

            // Bài 4: Kiểm tra xem một tam giác là tam giác gì
            Console.Write("Nhap độ dài cạnh thứ nhất: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài cạnh thứ hai: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài cạnh thứ ba: ");
            double z = double.Parse(Console.ReadLine());
            CheckTriangleType(x, y, z);

            // Bài 5: Xác định góc phần tư của một điểm trong hệ tọa độ
            Console.Write("Nhập hoành độ x: ");
            double xCoord = double.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ y: ");
            double yCoord = double.Parse(Console.ReadLine());
            DetermineQuadrant(xCoord, yCoord);

        }
    }
}
