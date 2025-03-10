using System;

class Principal
{
    static void Main()
    {
        var faturamentos = new (string Estado, double Valor)[]
        {
            ("SP", 67836.43),
            ("RJ", 36678.66),
            ("MG", 29229.88),
            ("ES", 27165.48),
            ("Outros", 19849.53)
        };

        double faturamentoTotal = 0;
        foreach (var faturamento in faturamentos)
        {
            faturamentoTotal += faturamento.Valor;
        }

        Console.WriteLine("Percentual de representação por estado:");
        foreach (var faturamento in faturamentos)
        {
            double percentual = (faturamento.Valor / faturamentoTotal) * 100;
            Console.WriteLine("{0}: {0}%",faturamento.Estado,percentual);
        }
    }
}