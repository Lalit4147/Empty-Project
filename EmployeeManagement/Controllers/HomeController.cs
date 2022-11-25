using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private  readonly IEmployeeRepository _employeeRepository;
        private readonly ILogger<HomeController> _logger;
        public HomeController(IEmployeeRepository employeeRepository, ILogger<HomeController> logger)
        {
            _employeeRepository = employeeRepository;
            _logger = logger;
        }
 
        public String Index()
        {
          return  _employeeRepository.GetEmployee(2).Name;
        }

        public JsonResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(2);
            return Json(model);
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