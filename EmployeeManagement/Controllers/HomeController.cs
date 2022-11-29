using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Components.Web;
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
 
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(3), 
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
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