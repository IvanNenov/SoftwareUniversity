using ProductsShop.Data;
using ProductsShop.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace ProductsShop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ImportProductFromXml());
        }

        static string ImportUsersFromXml()
        {
            string path = "Files/users.xml";
            string xmlString = File.ReadAllText(path);

            var xmlDoc = XDocument.Parse(xmlString);

            var elements = xmlDoc.Root.Elements();

            var users = new List<User>();

            foreach (var e in elements)
            {
                string firstName = e.Attribute("firstName")?.Value;
                string lastName = e.Attribute("lastName").Value;

                int? age = null;

                if (e.Attribute("age") != null)
                {
                    age = int.Parse(e.Attribute("age").Value);
                }

                var user = new User()
                {
                    FirstName = firstName,
                    lastName = lastName,
                    Age = age
                };

                users.Add(user);
            }

            using (var context = new ProductsShopContext())
            {
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            return $"{users.Count} users were imported from file :{path}";
        }

        static string ImportCategoriesFromXml()
        {
            string path = "Files/categories.xml";
            string xmlString = File.ReadAllText(path);

            var xmlDoc = XDocument.Parse(xmlString);

            var elements = xmlDoc.Root.Elements();

            var categories = new List<Category>();

            foreach (var e in elements)
            {
                var categoriy = new Category()
                {
                    Name = e.Element("name").Value
                };

                categories.Add(categoriy);
            }

            using (var context = new ProductsShopContext())
            {
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            return $"{categories.Count} users were imported from file :{path}";
        }

        static string ImportProductFromXml()
        {
            string path = "Files/products.xml";

            var xmlString = File.ReadAllText(path);

            var xmlDoc = XDocument.Parse(xmlString);

            var element = xmlDoc.Root.Elements();

            var catProducts = new List<CategoryProduct>();

            using (var context = new ProductsShopContext())
            {
                var userIds = context.Users.Select(u => u.Id).ToArray();
                var categoriesId = context.Categories.Select(c => c.Id).ToArray();

                Random rnd = new Random();

                foreach (var e in element)
                {
                    string name = e.Element("name").Value;
                    decimal price = decimal.Parse(e.Element("price").Value);

                    int sellerIndex = rnd.Next(0, userIds.Length);

                    int sellerId = userIds[sellerIndex];

                    var product = new Product()
                    {
                        Name = name,
                        Price = price,
                        SellerId = sellerId
                    };

                    int cattegoryIndex = rnd.Next(0, categoriesId.Length);

                    int categoryId = categoriesId[cattegoryIndex];

                    var catProduct = new CategoryProduct()
                    {
                        Product = product,
                        CategoryId = categoryId
                    };

                    catProducts.Add(catProduct);
                }

                context.AddRange(catProducts);
                context.SaveChanges();
            }

            return $"{catProducts.Count} products were imported from file :{path}";

        }
    }
}
