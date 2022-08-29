using System;

namespace Inicio
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto = 0;

        public double Imposto = 0;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
            + ", "
            + SalarioLiquido().ToString("f2");
        }
    }

}