
using System;

namespace Inicio
{
    class Retangulo

    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Largura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Largura * Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}