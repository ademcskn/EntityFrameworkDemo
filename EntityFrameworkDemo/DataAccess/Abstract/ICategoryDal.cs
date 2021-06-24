using EntityFrameworkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.DataAccess
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
        List<Category> GetAll();
        Category GetById(int id);
    }
}
