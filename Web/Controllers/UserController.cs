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
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            try
            {
                userManager.Create(user);
                return RedirectToAction("Index", "Login");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Edit(int id) => View(userManager.GetBy(id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, User user)
        {
            try
            {
                userManager.Edit(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(int id) => View(userManager.GetBy(id));
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, User user)
        {
            try
            {
                userManager.Delete(user.Id);
                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }

        public ActionResult Login() => RedirectToAction("Index", "Login");
    }
}