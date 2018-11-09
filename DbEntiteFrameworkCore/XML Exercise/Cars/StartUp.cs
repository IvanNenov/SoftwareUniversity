using Cars.Data;
using Cars.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Cars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ImportSuppliersFromXML());
        }

        static string ImportSuppliersFromXML()
        {
            string path = "Files/suppliers.xml";
            string xmlString = File.ReadAllText(path);

            var xmlDoc = XDocument.Parse(xmlString);

            var element = xmlDoc.Root.Elements();

            var suppliers = new List<Supplier>();

            foreach (var e in element)
            {
                string name = e.Attribute("name").Value;
                var isImporter = e.Attribute("is-importer").Value;
                bool isImp = true;
                if (isImporter != "true")
                {
                    isImp = false;
                }

                var supplier = new Supplier()
                {
                    Name = name,
                    IsImporter = isImp
                };

                suppliers.Add(supplier);
            }

            using (var context = new CarsContext())
            {
                context.Suppliers.AddRange(suppliers);
                context.SaveChanges();
            }

            return $"{suppliers.Count} suppliers were imported from file : {path}";
        }
    }
}
