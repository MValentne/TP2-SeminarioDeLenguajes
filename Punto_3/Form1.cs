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
            DateTime nacimiento = dateTimePicker1.Value;
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
            labelRespuesta.Text = $"Tienes {anios} años, {meses} meses y {dias} días.";
        }
    }
}
