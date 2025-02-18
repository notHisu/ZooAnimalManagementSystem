namespace ZooAnimalManagementSystem
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Lion lion = new Lion("Ura", 5);
            Elephant elephant = new Elephant("Eren", 10);
            Monkey monkey = new Monkey("Kong", 3);
            
            //Console.WriteLine("Lion's name is " + lion.Name);
            lion.ShowInfo();
            lion.MakeSound();

            elephant.ShowInfo();
            elephant.MakeSound();

            monkey.ShowInfo();
            monkey.MakeSound();


        }
    }
}