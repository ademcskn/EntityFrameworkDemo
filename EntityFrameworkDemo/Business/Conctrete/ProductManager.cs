using EntityFrameworkDemo.DataAccess;
using EntityFrameworkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            //iş kuralları 
            //Örnek:
            if (product.ProductName.Length < 2)
            {
                Console.WriteLine("ürün ismi en az iki karakter olmalı!");
            }
            else
            {
                _productDal.Add(product);
            }

        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
