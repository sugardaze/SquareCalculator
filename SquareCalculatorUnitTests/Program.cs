using System;
using static SquareCalculator.SquareCalculator;

namespace SquareCalculatorUnitTests
{
    public class SquareCalculatorTests
    {
        public static void Main()
        {
            TestCalculateCircleArea();
            TestCalculateTriangleArea();

            TestCalculateRuntimeArea();

            TestIsRightTriangle();
        }

        public static void TestCalculateCircleArea()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;
            double actualArea = circle.CalculateSquare();

            Console.WriteLine($"ТЕСТ Площадь круга:");
            Console.WriteLine($"ОЖИДАНИЕ: {expectedArea:F2}");
            Console.WriteLine($"ПОЛУЧЕНО: {actualArea:F2}");

            if (expectedArea.Equals(actualArea))
            {
                Console.WriteLine("УСПЕШНО");
            }
            else
            {
                Console.WriteLine("ОШИБКА");
            }

            Console.WriteLine();
        }

        public static void TestCalculateTriangleArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);
            double expectedArea = 6;
            double actualArea = triangle.CalculateSquare();

            Console.WriteLine($"ТЕСТ Площадь треугольника:");
            Console.WriteLine($"ОЖИДАНИЕ: {expectedArea:F2}");
            Console.WriteLine($"ПОЛУЧЕНО: {actualArea:F2}");

            if (expectedArea.Equals(actualArea))
            {
                Console.WriteLine("УСПЕШНО");
            }
            else
            {
                Console.WriteLine("ОШИБКА");
            }

            Console.WriteLine();
        }

        static void TestCalculateRuntimeArea() 
        {
            IShape shape = new Circle(5.0); 

            double area = shape.CalculateSquare();

            Console.WriteLine($"ТЕСТ Площадь фигуры, реализующей IShape:");
            Console.WriteLine($"ОЖИДАНИЕ: {area:F2}");

            double expectedArea = Math.PI * 5.0 * 5.0;

            Console.WriteLine($"ПОЛУЧЕНО: {expectedArea:F2}");

            if (Math.Abs(expectedArea - area) < 0.01)
            {
                Console.WriteLine("УСПЕШНО");
            }
            else
            {
                Console.WriteLine("ОШИБКА");
            }

            Console.WriteLine();
        }


        public static void TestIsRightTriangle()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);
            bool isRightTriangle = triangle.IsRightTriangle();

            Console.WriteLine($"ТЕСТ Проверка на прямоугольный треугольник:");
            Console.WriteLine($"ОЖИДАНИЕ: True");
            Console.WriteLine($"ПОЛУЧЕНО: {isRightTriangle}");

            if (isRightTriangle)
            {
                Console.WriteLine("УСПЕШНО");
            }
            else
            {
                Console.WriteLine("ОШИБКА");
            }

            Console.WriteLine();
        }
    }
}
