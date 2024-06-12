public class ContaSimples: ContaAbstrata{
    public ContaSimples():base(){}
    public override bool saque(double valor){
        if((valor<=0) || (valor>Saldo))
            return false;        
        listaDeOperacoes.Add(new Operacao(tipoDeOperacao.saque, valor));
        Saldo-=valor;
        return true;
    }
    public override bool deposito(double valor){
        if(valor<=0)
            return false;
        listaDeOperacoes.Add(new Operacao(tipoDeOperacao.deposito, valor));
        Saldo+=valor;
        return true;
    }
    
}