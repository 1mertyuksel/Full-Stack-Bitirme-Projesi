using Microsoft.AspNetCore.Mvc;

namespace PROJEM.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Forum()
        {
            return View();
        }
    }
}
