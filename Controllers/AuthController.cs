using Microsoft.AspNetCore.Mvc;

namespace Doctor_Appointment_System.Controllers
{
    public class AuthController : Controller
    {
        // LOGIN PAGE
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // LOGIN POST
        [HttpPost]
        public IActionResult Login(string email, string password, string role)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Email and Password required.";
                return View();
            }

            switch (role)
            {
                case "Patient":
                    return RedirectToAction("Dashboard", "Patient");

                case "Doctor":
                    return RedirectToAction("Dashboard", "Doctor");

                case "Admin":
                    return RedirectToAction("Dashboard", "Admin");

                default:
                    ViewBag.Error = "Invalid role selected.";
                    return View();
            }
        }

        // REGISTER ROLE SELECT PAGE
        public IActionResult Register()
        {
            return View();
        }

        // FORGOT PASSWORD
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(string email)
        {
            return RedirectToAction("ResetPassword");
        }

        // RESET PASSWORD
        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(string password)
        {
            return RedirectToAction("Login");
        }
    }
}