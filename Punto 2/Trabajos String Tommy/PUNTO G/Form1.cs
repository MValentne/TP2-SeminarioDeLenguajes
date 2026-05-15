using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_G
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void bttnAceptar_Click(object sender, EventArgs e)
        {
            string cadenaC = txtCadena.Text;
            int contadorNumeros = 0;

            foreach (char x in cadenaC)
            {
                if (char.IsDigit(x))
                {
                    contadorNumeros++;
                }
            }

            MessageBox.Show("El texto contiene " + contadorNumeros + " números.",
                    "Resultado de la cuenta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        public void bttnCancelar_Click(object sender, EventArgs e)
        {
            txtCadena.Clear();
            txtCadena.Focus();
        }
    }
}
