using System;
namespace Inicio
{
    class UsarAqui
    {
        public static void Renderizar()
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Informe os dados do funcionario");

            Console.Write("Nome ");
            func.Nome = Console.ReadLine();

            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + func);

            Console.WriteLine();
            System.Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            int aumento = int.Parse(Console.ReadLine());
            func.AumentarSalario(aumento);

            System.Console.WriteLine("Dados att: " + func);


        }
    }
}