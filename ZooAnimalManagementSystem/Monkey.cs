using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalManagementSystem
{
    public class Monkey : Animal
    {
        public Monkey(string name, int age) : base(name, age, "Monkey") { }
        public override void MakeSound()
        {
            Console.WriteLine("Oooh Oooh Gahh Gahhh!\n");
        }
    }

}
