using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PUNTO_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnProcesar_Click(object sender, EventArgs e)
        {

            string Original = txtBoxcaracteres.Text;
            string Buscado = txtBoxmodif1.Text;
            string Reemplazo = txtBoxmodif2.Text;

            string textoModificado = txtBoxcaracteres.Text.Replace(Buscado, Reemplazo);

            MessageBox.Show("El texto modificado es:\n\n" + textoModificado,
                    "Resultado Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            txtBoxcaracteres.Text = "";
            txtBoxmodif1.Text = "";
            txtBoxmodif2.Text = ""; 

            txtBoxcaracteres.Focus();

        }
    }
}
