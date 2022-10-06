using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiloto
{
    internal class Piloto
    {
        //Propriedade automatica
        //Encapsulamento
        //Get Set
        //Propriedade privada
        //Get e set é publico
        //Encapsulamento

        private string Nome { get; set; }
        
        public string Sobrenome { get; set; }
        
        public string GerarNomeCompletoMaiusculo()
        {
            return $"{Nome}{Sobrenome}".ToUpper();
        }

        public string GerarNomeCompletoMinusculo()
        {
            return $"{Nome}{Sobrenome}".ToLower();
        }

    }
}
