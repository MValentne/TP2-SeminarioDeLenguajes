namespace Trabajo_String
{
    partial class PuntoD
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
            btn_eliminar = new Button();
            label2 = new Label();
            panel1 = new Panel();
            lbl_confirmacion = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(517, 15);
            label1.TabIndex = 0;
            label1.Text = "Consigna: Eliminar todos los espacios en blanco al principio o fin de una cadena de texto (String)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 1;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(47, 149);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(138, 55);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar Espacios.";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(215, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el texto que se debe de arreglar.";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(lbl_confirmacion);
            panel1.Location = new Point(348, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 95);
            panel1.TabIndex = 4;
            // 
            // lbl_confirmacion
            // 
            lbl_confirmacion.Location = new Point(0, 0);
            lbl_confirmacion.Name = "lbl_confirmacion";
            lbl_confirmacion.Size = new Size(200, 95);
            lbl_confirmacion.TabIndex = 0;
            lbl_confirmacion.Text = "Aqui aparecerá el resultado final de la operacion";
            lbl_confirmacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PuntoD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 235);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btn_eliminar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PuntoD";
            Text = "PuntoD";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btn_eliminar;
        private Label label2;
        private Panel panel1;
        private Label lbl_confirmacion;
    }
}