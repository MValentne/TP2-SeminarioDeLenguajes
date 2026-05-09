namespace EjerciciosMatematicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPotencias_Click(object sender, EventArgs e)
        {
            FormPotencias f = new FormPotencias();
            f.ShowDialog();
        }
    

        
        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            FormRectangulo f = new FormRectangulo();
            f.ShowDialog();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            FormTriangulo f = new FormTriangulo();
            f.ShowDialog();
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            FormTemperatura f = new FormTemperatura();
            f.ShowDialog();
        }

        private void btnDivisas_Click(object sender, EventArgs e)
        {
            FormDivisas f = new FormDivisas();
            f.ShowDialog();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            FormCalculadora f = new FormCalculadora();
            f.ShowDialog();
        }
        

        private void btnIVA_Click(object sender, EventArgs e)
        {
            FormIVA f = new FormIVA();
            f.ShowDialog();
        }

        private void btnEntero_Click(object sender, EventArgs e)
        {
            FormEntero f = new FormEntero();
            f.ShowDialog();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            FormTablaMultiplicar f = new FormTablaMultiplicar();
            f.ShowDialog();
        }
    }
}
        