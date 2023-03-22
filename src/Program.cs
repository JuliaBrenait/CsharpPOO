using System.Globalization;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
           

            Console.WriteLine("Digite a cotação do dolar hoje:");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor de reais que você quer comprar");
            double reais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double valorfinal = ConversorMoeda.Conversao(reais, dolar);

            Console.WriteLine(valorfinal);

        }

        
        
    }
}
