using System.Diagnostics;

namespace Consiga_d
{
    public partial class Form1 : Form
    {
        private string cronometro;
        private Stopwatch stopwatch; // Stopwatch es una clase que se encuentra en el espacio de nombres System.Diagnostics y se utiliza
                                     // para medir el tiempo transcurrido. Proporciona métodos para iniciar, detener y reiniciar un cronómetro,
                                     // así como para obtener el tiempo transcurrido en diferentes unidades (horas, minutos, segundos, milisegundos).
        public Form1()
        {
            InitializeComponent();
            cronometro = "";
            stopwatch = new Stopwatch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            tmrTimer.Enabled = true;
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopwatch.ElapsedMilliseconds);
            // Creá un TimeSpan de 0 días, 0 horas, 0 minutos, 0 segundos, y X milisegundos"
            // ElapsedMilliseconds es de tipo long (número grande), y TimeSpan espera un int, entonces el (int) lo convierte de long a int.
            //ts es un objeto de tipo TimeSpan que se crea a partir del tiempo transcurrido en el cronómetro.


            var hours = ts.Hours;// gracias al objeto TimeSpan, podemos acceder a las propiedades Hours, Minutes, Seconds y Milliseconds para obtener las horas, minutos, segundos
            var minutes = ts.Minutes;
            var seconds = ts.Seconds;
            var milliseconds = ts.Milliseconds;

            cronometro = $"{hours}:{minutes}:{seconds}:{milliseconds}:"; // en string cronometro guardamos (no mostramos) las variables
            lblCronometro.Text = cronometro; // mostramos lo que vale cronometro en una lbl
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopwatch.Stop(); // Es una funcion de la clase Stopwatch que detiene el cronometro, cuando se utiliza esto deja de contar y se guardan las horas minutos segundos milisegundos cuando se paro.
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            stopwatch.Restart(); // Es una función de la clase Stopwatch que reinicia el cronómetro, es decir, lo detiene y lo vuelve a iniciar desde cero. Al llamar a Restart(), el cronómetro se detiene si estaba en ejecución y luego se inicia nuevamente, comenzando a contar desde cero.
            tmrTimer.Enabled = false; // Detiene el temporizador para que no siga actualizando el cronómetro en la interfaz de usuario.

            cronometro = "00:00:00:00"; // solo lo reiniciamos
            lblCronometro.Text = cronometro; //le damos el valor de cronometro a la etiqueta lblCronometro para que se muestre en la interfaz de usuario. En este caso, se muestra "00:00:00:00"
        }
    }
}
