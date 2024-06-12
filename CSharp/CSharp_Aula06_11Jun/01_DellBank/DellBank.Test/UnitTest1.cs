namespace DellBank.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        ContaSimples cs = new();
        cs.deposito(100);
        Assert.Equal(100, cs.Saldo);
    }
    [Fact]
    public void Test2()
    {
        ContaSimples cs = new();
        cs.saque(100);
        Assert.NotEqual(100, cs.Saldo);
    }
    [Fact (Skip ="Agora não")]
    public void Test3()
    {
        ContaSimples cs = new();
        cs.deposito(100);
        cs.saque(75);
        Assert.Equal(25, cs.Saldo);
    }

    [Theory]
    [InlineData(150)]
    [InlineData(-150)]
    [InlineData(1.99)]
    [InlineData(-1.57)]
    public void Test(double valor)
    {
        ContaSimples cs = new();
        if(valor<0){
            cs.saque(valor*-1);
            Assert.Equal(0, cs.Saldo);
        }
        else{
            cs.deposito(valor);
            Assert.NotEqual(0, cs.Saldo);
        }
    }

    [Theory]
    [InlineData(150, 150)]
    [InlineData(-150, 0.0001)]
    [InlineData(1.99, 1.99)]
    [InlineData(-1.57, 0)]
    public void TestV2(double valor, double esperado)
    {
        ContaSimples cs = new();
        if(valor<0){
            cs.saque(valor*-1);
            Assert.Equal(esperado, cs.Saldo,2);
        }
        else{
            cs.deposito(valor);
            Assert.Equal(esperado, cs.Saldo);    
        }
    }

}