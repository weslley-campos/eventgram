using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business.Business;
using Model.Models;
using Microsoft.AspNetCore.Http;

namespace Web.Controllers
{
    public class UserController : Controller
    {
        UserManager userManager;

        public UserController() => userManager = new UserManager();

        public IActionResult Index() => View(userManager.GetAll());

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                UserDefault user = new UserDefault();
                user.Nome = collection["Nome"];
                user.Email = collection["Email"];
                user.Senha = collection["Senha"];
                userManager.Create(user);
                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }

        
    }
}