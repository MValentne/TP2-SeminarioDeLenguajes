using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosMatematicos
{
    public partial class FormDivisas : Form
    {
        public FormDivisas()
        {
            InitializeComponent();
        }

        private void lblDolares_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtPesos.Text != "" && txtDolarHoy.Text != "")
            {
                double pesos = Convert.ToDouble(txtPesos.Text);
                double tipoCambio = Convert.ToDouble(txtDolarHoy.Text);

                // Cálculo: Pesos dividido el precio del dólar
                double dolares = pesos / tipoCambio;

                // Mostramos el resultado con 2 decimales usando "N2"
                lblDolares.Text = "U$S " + dolares.ToString("N2");
                grpResultado.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el monto y el tipo de cambio.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
