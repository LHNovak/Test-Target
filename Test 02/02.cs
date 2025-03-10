using System;

class Principal
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (Fibonacci(numero))
        {
            Console.WriteLine("O número {0} pertence à sequência de Fibonacci.",numero);
        }
        else
        {
            Console.WriteLine("O número {0} NÃO pertence à sequência de Fibonacci.",numero);
        }
    }

    static bool Fibonacci(int num)
    {
        if (num == 0 || num == 1) return true; 

        int a = 0, b = 1, c = 0;
        
        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c == num;
    }
}
