namespace EjerciciosMatematicos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPotencias = new Button();
            btnRectangulo = new Button();
            btnTriangulo = new Button();
            label1 = new Label();
            btnTemperatura = new Button();
            btnDivisas = new Button();
            btnCalculadora = new Button();
            btnIVA = new Button();
            btnEntero = new Button();
            btnTabla = new Button();
            SuspendLayout();
            // 
            // btnPotencias
            // 
            btnPotencias.Location = new Point(40, 95);
            btnPotencias.Name = "btnPotencias";
            btnPotencias.Size = new Size(104, 29);
            btnPotencias.TabIndex = 0;
            btnPotencias.Text = "Potencias";
            btnPotencias.UseVisualStyleBackColor = true;
            btnPotencias.Click += btnPotencias_Click;
            // 
            // btnRectangulo
            // 
            btnRectangulo.Location = new Point(40, 130);
            btnRectangulo.Name = "btnRectangulo";
            btnRectangulo.Size = new Size(104, 29);
            btnRectangulo.TabIndex = 1;
            btnRectangulo.Text = "Rectangulo";
            btnRectangulo.UseVisualStyleBackColor = true;
            btnRectangulo.Click += btnRectangulo_Click;
            // 
            // btnTriangulo
            // 
            btnTriangulo.Location = new Point(150, 95);
            btnTriangulo.Name = "btnTriangulo";
            btnTriangulo.Size = new Size(104, 29);
            btnTriangulo.TabIndex = 2;
            btnTriangulo.Text = "Triangulo";
            btnTriangulo.UseVisualStyleBackColor = true;
            btnTriangulo.Click += btnTriangulo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 3;
            label1.Text = "Seleccione lo que quiere realizar:";
            // 
            // btnTemperatura
            // 
            btnTemperatura.Location = new Point(150, 130);
            btnTemperatura.Name = "btnTemperatura";
            btnTemperatura.Size = new Size(104, 29);
            btnTemperatura.TabIndex = 4;
            btnTemperatura.Text = "Temperatura";
            btnTemperatura.UseVisualStyleBackColor = true;
            btnTemperatura.Click += btnTemperatura_Click;
            // 
            // btnDivisas
            // 
            btnDivisas.Location = new Point(280, 95);
            btnDivisas.Name = "btnDivisas";
            btnDivisas.Size = new Size(104, 29);
            btnDivisas.TabIndex = 5;
            btnDivisas.Text = "Divisas";
            btnDivisas.UseVisualStyleBackColor = true;
            btnDivisas.Click += btnDivisas_Click;
            // 
            // btnCalculadora
            // 
            btnCalculadora.Location = new Point(299, 130);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(104, 29);
            btnCalculadora.TabIndex = 6;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // btnIVA
            // 
            btnIVA.Location = new Point(420, 95);
            btnIVA.Name = "btnIVA";
            btnIVA.Size = new Size(104, 29);
            btnIVA.TabIndex = 7;
            btnIVA.Text = "IVA";
            btnIVA.UseVisualStyleBackColor = true;
            btnIVA.Click += btnIVA_Click;
            // 
            // btnEntero
            // 
            btnEntero.Location = new Point(420, 130);
            btnEntero.Name = "btnEntero";
            btnEntero.Size = new Size(104, 29);
            btnEntero.TabIndex = 8;
            btnEntero.Text = "Entero";
            btnEntero.UseVisualStyleBackColor = true;
            btnEntero.Click += btnEntero_Click;
            // 
            // btnTabla
            // 
            btnTabla.Location = new Point(530, 95);
            btnTabla.Name = "btnTabla";
            btnTabla.Size = new Size(104, 29);
            btnTabla.TabIndex = 9;
            btnTabla.Text = "Tabla";
            btnTabla.UseVisualStyleBackColor = true;
            btnTabla.Click += btnTabla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTabla);
            Controls.Add(btnEntero);
            Controls.Add(btnIVA);
            Controls.Add(btnCalculadora);
            Controls.Add(btnDivisas);
            Controls.Add(btnTemperatura);
            Controls.Add(label1);
            Controls.Add(btnTriangulo);
            Controls.Add(btnRectangulo);
            Controls.Add(btnPotencias);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPotencias;
        private Button btnRectangulo;
        private Button btnTriangulo;
        private Label label1;
        private Button btnTemperatura;
        private Button btnDivisas;
        private Button btnCalculadora;
        private Button btnIVA;
        private Button btnEntero;
        private Button btnTabla;
    }
}
