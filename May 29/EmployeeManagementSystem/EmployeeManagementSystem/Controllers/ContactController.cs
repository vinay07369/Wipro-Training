using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Thank you for contacting us!";
                ModelState.Clear();
                return View();
            }
            return View(model);
        }
    }
}
