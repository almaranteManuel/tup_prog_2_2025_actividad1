//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Drawing.Text;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ejercicio_1.models
//{
//    internal class Ortoedro
//    {
//        public Rectangulo[] laterales = new Rectangulo[4];
//        public Rectangulo[] bases = new Rectangulo[2];

//        public Ortoedro(double anchoBase, double ladoComun, double largoLateral)
//        {
//            bases[0] = new Rectangulo(anchoBase, ladoComun);
//            bases[1] = new Rectangulo(anchoBase, ladoComun);
//            laterales[0] = new Rectangulo(ladoComun, largoLateral);
//            laterales[1] = new Rectangulo(ladoComun, largoLateral);
//            laterales[2] = new Rectangulo(ladoComun, largoLateral);
//            laterales[3] = new Rectangulo(ladoComun, largoLateral);
//        }
//        public double calcularArea()
//        {
//            double areaBase = bases[0].CalcularArea();
//            double areaLateral = laterales[0].CalcularArea();
//            return areaBase*2 + areaLateral*4;
//        }

//        public double calcularVolumen()
//        {
//            double volumen = bases[0].CalcularArea();
//            return laterales[0].getLargo() * volumen;
//        }

//        public string Describir()
//        {
//            return "Ortoedro";
//        }
//    }
//}
using System;
using System.Collections.Generic;

namespace Ejercicio_1.models
{
    internal class Ortoedro
    {
        private List<Rectangulo> bases = new List<Rectangulo>();
        private List<Rectangulo> laterales = new List<Rectangulo>();

        public Ortoedro(double anchoBase, double ladoComun, double largoLateral)
        {
            bases.Add(new Rectangulo(anchoBase, ladoComun));
            bases.Add(new Rectangulo(anchoBase, ladoComun));

            for (int i = 0; i < 4; i++)
            {
                laterales.Add(new Rectangulo(ladoComun, largoLateral));
            }
        }

        public double CalcularArea()
        {
            double areaBases = 0;
            foreach (Rectangulo b in bases)
            {
                areaBases += b.CalcularArea();
            }

            double areaLaterales = 0;
            foreach (Rectangulo l in laterales)
            {
                areaLaterales += l.CalcularArea();
            }

            return areaBases + areaLaterales;
        }

        public double CalcularVolumen()
        {
            double areaBase = bases[0].CalcularArea();
            double altura = laterales[0].getLargo();
            return areaBase * altura;
        }

        public string Describir()
        {
            string json = $@"{{
                ""Figura"": ""Ortoedro"",
                ""Ancho base"": {bases[0].Ancho},
                ""Largo base"": {bases[0].Largo},
                ""Largo lateral"": {laterales[0].Largo},
                ""Área"": {this.CalcularArea()},
                ""Volumen"": {this.CalcularVolumen()}
            }}";
            return json;
        }
    }
}
