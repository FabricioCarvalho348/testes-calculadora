namespace CalculadoraTestes;

public class Calculadora
{
    private List<string> HistoricoNumerosCalculados;
    private string data;
    
    public Calculadora(string data)
    {
        HistoricoNumerosCalculados = new List<string>();
        this.data = data;
    }
    
    public int Somar(int val1, int val2)
    {
        int resultado = val1 + val2;

        HistoricoNumerosCalculados.Insert(0, "Resultado: " + resultado + "- data " + data);
        return resultado;
    }
    
    public int Subtrair(int val1, int val2)
    {
        int resultado = val1 - val2;
        
        HistoricoNumerosCalculados.Insert(0, "Resultado: " + resultado + "- data " + data);
        return resultado;
    }
    
    public int Multiplicar(int val1, int val2)
    {
        int resultado = val1 * val2;
        
        HistoricoNumerosCalculados.Insert(0, "Resultado: " + resultado + "- data " + data);
        return resultado;
    }
    public int Dividir(int val1, int val2)
    {
        int resultado = val1 / val2;
        
        HistoricoNumerosCalculados.Insert(0, "Resultado: " + resultado + " - data " + data);
        return resultado;
    }

    public List<String> Historico()
    {
        HistoricoNumerosCalculados.RemoveRange(3, HistoricoNumerosCalculados.Count - 3);

        return HistoricoNumerosCalculados;
    }
}