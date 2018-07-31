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
                userManager.Create(GetUserData(collection));
                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }

        public UserDefault GetUserData(IFormCollection collection)
        {
            UserDefault user = new UserDefault();
            user.Nome = collection["Nome"];
            user.Email = collection["Email"];
            user.Senha = collection["Senha"];
            return user;
        }

        public IActionResult Edit(int id) => View(userManager.GetById(id));

        [HttpPost]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                userManager.Edit(GetUserData(collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
    }
}