using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance.Animal.Dog
{
    internal class Chihuahua : Dog
    {
        public bool IsCuddling { get; set; }
        public Chihuahua (string name, int age) : base (name, age)
        {
            Name = name;
            Age = age;
        }

        public void Cuddle()
        {
            if (IsCuddling == true)
            {
                Console.WriteLine($"{Name} kelar sig nära.");
            }
            else
            {
                Console.WriteLine($"{Name} kelar inte just nu med någon.");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} skäller mer ljust som en Chihuahua.");
        }
    }
}
