using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trabajo_String
{
    public partial class PuntoB : Form
    {
        public PuntoB()
        {
            InitializeComponent();
        }

        private void btn_comprobar_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text)))
            {
                string cadena1 = textBox1.Text;
                string cadena2 = textBox2.Text;
                string Cadenamsg = (cadena2.Contains(cadena1)) ? "Sí, está dentro de la cadena." : "No, no está dentro de la cadena.";
                lbl_confirmacion.Text = $"Primer Cadena ingresada : {cadena1}" + $" \nSegunda Cadena ingresada : {cadena2}" +
                    $"\n ¿La primer cadena está dentro de la segunda? {Cadenamsg}";
            }

        }
    }


}
