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
                userManager.Create(GetUserData(0, collection));
                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }

        public UserDefault GetUserData(int id, IFormCollection collection)
        {
            UserDefault user = new UserDefault();
            user.Id = id;
            user.Nome = collection["Nome"];
            user.Email = collection["Email"];
            user.Senha = collection["Senha"];
            return user;
        }

        public IActionResult Edit(int id) => View(userManager.GetBy(id));

        [HttpPost]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                userManager.Edit(GetUserData(id, collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(int id) => View(userManager.GetBy(id));
        
        [HttpPost]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                userManager.Delete(id);
                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }
    }
}