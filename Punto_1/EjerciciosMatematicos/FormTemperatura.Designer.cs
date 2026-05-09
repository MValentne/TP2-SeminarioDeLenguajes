namespace EjerciciosMatematicos
{
    partial class FormTemperatura
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
            txtCelsius = new TextBox();
            btnConvertir = new Button();
            grpResultado = new GroupBox();
            lblFahrenheit = new Label();
            btnLimpiar = new Button();
            btnVolver = new Button();
            grpResultado.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 71);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "GradosCelsius";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(195, 68);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(125, 27);
            txtCelsius.TabIndex = 1;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(195, 136);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(107, 60);
            btnConvertir.TabIndex = 6;
            btnConvertir.Text = "Convertir a Fahrenheit";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // grpResultado
            // 
            grpResultado.CausesValidation = false;
            grpResultado.Controls.Add(lblFahrenheit);
            grpResultado.Location = new Point(375, 68);
            grpResultado.Name = "grpResultado";
            grpResultado.Size = new Size(250, 125);
            grpResultado.TabIndex = 7;
            grpResultado.TabStop = false;
            grpResultado.Text = "Resultado:";
            // 
            // lblFahrenheit
            // 
            lblFahrenheit.AutoSize = true;
            lblFahrenheit.Location = new Point(15, 32);
            lblFahrenheit.Name = "lblFahrenheit";
            lblFahrenheit.Size = new Size(94, 20);
            lblFahrenheit.TabIndex = 0;
            lblFahrenheit.Text = "lblFahrenheit";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(195, 211);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 409);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormTemperatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(grpResultado);
            Controls.Add(btnConvertir);
            Controls.Add(txtCelsius);
            Controls.Add(label1);
            Name = "FormTemperatura";
            Text = "FormTemperatura";
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCelsius;
        private Button btnConvertir;
        private GroupBox grpResultado;
        private Button btnLimpiar;
        private Label lblFahrenheit;
        private Button btnVolver;
    }
}