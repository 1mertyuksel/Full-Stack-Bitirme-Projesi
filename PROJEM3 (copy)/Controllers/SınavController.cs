// Controllers/SınavController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROJEM.Data;
using System.Collections.Generic;
using System.Linq;

namespace PROJEM.Controllers
{
    public class SınavController : Controller
    {
        private readonly DataContext _dbContext;

        public SınavController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Sınav()
        {
            var sorular = _dbContext.TümSorular.Include(s => s.Secenekler).ToList();
            return View(sorular);
        }

        [HttpPost]
        public IActionResult TestSonucunuKaydet(List<Soru> sorular)
        {
            int dogruSayisi = 0;
            int yanlisSayisi = 0;

            for (int i = 0; i < sorular.Count; i++)
            {
                
                var dogruCevap = sorular[i].DogruCevap;
                var kullaniciCevap = sorular[i].KullaniciCevabi;

                if (string.IsNullOrEmpty(kullaniciCevap))
                {
                    continue;
                }

                if (string.Equals(kullaniciCevap, dogruCevap, StringComparison.OrdinalIgnoreCase))
                {
                    dogruSayisi++;
                }
                else
                {
                    yanlisSayisi++;
                }
            }

            TempData["DogruSayisi"] = dogruSayisi;
            TempData["YanlisSayisi"] = yanlisSayisi;

            TempData["Mesaj"] = "Test sonuçları başarıyla kaydedildi.";
            return RedirectToAction("Sonuc");
        }

        public IActionResult Sonuc()
        {
            return View();
        }
    }
}
