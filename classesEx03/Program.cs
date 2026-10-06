using System.Globalization;
namespace classesEx03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(R);

        }
    }
}
