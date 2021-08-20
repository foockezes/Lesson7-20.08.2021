using System;

namespace ConsoleApp1
{
    class Program
    {
        class Rectangle
        {
            public double side1, side2;

            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }

            public double AreaCalculator()
            {
                return side1 * side2;
            }
            public double PerimeterCalculator()
            {
                return 2 * (side1 + side2);
            }
            public double Area
            {
                get { return AreaCalculator(); }
            }

            public double Perimeter
            {
                get { return PerimeterCalculator(); }
            }
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine($" площадь: {rectangle.Area}, периметр: {rectangle.Perimeter}");

            Rectangle rectangle1 = new Rectangle(12.80, 16.60);
            Console.WriteLine($" площадь: {Math.Round(rectangle1.Area,2)}, периметр: {Math.Round(rectangle1.Perimeter,2)}");
        }
    }
}

