using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult MemberOut()
        {
            return View();
        }

        public IActionResult MemberIn()
        {
            return View();
        }

    }
}
