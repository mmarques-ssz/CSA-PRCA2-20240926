using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO1
{
    internal class Soma
    {
        private int n1;
        private int n2;
        private int resultado;

        public void setN1(int n1)
        {
            this.n1 = n1;
        }
        public void setN2(int n2)
        {
            this.n2 = n2;
        }
        public int getN1()
        {
            return this.n1;
        }
        public int getN2()
        {
            return this.n2;
        }
        public int getResultado()
        {
            return this.resultado;
        }
        public void calcular()
        {
            this.resultado = this.n1 + this.n2;
        }
    }
}
