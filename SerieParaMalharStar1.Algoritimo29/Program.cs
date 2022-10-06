using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStar1.Algoritimo29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soma = 0;
            var subtracao = 0;
            var multiplicacao = 0;
            var divisao = 0.0m;

            Console.WriteLine("*Digite o nome do professor*");
            string nome = Console.ReadLine();
            Console.WriteLine($"Seu nome é: {nome}");
            //var materiais =  new [] {"C#", "Banco de dados"};
            int[] numeros = new int[10];

            numeros[0] = 15;
            numeros[1] = 37;
            numeros[2] = 19;
            numeros[3] = 73;
            numeros[4] = 81;
            numeros[5] = 24;
            numeros[6] = 66;
            numeros[7] = 92;
            numeros[8] = 17;
            numeros[9] = 22;

            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[3]);
            Console.WriteLine(numeros[4]);
            Console.WriteLine(numeros[5]);
            Console.WriteLine(numeros[6]);
            Console.WriteLine(numeros[7]);
            Console.WriteLine(numeros[8]);
            Console.WriteLine(numeros[9]);

            int op;
            do
            {
                Console.WriteLine("1-Listar 2-Processar 3-Somar 4-Multiplicação 5-Divisão 6-Subtrair 7-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Mostrando Valores: ");

                        for (var i = 0; i < numeros.Length; i++)
                        {
                            Console.WriteLine(numeros[i]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Processando Valores");
                        foreach (var item in numeros)
                        {
                            soma = soma + item;
                            subtracao = subtracao - item;
                            multiplicacao = multiplicacao * item;
                            divisao = Convert.ToDecimal(divisao) / (item);
                        }
                        break;
                    case 3:
                        Console.WriteLine($"A soma é: {soma}");
                        { }
                        break;
                    case 4:
                        Console.WriteLine($"A subtração é: {subtracao}");
                        { }
                        break;
                    case 5:
                        Console.WriteLine($"A multiplicação é: {multiplicacao}");
                        { }
                        break;
                    case 6:
                        Console.WriteLine($"A divisão é: {divisao}");
                        { }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Programa finalizado.");
                            Console.ReadKey();
                        }
                        break;
                }

            } while (op != 7);
        }
    }
}

/*var soma = numeros[9] + numeros[8];
var subtracao = numeros[9] - numeros[8];
var multiplicacao = numeros[9] * numeros[8];
var divisao = Convert.ToDecimal(numeros[9]) / (numeros[8]);

Console.WriteLine($"A soma é: {soma}");
Console.WriteLine($"A subtração é: {subtracao}");
Console.WriteLine($"A multiplicação é: {multiplicacao}");
Console.WriteLine($"A divisão é: {divisao}");*/


