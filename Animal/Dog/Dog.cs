using Inheritance.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance.Animal.Dog
{
    internal class Dog : Animal
    {
        public string FetchItem { get; set; } = "";

        public Dog (string name, int age) : base(name, age, HabitatType.Hushåll, DietType.Allätare, true)
        {
            Name = name;
            Age = age;
        }

        public void ItemFetching()
        {
                Console.WriteLine($"{Name} hämtar en {FetchItem}.");
        }

        public override void IsEating()
        {
            Console.WriteLine($"{Name} äter sin hundmat.");
        }
        public override void IsSleeping()
        {
            Console.WriteLine($"{Name} sover på sin favoritplats.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} skäller!");
        }
    }
}
