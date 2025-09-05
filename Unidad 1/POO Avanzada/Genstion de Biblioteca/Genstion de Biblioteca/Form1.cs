using _23100217_Serializacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genstion_de_Biblioteca
{
    public partial class Form1: Form
    {
        ArchivoSecuencialSerializadoBinario<Biblioteca> miArchivo = new
        ArchivoSecuencialSerializadoBinario<Biblioteca>("C:\\Users\\mv503\\Desktop\\Estructura de Datos\\ED-MarioVazquezAguila\\Unidad 1\\POO Avanzada\\Listas\\Biblioteca.dat");

        string strArchivo = "C:\\Users\\mv503\\Desktop\\Estructura de Datos\\ED-MarioVazquezAguila\\Unidad 1\\POO Avanzada\\Listas\\Biblioteca.dat";

        ArchivoSecuencialSerializadoBinario<Biblioteca> miArchivoAuxiliar = new
        ArchivoSecuencialSerializadoBinario<Biblioteca>("C:\\Users\\mv503\\Desktop\\Estructura de Datos\\ED-MarioVazquezAguila\\Unidad 1\\POO Avanzada\\Listas\\BibliotecaAuxiliar.dat");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
           
        }
        public void Listar()
        {
            dtgPrestamos.Rows.Clear();

            try
            {
                miArchivo.AbrirArchivoLectura();

                while (true)
                {
                    Biblioteca ListarBiblioteca = new Biblioteca();
                    ListarBiblioteca = miArchivo.Leer();
                    dtgPrestamos.Rows.Add(ListarBiblioteca.Titulo, ListarBiblioteca.Autor, ListarBiblioteca.ISBN,ListarBiblioteca.Id ,ListarBiblioteca.NombreUsuario, ListarBiblioteca.Devolucion);
                }
            }
            catch
            {

            }
            finally
            {
                miArchivo.Cerrar();
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            Biblioteca Registrar = new Biblioteca();

           try
           {
                Registrar.Titulo = txtTitulo.Text;
                Registrar.ISBN = long.Parse(txtISBN.Text);
                Registrar.Autor = txtAutor.Text;
                Registrar.Devolucion = cbDevolucion.Checked;
                Registrar.NombreUsuario = txtNombreUsuario.Text;
                Registrar.Id = int.Parse(txtidUsuario.Text);
                try
                {
                    miArchivo.AbrirArchivoEscritura();
                    miArchivo.Grabar(Registrar);
                    MessageBox.Show("Activación Exitosa, Reinicie la aplicación", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
           {
                miArchivo.Cerrar();

            }


        }

        private void cbDevolucion_CheckedChanged(object sender, EventArgs e)
        {
            

            try
            {
                Biblioteca Modificar = new Biblioteca();
                string strTitulo = txtTitulo.Text;
                int ID = int.Parse(txtidUsuario.Text);

                miArchivo.AbrirArchivoLectura();
                miArchivoAuxiliar.AbrirArchivoEscritura();

                while (true)
                {
                    Modificar = miArchivo.Leer();
                    if(Modificar.Id == ID && Modificar.Titulo == strTitulo)
                    {
                        Modificar.Devolucion = cbDevolucion.Checked;
                        

                        miArchivoAuxiliar.Grabar(Modificar);
                        txtAutor.Clear();
                        txtidUsuario.Clear();
                        txtISBN.Clear();
                        txtNombreUsuario.Clear();
                        txtTitulo.Clear();
                    }
                    else
                    {
                        miArchivoAuxiliar.Grabar(Modificar);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miArchivo.Cerrar();
                miArchivoAuxiliar.Cerrar();
               
            }

            miArchivo.EliminarArchivo();
            miArchivoAuxiliar.RenonbrarArchivo(strArchivo);

        }

        private void dtgPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // aseguramos que no sea header
            {
                DataGridViewRow fila = dtgPrestamos.Rows[e.RowIndex];

                txtTitulo.Text = fila.Cells["Titulo"].Value.ToString();
                txtAutor.Text = fila.Cells["Autor"].Value.ToString();
                txtISBN.Text = fila.Cells["ISBN"].Value.ToString();
                txtidUsuario.Text = fila.Cells["IdUsuario"].Value.ToString();
                txtNombreUsuario.Text = fila.Cells["Usuario"].Value.ToString();

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
