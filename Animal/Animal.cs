using Inheritance.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animal
{
    internal class Animal
    {
        // The base properties for the base animal class. All values have a default value where age be put in with a field instead because we have an exception if age is below 0.
        // Enums are also used for some properties to get a new datatype for different types of habitats, diets, sizes.
        // Most subclasses for animal are very basic properties that inherit from this Animal class.
        // All properties have default values, at least in the base class.
        public string Name { get; set; } = "";
        private int _age = 0;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Åldern på djuret kan ej vara negativt.");
                }
                _age = value;
            }
        }

        public HabitatType Habitat { get; set; } = HabitatType.Stadsområde;
        public DietType Diet { get; set; } = DietType.Allätare;
        public bool IsTame { get; set; } = false;

        public Animal(string name, int age, HabitatType habitat, DietType diet, bool isTame)
        {
            Name = name;
            Age = age;
            Habitat = habitat;
            Diet = diet;
            IsTame = isTame;
        }

        // We use virtual methods to make use of polymorphism for every subclass. Makes it super easy!

        public virtual void IsEating()
        {
            Console.WriteLine();
        }

        public virtual void IsSleeping()
        {
            Console.WriteLine();
        }

        public virtual void MakeSound ()
        {
            Console.WriteLine();
        }
    }
}
