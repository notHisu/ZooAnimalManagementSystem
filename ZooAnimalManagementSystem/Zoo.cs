using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalManagementSystem
{
    public class Zoo
    {
        private List<Animal> animals;

        public List<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }

        public Zoo()
        {
            animals = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void ShowAnimals()
        {
            foreach (Animal animal in animals)
            {
                animal.ShowInfo();
                animal.MakeSound();
            }
        }

        public IEnumerable<Animal> GetAnimalsByCriteria(Func<Animal, bool> criteria)
        {
            if (criteria == null)
            {
                throw new ArgumentNullException("criteria");
            }
            return animals.Where(criteria);
        }

    }
}
