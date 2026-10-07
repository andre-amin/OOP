using System.Globalization;

namespace classesEx05
{
    internal class Aluno
    {
        public string Nome;
        public double NotaPrimeiroTrimestre;
        public double NotaSegundoTrimestre;
        public double NotaTerceiroTrimestre;
        

        public double NotaFinal()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;
            
        }

        

        public override string ToString()
        {

            return $"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}";
            

        }
    }
}
