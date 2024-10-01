using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMvc.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string Mahocsinh, string Hoten)
    {
        string strResult = "Hello" + Mahocsinh + " - " + Hoten;
        ViewBag.Student = strResult;
        return View();
    }
}
