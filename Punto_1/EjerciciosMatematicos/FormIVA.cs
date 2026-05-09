using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosMatematicos
{
    public partial class FormIVA : Form
    {
        public FormIVA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "" && txtPorcentaje.Text != "")
            {
                double precio = Convert.ToDouble(txtPrecio.Text);
                double porcentaje = Convert.ToDouble(txtPorcentaje.Text);

                // Calculamos el valor del IVA y el total
                double valorIVA = precio * (porcentaje / 100);
                double total = precio + valorIVA;

                // Mostramos los resultados
                lblSoloIVA.Text = "IVA: $" + valorIVA.ToString("N2");// "N2 es un formato para ponerle dos decimales
                lblTotal.Text = "Total: $" + total.ToString("N2");

                grpDetalle.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el precio y el porcentaje.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
