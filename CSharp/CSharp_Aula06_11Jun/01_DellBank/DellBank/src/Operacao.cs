public enum tipoDeOperacao{saque, deposito};
public class Operacao
{
    public tipoDeOperacao Tipo{get; private set;}
    public double Valor {get; private set;}
    public DateTime MomentoDaOperacao {get; private set;}

    public Operacao(tipoDeOperacao tipo, double valor)
    {
        this.Tipo = tipo;
        this.Valor = valor;
        this.MomentoDaOperacao = DateTime.Now;
    }

    public override string ToString(){
        return "Operação: [" + this.Tipo+"; "+this.Valor+"; "+this.MomentoDaOperacao.ToString()+"]";
    }

}