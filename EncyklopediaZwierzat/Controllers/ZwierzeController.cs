using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncyklopediaZwierzat.Models;
using Microsoft.AspNetCore.Mvc;



namespace EncyklopediaZwierzat.Controllers
{
    public class ZwierzeController : Controller
    {
        private readonly IZwierzeRepository zwierzeRepository;

        public ZwierzeController(IZwierzeRepository zwierzeRepository)
        {
            this.zwierzeRepository = zwierzeRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var zwierzeta = zwierzeRepository.PobierzWszystkieZwierzeta();

            return View(zwierzeta);
        }
        public IActionResult Details(int id)
        {
            var zwierze = zwierzeRepository.PobierzZwierzeOId(id);
            if(zwierze == null)
            {
                return NotFound();
            }
            return View(zwierze);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
