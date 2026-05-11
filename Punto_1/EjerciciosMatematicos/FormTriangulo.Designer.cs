namespace EjerciciosMatematicos
{
    partial class FormTriangulo
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
            txtBase = new TextBox();
            label2 = new Label();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            btnVolver = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Base:";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(103, 38);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(125, 27);
            txtBase.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 97);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Altura:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(103, 97);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(30, 153);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(30, 398);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(175, 157);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // FormTriangulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnVolver);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(label2);
            Controls.Add(txtBase);
            Controls.Add(label1);
            Name = "FormTriangulo";
            Text = "FormTriangulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBase;
        private Label label2;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Button btnVolver;
        private Label lblResultado;
    }
}