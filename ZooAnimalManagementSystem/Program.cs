using ZooAnimalManagementSystem.Animals;

namespace ZooAnimalManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeConsole();
            var zoo = InitializeZoo();
            DemonstrateZooOperations(zoo);
        }

        private static void InitializeConsole()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }

        private static Zoo InitializeZoo()
        {
            var zoo = new Zoo();
            string fileName = "animals.json";

            // Subscribe to the animal added event
            zoo.OnAnimalAdded += (sender, animal) =>
                Console.WriteLine($"New animal added: {animal.Name}, a {animal.GetAnimalType()}.");
        
            // Add Lions
            zoo.AddAnimal(new Lion("Ura", 5));
            zoo.AddAnimal(new Lion("Mufasa", 7));
            zoo.AddAnimal(new Lion("Simba", 3));

            // Add Elephants
            zoo.AddAnimal(new Elephant("Eren", 10));
            zoo.AddAnimal(new Elephant("Dumbo", 2));
            zoo.AddAnimal(new Elephant("Horton", 4));

            // Add Monkeys
            zoo.AddAnimal(new Monkey("Kong", 3));
            zoo.AddAnimal(new Monkey("Rafiki", 6));

            zoo.SaveToFile(fileName);

            zoo.LoadFromFile(fileName);

            return zoo;
        }

        private static void DemonstrateZooOperations(Zoo zoo)
        {
            // Show all animals
            Console.WriteLine("\nAll Animals in Zoo:");
            zoo.ShowAnimals();

            // Demonstrate filtering by species
            Console.WriteLine("\nLions only:");
            var lions = zoo.GetAnimalsByCriteria(animal => animal.Species == "Lion");
            DisplayAnimals(lions);

            // Demonstrate filtering by age
            Console.WriteLine("\nAnimals older than 5 years:");
            var olderAnimals = zoo.GetAnimalsByCriteria(animal => animal.Age > 5);
            DisplayAnimals(olderAnimals);

            // Show animal types
            Console.WriteLine("\nAnimal Types:");
            foreach (var animal in zoo.Animals)
            {
                Console.WriteLine(animal.GetAnimalType());
            }
        }

        private static void DisplayAnimals(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
                animal.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}