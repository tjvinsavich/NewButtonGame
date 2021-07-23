﻿using Microsoft.AspNetCore.Mvc;
using NewButtonGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewButtonGame.Controllers
{
    public class ButtonController : Controller
    {
        private readonly IUpdateButton update;

        public ButtonController(IUpdateButton update)
        {
            this.update = update;
        }

        public IActionResult Index()
        {
            update.GenerateBad();
            return View();
        }

        public IActionResult One()
        {
            update.Choice(1);

            return RedirectToAction("Index");
        }

        public IActionResult Two()
        {
            update.Choice(2);

            return RedirectToAction("Index");
        }

        public IActionResult Three()
        {
            update.Choice(3);

            return RedirectToAction("Index");
        }
    }
}
