using Inheritance.Animal;
using Inheritance.Animal.Bird;
using Inheritance.Animal.Cat;
using Inheritance.Animal.Dog;
using Inheritance.Animal.Human;
using Inheritance.Enums;

namespace Inheritance
{
    internal class Program
    {
        // Here we create all the new objects for our baseclass / subclasses and call their methods.
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Simba", 6);
            cat1.Purring = true;
            Console.WriteLine($"{cat1.Name} är {cat1.Age} år gammal");
            Console.WriteLine($"{cat1.Name} bor i ett {cat1.Habitat}s miljö.");
            Console.WriteLine($"Katter är {DietType.Köttätare}.");
            cat1.MakeSound();
            cat1.IsEating();
            cat1.IsPurring();
            cat1.IsSleeping();
            
            Console.WriteLine();

            Cat cat2 = new Cat("Kiara", 4);
            Console.WriteLine($"{cat2.Name} är {cat2.Age} år gammal.");
            cat2.IsPurring();

            Console.WriteLine();

            Dog dog1 = new Dog("Molly", 5);
            dog1.MakeSound();

            Console.WriteLine();

            SiberianHusky siberianHusky1 = new SiberianHusky("Sigge", 5, true);
            Console.WriteLine($"{siberianHusky1.Name} lever i ett {siberianHusky1.Habitat}.");
            siberianHusky1.FetchItem = "pinne";
            siberianHusky1.MakeSound();
            siberianHusky1.SnowSled();
            siberianHusky1.IsEating();
            siberianHusky1.ItemFetching();

            Console.WriteLine();

            Chihuahua chihuahua1 = new Chihuahua("Jim", 8);
            chihuahua1.IsCuddling = true;
            chihuahua1.Cuddle();
            chihuahua1.MakeSound();

            Console.WriteLine();

            // Bird class doesn't specify the bird species

            Bird bird1 = new Bird("Korp", 6, HabitatType.Skog, "Svart", SizeType.Stor);
            Console.WriteLine($"En {bird1.BirdType} bor i {HabitatType.Skog}en och är {bird1.Age} år gammal. {bird1.BirdType}en är {bird1.Size}.");
            bird1.Fly();
            bird1.IsEating();
            bird1.IsSleeping();
            bird1.MakeSound();

            Console.WriteLine();

            Bird bird2 = new Bird("Mes", 2, HabitatType.Skog, "Färgglad", SizeType.Liten);
            Console.WriteLine($"En {bird2.BirdType} är {bird2.Age} år gammal, är {bird2.FeatherColour} men är {bird2.Size}");
            bird2.MakeSound();

            Console.WriteLine();

            Human human1 = new Human("Sven Björnsson", 57, "Male", "Svenska", 180, 75, "Elektriker", false);
            human1.Working();
            human1.MakeSound();
            human1.IsEating();
            human1.IsSleeping();
            Console.WriteLine($"{human1.Name} är {human1.Age} år gammal, är {human1.Height} cm lång och väger {human1.Weight} kg.");
            
        }
    }
}
