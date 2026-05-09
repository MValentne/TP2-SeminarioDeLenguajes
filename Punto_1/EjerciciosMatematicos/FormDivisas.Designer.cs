namespace EjerciciosMatematicos
{
    partial class FormDivisas
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
            txtPesos = new TextBox();
            label2 = new Label();
            txtDolarHoy = new TextBox();
            btnConvertir = new Button();
            btnVolver = new Button();
            grpResultado = new GroupBox();
            lblDolares = new Label();
            grpResultado.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 64);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Monto$:";
            // 
            // txtPesos
            // 
            txtPesos.Location = new Point(142, 57);
            txtPesos.Name = "txtPesos";
            txtPesos.Size = new Size(125, 27);
            txtPesos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 102);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Cambio (1 USD)";
            // 
            // txtDolarHoy
            // 
            txtDolarHoy.Location = new Point(224, 99);
            txtDolarHoy.Name = "txtDolarHoy";
            txtDolarHoy.Size = new Size(104, 27);
            txtDolarHoy.TabIndex = 3;
            txtDolarHoy.Text = "1000";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(47, 154);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(99, 54);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "Convertir  a Dólares";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(168, 154);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(99, 54);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // grpResultado
            // 
            grpResultado.Controls.Add(lblDolares);
            grpResultado.Location = new Point(384, 57);
            grpResultado.Name = "grpResultado";
            grpResultado.Size = new Size(250, 125);
            grpResultado.TabIndex = 6;
            grpResultado.TabStop = false;
            grpResultado.Text = "Resultado";
            // 
            // lblDolares
            // 
            lblDolares.AutoSize = true;
            lblDolares.Location = new Point(6, 42);
            lblDolares.Name = "lblDolares";
            lblDolares.Size = new Size(60, 20);
            lblDolares.TabIndex = 0;
            lblDolares.Text = "Dolares";
            lblDolares.Click += lblDolares_Click;
            // 
            // FormDivisas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpResultado);
            Controls.Add(btnVolver);
            Controls.Add(btnConvertir);
            Controls.Add(txtDolarHoy);
            Controls.Add(label2);
            Controls.Add(txtPesos);
            Controls.Add(label1);
            Name = "FormDivisas";
            Text = "FormDivisas";
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPesos;
        private Label label2;
        private TextBox txtDolarHoy;
        private Button btnConvertir;
        private Button btnVolver;
        private GroupBox grpResultado;
        private Label lblDolares;
    }
}