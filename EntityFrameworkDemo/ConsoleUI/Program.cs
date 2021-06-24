using EntityFrameworkDemo.Business;
using EntityFrameworkDemo.Business.Conctrete;
using EntityFrameworkDemo.DataAccess;
using EntityFrameworkDemo.DataAccess.Concrete.EntityFramework;
using EntityFrameworkDemo.Entities;
using System;
using System.Linq;

namespace EntityFrameworkDemo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Product
            //GetProductById(58);

            //GetAllProducts();

            //GetProductsByCategory(1);

            //ProductAdd();

            //ProductUpdate();

            //ProductDelete();

            #endregion

            #region Category
            //GetCategoryById(12);

            //CategoryAdd();

            //CategoryUpdate();

            //CategoryDelete(11);

            //GetAllCategories();

            #endregion

            Console.ReadLine();
        }

        #region ProductMethods
        private static void GetProductById(int id)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine(productManager.GetById(id).ProductName);
        }
        private static void ProductAdd()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            productManager.Add(new Product { ProductName = "Samsung S10 Plus", QuantityPerUnit = "Phone", CategoryId = 1, UnitPrice = 5000, UnitsInStock = 5 });

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void ProductDelete()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            productManager.Delete(new Product { ProductId = 79 });
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
        private static void GetProductsByCategory(int categoryId)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var product = productManager.GetById(categoryId);
            Console.WriteLine(product.ProductName);
        }
        private static void GetAllProducts()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var products = productManager.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }

        }
        #endregion

        #region CategoryMethods
        private static void GetAllCategories()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            var categories = categoryManager.GetAll();
            foreach (var category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }
        }
        private static void GetCategoryById(int id)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            Console.WriteLine(categoryManager.GetById(id).CategoryName);
        }
        private static void CategoryAdd()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.Add(new Category { CategoryName = "Yeni Kategori", Description = "Test" });

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }
        private static void CategoryUpdate()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            categoryManager.Update(new Category { CategoryId = 12, CategoryName = "Yeni Kategori", Description = "Yeni açıklama" });

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName + " / " + category.Description);
            }
        }
        private static void CategoryDelete(int id)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.Delete(new Category { CategoryId = id });

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

        }
        #endregion

    }
}
