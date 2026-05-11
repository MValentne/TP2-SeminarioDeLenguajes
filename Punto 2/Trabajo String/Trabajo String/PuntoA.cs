using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trabajo_String
{
    public partial class PuntoA : Form
    {
        string Nombre = string.Empty;
        public PuntoA()
        {
            InitializeComponent();
        }


        private void Btn_Consola_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                MessageBox.Show("Variable vacía, no se puede imprimir.");
            }
            else
            {
                Lbl_Confirmacion.Text = "Revise la consola para ver el saludo.";
                Debug.WriteLine($"¡Hola, {Nombre}!");
            }

        }

        private void Btn_Form_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                MessageBox.Show("Variable vacía, no se puede imprimir.");
            }
            else
            {
                MessageBox.Show($"¡Hola, {Nombre}!");
            }
        }
        private void Btn_CargarN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ingrese un nombre para saludar");
            }
            else
            {
                Nombre = textBox1.Text;
                MessageBox.Show("Nombre ingresado correctamente.");
            }
        }


    }
}
