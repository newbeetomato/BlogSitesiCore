using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.Controllers
{
    public class BlogContoller : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository()); 
        public IActionResult Index()
        {
            var values =bm.GetList();
            return View(values);

        }
    }
}
