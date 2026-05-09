namespace EjerciciosMatematicos
{
    partial class FormTablaMultiplicar
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
            btnGenerar = new Button();
            lstTabla = new ListBox();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero de que tabla desea?";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(18, 41);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(29, 91);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(97, 69);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar Tabla";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.Location = new Point(243, 18);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(171, 284);
            lstTabla.TabIndex = 3;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 369);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(103, 69);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormTablaMultiplicar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lstTabla);
            Controls.Add(btnGenerar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "FormTablaMultiplicar";
            Text = "FormTablaMultiplicar";
            Load += FormTablaMultiplicar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnGenerar;
        private ListBox lstTabla;
        private Button btnVolver;
    }
}