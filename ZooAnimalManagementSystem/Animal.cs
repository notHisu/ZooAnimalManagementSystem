using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalManagementSystem
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string species;

        public string Name

        { get { return name; }
            set { name = value; }
        }

        public int Age

        {
            get { return age; }
            set { age = value; }
        }

        public string Species

        {
            get { return species; }
            set { species = value; }
        }


        public Animal(string name, int age, string species)
        {
            this.name = name;
            this.age = age;
            this.species = species;
        }

        public abstract void MakeSound();

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Species: {species}");

        }
    }
}
