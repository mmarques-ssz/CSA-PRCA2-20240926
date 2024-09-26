using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret;
            ret = new Retangulo();

            ret.setBase(5);
            ret.setAltura(4);
            ret.calcularArea();
            Console.WriteLine(ret.getArea());
        }
    }
}
