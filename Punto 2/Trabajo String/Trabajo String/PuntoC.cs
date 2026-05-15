using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trabajo_String
{
    public partial class PuntoC : Form
    {
        public PuntoC()
        {
            InitializeComponent();
        }
   
        private void btn_comprobar_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text)))
            {
                char caracter = textBox1.Text[0];
                string cadena = textBox2.Text;
                int contador = 0;
                foreach (char c in cadena)
                {
                    if (c == caracter)
                    {
                        contador++;
                    }
                }
                lbl_confirmacion.Text = $"El caracter '{caracter}' aparece {contador} veces en la cadena '{cadena}'.";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un caracter y un texto.");
            }
        }
    }
}
