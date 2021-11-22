using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_3
{
     class Triangle : Figure
    {
        double a;
        double h;

        public Triangle(double side, double height)
        {
            a = side;
            h = height;
        }

        public override double S { get; set; }

        public override double Area()
        {
            S = 0.5 * a * h;
            Console.WriteLine(S);
            return S;
        }
    }
}
