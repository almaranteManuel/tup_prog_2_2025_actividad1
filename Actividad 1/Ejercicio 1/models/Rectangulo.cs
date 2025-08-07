using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.models
{
    internal class Rectangulo
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public Rectangulo(double ancho, double largo)
        {
            Ancho = ancho;
            Largo = largo;
        }

        public string Describir()
        {
            return "Rectangulo";
        }

        public double CalcularArea()
        {
            return Ancho * Largo;
        }

        public double getLargo()
        {
            return Largo;
        }
    }
}
