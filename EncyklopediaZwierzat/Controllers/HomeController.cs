using EncyklopediaZwierzat.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
