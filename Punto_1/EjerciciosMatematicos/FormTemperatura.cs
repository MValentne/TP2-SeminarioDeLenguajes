using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosMatematicos
{
    public partial class FormTemperatura : Form
    {
        public FormTemperatura()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtCelsius.Text != "")//si e distinto de vacio le mandamos
            {
                double celsius = Convert.ToDouble(txtCelsius.Text);

                // Fórmula: (Celsius * 9/5) + 32 lo saque de gulugloe
                double fahrenheit = (celsius * 1.8) + 32;

                lblFahrenheit.Text = "Fahrenheit: " + fahrenheit.ToString() + " °F";
                grpResultado.Visible = true; // Mostramos el resultado
            }
            else
            {
                MessageBox.Show("Por favor, ingrese los grados Celsius.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            lblFahrenheit.Text = "Fahrenheit: -";
            txtCelsius.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
