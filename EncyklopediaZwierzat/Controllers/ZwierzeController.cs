using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EncyklopediaZwierzat.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace EncyklopediaZwierzat.Controllers
{
    public class ZwierzeController : Controller
    {
        private readonly IZwierzeRepository zwierzeRepository;
        private IHostingEnvironment env;

        public ZwierzeController(IZwierzeRepository zwierzeRepository, IHostingEnvironment env)
        {
            this.zwierzeRepository = zwierzeRepository;
            this.env = env;
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
        public IActionResult Create(string FileName)
        {
            if (!string.IsNullOrEmpty(FileName))
                ViewBag.ImgPath = "/images/" + FileName;

            return View();
        }
        [HttpPost] // wysylane to co wprowadzone w formularzu
        [ValidateAntiForgeryToken]
        public IActionResult Create(Zwierze zwierze)
        {
            if(ModelState.IsValid)
            {
                zwierzeRepository.DodajZwierze(zwierze);
                return RedirectToAction(nameof(Index));
            }
            return View(zwierze);
        }
        public IActionResult Edit(int Id, string FileName)
        {
            var zwierze = zwierzeRepository.PobierzZwierzeOId(Id);
            if (zwierze == null)
                return NotFound();

            if (!string.IsNullOrEmpty(FileName))
                ViewBag.ImgPath = "/images/" + FileName;
            else
                ViewBag.ImgPath = zwierze.ZdjecieUrl;

            return View(zwierze);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Zwierze zwierze)
        {
            if (ModelState.IsValid)
            {
                zwierzeRepository.EdytujZwierze(zwierze);
                return RedirectToAction(nameof(Index));
            }
            return View(zwierze);
        }
        public IActionResult Delete(int Id)
        {
            var zwierze = zwierzeRepository.PobierzZwierzeOId(Id);
            if (zwierze == null)
                return NotFound();

            return View(zwierze); 
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteAccept(int Id, string ZdjecieUrl)
        {
            var zwierze = zwierzeRepository.PobierzZwierzeOId(Id);
                zwierzeRepository.UsunZwierze(zwierze);

            //usuwanie pliku
            if (ZdjecieUrl != null)
            {
                var webRoot = env.WebRootPath;
                var filePath = Path.Combine(webRoot.ToString()+ ZdjecieUrl);
                System.IO.File.Delete(filePath);
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpPost("uploadFile")]
        public async Task<IActionResult> UploadFile(IFormCollection form)
        {
            var webRoot = env.WebRootPath;
            var filePath = Path.Combine(webRoot.ToString() + "\\images\\" + form.Files[0].FileName);

            if(form.Files[0].FileName.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await form.Files[0].CopyToAsync(stream);
                }
            }
            if (Convert.ToString(form["Id"]) == string.Empty || Convert.ToString(form["Id"]) == "0")
                return RedirectToAction(nameof(Create), new { FileName = Convert.ToString(form.Files[0].FileName) });

            return RedirectToAction(nameof(Edit), new { FileName = Convert.ToString(form.Files[0].FileName),id=Convert.ToString(form["Id"]) });
        }
    }
}
