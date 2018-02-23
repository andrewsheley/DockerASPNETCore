using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DockerASPNETCore.Models;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace DockerASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;

        public HomeController(IHostingEnvironment hostingEnvironment, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            _configuration = configuration;
        }

        



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewData["Environment"] = _hostingEnvironment.EnvironmentName;
            ViewData["ConnectionString"] = _configuration.GetConnectionString("DBConnection");

            Core.Employee e = new Core.Employee() {
                EmployeeID = -1,
                LastName = "Sheley",
                FirstName = "Andrew",
                MiddleName = "Scott",
                ParkingLogID = 2,
            };



            return View();
        }

        public IActionResult Contact()
        {

            throw new Exception("Oh No!!!!! We got a problem!!!!!!");

            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
