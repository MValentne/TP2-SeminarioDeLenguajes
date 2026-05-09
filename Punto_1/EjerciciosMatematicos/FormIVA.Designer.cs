namespace EjerciciosMatematicos
{
    partial class FormIVA
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
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPrecio = new TextBox();
            txtPorcentaje = new TextBox();
            btnVolver = new Button();
            grpDetalle = new GroupBox();
            lblTotal = new Label();
            lblSoloIVA = new Label();
            grpDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(72, 162);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 45);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "Precio Base:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 96);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "%De IVA";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(190, 42);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(94, 27);
            txtPrecio.TabIndex = 4;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(190, 96);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(94, 27);
            txtPorcentaje.TabIndex = 5;
            txtPorcentaje.Text = "21";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 354);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 70);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver!";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lblTotal);
            grpDetalle.Controls.Add(lblSoloIVA);
            grpDetalle.Location = new Point(429, 42);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(250, 125);
            grpDetalle.TabIndex = 11;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Calculo";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(16, 71);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total:$";
            // 
            // lblSoloIVA
            // 
            lblSoloIVA.AutoSize = true;
            lblSoloIVA.Location = new Point(16, 35);
            lblSoloIVA.Name = "lblSoloIVA";
            lblSoloIVA.Size = new Size(42, 20);
            lblSoloIVA.TabIndex = 0;
            lblSoloIVA.Text = "IVA:$";
            // 
            // FormIVA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpDetalle);
            Controls.Add(btnVolver);
            Controls.Add(txtPorcentaje);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Name = "FormIVA";
            Text = "FormIVA";
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private TextBox txtPrecio;
        private TextBox txtPorcentaje;
        private Button btnVolver;
        private GroupBox grpDetalle;
        private Label lblTotal;
        private Label lblSoloIVA;
    }
}