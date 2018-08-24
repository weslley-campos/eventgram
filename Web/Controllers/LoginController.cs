using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Business.Business;

namespace Eventgram.Controllers
{
    public class LoginController : Controller
    {
        LoginManager loginManager = new LoginManager();

        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult Validate(IFormCollection values)
        {
            string email = values["Email"];
            string senha = values["Senha"];
            int? userId = loginManager.Validate(email, senha);

            if (userId != -1) return RedirectToAction("MyEvents", "Event", new { id = userId });

            return RedirectToAction(nameof(Index));
        }

        [ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            return RedirectToAction("Create", "User");
        }
    }
}