using System.Security.Cryptography.X509Certificates;

namespace Consigna_2
{
    public partial class Form1 : Form
    {
        private string nombre1;
        private string nombre2;
        private int edad1;
        private int edad2;
        private int mes1;
        private int mes2;
        private int dia1;
        private int dia2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // read current values from controls
            nombre1 = txtNombre1.Text;
            nombre2 = txtNombre2.Text;

            edad1 = dtpNombre1.Value.Year;
            edad2 = dtpNombre2.Value.Year;
            //declaracion de meses
            mes1 = dtpNombre1.Value.Month;
            mes2 = dtpNombre2.Value.Month;
            //declaracion de días
            dia1 = dtpNombre1.Value.Day;
            dia2 = dtpNombre2.Value.Day;

            // diferencia de años
            int diferenciaEdad = Math.Abs(edad1 - edad2);
            if (edad1 == edad2)
            {
                MessageBox.Show($"Nacieron el mismo año");
            }
            else
            {
                MessageBox.Show($"La diferencia de edad entre {nombre1} y {nombre2} es de {diferenciaEdad} años.");
            }

            //diferencia de meses
            int diferenciaMes = Math.Abs(mes1 - mes2);
            if (mes1 == mes2)
            {
                MessageBox.Show($"Nacieron el mismo mes");

            }
            else
            {
                MessageBox.Show($"La diferencia de mes entre {nombre1} y {nombre2} es de {diferenciaMes} meses.");
            }
           
            //diferencia de días
            int diferenciaDias = Math.Abs(dia1 - dia2);
            if (dia1 == dia2)
            {
                MessageBox.Show($"Nacieron el mismo día");

            }
            else
            {
                MessageBox.Show($"La diferencia de día entre {nombre1} y {nombre2} es de {diferenciaDias} días.");
            }
        }
    }
}