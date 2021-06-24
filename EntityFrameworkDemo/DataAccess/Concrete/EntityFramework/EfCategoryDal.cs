using EntityFrameworkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.DataAccess.Concrete.EntityFramework
{
    class EfCategoryDal : ICategoryDal
    {
        public void Add(Category category)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public void Delete(Category category)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Categories.Remove(context.Categories.SingleOrDefault(c => c.CategoryId == category.CategoryId));
                context.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Categories.SingleOrDefault(c => c.CategoryId == id);
            }
        }

        public void Update(Category category)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var categoryToUpdate = context.Categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
                categoryToUpdate.CategoryName = category.CategoryName;
                categoryToUpdate.Description = category.Description;
                context.SaveChanges();
            }
        }
    }
}
