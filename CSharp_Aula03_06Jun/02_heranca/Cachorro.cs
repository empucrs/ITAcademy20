public class Cachorro: Animal{
    private string subespecie;
    private string nomeCientifico;
    public string Subespecie{
        get{return subespecie;}
    }
    public Cachorro(string n, string e, int i, float p, string s):base(n, e, i, p){
        subespecie="sei la";
        nomeCientifico=Especie+" - "+subespecie;
    }
    public Cachorro():this("Cachorro", "canes canes", 8, 23f, "sei la"){ }

    public override string print(){
        string texto;
        texto=base.print();
        texto+=Nome+"\n";
        texto+="  --> MAS eu sou um cachorro";
        texto+="    Minha subespécie é "+ subespecie;
        texto+="    meu nome cientifico é "+ nomeCientifico;
        return texto;
    }

    //alternativa ao uso do virtual/overide
    public new void umTeste(){
        Console.WriteLine("A sobreescrita do teste");
    }

    // alternativa funciona, mas adiciona warning
    public void umNovoTeste(){
        Console.WriteLine("A sobreescrita do novo teste");
    }

}