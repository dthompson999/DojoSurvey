using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(string name, string location, string language, string comment)
        {
            // In the future, we'd like to redirect
            // but for now we'll return a view
            // return Redirect("/");
            // or
            // return RedirectToAction("Index");
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View("Results");
        }
    }
}