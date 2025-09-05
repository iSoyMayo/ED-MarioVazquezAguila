using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genstion_de_Biblioteca
{
    [Serializable]

    class Biblioteca : Libro
    {
		private bool blDevolucion;

		public bool Devolucion
		{
			get { return blDevolucion; }
			set { blDevolucion = value; }
		}


	}
}
