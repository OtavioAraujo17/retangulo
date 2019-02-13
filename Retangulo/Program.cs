using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();
          
            Console.WriteLine("Entre a largura e altura do rêtangulo: ");
            dados.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine("AREA : " + dados.Area().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("PERIMETRO : " + dados.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("DIAGONAL : " + dados.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
