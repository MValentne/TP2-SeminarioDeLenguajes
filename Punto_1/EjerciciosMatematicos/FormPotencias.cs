using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosMatematicos
{
    public partial class FormPotencias : Form
    {
        double numero, exponente, cuadrado, cubo, otro;
        public FormPotencias()
        {
            InitializeComponent();
        }

        private void FormPotencias_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDouble(txtNumero.Text);
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            lblCuadrado.Text = "Cuadrado: " + cuadrado.ToString();
            lblCubo.Text = "Cubo:     " + cubo.ToString();

            if (txtExponente.Text != "")
            {
                exponente = Convert.ToDouble(txtExponente.Text);
                otro = Math.Pow(numero, exponente);
                lblOtro.Text = numero + " ^ " + exponente + " = " + otro.ToString();
            }

            grpResultado.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
