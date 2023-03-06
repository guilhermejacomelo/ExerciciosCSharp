using System;

class QuantVogais
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string:");
        string frase = Console.ReadLine();
        int contador = ContarVogais(frase);
        Console.WriteLine("A string digitada contém " + contador + " vogais.");
    }

    static int ContarVogais(string frase)
    {
        int contador = 0;
        string vogais = "aeiouAEIOU";
        foreach (char c in frase)
        {
            if (vogais.IndexOf(c) >= 0)
            {
                contador++;
            }
        }
        return contador;
    }
}