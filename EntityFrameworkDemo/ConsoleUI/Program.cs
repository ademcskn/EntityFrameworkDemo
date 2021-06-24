using EntityFrameworkDemo.Business;
using EntityFrameworkDemo.DataAccess;
using EntityFrameworkDemo.Entities;
using System;
using System.Linq;

namespace EntityFrameworkDemo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAll();

            //GetProductByCategory(1);

            //ProductAdd();

            //ProductUpdate();

            //ProductDelete();

            GetById(58);

            Console.ReadLine();
        }

        private static void GetById(int id)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine(productManager.GetById(id).ProductName);
        }

        private static void ProductDelete()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            productManager.Delete(new Product { ProductId = 78 });
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ProductUpdate()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            productManager.Update(new Product { ProductId = 78, ProductName = "Laptop Lenovo", QuantityPerUnit = "Laptop", CategoryId = 1, UnitPrice = 5000, UnitsInStock = 5 });
        }

        private static void ProductAdd()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            productManager.Add(new Product { ProductName = "a", QuantityPerUnit = "Phone", CategoryId = 1, UnitPrice = 5000, UnitsInStock = 5 });
        }

        private static void GetProductByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = context.Products.Where(c => c.CategoryId == categoryId);
                foreach (var product in result)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
        }

        private static void GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                foreach (var product in context.Products)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
        }
    }
}
