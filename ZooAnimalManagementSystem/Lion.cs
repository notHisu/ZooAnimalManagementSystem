using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalManagementSystem
{
    public class Lion : Animal
    {
        public Lion(string name, int age) : base(name, age, "Lion")
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Roaaaarrrr!");
        }
    }
}
