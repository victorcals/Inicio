using System;

namespace Inicio
{
    class Course
    {
        public static void Renderizar()
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("dados do candidato");
            Console.Write("nome");
            p1.Nome = Console.ReadLine();
            Console.Write("idade");
            p1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("segundo cadidato");
            Console.Write("nome");
            p2.Nome = Console.ReadLine();

            Console.Write("idade");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("o mais velhor é " + p1.Nome);
            }

            else
            {
                Console.WriteLine("o mais velho é " + p2.Nome);
            }

        }
    }
}