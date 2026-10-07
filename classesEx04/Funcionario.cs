using System.Globalization;

namespace classesEx04
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            porcentagem = porcentagem / 100;
            double aumento = SalarioBruto * porcentagem;
            SalarioBruto += aumento;
        }

        public override string ToString()
        {
            return ($"{Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
