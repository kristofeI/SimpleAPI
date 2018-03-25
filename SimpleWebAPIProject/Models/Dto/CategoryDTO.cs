using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebAPIProject.Models.Dto
{
    [Serializable] public class CategoryDTO : DTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public int NumberOfProducts { get; set; }

        public int AllProducts { get; set; }

        public CategoryDTO()
        {

        }
    }
}
