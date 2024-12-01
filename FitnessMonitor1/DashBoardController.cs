using FitnessMonitor.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FitnessMonitor.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            // Retrieve the logged-in user's name from TempData or a session
            string userName = TempData["UserName"] as string;

            if (userName == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var model = new DashboardViewModel
            {
                UserName = userName,
                GoalCalories = "2000",  // Replace with real data
                Weight = "70kg"         // Replace with real data
            };

            return View(model);
        }
        public IActionResult resouce()
        {
            // Retrieve the logged-in user's name from TempData or a session
            string userName = TempData["UserName"] as string;

            if (userName == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var model = new DashboardViewModel
            {
                UserName = userName,
                GoalCalories = "2000",  // Replace with real data
                Weight = "70kg"         // Replace with real data
            };

            return View(model);
        }

    }
}
