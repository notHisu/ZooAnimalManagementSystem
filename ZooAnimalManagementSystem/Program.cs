namespace ZooAnimalManagementSystem
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Lion lion = new Lion("Lion", 5);
            //Console.WriteLine("Lion's name is " + lion.Name);
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