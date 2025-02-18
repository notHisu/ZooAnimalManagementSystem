using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
