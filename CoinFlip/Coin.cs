using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class Coin{

        private string ladoSorteado;

        public string LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }

        public Coin(){
            
        }

        public String Flip(){
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                LadoSorteado = "cara";
            }
            else{
                LadoSorteado = "coroa";
            } 

            // LadoSorteado = random.Next(2) == 0 ? "Cara" : "Coroa";  
            return (ladoSorteado);
        }
    }
}
