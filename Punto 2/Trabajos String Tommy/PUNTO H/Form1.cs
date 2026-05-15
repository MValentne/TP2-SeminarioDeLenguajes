using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_H
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

            string  textoInvertido = string.Empty;

            foreach (char c in cadenaC)
            {

                if (char.IsUpper(c))
                {
                    textoInvertido += char.ToLower(c);
                }

               else if (char.IsLower(c))
               {
                    textoInvertido += char.ToUpper(c);
               }
                else
                { 
                    textoInvertido += c;
                }
            }

            MessageBox.Show("El texto invertido es:\n\n" + textoInvertido,
                    "Cambio de Mayúsculas/Minúsculas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
