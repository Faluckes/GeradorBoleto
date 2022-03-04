using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorBoleto
{
    public class Boleto
    {
        public string Data { get; set; }

        public double ValorBoleto { get; set; }

        public string NumeroBanco { get; set; }

        public string NumeroBoleto { get; set; }

        public string NumeroGrande = "00000000";

        private string _valortotal;

        public Boleto(string numerobanco, double valorboleto)
        {
            ValorBoleto = valorboleto;
            NumeroBanco = numerobanco;

            Data = DateTime.Now.ToString("dd/MM/yyyy");


            Random numBoleto = new Random();
            string tempNum = numBoleto.Next(1000, 10000).ToString();

            while (tempNum.Length < 5)
            {
                tempNum = string.Concat("0", tempNum);
            }
            NumeroBoleto = tempNum;
        }
        public string ValorTotal
        {
            get
            {
                return string.Concat(" | " + NumeroBanco + " | " + NumeroBoleto + DateTime.Now.ToString("ddMMyyyy") + NumeroGrande + ValorBoleto.ToString().Replace(",", ""));
            }
            set
            {
                _valortotal = value;
            }
        }


    }

}
