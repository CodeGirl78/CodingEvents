﻿using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
       // GET: /<controller>/
        public IActionResult Index()
        {
            List<Event> events = new List<Event>(EventData.GetAll());

            return View(events);
        }

        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();

            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            Event newEvent = new Event
            {
                Name = addEventViewModel.Name,
                Description = addEventViewModel.Description
            };

            EventData.Add(newEvent);

            return Redirect("/Events");
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }
    }
}