using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace DemoMVC.Controllers

{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student std)
        {
            string str0utput = "Hello " + std.Mahocsinh + "-" + std.Hoten + "-" + std.Quequan;
            ViewBag.infoStudent = str0utput;
            return View();

        }

    }
}
