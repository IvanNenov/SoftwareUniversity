using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Data.Models
{
    public class PartCar
    {
        public int PartId { get; set; }
        public Part Part { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

        public ICollection<Car> Cars { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}
