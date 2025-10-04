using Microsoft.AspNetCore.Mvc;

namespace SmithSwimmingSchool.Controllers
{
    public class Swimmer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddVistor(Swimmer swimmer)
        {
            db.Add(swimmer);
            db.SaveChanges();
            return View();
        }
    }
}
