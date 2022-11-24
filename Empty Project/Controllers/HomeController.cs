using Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empty_Project.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeRepo _emprepo;
        public HomeController(EmployeeRepo employeerepo)
        {
            _emprepo = employeerepo; 
        }
      
        public string Index()
        {
           return _emprepo.GetEmployee(1).name;
        }
    }
}
