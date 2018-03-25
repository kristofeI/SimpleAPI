using SimpleWebAPIProject.Logic.Categories;
using SimpleWebAPIProject.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleWebAPIProject.Controllers
{
    public class CategoriesController : ApiController
    {
        [Route("api/Categories/GetById/{id:int}")]
        [HttpGet]
        public CategoryDTO GetById(int id)
        {
            CategoryLogic logic = new CategoryLogic();
            CategoryDTO output = logic.MapCategoryToDtoUsingId(id);

            return output;
        }
    }
}
