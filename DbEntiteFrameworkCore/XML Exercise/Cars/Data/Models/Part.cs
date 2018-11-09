using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Data.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
