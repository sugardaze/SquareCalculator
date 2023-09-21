using System;

namespace SquareCalculator
{
    public class SquareCalculator
    {

        public interface IShape
        {
            double CalculateSquare();
        }

        public class Circle : IShape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public double CalculateSquare()
            {
                return Math.PI * radius * radius;

            }
        }

        public class Triangle : IShape
        {
            private double side1, side2, side3;

            public Triangle(double side1, double side2, double side3)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }

            public double CalculateSquare()
            {
                double s = (side1 + side2 + side3) / 2;
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));


            }

            public bool IsRightTriangle()
            {
                double[] sides = { side1, side2, side3 };
                Array.Sort(sides);
                return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);

            }
        }
    }
}