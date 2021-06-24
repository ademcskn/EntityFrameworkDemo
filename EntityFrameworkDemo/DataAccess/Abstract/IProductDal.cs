using EntityFrameworkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.DataAccess
{
    public interface IProductDal
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetAll();
        Product GetById(int id);
    }
}
