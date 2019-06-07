using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncyklopediaZwierzat.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EncyklopediaZwierzat.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            
                return View(loginVM);

            var user = await this.userManager.FindByNameAsync(loginVM.UserName);

            if(user != null)
            {
                var result = await this.signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Nazwa użytkownika lub hasło nie właściwe");

            return View(loginVM);
        }
        // GET: /<controller>/
        public IActionResult Register()
        {
            return View(new LoginVM());
        }

       [HttpPost]
       public async Task<ActionResult> Register(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = loginVM.UserName };
                var result = await this.userManager.CreateAsync(user, loginVM.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(loginVM); // przekazywanie tych danych co wypelnil
        }
        [HttpPost]
        public async Task<ActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
