using Microsoft.AspNetCore.Mvc;

namespace Doctor_Appointment_System.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult FindDoctor() => View();
        public IActionResult BookAppointment() => View();
        public IActionResult BookingConfirm() => View();
        public IActionResult DoctorProfile() => View();
        public IActionResult AppointmentHistory() => View();
        public IActionResult Notifications() => View();
        public IActionResult Payment() => View();
        public IActionResult Profile() => View();

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(string name, string email, string password)
        {
            return RedirectToAction("Login", "Auth");
        }
    }
}