﻿using Microsoft.AspNetCore.Mvc;
using PlayGround;
using StringMaster.Models;
using StringsMaster.Models;
using System.Diagnostics;

namespace StringsMaster.Areas.General.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //ChordAPI api = new ChordAPI();
            //chord acorde = await api.GetChord("F");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}