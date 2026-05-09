using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosMatematicos
{
    public partial class FormTablaMultiplicar : Form
    {
        public FormTablaMultiplicar()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != "")
            {
                int num = Convert.ToInt32(txtNumero.Text);

                //Primero limpiamos la lista por las dudas de que se acumulen las tablas anteriores
                lstTabla.Items.Clear();

                //Usamos un bucle del 1 al 10
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = num * i;
                    //Agregamos el renglon al ListBox
                    lstTabla.Items.Add(num + " x " + i + " = " + resultado);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresá un número.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTablaMultiplicar_Load(object sender, EventArgs e)
        {

        }
    }
}
