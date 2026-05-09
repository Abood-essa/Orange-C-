using Microsoft.AspNetCore.Mvc;
using Validation.Data;
using Validation.Models;

namespace Validation.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {

            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            _context.Employees.Add(employee);
            _context.SaveChanges();

            TempData["Success"] = "Employee added successfully";

            return RedirectToAction("Create");
        }



    }
}
