using Inheritance.Enums;
using System.Reflection.Metadata;

namespace Inheritance.Animal.Bird
{
    internal class Bird : Animal
    {
        public string BirdType { get; set; }
        public string FeatherColour { get; set; }
        public bool CanFly { get; set; } = true;
        public SizeType Size { get; set; }
        public Bird(string birdType, int age, HabitatType habitat, string featherColour, SizeType size) : base("", age, HabitatType.Skog, DietType.Allätare, false)
        {
            BirdType = birdType;
            Age = age;
            Habitat = habitat;
            FeatherColour = featherColour;
            Size = size;
        }

        public void Fly()
        {
            if (CanFly == true)
            {
                Console.WriteLine($"En {BirdType} flyger runt i luften!");
            }
            else
            {
                Console.WriteLine("Denna fågel kan inte flyga.");
            }
        }
        public override void IsEating()
        {
            Console.WriteLine($"En {BirdType} äter något den hittat på marken.");
        }

        public override void IsSleeping()
        {
            Console.WriteLine($"En {BirdType} sover någonstans uppe i trädet.");
        }
        public override void MakeSound()
        {
            if (Size == SizeType.Liten)
            {
                Console.WriteLine($"En {BirdType} kvittrar!");
            }
            else
            {
                Console.WriteLine($"En {BirdType} kraxar högt.");
            }
            
        }

    }
}
