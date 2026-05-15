using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {

            string cadenaC = textBox1.Text;
            string NuevaCadena = "";

            foreach (char c in cadenaC)
            {
                NuevaCadena += char.ToUpper(c);
            }

            MessageBox.Show("El resultado es: " + NuevaCadena,
                "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        { 
            textBox1.Text = "";
        }
    }
}
