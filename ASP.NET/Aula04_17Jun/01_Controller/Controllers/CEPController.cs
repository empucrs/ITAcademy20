using _01_Controller.Models;
using _01_Controller.Services;
using Microsoft.AspNetCore.Mvc;

public class CEPController : Controller
{
    private ICEPService myLocalLink;
    public CEPController(ICEPService ics){
        myLocalLink=ics;
    }

    public IActionResult listCEP(){
        return View(myLocalLink.listaTodosOsCEPs());
    }

}
