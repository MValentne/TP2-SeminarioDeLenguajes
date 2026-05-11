using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosMatematicos
{
    public partial class FormTriangulo : Form
    {
        public FormTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtBase.Text != "" && txtAltura.Text != "")
            {
                double baseT = Convert.ToDouble(txtBase.Text);
                double alturaT = Convert.ToDouble(txtAltura.Text);

                // Fórmula: (Base * Altura) / 2
                double area = (baseT * alturaT) / 2;

                lblResultado.Text = "Área: " + area.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, completá la base y la altura.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
