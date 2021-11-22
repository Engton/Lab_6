using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_3
{
    class Circle : Figure
    {
        double r;
        public Circle(double radius)
        {
            r = radius;
        }
        public override double S { get; set; }

        public override double Area()
        {
            S = 3.14 * r * r;
            Console.WriteLine(S);
            return S;
        }
    }
}
