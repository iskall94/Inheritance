using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Enums;

namespace Inheritance.Animal.Dog
{
    internal class SiberianHusky : Dog
    {
        public bool IsSledTrained { get; set; } = true;

        public SiberianHusky(string name, int age, bool isSledTrained) : base(name, age)
        {
            Habitat = HabitatType.Polarområde;
            IsSledTrained = isSledTrained;
        }
        public static void HasThickFur()
        {
            Console.WriteLine("En Siberian Husky är känd för att ha tjock päls.");
        }
        
        public void SnowSled()
        {
            if (IsSledTrained == true)
            {
                Console.WriteLine($"{Name} drar kälken i snön!");
            }
            else
            {
                Console.WriteLine($"{Name} har inte övat på att dra kälke i snö...");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} skäller och yler som en Siberian Husky!");
        }
    }
}
