using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string Masinhvien, string Hoten)

    {
        string str0utput = "Xin chào " + Masinhvien + "-" + Hoten;
        ViewBag.Message = str0utput;
        return View();
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
    public IActionResult Demo()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Demo(string FullName)
    {
        string str0utput = "xin chao " + FullName;
        ViewBag.Message = str0utput;
        return View();
    }


}
