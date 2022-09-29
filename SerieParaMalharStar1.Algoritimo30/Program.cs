using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStar1.Algoritimo30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, produto;

            Console.WriteLine("--- PRODUTO DE 2 ---");
            Console.WriteLine("Digite o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            produto = num1 * num2;
            Console.WriteLine($"O produto é:  {produto}");

            Console.ReadKey();
        }
    }
}
