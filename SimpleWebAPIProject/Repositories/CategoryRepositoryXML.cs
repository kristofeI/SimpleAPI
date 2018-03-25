using SimpleWebAPIProject.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SimpleWebAPIProject.Repositories
{
    public class CategoryRepositoryXML : IRepository<Category>
    {
        public List<Category> GetAll()
        {
            var doc = XDocument.Load(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Categories.xml"));

            var categories = doc.Root
                .Descendants("Category")
                .Select(node => new Category
                {
                    Id = int.Parse(node.Element("Id").Value),
                    Name = node.Element("Name").Value,
                    NumberOfProducts = int.Parse(node.Element("NumberOfProducts").Value)
                })
                .ToList();

            return categories;
        }

        public Category GetById(int id)
        {
            var doc = XDocument.Load(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Categories.xml"));

            var categories = doc.Root
                .Descendants("Category")
                .Select(node => new Category
                {
                    Id = int.Parse(node.Element("Id").Value),
                    Name = node.Element("Name").Value,
                    NumberOfProducts = int.Parse(node.Element("NumberOfProducts").Value)
                })
                .ToList();

            return categories.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
