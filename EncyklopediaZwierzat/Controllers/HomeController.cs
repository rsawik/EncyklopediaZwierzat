using EncyklopediaZwierzat.Models;
using EncyklopediaZwierzat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EncyklopediaZwierzat.Controllers
{
    public class HomeController : Controller
    {
        private readonly IZwierzeRepository _zwierzeRepository; //8
        // GET: /<controller>/

        public HomeController(IZwierzeRepository zwierzeRepository) // gdy tworzony jest HomeController ma być przekazywany IZwierzeRepo //9
        {
            _zwierzeRepository = zwierzeRepository;
        }

        public IActionResult Index()
        {
            var zwierzeta = _zwierzeRepository.PobierzWszystkieZwierzeta().OrderBy(s => s.Nazwa); //11 posortowane zwierzaki po nazwie

            var homeVM = new HomeVM()
            {
                Tytul = "Encyklopedia Zwierząt",
                Zwierzeta = zwierzeta.ToList()
            };

            return View(homeVM); //12 przekazanie do widoku tytul i liste samochodow
        }
        public IActionResult Szczegoly(int id)
        {
            var zwierze = _zwierzeRepository.PobierzZwierzeOId(id);
            if (zwierze == null)
                return NotFound();


            return View(zwierze);
        }
    }
}
