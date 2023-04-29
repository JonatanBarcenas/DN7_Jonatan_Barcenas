using GymManager.AplicationServices.Members;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    public class HomeController : Controller
    {

        
        public HomeController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
