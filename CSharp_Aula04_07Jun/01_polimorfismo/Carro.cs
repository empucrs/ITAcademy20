public class Carro{
    private int ano;
    private string marca;
    public Carro(int ano, string marca){
        this.ano=ano;
        this.marca=marca;
    }
    public override string ToString(){
        return "Carro\n  Ano:"+this.ano+"\n  Marca:"+this.marca+"\n\n";
    }
}