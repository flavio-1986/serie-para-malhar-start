using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoeAirlines.Entities;
using VoeAirlines.Entities.Enums;

namespace VoeAirlines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aeronave aero = new Aeronave();
            /*
             * Aeronave: é a Classe
             * aero: é o objeto da classe
             * =: é o que atribui
             * new: é o operador de instânciação (concretização de uma classe)
             * Aeronave(): chamada ao construtor
             */

            //Interface com Usuario
            Console.WriteLine("Informe o fabricante: ");
            var entradaFabricante = Console.ReadLine();
            Console.WriteLine("Informe a Matricula: ");
            var entradaMatricula = Console.ReadLine();
            Console.WriteLine("Informe o Modelo: ");
            var entradaModelo = Console.ReadLine();
            Console.WriteLine("Informe o Código: ");
            var entradaCodigo = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de passageiros: ");
            var entradaQtePassageiros = int.Parse (Console.ReadLine());

            //Atribuicoes 
            aero.Fabricante = entradaFabricante;
            aero.Matricula = entradaMatricula;
            aero.Modelo = entradaModelo;
            aero.Codigo = entradaCodigo;
            aero.Capacidade = entradaQtePassageiros;

            //Noticia
            Console.WriteLine($"Jatinho Executivo do Messi é um {aero.Modelo} -" +
                $" {aero.Codigo} Fabricado pelo {aero.Fabricante}" +
                $" de matricula {aero.Matricula}.");
            Console.ReadKey();

    }
    }
}
