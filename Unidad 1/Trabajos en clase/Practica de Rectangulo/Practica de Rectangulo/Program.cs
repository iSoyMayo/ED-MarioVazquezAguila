using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de_Rectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("  1. Calcular area de un Rectángulo\n  2. Calcular perímetro de un rectángulo\n  3. Calcular area de un cuadrado\n  4. Calcular perímetro de un cuadrado");
            Console.Write("> Ingrese una opción: ");

            Rectangulo rectangulo = new Rectangulo();
            Cuadrado cuadrado = new Cuadrado();

            switch (opcion)
            {
                case 1:
                    rectangulo.CalcularArea();
                    rectangulo.MostrarDatos();
                    break;

                case 2:
                    rectangulo.CalcularPerimetro();
                    rectangulo.MostrarDatos();

                    break;

                case 3:
                    
                    break;

                case 4:
                    break;

                 default:
                    break;
            }

        }
    }
}
