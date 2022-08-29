using System;

namespace Inicio
{
    class Salario
    {
        public static void Renderizar()
        {
            Humano h1 = new Humano();
            Humano h2 = new Humano();

            Console.WriteLine("Informe os dados da primeira pessoa ");
            Console.Write("Nome ");
            h1.Nome = Console.ReadLine();
            Console.Write("Infome o salario ");
            h1.Salario = double.Parse(Console.ReadLine());


            Console.WriteLine("ifnrome os dados do seugundo cadidato ");
            Console.Write("Nome ");
            h2.Nome = Console.ReadLine();
            Console.Write("salario ");
            h2.Salario = double.Parse(Console.ReadLine());

            if (h1.Salario > h2.Salario)
            {
                System.Console.WriteLine("quem recebe o maior salario é " + h1.Nome);
            }

            else
            {
                System.Console.WriteLine("quem recebe o maior salario é " + h2.Nome);
            }

            double media = h1.Salario + h2.Salario / 2.0;

            Console.WriteLine("A media de salario da fabrica é de " + media);
        }

    }
}