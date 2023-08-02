using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedagemHotel.Models
{
    public class Reserva
    {
        List<Pessoa> Pessoas = new List<Pessoa>();
        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        public Reserva() {}

        public Reserva(List<Pessoa> pessoa,Suite suite, int diasreservados){
            Suite = suite; 
            Pessoas = pessoa;
            DiasReservados = diasreservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            if(Suite.Capacidade >= hospedes.Count){
                Pessoas = hospedes;
            }else{
                System.Console.WriteLine("Suite esta lotada!");
            }
        }   

        public void CadastrarSuite(Suite suite){
            suite.Capacidade = Suite.Capacidade;
            suite.ValorDiaria = Suite.ValorDiaria;
            suite.TipoSuite = Suite.TipoSuite;
        }

        public int ObterQntHospedes(){
            return Pessoas.Count;
        }

        public double ValorDiaria(){
            double ValorTotal;
            if(DiasReservados > 10){
                 ValorTotal = (Suite.ValorDiaria * DiasReservados) - Suite.ValorDiaria * DiasReservados * 0.1;
            }else{
                ValorTotal = Suite.ValorDiaria * DiasReservados;
                }
            return ValorTotal;
            
        }

        public override string ToString()
        {
           
            StringBuilder stringBuilder = new StringBuilder();
             stringBuilder.AppendLine("Quantidade de hospedes: "+ObterQntHospedes());
             System.Console.WriteLine();
             foreach(Pessoa i in Pessoas){
                stringBuilder.AppendLine("Nome: "+i.Nome);
                stringBuilder.AppendLine("Sobrenome: "+i.Sobrenome);
                stringBuilder.AppendLine("Valor da diaria: "+ValorDiaria());
                System.Console.WriteLine();
            }
           
            return stringBuilder.ToString();
        }
    }
}