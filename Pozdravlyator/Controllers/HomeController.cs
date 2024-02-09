﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pozdravlyator.Domein;
using Pozdravlyator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pozdravlyator.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly DataMeneger dataMeneger;

        //public HomeController(ILogger<HomeController> logger)
        //{
            //_logger = logger;
        //}

        public HomeController(DataMeneger dataMeneger)
        {
            this.dataMeneger = dataMeneger;
        }

        public IActionResult Index()
        {
            return View(dataMeneger.Birthdays.GetTodayBirthdays());
        }

        public IActionResult AllBirth()
        {
            return View(dataMeneger.Birthdays.GetBirthdays());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
