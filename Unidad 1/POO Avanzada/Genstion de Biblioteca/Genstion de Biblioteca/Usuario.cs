using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genstion_de_Biblioteca
{
    [Serializable]

    class Usuario
    {
		private string strNombreUsuario;

		public string NombreUsuario
		{
			get { return strNombreUsuario; }
			set { strNombreUsuario = value; }
		}

		private int intId;

		public int Id
		{
			get { return intId; }
			set { intId = value; }
		}

	}
}
