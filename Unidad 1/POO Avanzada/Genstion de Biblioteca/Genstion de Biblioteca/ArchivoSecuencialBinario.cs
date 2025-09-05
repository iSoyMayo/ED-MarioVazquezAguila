using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace _23100217_Serializacion
{
    internal class ArchivoSecuencialSerializadoBinario<Tipo1>
    {
        string nombrearchivo;
        System.IO.FileStream Flujo;
        BinaryFormatter Seriador;
        long posicionanterior;


        public string NombreArchivo
        {
            get { return nombrearchivo; }
            set { nombrearchivo = value; }
        }

        public long PosicionAnterior
        {
            get { return posicionanterior; }
            set { posicionanterior = value; }
        }


        public ArchivoSecuencialSerializadoBinario(string otronombreachivo)
        {
            nombrearchivo = otronombreachivo;
            posicionanterior = 0;
        }

        public ArchivoSecuencialSerializadoBinario()
        {
        }

        ~ArchivoSecuencialSerializadoBinario()
        {
            this.Cerrar();
        }

        private void CrearArchivo()
        {
            Flujo = new FileStream(NombreArchivo, FileMode.Create);
            PosicionAnterior = 0;
        }

        public void AbrirArchivoEscritura()
        {
            if (File.Exists(NombreArchivo))
            {
                Flujo = new FileStream(NombreArchivo, FileMode.Append);
            }
            else
            {
                this.CrearArchivo();
            }
            Seriador = new BinaryFormatter();
        }

        public void AbrirArchivoLectura()
        {
            if (File.Exists(NombreArchivo))
            {
                Flujo = new FileStream(NombreArchivo, FileMode.Open);
            }
            else
            {
                throw new Exception("No existe el archivo: " + NombreArchivo);
            }
            Seriador = new BinaryFormatter();
            PosicionAnterior = 0;
        }

        public void AbrirArchivoLecturaEscritura()
        {
            if (File.Exists(NombreArchivo))
            {
                Flujo = new FileStream(NombreArchivo, FileMode.Open, FileAccess.ReadWrite);
            }
            else
            {
                this.CrearArchivo();
            }
            Seriador = new BinaryFormatter();
            PosicionAnterior = 0;
        }

        public void Grabar(Tipo1 otroEstudiante)
        {
            Seriador.Serialize(Flujo, otroEstudiante);
        }

        public Tipo1 Leer()
        {
            PosicionAnterior = Flujo.Position;
            Tipo1 miTipo1Leido = (Tipo1)(Seriador.Deserialize(Flujo));
            return miTipo1Leido;
        }

        public void Modificar(Tipo1 modificarEstudiante)
        {
            Flujo.Seek(PosicionAnterior, SeekOrigin.Begin);
            this.Grabar(modificarEstudiante);
        }

        public void Cerrar()
        {
            if (Flujo != null)
            {
                Flujo.Close();
            }
        }

        public void EliminarArchivo()
        {
            File.Delete(NombreArchivo);
        }

        public void RenonbrarArchivo(string NuevoNombre)
        {
            File.Move(NombreArchivo, NuevoNombre);
        }



    }
}