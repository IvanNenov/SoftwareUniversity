using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models
{
    public abstract class Procedure : IProcedure
    {
        protected List<IAnimal> procedureHistory;

        protected Procedure()
        {
            this.procedureHistory = new List<IAnimal>();
        }

        public IReadOnlyCollection<IAnimal> ProcedureHistory
        {
            get
            {
                return this.procedureHistory;
            }
        }

        public string History()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");

            foreach (var animal in this.procedureHistory)
            {
                sb.AppendLine("    " + animal.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public abstract void DoService(IAnimal animal, int procedureTime);
        
    }
}
