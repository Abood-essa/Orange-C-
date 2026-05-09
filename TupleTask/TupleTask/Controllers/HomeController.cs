using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TupleTask.Models;

namespace TupleTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var student = new Student
            {
                Id = 1,
                Name = "Abd",
                Age = 21
            };

            var course = new Course
            {
                CourseId = 101,
                CourseName = "ASP.NET Core MVC",
                InstructorName = "Mr. Ahmad"

            };

            var data = Tuple.Create(student, course);

            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
