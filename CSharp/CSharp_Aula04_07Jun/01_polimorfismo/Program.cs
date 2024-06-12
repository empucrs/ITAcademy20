namespace _01_polimorfismo;
class Program
{
    static void Main(string[] args)
    {

        var a = new Animal("Animalzinho", "animal", 7, 1.2f);
        testeQualquer(a as Animal);
        if(a is Animal){
            Console.WriteLine("a é um animal");
            (a as Animal)!.emiteUmSom();
            (a as Animal)!.emiteUmSom();            
        }
        if(a is Cachorro){
            Console.WriteLine("a é um Cachorro");
            (a as Animal)!.emiteUmSom();
            (a as Cachorro)!.emiteUmSom();
        }
        if(a is Gato){
            Console.WriteLine("a é um Gato");
            (a as Animal)!.emiteUmSom();
            (a as Gato)!.emiteUmSom();
        }

        a = new Cachorro("Animalzinho", "animal", 7, 1.2f, "canes canes");
        testeQualquer(a as Animal);
        if(a is Animal){
            Console.WriteLine("a é um animal");
            (a as Animal)!.emiteUmSom();
            (a as Animal)!.emiteUmSom();
        }
        if(a is Cachorro){
            Console.WriteLine("a é um Cachorro");
            (a as Animal)!.emiteUmSom();
            (a as Cachorro)!.emiteUmSom();
        }
        if(a is Gato){
            Console.WriteLine("a é um Gato");
            (a as Animal)!.emiteUmSom();
            (a as Gato)!.emiteUmSom();
        }

        a = new Gato("Animalzinho", "animal", 7, 1.2f, true, true);
        testeQualquer(a as Animal);
        if(a is Animal){
            Console.WriteLine("a é um animal");
            (a as Animal)!.emiteUmSom();
            (a as Animal)!.emiteUmSom();
        }
        if(a is Cachorro){
            Console.WriteLine("a é um Cachorro");
            (a as Animal)!.emiteUmSom();
            (a as Cachorro)!.emiteUmSom();
        }
        if(a is Gato){
            Console.WriteLine("a é um Gato");
            (a as Animal)!.emiteUmSom();
            (a as Gato)!.emiteUmSom();
            Console.WriteLine((a as Gato)!.toCarro());
        }
    }

    public static void testeQualquer(Animal a){

        if(a is Gato){
            Console.WriteLine("Gato");
        }
        else if(a is Cachorro){
            Console.WriteLine("Cachorro");
        }
        else{
            Console.WriteLine("Animal");
        }

    }
}
