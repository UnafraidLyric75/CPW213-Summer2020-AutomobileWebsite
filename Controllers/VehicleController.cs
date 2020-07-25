using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomobileWebsite.Data;
using AutomobileWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutomobileWebsite.Controllers
{
    public class VehicleController : Controller
    {
        private VehicleContext _context;

        public VehicleController(VehicleContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Vehicle> vehicles = _context.Vehicles.ToList();

            return View(vehicles);
        }
    }
}
