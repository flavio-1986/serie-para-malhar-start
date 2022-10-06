using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStar1.Algoritimo33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("****Antecesso & sucessoR***");
            Console.WriteLine();
            Console.WriteLine("Informe um numero entre 1 e 999: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1 - 1} é o seu Antecessor.");
            Console.WriteLine($"{num1 + 1} é o seu Sucessor.");
            Console.ReadKey();
        }
    }
}
