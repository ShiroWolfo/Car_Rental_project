using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Utility;

namespace Car_Rental_project.Controllers
{
    [Authorize(Roles = Enums.ConstUserRoles.Employee)]
    public class EmployeeDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }




    }
}
