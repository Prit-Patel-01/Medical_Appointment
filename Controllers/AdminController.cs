using Microsoft.AspNetCore.Mvc;

namespace Doctor_Appointment_System.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult DoctorVerification() => View();
        public IActionResult Reports() => View();
        public IActionResult UserManagement() => View();

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(string name, string email, string password)
        {
            return RedirectToAction("Login", "Auth");
        }
    }
}