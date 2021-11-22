using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_3
{
    class Cow : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The cow says: moooo");
        }
    }
}
