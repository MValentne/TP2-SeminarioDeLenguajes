using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consigna_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Ingrese fechas de nacimiento de ambas personas.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonComparar_Click(object sender, EventArgs e)
        {
            DateTime alice = dateTimePickerAlice.Value.Date;
            DateTime bob = dateTimePickerBob.Value.Date;

            if (alice == bob)
            {
                MessageBox.Show($"{textBoxAlice.Text} y {textBoxBob.Text} nacieron el mismo dia!");
                return;
            }

            // Siempre restamos menor a mayor para evitar valores negativos
            DateTime mayor = alice > bob ? alice : bob;
            DateTime menor = alice > bob ? bob : alice;
            string nombreMayor = alice > bob ? textBoxAlice.Text : textBoxBob.Text;
            string nombreMenor = alice > bob ? textBoxBob.Text : textBoxAlice.Text;

            int anios = mayor.Year - menor.Year;
            int meses = mayor.Month - menor.Month;
            int dias = mayor.Day - menor.Day;

            // Ajustes en cascada
            if (dias < 0)
            {
                meses--;
                // Dias que le faltan al mes anterior del mayor para completarse
                dias += DateTime.DaysInMonth(mayor.Year, mayor.Month == 1 ? 12 : mayor.Month - 1);
            }
            if (meses < 0)
            {
                anios--;
                meses += 12;
            }

            MessageBox.Show($"{nombreMenor} es menor que {nombreMayor} " +
                $"con una diferencia de {anios} anios, {meses} meses y {dias} dias.");
        }
    }
}