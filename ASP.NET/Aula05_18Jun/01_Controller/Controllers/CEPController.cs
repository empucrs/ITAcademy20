using Microsoft.AspNetCore.Mvc;
using _01_Controller.Models;
using _01_Controller.Services;

public class CEPController : Controller
{
    private ICEPService myService;

    public CEPController(ICEPService ics)
    {
        myService = ics;
    }

    public IActionResult lista()
    {
        return View(myService.listaTodosOsCEPs());
    }

    public IActionResult cadastra(string? id)
    {
        if (id == null)
            return View();
        else
        {
            CEPViewModel? cvm = myService.pesquiseUmCEPEspecifico(id);
            return View(cvm);
        }
    }

    public IActionResult editar(string? id)
    {
        if (id == null)
            return View();
        else
        {
            CEPViewModel? cvm = myService.pesquiseUmCEPEspecifico(id);
            return View(cvm);
        }
    }

    public IActionResult excluir(string? id)
    {
        Console.WriteLine("Excluindo o CEP: " + id);
        myService.ExcluaUmCEP(id);
        return View("lista", myService.listaTodosOsCEPs());
    }

    [HttpPost]
    public IActionResult cadastra(CEPViewModel novoCEP)
    {
        if (ModelState.IsValid)
            myService.cadastreUmCEP(novoCEP);
        return View("lista", myService.listaTodosOsCEPs());
    }
}
