public class Gato: Animal{
    private bool sobeEmArvore;
    private bool selvagem;
    public Gato(string n, string e, int i, float p, bool sa, bool s):base(n, e, i, p){
        sobeEmArvore=sa;
        selvagem=s;
    }
    public override string print(){
        string texto;
        texto=base.print();
        texto+=Nome+"\n";
        texto+="  Miaaaaau";
        texto+="    "+(!selvagem?"Não sou":"Sou")+" selvagem ";
        texto+="    Eu "+(sobeEmArvore?"subo":"NÃO subo")+" em árvore";
        return texto;
    }

    public new void emiteUmSom(){
        Console.WriteLine("miaaaaaaaaaaaaaaaaaau");
    }

    public Carro toCarro(){
        return new Carro(this.Idade, this.Nome);
    }    
}