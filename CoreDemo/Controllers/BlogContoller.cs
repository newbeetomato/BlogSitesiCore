using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
