using System;

namespace Inicio
{
    class Utilizar
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine("entre os dados do produto");
            Console.Write("nome: ");
            p.Nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("dados do produto: " + p);
            Console.WriteLine();

            Console.Write("digite o numero de prodrutos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            System.Console.WriteLine();
            System.Console.WriteLine("dados att: " + p);
            System.Console.WriteLine();



            Console.Write("digite o numero de prodrutos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            System.Console.WriteLine();
            System.Console.WriteLine("dados att: " + p);
            System.Console.WriteLine();
        }
    }
}