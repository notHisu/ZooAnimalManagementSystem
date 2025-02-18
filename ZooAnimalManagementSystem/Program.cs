namespace ZooAnimalManagementSystem
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Zoo zoo = new Zoo();

            zoo.AddAnimal(new Lion("Ura", 5));
            zoo.AddAnimal(new Lion("Mufasa", 7));
            zoo.AddAnimal(new Lion("Simba", 3));

            zoo.AddAnimal(new Elephant("Eren", 10));
            zoo.AddAnimal(new Elephant("Dumbo", 2));
            zoo.AddAnimal(new Elephant("Horton", 4));

            zoo.AddAnimal(new Monkey("Kong", 3));
            zoo.AddAnimal(new Monkey("Rafiki", 6));

            zoo.ShowAnimals();

            var bySpecies = zoo.GetAnimalsByCriteria(animal => animal.Species == "Lion");
            
            foreach (var animal in bySpecies)
            {
                animal.ShowInfo();
                Console.WriteLine();
            }

            var byAge = zoo.GetAnimalsByCriteria(animal => animal.Age > 5);

            foreach (var animal in byAge)
            {
                animal.ShowInfo();
                Console.WriteLine();
            }

            /*
            Lion lion = new Lion("Ura", 5);
            Elephant elephant = new Elephant("Eren", 10);
            Monkey monkey = new Monkey("Kong", 3);
            
            Console.WriteLine("Lion's name is " + lion.Name);
            lion.ShowInfo();
            lion.MakeSound();

            elephant.ShowInfo();
            elephant.MakeSound();

            monkey.ShowInfo();
            monkey.MakeSound();
            */


        }
    }
}