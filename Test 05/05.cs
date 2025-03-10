using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string entrada = Console.ReadLine();

        string invertida = InverterString(entrada);

        Console.WriteLine("String invertida: {0}",invertida);
    }

    static string InverterString(string texto)
    {
        char[] caracteres = new char[texto.Length];

        for (int i = 0; i < texto.Length; i++)
        {
            caracteres[i] = texto[texto.Length - 1 - i];
        }

        return new string(caracteres);
    }
}
