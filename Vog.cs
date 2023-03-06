using System;

class Vog
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string:");
        string frase = Console.ReadLine();
        string vogais = GetVogais(frase);
        Console.WriteLine("As vogais na string digitada são: " + vogais);
    }

    //Nesta função iremos pegar somente as vogais e mostrar para o usuário, percorrendo toda a string
    static string GetVogais(string frase)
    {
        string resultado = "";
        string vogais = "aeiouAEIOU";
        foreach (char c in frase)
        {
            if (vogais.IndexOf(c) >= 0)
            {
                resultado += c;
            }
        }
        return resultado;
    }
}