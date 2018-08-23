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

        public IActionResult GetAllByUser(int id)
        {
            ViewBag.Id = id;
            return View(eventManager.GetAllByUser(id));
        }

        public IActionResult Create(int id) => View();

        [HttpPost]
        public IActionResult Create(int id, Event @event)
        {
            try
            {
                eventManager.Create(id, @event);
                Console.WriteLine(id);
                return RedirectToAction("GetAllByUser", "Event", new { Id = id});
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
                return RedirectToAction("GetAllByUser", "Event", new { Id = @event.IdUser });
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
                int idUser = eventManager.Delete(id);
                return  RedirectToAction("GetAllByUser", "Event", new { Id = idUser });
            }
            catch
            {
                return View();
            }
        }

    }
}