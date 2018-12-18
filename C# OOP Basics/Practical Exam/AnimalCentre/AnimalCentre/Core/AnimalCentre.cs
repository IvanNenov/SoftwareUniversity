using AnimalCentre.Models;
using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;
using AnimalCentre.Models.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Core
{
    public class AnimalCentre
    {
        private Hotel hotel;
        private List<Procedure> procedures;
        private Dictionary<string, List<string>> owners;

        public AnimalCentre()
        {
            this.hotel = new Hotel();
            this.procedures = new List<Procedure>();
            this.owners = new Dictionary<string, List<string>>();
        }

        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            if (this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} already exist");
            }

            IAnimal animal = null;
            //type.tolower()??
            if (type.ToLower() == "dog")
            {
                animal = new Dog(name, energy, happiness, procedureTime);
            }

            else if (type.ToLower() == "cat")
            {
                animal = new Cat(name, energy, happiness, procedureTime);
            }

            else if (type.ToLower() == "lion")
            {
                animal = new Lion(name, energy, happiness, procedureTime);
            }

            else if (type.ToLower() == "pig")
            {
                animal = new Pig(name, energy, happiness, procedureTime);
            }

            if (animal != null)
            {
                this.hotel.Accommodate(animal);
            }

            return $"Animal {name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            if (!this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }

            var animal = this.hotel.Animals.First(x => x.Value.Name == name).Value;

            if (this.procedures.Any(x => x.GetType() == typeof(Chip)))
            {
                this.procedures.First(x => x.GetType() == typeof(Chip)).DoService(animal, procedureTime);
            }

            else
            {
                var chip = new Chip();
                chip.DoService(animal, procedureTime);
                this.procedures.Add(chip);
            }

            return $"{animal.Name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
            if (!this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }

            var animal = this.hotel.Animals.First(x => x.Value.Name == name).Value;

            if (this.procedures.Any(x => x.GetType() == typeof(Vaccinate)))
            {
                this.procedures.First(x => x.GetType() == typeof(Vaccinate)).DoService(animal, procedureTime);
            }

            else
            {
                var vaccine = new Vaccinate();
                vaccine.DoService(animal, procedureTime);
                this.procedures.Add(vaccine);
            }

            return $"{animal.Name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {
            if (!this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }

            var animal = this.hotel.Animals.First(x => x.Value.Name == name).Value;

            if (this.procedures.Any(x => x.GetType() == typeof(Fitness)))
            {
                this.procedures.First(x => x.GetType() == typeof(Fitness)).DoService(animal, procedureTime);
            }

            else
            {
                var fitness = new Fitness();
                fitness.DoService(animal, procedureTime);
                this.procedures.Add(fitness);
            }

            return $"{animal.Name} had fitness procedure";
        }

        public string Play(string name, int procedureTime)
        {
            if (!this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }

            var animal = this.hotel.Animals.First(x => x.Value.Name == name).Value;

            if (this.procedures.Any(x => x.GetType() == typeof(Play)))
            {
                this.procedures.First(x => x.GetType() == typeof(Play)).DoService(animal, procedureTime);
            }

            else
            {
                var play = new Play();
                play.DoService(animal, procedureTime);
                this.procedures.Add(play);
            }

            return $"{animal.Name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            if (!this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }

            var animal = this.hotel.Animals.First(x => x.Value.Name == name).Value;

            if (this.procedures.Any(x => x.GetType() == typeof(DentalCare)))
            {
                this.procedures.First(x => x.GetType() == typeof(DentalCare)).DoService(animal, procedureTime);
            }

            else
            {
                var dentalCare = new DentalCare();
                dentalCare.DoService(animal, procedureTime);
                this.procedures.Add(dentalCare);
            }

            return $"{animal.Name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            if (!this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }

            var animal = this.hotel.Animals.First(x => x.Value.Name == name).Value;

            if (this.procedures.Any(x => x.GetType() == typeof(NailTrim)))
            {
                this.procedures.First(x => x.GetType() == typeof(NailTrim)).DoService(animal, procedureTime);
            }

            else
            {
                var nailTrim = new NailTrim();
                nailTrim.DoService(animal, procedureTime);
                this.procedures.Add(nailTrim);
            }

            return $"{animal.Name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            if (!this.hotel.Animals.ContainsKey(animalName))
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }

            var animal = this.hotel.Animals.First(x => x.Value.Name == animalName).Value;

            this.hotel.Adopt(animalName, owner);

            if (!this.owners.ContainsKey(owner))
            {
                this.owners.Add(owner, new List<string>());
            }

            this.owners[owner].Add(animalName);

            if (animal.IsChipped)
            {
                return $"{owner} adopted animal with chip";
            }

            else
            {
                return $"{owner} adopted animal without chip";
            }
        }

        public string History(string type)
        {
            var currentPr = this.procedures.First(x => x.GetType().Name == type);
            return currentPr.History();
        }

        public void Print()
        {
            foreach (var own in this.owners.OrderBy(x => x.Key))
            {
                Console.WriteLine($"--Owner: {own.Key}");

                Console.WriteLine($"    - Adopted animals: {string.Join(" ", own.Value)}");
            }
        }
    }
}
