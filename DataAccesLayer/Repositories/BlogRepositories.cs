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
    public class BlogRepositories : IBlogDal
    {
        Context c = new Context();

        public void AddBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
