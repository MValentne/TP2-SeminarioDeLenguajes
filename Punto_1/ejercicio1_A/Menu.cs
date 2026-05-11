using System.Diagnostics.Eventing.Reader;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP2Seminario
{
    public partial class Menu : Form
    {
        double a, b, c, d, k, x, y, z;
        double resultado;
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void btnCalcular1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtVariableA.Text);
            b = Convert.ToDouble(txtVariableB.Text);
            c = Convert.ToDouble(txtVariableC.Text);
            b = Math.Pow(b, 3);

            resultado = (b - (4 * a * c)) / (2 * a);

            lblResultado.Text = resultado.ToString();
            grpResultado.Visible = true;
            lblResultado.Visible = true;
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtVariableX.Text);
            y = Convert.ToDouble(txtVariableY.Text);
            a = Convert.ToDouble(txtVariableA.Text);

            resultado = ((Math.Pow(2, 4)*x)+ ((2*y)-8)) / (4 * Math.Pow(a, 2));
            lblResultado.Text = resultado.ToString();
            grpResultado.Visible = true;
            lblResultado.Visible = true;
        }

        private void btnCalcular3_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtVariableX.Text);
            y = Convert.ToDouble(txtVariableY.Text);
            z = Convert.ToDouble(txtVariableZ.Text);

            resultado = ((3 * x) + (2 * y)) / (2 * (Math.Pow(z, 2)));

            lblResultado.Text = resultado.ToString();
            grpResultado.Visible = true;
            lblResultado.Visible = true;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (nupNumCalculo.Value == 1 ) 
            {
                lblA.Visible = true;
                lblB.Visible = true;
                lblC.Visible = true;
                txtVariableA.Visible = true;
                txtVariableB.Visible = true;
                txtVariableC.Visible = true;
                btnCalcular1.Visible = true;
            }
            else if (nupNumCalculo.Value == 2)
            {

                lblX.Visible = true;
                lblY.Visible = true;
                lblA.Visible = true;
                txtVariableX.Visible = true;
                txtVariableY.Visible = true;
                txtVariableA.Visible = true;
                btnCalcular2.Visible = true;


            }
            else if (nupNumCalculo.Value == 3)
            {
                lblX.Visible = true;
                lblY.Visible = true;
                lblZ.Visible = true;
                txtVariableX.Visible = true;
                txtVariableY.Visible = true;
                txtVariableZ.Visible = true;
                btnCalcular3.Visible = true;
            }
        }
    }
}
