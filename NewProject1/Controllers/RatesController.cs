using Microsoft.AspNetCore.Mvc;
using NewProject1.Models;

namespace NewProject1.Controllers
{
    public class RatesController : Controller
    {
        private static List<Rate> rates = new List<Rate>();

        public RatesController()
        {
            rates = new List<Rate>();
            rates.Add(new Rate() { Id = 1, Score = 2, Name = "yosi", Comment = "Nice", Time = "10:20" });
            rates.Add(new Rate() { Id = 2, Score = 2, Name = "yosi", Comment = "Nice", Time = "10:20" });
            rates.Add(new Rate() { Id = 3, Score = 2, Name = "yosi", Comment = "Nice", Time = "10:20" });
            rates.Add(new Rate() { Id = 4, Score = 2, Name = "yosi", Comment = "Nice", Time = "10:20" });
        }

        public IActionResult Index()
        {
            return View(rates);
        }

        public IActionResult List()
        {
            return View(rates);

        }

        public IActionResult Detailes(int id)
        {
            Rate rate = rates.Find(x => x.Id == id); 
            return View(rate);
        }



    }
}
