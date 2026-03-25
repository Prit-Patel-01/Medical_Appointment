using Microsoft.AspNetCore.Mvc;

namespace Doctor_Appointment_System.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult Appointments() => View();
        public IActionResult Profile() => View();
        public IActionResult Availability() => View();
        public IActionResult Earnings() => View();

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(string name, string email, string password)
        {
            return RedirectToAction("Login", "Auth");
        }
    }
}