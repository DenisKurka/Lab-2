using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Rectangle
    {
        private double Side1;
        private double Side2;

        private double Area;
        private double Perimeter;

        public Rectangle(double Side1, double Side2)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
        }

        public double area
        {
            get
            {
                return Area;
            }

        }

        public double AreaCalculator(double Area, double Side1, double Side2)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;

            Console.WriteLine("Введите длину первой стороны: ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны: ");
            Side2 = Convert.ToDouble(Console.ReadLine());

            this.Area = Area;
            Area = Side1 * Side2;

            Console.WriteLine($"Площадь: {Area}");

            return Area;
        }

        public double perimeter
        {
            get
            {
             return Perimeter;
            }

        }
        public double PerimeterCalculator(double Perimeter, double Side1, double Side2)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;

            Console.WriteLine("Введите длину первой стороны: ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны: ");
            Side2 = Convert.ToDouble(Console.ReadLine());

            this.Perimeter = Perimeter;
            Perimeter = (Side1 + Side2)*2;

            Console.WriteLine($"Периметр: {Perimeter}");

            return Perimeter;
        }
    }
}
//Console.ReadLine();