using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            textBox1.Focus();
        }

        private void buttonProcesar_Click_1(object sender, EventArgs e)
        {
            string textoT = textBox1.Text;
            string cadenaC = textBox2.Text;

            foreach (char x in cadenaC)
            {
                textoT = textoT.Replace(x.ToString(), "");
            }

            MessageBox.Show("El texto limpio es:\n\n" + textoT, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}


