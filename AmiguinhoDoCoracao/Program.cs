using System.Globalization;


namespace AmiguinhoDoCoracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amiguinho amigo;

            amigo = new Amiguinho();

            Console.WriteLine("Nos conte mais sobre seu amiguinho!");
            Console.Write("Qual o nome do seu amiguinho: ");
            amigo.Nome = Console.ReadLine();

            Console.Write("Qual a altura do seu amiguinho: ");
            amigo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(amigo.Altura <= 1.50)
            {
                Console.WriteLine("Seu amiguinho é pequeno na altura, mas grande de coração!");
            }
            else
            {
                Console.WriteLine("Algo de errado não está certo. Todo mundo sabe que o amiguinho tem menos de 1.50!");
            }
        }
    }
}
