using SimpleWebAPIProject.Models.Domain;
using SimpleWebAPIProject.Models.Dto;
using SimpleWebAPIProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebAPIProject.Logic.Categories
{
    public class CategoryLogic
    {
        private CategoryRepositoryXML cRepository;

        public CategoryLogic()
        {
            cRepository = new CategoryRepositoryXML();
        }

        public Category GetCategoryById(int id)
        {
            return cRepository.GetById(id);
        }

        public CategoryDTO MapCategoryToDtoUsingId(int id)
        {
            Category searchedCategory = GetCategoryById(id);
            bool isActive = IsCategoryActive(searchedCategory);
            int allProducts = NumberOfProductsInAllCategories();
            CategoryMapper mapper = new CategoryMapper();

            CategoryDTO output = mapper.WriteDTO(searchedCategory, isActive, allProducts);

            return output;
        }

        public bool IsCategoryActive(Category category)
        {
            bool output = true;

            if (!(category.NumberOfProducts > 0))
            {
                output = false;
            }

            return output;
        }

        public int NumberOfProductsInAllCategories()
        {
            List<Category> allCategories = cRepository.GetAll();

            int output = 0;

            foreach (Category item in allCategories)
            {
                output += item.NumberOfProducts;
            }

            return output;
        }


    }
}
