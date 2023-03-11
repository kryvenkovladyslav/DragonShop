using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IManufacturerService manufacturerService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IManufacturerService manufacturerService)
        {
            this.manufacturerService = manufacturerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manufacturers()
        {
            var manufacturerIcons = new List<ManufacturerIconModel>();

            var manufacturers = manufacturerService.GetAll(false);

            foreach (var manufacturer in manufacturers)
            {
                manufacturerIcons.Add(new ManufacturerIconModel 
                { Name = manufacturer.Name, ImagePath = manufacturer.ImagePath, ID = manufacturer.ID });
            }

            return View(manufacturerIcons);
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
