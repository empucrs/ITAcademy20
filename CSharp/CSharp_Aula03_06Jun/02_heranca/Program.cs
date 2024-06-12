//public Animal(string n, string e, int i, float p)
Animal a = new("caturrita", "aves aves", 147, 0.5f);
Console.WriteLine(a.print());

Cachorro c = new();
Console.WriteLine(c.print());

c = new("Spike", "canes shiuwawa", 1, 0.001f, "shiwawa shiwawas");
Console.WriteLine(c.print());

c.umTeste();