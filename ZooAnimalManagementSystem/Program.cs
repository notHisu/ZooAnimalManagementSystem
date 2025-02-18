namespace ZooAnimalManagementSystem
{
    public abstract class Animal
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string Species { get; set; }

        public Animal(string name, int age, string species)
        {
            this.Name = name;
            this.Age = age;
            this.Species = species;
        }

        public abstract void MakeSound();

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Species: {Species}");
        }
    }

    public class Lion : Animal
    {
        public Lion(string name, int age) : base(name, age, "Lion") {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Roaaaarrrr!");
        }
    }

    public class Elephant : Animal
    {
        public Elephant(string name, int age) : base(name, age, "Elephant") { }
        public override void MakeSound()
        {
            Console.WriteLine("Con voi kêu làm sao ta?");
        }
    }

    public class Monkey : Animal
    {
        public Monkey(string name, int age) : base(name, age, "Monkey") { }
        public override void MakeSound()
        {
            Console.WriteLine("Oooh Oooh Gahh Gahhh!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Lion lion = new Lion("Lion", 5);
            lion.ShowInfo();
            lion.MakeSound();

            Elephant elephant = new Elephant("Elephant", 10);
            elephant.ShowInfo();
            elephant.MakeSound();

            Monkey monkey = new Monkey("Monkey", 3);
            monkey.ShowInfo();
            monkey.MakeSound();

        }
    }
}