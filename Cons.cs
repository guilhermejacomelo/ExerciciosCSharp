using System;

class Cons
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string:");
        string frase = Console.ReadLine();
        string consoantes = GetConsoantes(frase);
        Console.WriteLine("As consoantes na string digitada são: " + consoantes);
    }

    static string GetConsoantes(string frase)
    {
        string resultado = "";
        string vogais = "aeiouAEIOU";
        foreach (char c in frase)
        {
            if (Char.IsLetter(c) && vogais.IndexOf(c) < 0)
            {
                resultado += c;
            }
        }
        return resultado;
    }
}