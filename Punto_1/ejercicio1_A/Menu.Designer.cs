namespace TP2Seminario
{
    partial class Menu
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
            btnCalcular1 = new Button();
            btnCalcular3 = new Button();
            lblB = new Label();
            lblA = new Label();
            lblC = new Label();
            btnCalcular2 = new Button();
            lblX = new Label();
            lblY = new Label();
            lblZ = new Label();
            lblPreguntaCalculo = new Label();
            nupNumCalculo = new NumericUpDown();
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            txtVariableC = new TextBox();
            txtVariableY = new TextBox();
            txtVariableX = new TextBox();
            txtVariableZ = new TextBox();
            grpResultado = new GroupBox();
            lblResultado = new Label();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)nupNumCalculo).BeginInit();
            grpResultado.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular1
            // 
            btnCalcular1.Location = new Point(29, 246);
            btnCalcular1.Name = "btnCalcular1";
            btnCalcular1.Size = new Size(94, 29);
            btnCalcular1.TabIndex = 0;
            btnCalcular1.Text = "Calcular1";
            btnCalcular1.UseVisualStyleBackColor = true;
            btnCalcular1.Visible = false;
            btnCalcular1.Click += btnCalcular1_Click;
            // 
            // btnCalcular3
            // 
            btnCalcular3.Location = new Point(29, 316);
            btnCalcular3.Name = "btnCalcular3";
            btnCalcular3.Size = new Size(94, 29);
            btnCalcular3.TabIndex = 2;
            btnCalcular3.Text = "Calcular3";
            btnCalcular3.UseVisualStyleBackColor = true;
            btnCalcular3.Visible = false;
            btnCalcular3.Click += btnCalcular3_Click;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(14, 133);
            lblB.Name = "lblB";
            lblB.Size = new Size(70, 20);
            lblB.TabIndex = 0;
            lblB.Text = "Ingrese b";
            lblB.Visible = false;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(15, 100);
            lblA.Name = "lblA";
            lblA.Size = new Size(69, 20);
            lblA.TabIndex = 1;
            lblA.Text = "Ingrese a";
            lblA.Visible = false;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(14, 169);
            lblC.Name = "lblC";
            lblC.Size = new Size(68, 20);
            lblC.TabIndex = 2;
            lblC.Text = "Ingrese c";
            lblC.Visible = false;
            // 
            // btnCalcular2
            // 
            btnCalcular2.Location = new Point(29, 281);
            btnCalcular2.Name = "btnCalcular2";
            btnCalcular2.Size = new Size(94, 29);
            btnCalcular2.TabIndex = 1;
            btnCalcular2.Text = "Calcular2";
            btnCalcular2.UseVisualStyleBackColor = true;
            btnCalcular2.Visible = false;
            btnCalcular2.Click += btnCalcular2_Click;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(164, 133);
            lblX.Name = "lblX";
            lblX.Size = new Size(68, 20);
            lblX.TabIndex = 3;
            lblX.Text = "ingrese x";
            lblX.Visible = false;
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(164, 96);
            lblY.Name = "lblY";
            lblY.Size = new Size(68, 20);
            lblY.TabIndex = 4;
            lblY.Text = "ingrese y";
            lblY.Visible = false;
            // 
            // lblZ
            // 
            lblZ.AutoSize = true;
            lblZ.Location = new Point(164, 169);
            lblZ.Name = "lblZ";
            lblZ.Size = new Size(68, 20);
            lblZ.TabIndex = 3;
            lblZ.Text = "ingrese z";
            lblZ.Visible = false;
            // 
            // lblPreguntaCalculo
            // 
            lblPreguntaCalculo.AutoSize = true;
            lblPreguntaCalculo.Location = new Point(12, 18);
            lblPreguntaCalculo.Name = "lblPreguntaCalculo";
            lblPreguntaCalculo.Size = new Size(179, 20);
            lblPreguntaCalculo.TabIndex = 5;
            lblPreguntaCalculo.Text = "Qué Cálculo desea hacer?";
            // 
            // nupNumCalculo
            // 
            nupNumCalculo.Location = new Point(29, 41);
            nupNumCalculo.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nupNumCalculo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupNumCalculo.Name = "nupNumCalculo";
            nupNumCalculo.Size = new Size(150, 27);
            nupNumCalculo.TabIndex = 6;
            nupNumCalculo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(90, 97);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(45, 27);
            txtVariableA.TabIndex = 7;
            txtVariableA.Visible = false;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(90, 130);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(45, 27);
            txtVariableB.TabIndex = 8;
            txtVariableB.Visible = false;
            // 
            // txtVariableC
            // 
            txtVariableC.Location = new Point(90, 166);
            txtVariableC.Name = "txtVariableC";
            txtVariableC.Size = new Size(45, 27);
            txtVariableC.TabIndex = 9;
            txtVariableC.Visible = false;
            // 
            // txtVariableY
            // 
            txtVariableY.Location = new Point(254, 97);
            txtVariableY.Name = "txtVariableY";
            txtVariableY.Size = new Size(45, 27);
            txtVariableY.TabIndex = 10;
            txtVariableY.Visible = false;
            // 
            // txtVariableX
            // 
            txtVariableX.Location = new Point(254, 133);
            txtVariableX.Name = "txtVariableX";
            txtVariableX.Size = new Size(45, 27);
            txtVariableX.TabIndex = 11;
            txtVariableX.Visible = false;
            // 
            // txtVariableZ
            // 
            txtVariableZ.Location = new Point(254, 169);
            txtVariableZ.Name = "txtVariableZ";
            txtVariableZ.Size = new Size(45, 27);
            txtVariableZ.TabIndex = 12;
            txtVariableZ.Visible = false;
            // 
            // grpResultado
            // 
            grpResultado.Controls.Add(lblResultado);
            grpResultado.Location = new Point(164, 230);
            grpResultado.Name = "grpResultado";
            grpResultado.Size = new Size(175, 148);
            grpResultado.TabIndex = 13;
            grpResultado.TabStop = false;
            grpResultado.Text = "Resultado";
            grpResultado.Visible = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(6, 25);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(84, 20);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado...";
            lblResultado.Visible = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(222, 27);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 52);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar Calculo";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(grpResultado);
            Controls.Add(txtVariableZ);
            Controls.Add(txtVariableX);
            Controls.Add(txtVariableY);
            Controls.Add(txtVariableC);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Controls.Add(nupNumCalculo);
            Controls.Add(lblPreguntaCalculo);
            Controls.Add(btnCalcular1);
            Controls.Add(lblC);
            Controls.Add(btnCalcular3);
            Controls.Add(lblA);
            Controls.Add(lblB);
            Controls.Add(btnCalcular2);
            Controls.Add(lblZ);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Name = "Menu";
            Text = "Menu Principal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nupNumCalculo).EndInit();
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular1;
        private Button btnCalcular3;
        private Label lblC;
        private Label lblA;
        private Label lblB;
        private Button btnCalcular2;
        private Label lblX;
        private Label lblY;
        private Label lblZ;
        private Label lblPreguntaCalculo;
        private NumericUpDown nupNumCalculo;
        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private TextBox txtVariableC;
        private TextBox txtVariableY;
        private TextBox txtVariableX;
        private TextBox txtVariableZ;
        private GroupBox grpResultado;
        private Label lblResultado;
        private Button btnConfirmar;
    }
}
