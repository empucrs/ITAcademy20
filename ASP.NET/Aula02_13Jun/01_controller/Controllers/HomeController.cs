using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _01_controller.Models;

namespace _01_controller.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public void Acao01(){
        Console.WriteLine("Uma acao interna no meu servidor");
    }

    public string Acao02(){
        return "Um texto gerado internamente ao meu controlador";
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
