public class Cliente
{
    private string nome;
    private string[] vet = {"Edson", "Ifarraguirre", "Moreno"};
    public string propriedadeNome{
        get{ return nome + " Moreno"; }
        set { nome=value; }
    }

    public static void imprimeAlgo(){
        Console.WriteLine("Estou imprimindo algo");
    }

    public void imprimeAE(){
        imprimeAlgo(this);
    }

    public static void imprimeAlgo(Cliente c){
        Console.WriteLine("Estou imprimindo algo - " + c?.propriedadeNome);
    }

    public string this[int i]{
        //get { return nome + " --> " + i;}
        //get { return nome + " Moreno --> " + (i+1);}
        get { return  vet[i%3]; }
        set { vet[i%3] = value; }
    }

    //public string vaisaber[int i]{
        //get { return nome + " Moreno --> " + (i+1);}
    //}

    public int tamanho{
        get{ return nome.Length;}
    }
/*
    // NÃO É PERMITIDO POIS É UMA LINGUAGEM SEGURA... APENAS LINGUAGENS "NÃO SEGURAS" PERMITE ISSO
    public void* bruxaria{
        get{ return (void *) &nome; }
    }
*/
    private decimal limiteCredito;
    private uint clienteID;

    public Cliente():this("um nome", 11M, 171)
    {
        Console.WriteLine("-2-");
    }

/*
    public Cliente(string s, decimal d){        
        nome=s;
        limiteCredito=d;
        clienteID=0;
    }
*/    
    public Cliente(int p1, out int p2):this(){
        Console.WriteLine("-1-");
        p2=10;
    }

    public Cliente(int p1, int p2){
        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
    public Cliente(bool boooo, string outracoisa):this(outracoisa, boooo){}

    public Cliente(string s, bool b){
        nome=s;
        if(b) limiteCredito=100M;        
        else    limiteCredito=1;
        clienteID=191;
    }


    //public Cliente(string s="Lorenzo aniversariante de ontem", decimal d=1.95M, uint u=1){
    public Cliente(string s, decimal d=1.95M, uint u=10){
        Console.WriteLine("-3-");
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