public class Animal
{

    private string nome;
    public string Nome{
        get{return nome;}        
    }
    private string especie;
    public string Especie{
        get{return especie;}
    }
    private int idade;
    public int Idade{
        get{return idade;}        
    }
    private float peso;
    public float Peso{
        get{return peso;}        
    }

    public Animal(string n, string e, int i, float p){
        nome=n;
        especie=e;
        idade=i;
        peso=p;
    }

    public virtual string print(){        
        string texto="Animal\n";
        texto+="  Nome:"+nome+"\n";
        texto+="  Especie:"+especie+"\n";
        texto+="  Idade:"+ idade.ToString()+"\n";
        texto+="  Peso:"+peso.ToString()+"\n";
        return texto;
    }

    public void umTeste(){
        Console.WriteLine("Uma proposta de sobrescrita");
    }
    
    public void umNovoTeste(){
        Console.WriteLine("Uma proposta de sobrescrita novo teste");
    }
    
}