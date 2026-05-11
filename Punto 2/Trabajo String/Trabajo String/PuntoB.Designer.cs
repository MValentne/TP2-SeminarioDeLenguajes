namespace Trabajo_String
{
    partial class PuntoB
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Lbl_Cad1 = new Label();
            Lbl_Cad2 = new Label();
            btn_comprobar = new Button();
            lbl_confirmacion = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(77, 9);
            label1.Name = "label1";
            label1.Size = new Size(393, 34);
            label1.TabIndex = 0;
            label1.Text = "Consigna: Ingresando 2 cadenas, identificar si una está dentro de la otra. Ejemplo: Teniendo la cadena \"ola\", identificar si está dentro de \"Hola\".";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // Lbl_Cad1
            // 
            Lbl_Cad1.AutoSize = true;
            Lbl_Cad1.Location = new Point(12, 61);
            Lbl_Cad1.Name = "Lbl_Cad1";
            Lbl_Cad1.Size = new Size(142, 15);
            Lbl_Cad1.TabIndex = 3;
            Lbl_Cad1.Text = "Ingrese la primera cadena";
            // 
            // Lbl_Cad2
            // 
            Lbl_Cad2.AutoSize = true;
            Lbl_Cad2.Location = new Point(12, 116);
            Lbl_Cad2.Name = "Lbl_Cad2";
            Lbl_Cad2.Size = new Size(146, 15);
            Lbl_Cad2.TabIndex = 4;
            Lbl_Cad2.Text = "Ingrese la segunda cadena";
            // 
            // btn_comprobar
            // 
            btn_comprobar.Location = new Point(24, 163);
            btn_comprobar.Name = "btn_comprobar";
            btn_comprobar.Size = new Size(114, 44);
            btn_comprobar.TabIndex = 5;
            btn_comprobar.Text = "Comprobar Cadenas";
            btn_comprobar.UseVisualStyleBackColor = true;
            btn_comprobar.Click += btn_comprobar_Click;
            // 
            // lbl_confirmacion
            // 
            lbl_confirmacion.Location = new Point(3, 0);
            lbl_confirmacion.Name = "lbl_confirmacion";
            lbl_confirmacion.Size = new Size(236, 146);
            lbl_confirmacion.TabIndex = 6;
            lbl_confirmacion.Text = "Este label cambiará una vez se ingresen las 2 cadenas indicando si una está dentro de la otra.";
            lbl_confirmacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(lbl_confirmacion);
            panel1.Location = new Point(306, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 146);
            panel1.TabIndex = 7;
            // 
            // PuntoB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 235);
            Controls.Add(panel1);
            Controls.Add(btn_comprobar);
            Controls.Add(Lbl_Cad2);
            Controls.Add(Lbl_Cad1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PuntoB";
            ShowInTaskbar = false;
            Text = "PuntoB";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Lbl_Cad1;
        private Label Lbl_Cad2;
        private Button btn_comprobar;
        private Label lbl_confirmacion;
        private Panel panel1;
    }
}