using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de_Rectangulo
{
    internal class Rectangulo
    {

        private double _dblAncho;

        public double Ancho
        {
            get { return _dblAncho; }
            set { _dblAncho = value; }
        }

        private double  _dblAlto;

        public double  Alto
        {
            get { return _dblAlto; }
            set { _dblAlto = value; }
        }

        private double _dblResultado;

        public double Resultado
        {
            get { return _dblResultado; }
            set { _dblResultado = value; }
        }


        public Rectangulo()
        {
            Ancho = 0.0;
            Alto = 0.0;
            Resultado = 0.0;
        }

        public void CalcularArea()
        {
            Console.Write("> Ingrese el ancho del rectangulo: ");
            Ancho = double.Parse(Console.ReadLine());

            Console.Write("> Ingrese el alto del rectangulo: ");
            Alto = double.Parse(Console.ReadLine());

            Resultado = Ancho * Alto;
            
        }

        public void CalcularPerimetro()
        {
            Console.Write("> Ingrese el ancho del rectangulo: ");
            Ancho = double.Parse(Console.ReadLine());

            Console.Write("> Ingrese el alto del rectangulo: ");
            Alto = double.Parse(Console.ReadLine());

            Resultado = 2 * (Ancho * Alto);
        }

        public void MostrarDatos()
        {
            Console.Write($"> El resultado es: {Resultado}");
        }
        
    }
}
