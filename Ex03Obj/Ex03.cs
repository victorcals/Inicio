using System;

namespace Inicio
{
    class Ex03
    {
        public static void Renderizar()
        {

            Retangulo ret = new Retangulo();
            Console.WriteLine("Informe a Largura do triangulo: ");
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Altura do triangulo: ");
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + ret.Area().ToString("f2"));
            System.Console.WriteLine("Perimetro " + ret.Perimetro().ToString("f2"));
            System.Console.WriteLine("Diagonal " + ret.Diagonal().ToString("f2"));





        }
    }
}