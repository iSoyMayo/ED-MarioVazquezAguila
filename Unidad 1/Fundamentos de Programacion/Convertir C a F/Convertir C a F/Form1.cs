using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertir_C_a_F
{
    public partial class frmInicio: Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int Resultado;

            Resultado = (int.Parse(txtGradosC.Text) * 9/5)+32;

            txtGradosF.Text = Resultado.ToString();
        }
    }
}
