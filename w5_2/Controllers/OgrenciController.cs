using Microsoft.AspNetCore.Mvc;
using w5_2.Models;

namespace w5_2.Controllers
{
    public class OgrenciController : Controller
    {
        static List<Ogrenci> ogrenciList = new List<Ogrenci>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Duzenle(string id)
        {
            TempData["Id"] = id;
            return View(ogrenciList.Find(ogr => ogr.OgrNumara.Equals(id)));
        }

        public IActionResult Kayit()
        {
            return View();
        }

        public IActionResult Sil(string id)
        {
            TempData["Id"] = id;
            return View(ogrenciList.Find(ogr => ogr.OgrNumara.Equals(id)));
        }

        public IActionResult Listele()
        {
            return View(ogrenciList);
        }

        [HttpPost]
        public IActionResult Kaydedildi(Ogrenci ogr)
        {
            ogrenciList.Add(ogr);

            return View("Listele", ogrenciList);
        }

        [HttpPost]
        public IActionResult Silindi()
        {
            string tmp = TempData["Id"].ToString();
            Ogrenci ogr = ogrenciList.Find(ogr => ogr.OgrNumara.Equals(tmp));
            ogrenciList.Remove(ogr);

            return View("Listele", ogrenciList);
        }

        [HttpPost]
        public IActionResult Duzenlendi(Ogrenci ogr)
        {
            string tmp = TempData["Id"].ToString();
            int index = ogrenciList.FindIndex(ogr => ogr.OgrNumara.Equals(tmp));
            ogrenciList[index] = ogr;

            return View("Listele", ogrenciList);
        }
    }
}
