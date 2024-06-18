using _01_Controller.Models;

namespace _01_Controller.Services;

public class ArmazenaCEP : ICEPService
{
    private List<CEPViewModel> listaDeCEPs;

    public ArmazenaCEP(){
        listaDeCEPs = new List<CEPViewModel>();
        listaDeCEPs.Add(new CEPViewModel(){CEP="90470320", logradouro="Rua Primeiro de Janeiro", Bairro="Três Figueiras", Cidade="Porto Alegre", Estado="RS" });
        listaDeCEPs.Add(new CEPViewModel(){CEP="90150040", logradouro="Rua Augusto Melecchi", Bairro="Menino Deus", Cidade="Florianópolis", Estado="SC" });
        listaDeCEPs.Add(new CEPViewModel(){CEP="91740000", logradouro="Avenida da Cavalhada", Bairro="Cavalhada", Cidade="Curitiba", Estado="PR" });
        listaDeCEPs.Add(new CEPViewModel(){CEP="90035005", logradouro="Rua Ramiro Barcelos", Bairro="Independência", Cidade="Birigui", Estado="SP" });
    }
    public void cadastreUmCEP(CEPViewModel novoCEP)
    {
        listaDeCEPs.Add(novoCEP);
    }

    public IEnumerable<CEPViewModel> listaTodosOsCEPs()
    {
        return listaDeCEPs;
    }

    public CEPViewModel? pesquiseUmCEPEspecifico(string CEP)
    {
        throw new NotImplementedException();
    }
}