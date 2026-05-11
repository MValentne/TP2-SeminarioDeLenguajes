using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosMatematicos
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (txtN1.Text != "" && txtN2.Text != "") // verificamos que ambos campos no estén vacíos lo mismo de los otros formularios o botone
            {
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN2.Text);
                double res = n1 + n2;
                lblResultado.Text = "Resultado: " + res.ToString();
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (txtN1.Text != "" && txtN2.Text != "")
            {
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN2.Text);
                double res = n1 - n2;
                lblResultado.Text = "Resultado: " + res.ToString();
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txtN1.Text != "" && txtN2.Text != "")
            {
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN2.Text);
                double res = n1 * n2;
                lblResultado.Text = "Resultado: " + res.ToString();
            }
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            if (txtN1.Text != "" && txtN2.Text != "")
            {
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN2.Text);

                if (n2 != 0) // para que no haga macana
                {
                    double res = n1 / n2;
                    lblResultado.Text = "Resultado: " + res.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero."); // mensaje de macana
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
