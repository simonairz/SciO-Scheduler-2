﻿using Microsoft.AspNetCore.Mvc;
using SciO_Scheduler_2.Models;
using System.Diagnostics;

namespace SciO_Scheduler_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }
        public IActionResult Gantt()
        {
            return View();
        }
        public IActionResult timeTablesController() {
            return View(); 
        }
        public IActionResult Gantts()
        {
            return View();
        }

        public IActionResult MyChart()
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