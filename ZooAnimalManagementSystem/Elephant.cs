using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalManagementSystem
{
    public class Elephant : Animal
    {
        public Elephant(string name, int age) : base(name, age, "Elephant") { }
        public override void MakeSound()
        {
            Console.WriteLine("Con voi kêu làm sao ta?\n");
        }
    }
}
