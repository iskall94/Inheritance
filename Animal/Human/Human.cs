using Inheritance.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance.Animal.Human

    // Humans are very complex so this is just a sample object for humans and how you can create one.
{
    internal class Human : Animal
    {
        public string Gender { get; set; }
        public string LanguageSpoken { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Occupation { get; set; }
        public bool HasPet { get; set; }
        public Human(string name, int age, string gender, string languageSpoken, int height, int weight, string occupation, bool hasPet  ) : base (name, age, HabitatType.Hushåll, DietType.Allätare, false)
        {
            Name = name;
            Age = age;
            Gender = gender;
            LanguageSpoken = languageSpoken;
            Height = height;
            Weight = weight;
            Occupation = occupation;
            HasPet = hasPet;
        }

        public void Working()
        {
            Console.WriteLine($"{Name} jobbar som {Occupation}.");
        }

        public override void IsEating()
        {
            Console.WriteLine($"{Name} äter sin nytillagade mat.");
        }

        public override void IsSleeping()
        {
            Console.WriteLine($"{Name} sover gott i sängen.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} pratar {LanguageSpoken}.");
        }
    }
}
