using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsShop.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public int? Age { get; set; }

        public ICollection<Product> Sold { get; set; }
        public ICollection<Product> Bought { get; set; }
    }
}
