using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creacion_de_Calculadora
{
    public partial class Form1: Form
    {
        List<double> Resultados = new List<double>();
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
    }
}
