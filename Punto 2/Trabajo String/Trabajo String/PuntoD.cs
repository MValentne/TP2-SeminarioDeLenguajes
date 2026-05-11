using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trabajo_String
{
    public partial class PuntoD : Form
    {
        public PuntoD()
        {
            InitializeComponent();
        }

    private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese un texto válido.");
                return;
            }else
            {
                string texto = textBox1.Text;
                string textoSinEspacios = texto.Trim();
                lbl_confirmacion.Text = $"Texto original: '{texto}'"+
                    $"\nTexto sin espacios: '{textoSinEspacios}'";
            }
            
        }
    }
}
