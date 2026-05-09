namespace EjerciciosMatematicos
{
    partial class FormEntero
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
            btnAnalizar = new Button();
            btnVolver = new Button();
            grpInfo = new GroupBox();
            lblSigno = new Label();
            lblPar = new Label();
            grpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 42);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un Numero:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(194, 42);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Location = new Point(50, 87);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(94, 55);
            btnAnalizar.TabIndex = 2;
            btnAnalizar.Text = "Analizar Numero";
            btnAnalizar.UseVisualStyleBackColor = true;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(27, 375);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(85, 63);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblSigno);
            grpInfo.Controls.Add(lblPar);
            grpInfo.Location = new Point(360, 42);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(250, 125);
            grpInfo.TabIndex = 4;
            grpInfo.TabStop = false;
            grpInfo.Text = "Informacion del Calculo";
            // 
            // lblSigno
            // 
            lblSigno.AutoSize = true;
            lblSigno.Location = new Point(21, 80);
            lblSigno.Name = "lblSigno";
            lblSigno.Size = new Size(61, 20);
            lblSigno.TabIndex = 6;
            lblSigno.Text = "Signo?: ";
            // 
            // lblPar
            // 
            lblPar.AutoSize = true;
            lblPar.Location = new Point(21, 37);
            lblPar.Name = "lblPar";
            lblPar.Size = new Size(59, 20);
            lblPar.TabIndex = 5;
            lblPar.Text = "Es par?:";
            // 
            // FormEntero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpInfo);
            Controls.Add(btnVolver);
            Controls.Add(btnAnalizar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "FormEntero";
            Text = "FormEntero";
            Load += FormEntero_Load;
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnAnalizar;
        private Button btnVolver;
        private GroupBox grpInfo;
        private Label lblSigno;
        private Label lblPar;
    }
}