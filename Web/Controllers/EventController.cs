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

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                eventManager.Create(GetEventData(0, collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public Event GetEventData(int id, IFormCollection collection)
        {
            Event myEvent = new Event();
            myEvent.Id = id;
            myEvent.EventName = collection["eventName"];
            myEvent.EventDescription = collection["eventDescription"];
            myEvent.EventLocation = collection["eventLocation"];
            myEvent.EventDate = collection["eventDate"];
            myEvent.EventModerator = collection["eventModerator"];
            return myEvent;
        }

        public IActionResult Edit(int id) => View(eventManager.GetBy(id));

        [HttpPost]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                eventManager.Edit(GetEventData(id, collection));
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