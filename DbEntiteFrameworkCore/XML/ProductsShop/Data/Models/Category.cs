using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductsShop.Data.Models
{
    public class Category
    {
        public Category()
        {
            CategoryProducts = new HashSet<CategoryProduct>();
        }
        public int Id { get; set; }

        [StringLength(15 , MinimumLength =3)]
        public string Name { get; set; }

        public ICollection<CategoryProduct> CategoryProducts { get; set; }
    }
}
