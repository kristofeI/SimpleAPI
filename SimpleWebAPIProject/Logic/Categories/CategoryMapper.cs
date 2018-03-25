using SimpleWebAPIProject.Models.Domain;
using SimpleWebAPIProject.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebAPIProject.Logic.Categories
{
    public class CategoryMapper
    {
        public CategoryDTO WriteDTO(Category category, bool isActive, int allProducts)
        {
            CategoryDTO output = new CategoryDTO();

            output.Id = category.Id;
            output.Name = category.Name;
            output.IsActive = isActive;
            output.NumberOfProducts = category.NumberOfProducts;
            output.AllProducts = allProducts;

            return output;
        }
    }
}
