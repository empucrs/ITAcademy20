public abstract class Contas{    
    private DateTime DataDeAbertura{ get; }
    public Contas(){
        DataDeAbertura = DateTime.Now;
    }
    public void saque(int valor){}
    public void deposito(int valor){
    }
    
}