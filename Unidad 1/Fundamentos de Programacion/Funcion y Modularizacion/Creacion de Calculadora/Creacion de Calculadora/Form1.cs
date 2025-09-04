using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creacion_de_Calculadora
{
    public partial class Form1: Form
    {
        public List<double> ListaResultados = new List<double>();
        public double Numero1;
        public double Numero2;
        public char Operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";

        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";

        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";

        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";

        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";

        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";

        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";

        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";

        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = (double.Parse(txtPantalla.Text)*-1).ToString();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            bool Bandera = false;
            foreach (char c in txtPantalla.Text)
            {
                if(c == '.')
                {
                    Bandera = true;

                }
            }

            if(Bandera != true)
            {
                txtPantalla.Text = txtPantalla.Text + ".";
            }
            else
            {
                MessageBox.Show("Ya existe un punto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            Operador = 'D';
            Numero1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double Resultado;
            Numero2 = double.Parse(txtPantalla.Text);
            switch (Operador)
            {
                case 'S':
                    Resultado = Numero1 + Numero2;
                    txtPantalla.Text = Resultado.ToString();
                    ListaResultados.Add(Resultado);

                    Operador = ' ';
                    Numero1 = 0;
                    Numero2 = 0;
                    break;
                case 'R':
                    Resultado = Numero1 - Numero2;
                    txtPantalla.Text = Resultado.ToString();
                    ListaResultados.Add(Resultado);

                    Operador = ' ';
                    Numero1 = 0;
                    Numero2 = 0;
                    break;
                case 'D':
                    if(Numero2 != 0)
                    {
                        Resultado = Numero1 / Numero2;
                        txtPantalla.Text = Resultado.ToString();
                        ListaResultados.Add(Resultado);


                        Operador = ' ';
                        Numero1 = 0;
                        Numero2 = 0;
                    }
                    else
                    {
                        MessageBox.Show("No puedes dividir entre 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPantalla.Clear();
                    }
                        break;
                case 'M':
                    Resultado = Numero1 * Numero2;
                    txtPantalla.Text = Resultado.ToString();
                    ListaResultados.Add(Resultado);

                    Operador = ' ';
                    Numero1 = 0;
                    Numero2 = 0;
                    break;
                default:
                    MessageBox.Show("No ha seleccionado ningun operador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            Operador = 'S';
            Numero1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            Operador = 'R';
            Numero1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();


        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Operador = 'M';
            Numero1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();

        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double Suma = 0;
            foreach(double N in ListaResultados)
            {
                Suma = Suma + N;
            }

            double Promedio = Suma / ListaResultados.Count;

            MessageBox.Show($"{Promedio} Es el promedio de las operaciones actuales", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
