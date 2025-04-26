using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class Vitorias
    {
        private int vitoriaSequencia;
        private int totalVitorias;

        public int VitoriaSequencia { get => vitoriaSequencia; set => vitoriaSequencia = value; }
        public int TotalVitorias { get => totalVitorias; set => totalVitorias = value; }

        public Vitorias(){

        }

        // Contador de Vitórias em sequência e o total de vitórias
        public Boolean Sequencia(int ladoSorteado, int ladoEscolhido){
            VitoriaSequencia = 0;
            if (ladoSorteado == ladoEscolhido)
            {
                TotalVitorias++;
                VitoriaSequencia++;
                return true;
            }
            else {
                VitoriaSequencia = 0;
                return false;
            }
        }
    }
}
