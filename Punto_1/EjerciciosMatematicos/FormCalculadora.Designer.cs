namespace EjerciciosMatematicos
{
    partial class FormCalculadora
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
            label2 = new Label();
            lblResultado = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMulti = new Button();
            btnDivi = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 88);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero 2:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(357, 42);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(168, 35);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(125, 27);
            txtN1.TabIndex = 3;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(168, 88);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(125, 27);
            txtN2.TabIndex = 4;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(75, 132);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(100, 70);
            btnSumar.TabIndex = 5;
            btnSumar.Text = "Sumar!";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(193, 132);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(100, 70);
            btnRestar.TabIndex = 6;
            btnRestar.Text = "Restar!";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(75, 217);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(100, 70);
            btnMulti.TabIndex = 7;
            btnMulti.Text = "Multiplicar!";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivi
            // 
            btnDivi.Location = new Point(193, 217);
            btnDivi.Name = "btnDivi";
            btnDivi.Size = new Size(100, 70);
            btnDivi.TabIndex = 8;
            btnDivi.Text = "Dividir!";
            btnDivi.UseVisualStyleBackColor = true;
            btnDivi.Click += btnDivi_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(23, 368);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 70);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver!";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnDivi);
            Controls.Add(btnMulti);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCalculadora";
            Text = "FormCalculadora";
            Load += FormCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblResultado;
        private TextBox txtN1;
        private TextBox txtN2;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMulti;
        private Button btnDivi;
        private Button btnVolver;
    }
}