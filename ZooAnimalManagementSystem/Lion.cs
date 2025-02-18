using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalManagementSystem
{
    public class Lion : Animal, ICarnivore
    {
        public Lion(string name, int age) : base(name, age, "Lion")
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Roaaaarrrr!\n");
        }

        public void Hunt()
        {
            Console.WriteLine("The lion is hunting for prey.\n");
        }
    }
}
