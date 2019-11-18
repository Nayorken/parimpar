using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parimpar
{
    class par
    {
        private double valor; 
        public string recebe
        {
            set
            {
                valor = Convert.ToDouble(value);   
            }
        }
        public string envia
        {
            get
            {
                if (valor%2==1) return "O número " + valor + " é Impar.";
                else return "O número " + valor + " é Par.";
            }
        }

    }
}
