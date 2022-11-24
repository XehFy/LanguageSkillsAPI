using Microsoft.AspNetCore.Mvc;

namespace LanguageSkillsAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
