using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStar1.Algoritimo31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, media;

            Console.WriteLine("=== Média Aritimetica ===");
            Console.WriteLine("Digite o primeiro valor: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            num3 = double.Parse(Console.ReadLine());
            media = (num1 + num2 + num3) / 3;
            Console.WriteLine($"A média é: {media}");

            Console.ReadKey();
        }
    }
}
