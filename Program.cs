using System;
using System.Threading;
class Pti
{
    static void Main()
    {
        string resposta = "s";

        do
        {
            Console.Clear();
            Console.Write("Digite o preço da Gasolina: R$ ");
            double gasolina = double.Parse(Console.ReadLine());
            Console.Write("Digite o preço do Etanol: R$ ");
            double etanol = double.Parse(Console.ReadLine());
            double vantagem = (etanol / gasolina);

            if (vantagem == 0.70)
            {
                Console.WriteLine("Tanto faz abastecer com Gasolina ou Etanol!");
            }
            else if (vantagem < 0.70)
            {
                Console.WriteLine("Abasteça com Etanol!");
            }
            else
            {
                Console.WriteLine("Abasteça com Gasolina!");
            }
            Console.Write("Deseja fazer um novo cáculo? [S] ou [N]? ");
            resposta = Console.ReadLine().ToLower();
        } while (resposta == "s");
        Console.Clear();
        Thread.Sleep(500);
        Console.WriteLine("Encerrando o Programa...");
        Thread.Sleep(500);
        Console.WriteLine("Volte Sempre");
    }
}