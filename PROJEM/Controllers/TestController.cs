using Microsoft.AspNetCore.Mvc;
using PROJEM.Models;
using System.Collections.Generic; 

namespace PROJEM.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Test()
        {
            var question = new Soru();
            question.ID = 1; 
            question.SoruMetni = "Türkiye'nin başkenti neresidir?";
            question.Secenekler = new List<SecenekModel>
            {
                new SecenekModel { SecenekID = "A", SecenekMetni = "Ankara" },
                new SecenekModel { SecenekID = "B", SecenekMetni = "İstanbul" },
                new SecenekModel { SecenekID = "C", SecenekMetni = "İzmir" },
                new SecenekModel { SecenekID = "D", SecenekMetni = "Antalya" }
            };
            question.DogruCevap = "A";

            return View(question); 
        }
    }
}
