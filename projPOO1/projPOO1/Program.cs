using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soma s;
            s = new Soma();
           
            Console.Write("Digite o 1º número: ");
            s.setN1(int.Parse(Console.ReadLine()));

            Console.Write("Digite o 2º número: ");
            s.setN2(int.Parse(Console.ReadLine()));

            s.calcular();

            Console.WriteLine("Resultado da soma de {0} com {1} é {2}", 
                s.getN1(), s.getN2(), s.getResultado());
        }
    }
}
