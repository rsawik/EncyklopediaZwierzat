using EncyklopediaZwierzat.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EncyklopediaZwierzat.Controllers
{
    [Authorize]
    public class OpiniaController : Controller
    {
        private readonly IOpiniaRepository opiniaRepository;

        public OpiniaController(IOpiniaRepository opiniaRepository)
        {
            this.opiniaRepository = opiniaRepository;
        }
        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinia opinia)
        {
            if(ModelState.IsValid)
            {
                this.opiniaRepository.DodajOpinie(opinia);
                return RedirectToAction("OpiniaWyslana");
            }
            return View(opinia);
        }

        public IActionResult OpiniaWyslana()
        {
            return View();
        }
    }
}