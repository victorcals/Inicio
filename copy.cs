using System;

namespace ListaExercicio
{
    class Ex02
    {
        public static void Renderizar()
        {

            double dolar;
            double euro;
            double peso;


            Console.WriteLine("Digite o valor em real para ser convertido.");
            double real = double.Parse(Console.ReadLine());

            euro = real * 6.14;
            dolar = real * 5.17;
            peso = (1 * 5) / 100;

            Console.WriteLine(euro);
            Console.WriteLine(dolar);
            Console.WriteLine(peso);

        }

    }

}
