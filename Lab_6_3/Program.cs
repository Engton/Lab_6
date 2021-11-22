using System;

namespace Lab_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            circle.Area();

            Pig pig = new Pig();
            pig.animalSound();
        }
    } 
}
