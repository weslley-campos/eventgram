using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Business;
using Model.Models;

namespace Web.Controllers
{
    public class EventController : Controller
    {
        EventManager eventManager;

        public EventController() => eventManager = new EventManager();

        public IActionResult Index() => View(eventManager.GetAll());

        public IActionResult GetAllByUser(int UserId) => View(eventManager.GetAllByUser(UserId));

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Event @event)
        {
            try
            {
                eventManager.Create(@event);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Edit(int id) => View(eventManager.GetBy(id));

        [HttpPost]
        public IActionResult Edit(int id, Event @event)
        {
            try
            {
                eventManager.Edit(@event);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(int id) => View(eventManager.GetBy(id));

        [HttpPost]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                eventManager.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}