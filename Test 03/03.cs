using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Principal
{
    static void Main()
    {
        string caminhoArquivo = "faturamento.json";
        string json = File.ReadAllText();
        List<FaturamentoDiario> faturamento = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(json);

        var diasComFaturamento = faturamento.Where(d => d.Valor > 0).ToList();

        if (!diasComFaturamento.Any())
        {
            Console.WriteLine("Não há dados de faturamento disponíveis.");
            return;
        }

        double menorFaturamento = diasComFaturamento.Min(d => d.Valor);
        double maiorFaturamento = diasComFaturamento.Max(d => d.Valor);

        double mediaMensal = diasComFaturamento.Average(d => d.Valor);

        int diasAcimaDaMedia = diasComFaturamento.Count(d => d.Valor > mediaMensal);

        Console.WriteLine($"Menor faturamento: R$ {menorFaturamento:F2}");
        Console.WriteLine($"Maior faturamento: R$ {maiorFaturamento:F2}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}

class FaturamentoDiario
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}