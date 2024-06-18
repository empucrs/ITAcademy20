using _01_Controller.Models;

namespace _01_Controller.Services;

public class ArmazenaCEP : ICEPService
{
    private List<CEPViewModel> listaDeCEPs;

    public ArmazenaCEP(){
        listaDeCEPs = new List<CEPViewModel>();
        listaDeCEPs.Add(new CEPViewModel(){CEP="90470320", logradouro="Rua Primeiro de Janeiro", Bairro="Três Figueiras", Cidade="Porto Alegre", Estado="RS", DataDoCadastro=DateTime.Now, numeroQq=0 });
        listaDeCEPs.Add(new CEPViewModel(){CEP="90150040", logradouro="Rua Augusto Melecchi", Bairro="Menino Deus", Cidade="Florianópolis", Estado="SC", DataDoCadastro=DateTime.Now, numeroQq=1 });
        listaDeCEPs.Add(new CEPViewModel(){CEP="91740000", logradouro="Avenida da Cavalhada", Bairro="Cavalhada", Cidade="Curitiba", Estado="PR", DataDoCadastro=DateTime.Now, numeroQq=2 });
        listaDeCEPs.Add(new CEPViewModel(){CEP="90035005", logradouro="Rua Ramiro Barcelos", Bairro="Independência", Cidade="Birigui", Estado="SP", DataDoCadastro=DateTime.Now, numeroQq=3 });
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