using System;

namespace Inicio
{
    class ObjUm
    {
        public static void Renderizar()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("entra com as medidas do triangulo x");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());



            Console.WriteLine("entra com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());


            double areaX = x.Area();


            double areaY = y.Area();

            Console.WriteLine("area de x " + areaX.ToString("f2"));
            Console.WriteLine("area de x " + areaY.ToString("f2"));


            if (areaX > areaY)
            {
                Console.WriteLine("x é maior");
            }

            else
            {
                Console.WriteLine("maior é y");
            }
        }

    }

}
