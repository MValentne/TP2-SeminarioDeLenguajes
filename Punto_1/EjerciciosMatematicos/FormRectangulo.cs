using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosMatematicos
{
    public partial class FormRectangulo : Form
    {
        public FormRectangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtBase.Text != "" && txtAltura.Text != "")
            {
                double b = Convert.ToDouble(txtBase.Text);
                double h = Convert.ToDouble(txtAltura.Text);

                double area = b * h;
                double perimetro = 2 * (b + h);

                lblArea.Text = "Área: " + area.ToString();
                lblPerimetro.Text = "Perímetro: " + perimetro.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, completa los campos.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBase.Clear();//lo mismo pude poner txtBase.Text = "";
            txtAltura.Clear();
            lblArea.Text = "Área:";
            lblPerimetro.Text = "Perímetro:";
            txtBase.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); //cierre y vuelve al formulario anterior
        }
    }
}
