namespace EjerciciosMatematicos
{
    partial class FormPotencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNumero = new TextBox();
            label2 = new Label();
            txtExponente = new TextBox();
            btnCalcular = new Button();
            btnVolver = new Button();
            grpResultado = new GroupBox();
            lblOtro = new Label();
            lblCubo = new Label();
            lblCuadrado = new Label();
            grpResultado.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(97, 16);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(71, 27);
            txtNumero.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Exponente";
            // 
            // txtExponente
            // 
            txtExponente.Location = new Point(97, 70);
            txtExponente.Name = "txtExponente";
            txtExponente.Size = new Size(71, 27);
            txtExponente.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 133);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 182);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // grpResultado
            // 
            grpResultado.CausesValidation = false;
            grpResultado.Controls.Add(lblOtro);
            grpResultado.Controls.Add(lblCubo);
            grpResultado.Controls.Add(lblCuadrado);
            grpResultado.Location = new Point(213, 16);
            grpResultado.Name = "grpResultado";
            grpResultado.Size = new Size(250, 159);
            grpResultado.TabIndex = 6;
            grpResultado.TabStop = false;
            grpResultado.Text = "Resultado";
            // 
            // lblOtro
            // 
            lblOtro.AutoSize = true;
            lblOtro.Location = new Point(35, 117);
            lblOtro.Name = "lblOtro";
            lblOtro.Size = new Size(42, 20);
            lblOtro.TabIndex = 2;
            lblOtro.Text = "Otro:";
            // 
            // lblCubo
            // 
            lblCubo.AutoSize = true;
            lblCubo.Location = new Point(30, 87);
            lblCubo.Name = "lblCubo";
            lblCubo.Size = new Size(47, 20);
            lblCubo.TabIndex = 1;
            lblCubo.Text = "Cubo:";
            // 
            // lblCuadrado
            // 
            lblCuadrado.AutoSize = true;
            lblCuadrado.Location = new Point(30, 54);
            lblCuadrado.Name = "lblCuadrado";
            lblCuadrado.Size = new Size(77, 20);
            lblCuadrado.TabIndex = 0;
            lblCuadrado.Text = "Cuadrado:";
            // 
            // FormPotencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpResultado);
            Controls.Add(btnVolver);
            Controls.Add(btnCalcular);
            Controls.Add(txtExponente);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "FormPotencias";
            Text = "FormPotencias";
            Load += FormPotencias_Load;
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label label2;
        private TextBox txtExponente;
        private Button btnCalcular;
        private Button btnVolver;
        private GroupBox grpResultado;
        private Label lblCuadrado;
        private Label lblCubo;
        private Label lblOtro;
    }
}