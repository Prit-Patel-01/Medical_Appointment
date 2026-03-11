using Microsoft.AspNetCore.Mvc;

namespace Medical_Appointment.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
