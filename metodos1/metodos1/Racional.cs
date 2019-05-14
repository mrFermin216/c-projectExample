using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos1
{
    class Racional
    {
        public int numerador { get; set; }
        public int denominador { get; set; }

        public Racional (int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", numerador, denominador);
        }
    }
}
