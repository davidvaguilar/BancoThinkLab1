using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoThinkLab1
{
    internal class Credito
    {
        public string Rut { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string DireccionParticular { get; set; }
        public double Sueldo { get; set; }
        public string DireccionLaboral { get; set; }
        public double MontoCredito { get; set; }
        public int CantidadCuotas { get; set; }

        public Credito() {
            this.Sueldo = 100000;
            this.MontoCredito = 160000;
            this.CantidadCuotas = 50;
        }

        public float calcularCredito()
        {
            double maximoCredito = this.Sueldo * 1.5;
            float interesMensual = 0;

            Console.WriteLine(maximoCredito);
            if( maximoCredito >= this.MontoCredito ) 
            {
                Console.WriteLine(this.CantidadCuotas);
                if( this.CantidadCuotas > 48)
                {
                    interesMensual = 3f / 12f;
                } 
                else {
                    interesMensual = 1.85f / 12f;
                }
            }
            return interesMensual;

        }



    }
}
