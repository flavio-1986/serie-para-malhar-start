using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStar1.Algoritimo32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            
            Console.WriteLine("### Tipo do Valor ###");
            Console.WriteLine("Digite algo para saber o tipo: ");
            x = Console.ReadLine();
            Console.WriteLine($"O é do tipo:  {x.GetType()}");
            
            Console.ReadKey();
        }
    }
}
