using System;
namespace Inicio
{
    class lacos

    {
        public static void Renderizar()
        {
            Console.WriteLine("digite quantos numero vai ler");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("valor : #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("soma = " + soma);

        }
    }
}