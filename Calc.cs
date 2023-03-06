using System;

class Calc{

    static void Main(string[] args)
    {
        double num1, num2, resultado;
        char operacao;

        Console.WriteLine("Bem-vindo à calculadora!\n");

        Console.Write("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Digite '+' para soma");
        Console.WriteLine("Digite '-' para subtração");
        Console.WriteLine("Digite '*' para multiplicação");
        Console.WriteLine("Digite '/' para divisão");
        Console.WriteLine("Digite '%' para resto da divisão\n");
        Console.WriteLine("Agora escolha a operação desejada: "); 
        
        operacao = char.Parse(Console.ReadLine());


        switch (operacao)
        {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine("O resultado da soma é: " + resultado);
                break;

            case '-':
                resultado = num1 - num2;
                Console.WriteLine("O resultado da subtração é: " + resultado);
                break;

            case '*':
                resultado = num1 * num2;
                Console.WriteLine("O resultado da multiplicação é: " + resultado);
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero!");
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado da divisão é: " + resultado);
                }
                break;

            case '%':
                resultado = num1 % num2;
                Console.WriteLine("O resultado do resto da divisão é: " + resultado);
                break;

            default:
                Console.WriteLine("Operação inválida!");
                break;
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}