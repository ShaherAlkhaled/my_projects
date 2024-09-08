using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Vue.Controllers
{
    public class FishesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
