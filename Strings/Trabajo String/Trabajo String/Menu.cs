namespace Trabajo_String
{
    public partial class Menu_Inicio : Form
    {
        public Menu_Inicio()
        {
            InitializeComponent();
        }

        private void Btn_PuntoA_Click(object sender, EventArgs e)
        {
            Form PuntoA = new PuntoA();
            PuntoA.ShowDialog();
        }

        private void Btn_PuntoB_Click(object sender, EventArgs e)
        {
            Form PuntoB = new PuntoB();
            PuntoB.ShowDialog();

        }
        private void btn_PuntoC_Click(object sender, EventArgs e)
        {
            Form PuntoC = new PuntoC();
            PuntoC.ShowDialog();
        }

    }
}
