using Microsoft.AspNetCore.Mvc;

namespace PROJEM.Controllers
{
    public class UrunlerController : Controller
    {
        public IActionResult MacAnalizleri()
        {
            return View();
        }
        
        
        public IActionResult OyuncuAnalizleri()
        {
            return View();
        }
        
        
        public IActionResult TaktikAnalizler()
        {
            return View();
        }
    }
}