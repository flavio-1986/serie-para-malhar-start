using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStar1.Alongamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comentario de uma linha
            //Alongamento
            //Variável - Atribuiçãp - Entrada
            
            /*
             Comentario de Bloco
             */
            Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();
            Console.WriteLine("Digite a media: ");
                double media = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());
                string mensagem = idade < 18 ? "maior" : "menor";
            Console.WriteLine($"{nome} Sua media foi {media}");
            Console.WriteLine($"{nome} Voce é {mensagem.ToUpper()} ");
            Console.ReadKey();
        }
    }
}
