using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.models
{
    internal class Ortoedro
    {
        public Rectangulo[] laterales = new Rectangulo[4];

        public Rectangulo[] bases = new Rectangulo[2];

        public Ortoedro(double anchoBase, double ladoComun, double largoLateral)
        {
            bases[0] = new Rectangulo(anchoBase, ladoComun);
            bases[1] = new Rectangulo(anchoBase, ladoComun);
            laterales[0] = new Rectangulo(ladoComun, largoLateral);
            laterales[1] = new Rectangulo(ladoComun, largoLateral);
            laterales[2] = new Rectangulo(ladoComun, largoLateral);
            laterales[3] = new Rectangulo(ladoComun, largoLateral);
        }
        public double calcularArea()
        {
            double areaBase = bases[0].CalcularArea();
            double areaLateral = laterales[0].CalcularArea();
            return areaBase*2 + areaLateral*4;
        }

        public double calcularVolumen()
        {
            double volumen = bases[0].CalcularArea();
            return laterales[0].getLargo() * volumen;
        }
    }
}
