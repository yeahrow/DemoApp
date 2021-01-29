using DemoApp.MVC.Models;
using DemoApp.MVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        public HomeController(ILogger<HomeController> logger,
            ISingletonService singletonService,
            IScopedService scopedService,
            ITransientService transientService)
        {
            _logger = logger;

            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ServicesLifetime()
        {
            ViewData["singletonServiceId"] = _singletonService.ServiceId;
            ViewData["scopedServiceId"] = _scopedService.ServiceId;
            ViewData["transientServiceId"] = _transientService.ServiceId;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
