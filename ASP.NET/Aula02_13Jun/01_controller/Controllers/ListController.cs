using Microsoft.AspNetCore.Mvc;

public class ListController: Controller{

    private List<string> listaDeValores;

    public ListController()    {
        listaDeValores=new();
        listaDeValores.Add("Edson");
        listaDeValores.Add("Edson");
        listaDeValores.Add("Edson");
        listaDeValores.Add("Edson");
    }

    public List<string> Index(){
        return listaDeValores;

    }
    
}