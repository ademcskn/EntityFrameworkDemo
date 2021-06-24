
using EntityFrameworkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.DataAccess
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var productToUpdate = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
                //SingleOrDefault da eğer 1 den fazla veri dönerse hata verir.
            }
        }
    }
}
