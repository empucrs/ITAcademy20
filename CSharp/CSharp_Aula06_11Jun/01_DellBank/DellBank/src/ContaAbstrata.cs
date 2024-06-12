using System.Data.Common;

public abstract class ContaAbstrata: IContas{
    private static uint contaIDsequencial=1;
    private uint contaID;
    public DateTime DataDeAbertura{ get; protected set;}
    protected List<Operacao> listaDeOperacoes;
    public double Saldo{ get; protected set; }

    public ContaAbstrata(){
        contaID = contaIDsequencial;
        contaIDsequencial++;
        DataDeAbertura = DateTime.Now;
        listaDeOperacoes = new List<Operacao>();
        Saldo=0;
    }
    public abstract bool saque(double valor);
    public abstract bool deposito(double valor);

    public string extrato()
    {
        string result="Conta "+this.contaID+"\n";
        result+=$"Saldo: R${this.Saldo}\n";
        result+="Extrato:\n";
        foreach (var operacao in listaDeOperacoes)
            result+="  "+operacao.ToString()+"\n";
        return result;
    }
}