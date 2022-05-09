using Microsoft.AspNetCore.Mvc;
using NewProject1.Services;

namespace NewProject1.Controllers
{
    public class myRatesController : Controller
    {

        private IRateService rateService;

        public myRatesController()
        {
            rateService = new RateService();
        }

        public IActionResult Index()
        {
            return View(rateService.GetAll());
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string Name, int Score, string Comment, string Time)
        {
            rateService.Create(Name, Score, Comment, Time);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string Name, int Score, string Comment, string Time)
        {
            rateService.Edit(id, Name, Score, Comment, Time);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            rateService.Delete(id);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Detailes(int id)
        {
            return View(rateService.Get(id));
        }


    }
}
