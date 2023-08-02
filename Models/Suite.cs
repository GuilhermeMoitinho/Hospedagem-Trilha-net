using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public double ValorDiaria { get; set; }

        public Suite(double valorDiaria){
            ValorDiaria = valorDiaria;
        }
    }
}