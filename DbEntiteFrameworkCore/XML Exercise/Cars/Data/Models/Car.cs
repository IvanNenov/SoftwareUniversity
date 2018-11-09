using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public DateTime Make { get; set; }
        public string Model { get; set; }
        public decimal TravelledDistance { get; set; }

    }
}
