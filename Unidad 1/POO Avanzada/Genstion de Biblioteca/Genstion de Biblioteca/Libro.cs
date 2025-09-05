using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genstion_de_Biblioteca
{
	[Serializable]
    class Libro:Usuario
    {
		private string strTitulo;

		public string Titulo
		{
			get { return strTitulo; }
			set { strTitulo = value; }
		}

		private string strAutor;

		public string Autor
		{
			get { return strAutor; }
			set { strAutor = value; }
		}

		private long intIsbn;

		public long ISBN
		{
			get { return intIsbn; }
			set { intIsbn = value; }
		}

	}
}
