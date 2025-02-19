using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ZooAnimalManagementSystem.Animals;

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

        // Define the event
        public event EventHandler<Animal> OnAnimalAdded;

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);

            // Raise the event
            OnAnimalAdded?.Invoke(this, animal);
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

        public void SaveToFile(string fileName)
        {
            var json = JsonSerializer.Serialize(animals);
            File.WriteAllText(fileName, json);
        }

        public void LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                animals = JsonSerializer.Deserialize<List<Animal>>(json, new JsonSerializerOptions
                {
                    Converters = { new AnimalJsonConverter() }
                });
            }
            else
            {
                throw new FileNotFoundException("The specified file does not exist.");
            }
        }
    }

    public class AnimalJsonConverter : JsonConverter<Animal>
    {
        public override Animal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                var name = root.GetProperty("Name").GetString();
                var age = root.GetProperty("Age").GetInt32();
                var species = root.GetProperty("Species").GetString();

                return species switch
                {
                    "Lion" => new Lion(name, age),
                    "Elephant" => new Elephant(name, age),
                    "Monkey" => new Monkey(name, age),
                    _ => throw new NotSupportedException($"Species '{species}' is not supported")
                };
            }
        }

        public override void Write(Utf8JsonWriter writer, Animal value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("Name", value.Name);
            writer.WriteNumber("Age", value.Age);
            writer.WriteString("Species", value.Species);
            writer.WriteEndObject();
        }
    }
}
