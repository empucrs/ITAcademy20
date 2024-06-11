using System.ComponentModel;

enum diasDaSemana { [Description("Um valor para segunda")]Segunda, terca, quarta, quinta, sexta, sabado, domingo };
enum test{
    a,
    b,
    c=b,
    d=1
}

class Program{
    public static void Main(string[] args){
        HashSet<int> hsInt = new HashSet<int>();
        List<int> lstInt = new List<int>();

        for(int i=0; i<1000; i++){
            hsInt.Add(i);
            lstInt.Add(i);
        }

        lstInt.Add(101);
        lstInt.AddRange(hsInt);
 
        diasDaSemana diaAtual = diasDaSemana.Segunda;
        Console.WriteLine($"{diaAtual} e numericamente diz-se {(int)diaAtual} => {diaAtual.ToString()} ==> {GetEnumDescription1(diaAtual)}");

        diaAtual = diasDaSemana.terca;
        Console.WriteLine($"{diaAtual} e numericamente diz-se {(int)diaAtual}");

        test xuxu=test.a;
        Console.WriteLine($"{xuxu} e numericamente diz-se {(int)xuxu}");
        xuxu=test.b;
        Console.WriteLine($"{xuxu} e numericamente diz-se {(int)xuxu}");
        xuxu=test.c;
        Console.WriteLine($"{xuxu} e numericamente diz-se {(int)xuxu}");
        xuxu=test.d;
        Console.WriteLine($"{xuxu} e numericamente diz-se {(int)xuxu}");


    }

public static string GetEnumDescription1(Enum value)
{
    if (value == null) { return ""; }

    var type = value.GetType();
    var field = type.GetField(value.ToString());
    var custAttr = field?.GetCustomAttributes(typeof(DescriptionAttribute), false);
    DescriptionAttribute? attribute = custAttr?.SingleOrDefault() as DescriptionAttribute;
    return attribute == null ? value.ToString() : attribute.Description;
}
}