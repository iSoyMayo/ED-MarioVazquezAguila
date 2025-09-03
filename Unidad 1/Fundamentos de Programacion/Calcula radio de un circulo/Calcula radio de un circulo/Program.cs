using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_radio_de_un_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double  RadioCirculo;
            double Resultado;

            Console.Write("> Ingrese el radio del cuadrado: ");
            RadioCirculo = int.Parse(Console.ReadLine());

            Resultado = Math.PI * Math.Pow(RadioCirculo, 2);

            Console.WriteLine($"\n> El resultado es: {Resultado}");

            Console.ReadKey();

        }
    }
}
