using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.Controllers
{
    public class Blog : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository()); 
        public IActionResult Index()
        {
            var values =bm.GetBlogListWithCategory();
            return View(values);

        }
        public IActionResult BlogDetails(int id)
        {
            return View();
        }
    }
}
