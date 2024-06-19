using System.Collections.Concurrent;
using _01_Controller.Models;

namespace _01_Controller.Services;

public class ConcorrenteCEP : ICEPService
{
    private ConcurrentDictionary<string, CEPViewModel> listaDeCEPs;

    public ConcorrenteCEP()
    {
        listaDeCEPs = new ConcurrentDictionary<string, CEPViewModel>();
        listaDeCEPs.TryAdd(
            "90470320",
            new CEPViewModel()
            {
                CEP = "90470320",
                logradouro = "Rua Primeiro de Janeiro",
                Bairro = "Três Figueiras",
                Cidade = "Viamão",
                Estado = "RS",
                DataDoCadastro = DateTime.Now,
                numeroQq = 0
            }
        );
        listaDeCEPs.TryAdd(
            "90150040",
            new CEPViewModel()
            {
                CEP = "90150040",
                logradouro = "Rua Augusto Melecchi",
                Bairro = "Menino Deus",
                Cidade = "Viamão",
                Estado = "SC",
                DataDoCadastro = DateTime.Now,
                numeroQq = 1
            }
        );
        listaDeCEPs.TryAdd(
            "91740000",
            new CEPViewModel()
            {
                CEP = "91740000",
                logradouro = "Avenida da Cavalhada",
                Bairro = "Cavalhada",
                Cidade = "Viamão",
                Estado = "PR",
                DataDoCadastro = DateTime.Now,
                numeroQq = 2
            }
        );
        listaDeCEPs.TryAdd(
            "90035005",
            new CEPViewModel()
            {
                CEP = "90035005",
                logradouro = "Rua Ramiro Barcelos",
                Bairro = "Independência",
                Cidade = "Viamão",
                Estado = "SP",
                DataDoCadastro = DateTime.Now,
                numeroQq = 3
            }
        );
    }

    public void cadastreUmCEP(CEPViewModel novoCEP)
    {
        if (!listaDeCEPs.TryAdd(novoCEP.CEP, novoCEP))
        {
            CEPViewModel? aux;
            listaDeCEPs.TryGetValue(novoCEP.CEP, out aux);
            listaDeCEPs.TryUpdate(novoCEP.CEP, novoCEP, aux!);
        }
    }

    public IEnumerable<CEPViewModel> listaTodosOsCEPs()
    {
        return listaDeCEPs.Values;
    }

    public CEPViewModel? pesquiseUmCEPEspecifico(string CEP)
    {
        CEPViewModel? result;
        listaDeCEPs.TryGetValue(CEP, out result);
        return result;
    }

    public bool ExcluaUmCEP(string CEP)
    {
        Console.WriteLine("Excluindo o CEP: " + CEP);
        CEPViewModel? aux;
        return listaDeCEPs.TryRemove(CEP, out aux);
    }

    public bool editarUmCEP(CEPViewModel novoCEP)
    {
        CEPViewModel? aux;
        listaDeCEPs.TryGetValue(novoCEP.CEP, out aux);
        if (aux == null)
            return false;
        return listaDeCEPs.TryUpdate(novoCEP.CEP, novoCEP, aux);
    }
}
