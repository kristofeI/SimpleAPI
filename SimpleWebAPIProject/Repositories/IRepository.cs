using SimpleWebAPIProject.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebAPIProject.Repositories
{
    public interface IRepository<T> where T: EntityBase
    {
        T GetById(int id);
        List<T> GetAll();
    }
}
