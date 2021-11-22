using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_3
{
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
