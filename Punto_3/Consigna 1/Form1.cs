using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_SeminarioLenguajes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //Imprime el tiempo actual
            labelRespuesta.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = dateTimePickerNacimiento.Value;
            DateTime hoy = DateTime.Today;

            int anios = hoy.Year - nacimiento.Year;
            int meses = hoy.Month - nacimiento.Month;
            int dias = hoy.Day - nacimiento.Day;

            // Ajustes si los valores quedan negativos
            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(hoy.Year, hoy.AddMonths(-1).Month);
            }
            if (meses < 0)
            {
                anios--;
                meses += 12;
            }

            string nombre = textBoxNombre.Text;
            MessageBox.Show($"Tienes {anios} años, {meses} meses y {dias} días, {nombre}");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //TO DO: Segun fecha de nacimiento, calcular edad en la fecha determinada.
            DateTime objetivo = dateTimePickerObjetivo.Value;
            DateTime nacimiento = dateTimePickerNacimiento.Value;
            int aniosC = objetivo.Year - nacimiento.Year;
            int mesesC = objetivo.Month - nacimiento.Month;
            int diasC = objetivo.Day - nacimiento.Day;

            //ajustes si los valores quedan negativos
            if (diasC < 0)
            {
                mesesC--;
                diasC += DateTime.DaysInMonth(objetivo.Year, objetivo.AddMonths(-1).Month);
            }
            if (mesesC < 0)
            {   
                aniosC--;
                mesesC += 12;
            }

            //MM - DD - AA (ToSHortDateString())
            MessageBox.Show($"En la fecha {objetivo.ToShortDateString()}, tendrás {aniosC} años, {mesesC} meses y {diasC} días.");
        }
    }
}
