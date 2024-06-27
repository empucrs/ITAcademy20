using _01_Controller.Models;

namespace _01_Controller.Services;

public interface ICEPService
{
    IEnumerable<CEPViewModel> listaTodosOsCEPs();
    CEPViewModel? pesquiseUmCEPEspecifico(string CEP);
    void cadastreUmCEP(CEPViewModel novoCEP);
    bool ExcluaUmCEP(string CEP);
}
