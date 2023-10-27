using DesigmPattern.IteratorDesigmPattern.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesigmPattern.IteratorDesigmPattern.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();
            visitRouteMover.addvisit(new VisitRoute { CountryName = "Almanya", CityName = "Berlin", VisitPlaceName = "Berlin Kapısı" });
            visitRouteMover.addvisit(new VisitRoute { CountryName = "Fransa", CityName = "Paris", VisitPlaceName = "Eyfel " });
            visitRouteMover.addvisit(new VisitRoute { CountryName = "italya", CityName = "Venedik", VisitPlaceName = "Gondol" });
            visitRouteMover.addvisit(new VisitRoute { CountryName = "İtalya", CityName = "Roma", VisitPlaceName = "Kolezyum" });
            visitRouteMover.addvisit(new VisitRoute { CountryName = "Çek Çumhuriyetti", CityName = "Prag", VisitPlaceName = "Meydan" });

            var iterator = visitRouteMover.CreateIterator();
            while(iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.CountryName + " " + iterator.CurrentItem.CityName + " " + iterator.CurrentItem.VisitPlaceName);

            }
            ViewBag.v = strings;
            return View();
        }
    }
}
