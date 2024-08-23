using CalculadoraTestes;

namespace TestExemplo;

public class UnitTest1
{
    public Calculadora ConstruirClass()
    {
        string data = "02/02/2022";
        Calculadora calculadora = new Calculadora("02/02/2022");

        return calculadora;
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        Calculadora calculadora = ConstruirClass();

        int resultadoCalculadora = calculadora.Somar(val1, val2);
        
        Assert.Equal(resultado, resultadoCalculadora);
    }
    
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calculadora = ConstruirClass();

        int resultadoCalculadora = calculadora.Multiplicar(val1, val2);
        
        Assert.Equal(resultado, resultadoCalculadora);
    }
    
    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(10, 5, 5)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calculadora = ConstruirClass();

        int resultadoCalculadora = calculadora.Subtrair(val1, val2);
        
        Assert.Equal(resultado, resultadoCalculadora);
    }
    
    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        Calculadora calculadora = ConstruirClass();

        int resultadoCalculadora = calculadora.Dividir(val1, val2);
        
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calculadora = ConstruirClass();

        Assert.Throws<DivideByZeroException>(
            () => calculadora.Dividir(3, 0)
            );
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calculadora = ConstruirClass();
        
        calculadora.Somar(1, 2);
        calculadora.Somar(5, 5);
        calculadora.Somar(18, 14);
        calculadora.Somar(74, 40);

        var lista = calculadora.Historico();
        
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}