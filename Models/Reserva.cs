
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
               throw new Exception("ERRO: A capacidade da suite é menor que o número de hospedes");
            
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
           
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            
            if (DiasReservados >= 10)
            {
                valor = 0;
                valor = DiasReservados * Suite.ValorDiaria;
                decimal teste = valor / 10;
                valor = valor - teste;
                
            }

            return valor;
        }
    }
}