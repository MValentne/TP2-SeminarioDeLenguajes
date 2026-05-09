using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosMatematicos
{
    public partial class FormEntero : Form
    {
        public FormEntero()
        {
            InitializeComponent();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != "")
            {
                int num = Convert.ToInt32(txtNumero.Text);

                //Verificamos si es Par o Impar
                if (num % 2 == 0)
                {
                    lblPar.Text = "Es par: SÍ (Es Par)";
                }
                else
                {
                    lblPar.Text = "Es par: NO (Es Impar)";
                }

                //Verificamos si es Positivo, Negativo o Cero
                if (num > 0)// positivo es mayor a cero
                {
                    lblSigno.Text = "Signo: Positivo";
                }
                else if (num < 0)// negativo es menor a cero
                {
                    lblSigno.Text = "Signo: Negativo";
                }
                else// si no es ni positivo ni negativo es cero
                {
                    lblSigno.Text = "Signo: Es Cero";
                }

                grpInfo.Visible = true;
            }
            else
            {
                MessageBox.Show("Escriba un numero entero.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEntero_Load(object sender, EventArgs e)
        {

        }
    }
}

