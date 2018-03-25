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
            //List<Category> categories = new List<Category>();

            //XDocument xdoc = XDocument.Load(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Categories.xml"));
            //xdoc.Descendants("Category").Select(p => new {
            //    id = p.Attribute("Id").Value,
            //    name = p.Element("Name").Value,
            //    numberOfProducts = p.Element("NumberOfProducts").Value
            //}).ToList().ForEach(p => {
            //    Category cat = new Category();
            //    cat.Id = int.Parse(p.id);
            //    cat.Name = p.name;
            //    cat.NumberOfProducts = int.Parse(p.numberOfProducts);
            //    categories.Add(cat);
            //});

            //string strpath = System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Categories.xml");

            //using (XmlReader reader = XmlReader.Create(strpath))
            //{
            //    while (reader.Read())
            //    {
            //        if (reader.IsStartElement())
            //        {
            //            Category category = new Category();

            //            switch (reader.Name.ToString())
            //            {
            //                case "Id":
            //                    category.Id = int.Parse(reader.ReadString());
            //                    break;

            //                case "Name":
            //                    category.Name = reader.ReadString();
            //                    break;

            //                case "NumberOfProducts":
            //                    category.NumberOfProducts = int.Parse(reader.ReadString());
            //                    break;
            //            }

            //            categories.Add(category);
            //        }
            //    }
            //}

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
            //List<Category> categories = new List<Category>();

            //string strpath = System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Categories.xml");

            //using (XmlReader reader = XmlReader.Create(strpath))
            //{
            //    while (reader.Read())
            //    {
            //        if (reader.IsStartElement())
            //        {
            //            Category category = new Category();

            //            switch (reader.Name.ToString())
            //            {
            //                case "Id":
            //                    category.Id = int.Parse(reader.ReadString());
            //                    break;

            //                case "Name":
            //                    category.Name = reader.ReadString();
            //                    break;

            //                case "NumberOfProducts":
            //                    category.NumberOfProducts = int.Parse(reader.ReadString());
            //                    break;
            //            }

            //            categories.Add(category);
            //        }
            //    }
            //}

            //List<Category> categories = new List<Category>();

            //XDocument xdoc = XDocument.Load(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Categories.xml"));
            //Category cat = new Category();

            //xdoc.Descendants("Category").Select(p => new {
            //    id = p.Attribute("Id").Value,
            //    name = p.Element("Name").Value,
            //    numberOfProducts = p.Element("NumberOfProducts").Value
            //}).ToList().ForEach(p => {
            //    cat.Id = int.Parse(p.id);
            //    cat.Name = p.name;
            //    cat.NumberOfProducts = int.Parse(p.numberOfProducts);
            //    categories.Add(cat);
            //});

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
