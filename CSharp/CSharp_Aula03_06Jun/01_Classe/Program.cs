Cliente c = new Cliente("Edson", 1.99M, 106);
Console.WriteLine(c.propriedadeNome);

c.propriedadeNome = "Francisco";
Console.WriteLine(c.propriedadeNome);

Console.WriteLine(c.tamanho);


Console.WriteLine(c[0]);
Console.WriteLine(c[1]);
Console.WriteLine(c[2]);
Console.WriteLine(c[3]);

c[3]="Antonio";
Console.WriteLine(c[0]);
Console.WriteLine(c[1]);
Console.WriteLine(c[2]);
Console.WriteLine(c[3]);

c=new();
Console.WriteLine(c.propriedadeNome);

c=new("Qualquer nome");
Console.WriteLine(c.propriedadeNome);

c=new("Teste", true);
Console.WriteLine(c.propriedadeNome);

c=new("teste");

int a=1;
int b=2;
c=new(a,out b);

Console.WriteLine(b);


Cliente.imprimeAlgo();
Cliente.imprimeAlgo(null);
Cliente.imprimeAlgo(c);

c.imprimeAE();