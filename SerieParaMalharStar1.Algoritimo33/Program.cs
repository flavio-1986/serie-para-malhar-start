using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharSar1.Algoritmo33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;

            Console.WriteLine("+++ Antecessor e Sucessor +++");
            Console.WriteLine("Informe um numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{num1 - 1} é Antecessor");
            Console.WriteLine($"{num1 + 1} é Sucessor");
            Console.ReadKey();

        }
    }
}
