
public class Program
{
public static void Main(string[] args){
    Console.WriteLine("Hello, World!");

    ArrayPilha ap = new ArrayPilha();
    Object o = new Object();
    ap.empilha(o);
    Console.WriteLine(ap.topo?.ToString() ?? "Objeto não existe");

    ArrayPilha? xuxu=null;

    Console.WriteLine(imprimeAlgo(xuxu));
}
public static string imprimeAlgo(IPilha? refer){
        return refer?.topo?.ToString() ?? "vazio";
}    
}
