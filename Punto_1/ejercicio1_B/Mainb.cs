namespace ejercicio1_B
{
    public partial class Mainb : Form
    {
        double a, b, c, d, x, k;
        double resultado;
        public Mainb()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            
            
            if (string.IsNullOrWhiteSpace(txtA.Text) ||
                string.IsNullOrWhiteSpace(txtB.Text) ||
                string.IsNullOrWhiteSpace(txtC.Text) ||
                string.IsNullOrWhiteSpace(txtD.Text) ||
                string.IsNullOrWhiteSpace(txtX.Text) ||
                string.IsNullOrWhiteSpace(txtK.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            d = Convert.ToDouble(txtD.Text);
            x = Convert.ToDouble(txtX.Text);
            k = Convert.ToDouble(txtK.Text);

            resultado = (a * Math.Pow(x, 4))
                      + (b * Math.Pow(x, 3))
                      - (c * Math.Pow(x, 2))
                      + (d * x)
                      + k;

            lblResultado.Text = resultado.ToString();
            grpResultado.Visible = true;
            lblResultado.Visible = true;
        }
    }
}
