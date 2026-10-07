using System.Globalization;

namespace classesEx05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaSegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaTerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            if(aluno.NotaFinal() >= 90.00)
            {
                Console.WriteLine(aluno);
                Console.Write("APROVADO");
            }
            else
            {
                double diferenca = 60.00 - aluno.NotaFinal();
                Console.WriteLine(aluno);
                Console.WriteLine("REPROVADO");
                Console.Write($"FALTARAM {diferenca.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
            

            
            
        }
    }
}
