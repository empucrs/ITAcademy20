public class ContaEspecial: ContaSimples{
    private double chequeEspecial;
    public ContaEspecial(double credito):base(){
        this.chequeEspecial = credito;
    }
    public override bool saque(double valor){
        if((valor<=0) || (valor>(Saldo+chequeEspecial)))
            return false;        
        listaDeOperacoes.Add(new Operacao(tipoDeOperacao.saque, valor));
        Saldo-=valor;
        return true;
    }

    public double verificaCredito(){
        if(Saldo>0)
            return chequeEspecial;
        return (chequeEspecial+Saldo);
    }
}