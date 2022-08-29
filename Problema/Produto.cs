using System;
namespace Inicio
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return Nome
            + ", $"
            + Preco.ToString("f2")
            + ", "
            + Quantidade
            + " Unidade , Total: $ "
            + ValorEmEstoque().ToString("f2");
        }
    }
}