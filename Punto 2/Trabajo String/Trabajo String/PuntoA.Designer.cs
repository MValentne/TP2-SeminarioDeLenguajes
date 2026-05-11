namespace Trabajo_String
{
    partial class PuntoA
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
            Btn_CargarN = new Button();
            Lbl_Consigna = new Label();
            textBox1 = new TextBox();
            Btn_Consola = new Button();
            Btn_Form = new Button();
            Lbl_Confirmacion = new Label();
            SuspendLayout();
            // 
            // Btn_CargarN
            // 
            Btn_CargarN.Location = new Point(25, 119);
            Btn_CargarN.Name = "Btn_CargarN";
            Btn_CargarN.Size = new Size(99, 39);
            Btn_CargarN.TabIndex = 0;
            Btn_CargarN.Text = "Cargar Nombre";
            Btn_CargarN.UseVisualStyleBackColor = true;
            Btn_CargarN.Click += Btn_CargarN_Click;
            // 
            // Lbl_Consigna
            // 
            Lbl_Consigna.Location = new Point(12, 9);
            Lbl_Consigna.Name = "Lbl_Consigna";
            Lbl_Consigna.Size = new Size(511, 48);
            Lbl_Consigna.TabIndex = 1;
            Lbl_Consigna.Text = "Crear un programa saludador. Al ingresar un nombre, debe de aparecer tanto por consola como por un Formulario '¡Hola 'El nombre ingresado'!'";
            Lbl_Consigna.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // Btn_Consola
            // 
            Btn_Consola.Location = new Point(163, 119);
            Btn_Consola.Name = "Btn_Consola";
            Btn_Consola.Size = new Size(99, 39);
            Btn_Consola.TabIndex = 3;
            Btn_Consola.Text = "Iniciar Consola";
            Btn_Consola.UseVisualStyleBackColor = true;
            Btn_Consola.Click += Btn_Consola_Click;
            // 
            // Btn_Form
            // 
            Btn_Form.Location = new Point(277, 119);
            Btn_Form.Name = "Btn_Form";
            Btn_Form.Size = new Size(89, 39);
            Btn_Form.TabIndex = 4;
            Btn_Form.Text = "Iniciar Form";
            Btn_Form.UseVisualStyleBackColor = true;
            Btn_Form.Click += Btn_Form_Click;
            // 
            // Lbl_Confirmacion
            // 
            Lbl_Confirmacion.AutoSize = true;
            Lbl_Confirmacion.Location = new Point(177, 86);
            Lbl_Confirmacion.Name = "Lbl_Confirmacion";
            Lbl_Confirmacion.Size = new Size(0, 15);
            Lbl_Confirmacion.TabIndex = 5;
            // 
            // PuntoA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 235);
            Controls.Add(Lbl_Confirmacion);
            Controls.Add(Btn_Form);
            Controls.Add(Btn_Consola);
            Controls.Add(textBox1);
            Controls.Add(Lbl_Consigna);
            Controls.Add(Btn_CargarN);
            Name = "PuntoA";
            Text = "PuntoA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_CargarN;
        private Label Lbl_Consigna;
        private TextBox textBox1;
        private Button Btn_Consola;
        private Button Btn_Form;
        private Label Lbl_Confirmacion;
    }
}