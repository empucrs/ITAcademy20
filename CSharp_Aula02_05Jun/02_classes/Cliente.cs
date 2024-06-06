public class Cliente
{
    private string nome;
    private decimal limiteCredito;
    private uint clienteID;

    public Cliente(string s, decimal d, uint u){
        nome=s;
        limiteCredito=d;
        clienteID=u;
    }

    public string getName(){
        return nome;
    }
    public void setName(string s){
        nome=s;
    }

    public decimal getLimiteCredito(){
        return limiteCredito;
    }
    public void setLimiteCredito(decimal d){
        limiteCredito+=d;
    }

    public void metodo01(string entrada, out string saida){
        saida = nome+ " -> " + entrada;
    }

    public string metodo02(ref string palavra){
        palavra = nome+ " -> Gratiluz" + palavra;
        return "O retorno do metodo 2 está ok";
    }

    public void metodo03(params int[] valores){

        
        Console.WriteLine("O método recebeu "+valores.Length+" parametros");
        foreach (int item in valores)
            Console.Write(item+", ");
        Console.WriteLine();
    }



    
}