namespace ejercicio1_B
{
    partial class Mainb
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
            label1 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            txtD = new TextBox();
            txtX = new TextBox();
            txtK = new TextBox();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            lblD = new Label();
            lblX = new Label();
            lblK = new Label();
            lblResultado = new Label();
            grpResultado = new GroupBox();
            btnCalcular = new Button();
            grpResultado.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(297, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los valores para el calculo por favor";
            // 
            // txtA
            // 
            txtA.Location = new Point(62, 59);
            txtA.Name = "txtA";
            txtA.Size = new Size(25, 27);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(140, 59);
            txtB.Name = "txtB";
            txtB.Size = new Size(25, 27);
            txtB.TabIndex = 2;
            // 
            // txtC
            // 
            txtC.Location = new Point(225, 62);
            txtC.Name = "txtC";
            txtC.Size = new Size(25, 27);
            txtC.TabIndex = 3;
            // 
            // txtD
            // 
            txtD.Location = new Point(299, 62);
            txtD.Name = "txtD";
            txtD.Size = new Size(25, 27);
            txtD.TabIndex = 4;
            // 
            // txtX
            // 
            txtX.Location = new Point(365, 62);
            txtX.Name = "txtX";
            txtX.Size = new Size(25, 27);
            txtX.TabIndex = 5;
            // 
            // txtK
            // 
            txtK.Location = new Point(444, 62);
            txtK.Name = "txtK";
            txtK.Size = new Size(24, 27);
            txtK.TabIndex = 6;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(39, 62);
            lblA.Name = "lblA";
            lblA.Size = new Size(17, 20);
            lblA.TabIndex = 7;
            lblA.Text = "a";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(116, 62);
            lblB.Name = "lblB";
            lblB.Size = new Size(18, 20);
            lblB.TabIndex = 8;
            lblB.Text = "b";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(203, 62);
            lblC.Name = "lblC";
            lblC.Size = new Size(16, 20);
            lblC.TabIndex = 9;
            lblC.Text = "c";
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Location = new Point(277, 65);
            lblD.Name = "lblD";
            lblD.Size = new Size(18, 20);
            lblD.TabIndex = 10;
            lblD.Text = "d";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(341, 66);
            lblX.Name = "lblX";
            lblX.Size = new Size(16, 20);
            lblX.TabIndex = 11;
            lblX.Text = "x";
            // 
            // lblK
            // 
            lblK.AutoSize = true;
            lblK.Location = new Point(422, 65);
            lblK.Name = "lblK";
            lblK.Size = new Size(16, 20);
            lblK.TabIndex = 12;
            lblK.Text = "k";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(6, 23);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "Resultado:";
            lblResultado.Visible = false;
            // 
            // grpResultado
            // 
            grpResultado.Controls.Add(lblResultado);
            grpResultado.Location = new Point(39, 157);
            grpResultado.Name = "grpResultado";
            grpResultado.Size = new Size(250, 125);
            grpResultado.TabIndex = 14;
            grpResultado.TabStop = false;
            grpResultado.Text = "Resultado";
            grpResultado.Visible = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(37, 102);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Mainb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(grpResultado);
            Controls.Add(lblK);
            Controls.Add(lblX);
            Controls.Add(lblD);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(txtK);
            Controls.Add(txtX);
            Controls.Add(txtD);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label1);
            Name = "Mainb";
            Text = "Form1";
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtD;
        private TextBox txtX;
        private TextBox txtK;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Label lblD;
        private Label lblX;
        private Label lblK;
        private Label lblResultado;
        private GroupBox grpResultado;
        private Button btnCalcular;
    }
}
