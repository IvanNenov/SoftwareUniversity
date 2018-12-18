using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models
{
    public abstract class Animal : IAnimal
    {
        //•	Owner – string (by default: "Centre")
        //•	IsAdopt – bool (by default: false)
        //•	IsChipped – bool (by default: false)
        //•	IsVaccinated – bool (by default: false)

        private int happiness;
        private int energy;

        protected Animal(string name, int energy, int happiness, int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;
            this.Owner = "Centre";
            this.IsAdopt = false;
            this.IsChipped = false;
            this.IsVaccinated = false;
        }

        public int Happiness
        {
            get
            {
                return this.happiness;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid happiness");
                }

                this.happiness = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid energy");
                }
                this.energy = value;
            }
        }

        public string Name { get; set; }
        public int ProcedureTime { get; set; }
        public string Owner { get; set; }
        public bool IsAdopt { get; set; }
        public bool IsChipped { get; set; }
        public bool IsVaccinated { get; set; }

        public override string ToString()
        {
            return $"Animal type: {this.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
