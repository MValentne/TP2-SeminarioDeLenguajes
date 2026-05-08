namespace Trabajo_String
{
    partial class PuntoC
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
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            btn_comprobar = new Button();
            panel1 = new Panel();
            lbl_confirmacion = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(536, 32);
            label1.TabIndex = 0;
            label1.Text = "Consigna: Dado un caracter en particular ingresado por teclado y un texto ingresado por teclado, informar la cantidad de veces que dicho caracter aparece en el texto.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(176, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el caracter a ser contado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 75);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(28, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(176, 41);
            label3.TabIndex = 3;
            label3.Text = "Ingrese el texto completo en el que se buscará el caracter.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 4;
            // 
            // btn_comprobar
            // 
            btn_comprobar.Location = new Point(41, 178);
            btn_comprobar.Name = "btn_comprobar";
            btn_comprobar.Size = new Size(135, 32);
            btn_comprobar.TabIndex = 5;
            btn_comprobar.Text = "Comprobar texto.";
            btn_comprobar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(lbl_confirmacion);
            panel1.Location = new Point(353, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 6;
            // 
            // lbl_confirmacion
            // 
            lbl_confirmacion.Location = new Point(0, 0);
            lbl_confirmacion.Name = "lbl_confirmacion";
            lbl_confirmacion.Size = new Size(200, 100);
            lbl_confirmacion.TabIndex = 0;
            lbl_confirmacion.Text = "Aquí aparecerá el resultado total junto con los datos ingresados.";
            lbl_confirmacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PuntoC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 235);
            Controls.Add(panel1);
            Controls.Add(btn_comprobar);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PuntoC";
            Text = "PuntoC3";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button btn_comprobar;
        private Panel panel1;
        private Label lbl_confirmacion;
    }
}