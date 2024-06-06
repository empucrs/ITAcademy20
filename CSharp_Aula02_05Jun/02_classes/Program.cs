namespace _02_classes;
class Program
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente("Edson Moreno", 1.99M, 260);
        Console.WriteLine(c);

        c=new("Edson Moreno", 1.98M, 261);
        Console.WriteLine(c);  

        string a, b;
        a="Prof.";
        c.metodo01(a,out b);        
        Console.WriteLine(b);

        a="Dell computers";
        Console.WriteLine(a);
        Console.WriteLine(c.metodo02(ref a));
        Console.WriteLine(a);

        int[] listaDeValores = new int[5] {1,2,3,4,5};
        c.metodo03(listaDeValores);
        c.metodo03(1,2);
        c.metodo03(1);
        c.metodo03(9,1,3,2,1,4,65,76,1,23,0);

    }
}
