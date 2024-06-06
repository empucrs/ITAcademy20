namespace _01_nullable;
class Program
{
    private static int? second;
    private static int fifth;
    
    static void Main(string[] args)
    {
        int first=0;
        int xuxu=new();
        int? third=new();
        DateTime? fourth = new();
        int abc=default;
        int? cde=default;
        DateTime fgh = default;
        DateTime? ijk = default;

        Console.WriteLine("Variavel first = "+first);
        Console.WriteLine("Variavel second = "+second);
        Console.WriteLine("Variavel third = "+third);
        Console.WriteLine("Variavel fourth = "+fourth);
        Console.WriteLine("Variavel fifth = "+fifth);
        Console.WriteLine("Variavel xuxu = "+xuxu);
        Console.WriteLine("Variavel i abc = "+abc);
        Console.WriteLine("Variavel i cde = "+cde);
        Console.WriteLine("Variavel dt fgh = "+fgh);
        Console.WriteLine("Variavel dt ijk = "+ijk);

        Console.WriteLine("Variavel fourth.today = "+DateTime.Today);

        Console.WriteLine("fourth ou today = "+(fourth ?? DateTime.Today));        
        fourth=null;
        Console.WriteLine("fourth ou today = "+(fourth ?? DateTime.Today));        
        
    }
}
