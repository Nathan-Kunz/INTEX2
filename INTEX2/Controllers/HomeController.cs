using INTEX2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //summary page
        public IActionResult Summary()
        {
            return View();
        }

        //supervised and unsupervised pages
        public IActionResult Supervised()
        {
            return View();
        }
        public IActionResult Unsupervised()
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


//public class UsersController : Controller
//{
//    private readonly UserManager<ApplicationUser> _userManager;

//    public UsersController(UserManager<ApplicationUser> userManager)
//    {
//        _userManager = userManager;
//    }

//    public async Task<IActionResult> CreateAdminUser(string email, string password)
//    {
//        // Create new user
//        var user = new ApplicationUser { UserName = email, Email = email };
//        var result = await _userManager.CreateAsync(user, password);

//        if (!result.Succeeded)
//        {
//            // Handle error
//        }

//        // Add user to "Admin" role
//        result = await _userManager.AddToRoleAsync(user, "Admin");

//        if (!result.Succeeded)
//        {
//            // Handle error
//        }

//        return Ok();
//    }
//}
