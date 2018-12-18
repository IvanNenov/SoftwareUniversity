using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Models
{
    public class Hotel : IHotel
    {
        private const int capacity = 10;
        private Dictionary<string, IAnimal> animals;

        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>();
        }

        public IReadOnlyDictionary<string, IAnimal> Animals
        {
            get
            {
                return this.animals;
            }
        }

        public void Accommodate(IAnimal animal)
        {
            if (this.animals.Keys.Count >= capacity)
            {
                throw new InvalidOperationException("Not enough capacity");
            }

            if (this.Animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }

            this.animals.Add(animal.Name, animal);
        }

        public void Adopt(string animalName, string owner)
        {
            if (!this.animals.ContainsKey(animalName))
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }

            var existingAnimal = this.animals.FirstOrDefault(x => x.Value.Name == animalName).Value;
            //  var existingAnimal = this.animals.First(x => x.Value.Name == animalName).Value;

            existingAnimal.Owner = owner;
            existingAnimal.IsAdopt = true;
            this.animals.Remove(existingAnimal.Name);
        }
    }
}
