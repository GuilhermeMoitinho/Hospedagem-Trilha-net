using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}