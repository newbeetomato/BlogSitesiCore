using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concreat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class CategoryRepositories : ICategoryDal
    {
        Context c=new Context();
        public void AddCategory(Category category)
        {
            c.Categories.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
           return c.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }
    }
}
