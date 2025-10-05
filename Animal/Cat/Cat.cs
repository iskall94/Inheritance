using Inheritance.Enums;

namespace Inheritance.Animal.Cat
{
    internal class Cat : Animal
    {
        public bool Purring { get; set; }
        public Cat(string name, int age) : base(name, age, HabitatType.Hushåll, DietType.Köttätare, true)
        {
            Name = name;
            Age = age;
        }
        public override void IsEating()
        {
            Console.WriteLine($"{Name} äter sin kattmat från en skål!");
        }
        public override void IsSleeping()
        {
            Console.WriteLine($"{Name} sover lugnt på soffan.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} mjauar!");
        }

        public void IsPurring()
        {
            if (Purring == true)
            {
                Console.WriteLine($"{Name} spinner lugnt.");
            } 
            else
            {
                Console.WriteLine($"{Name} spinner inte just nu.");
            }
        }
    }
}