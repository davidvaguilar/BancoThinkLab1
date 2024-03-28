using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoThinkLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Inicializado");
            Credito c1 = new Credito();

            Console.WriteLine("Monto del Credito es : "+c1.MontoCredito);
            Console.WriteLine("El total del Credito va ser : "+c1.calcularCredito());
            Console.WriteLine(c1.CantidadCuotas+" Cuotas de : " + c1.calcularCredito() / c1.CantidadCuotas);
        }
    }
}
