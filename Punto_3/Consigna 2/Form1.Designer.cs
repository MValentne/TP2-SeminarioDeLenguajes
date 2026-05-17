namespace Consigna_2
{
    partial class Form1
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
            dtpNombre1 = new DateTimePicker();
            dtpNombre2 = new DateTimePicker();
            txtNombre1 = new TextBox();
            txtNombre2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // dtpNombre1
            // 
            dtpNombre1.Location = new Point(328, 21);
            dtpNombre1.Name = "dtpNombre1";
            dtpNombre1.Size = new Size(250, 27);
            dtpNombre1.TabIndex = 0;
            // 
            // dtpNombre2
            // 
            dtpNombre2.Location = new Point(328, 93);
            dtpNombre2.Name = "dtpNombre2";
            dtpNombre2.Size = new Size(250, 27);
            dtpNombre2.TabIndex = 1;
            // 
            // txtNombre1
            // 
            txtNombre1.Location = new Point(150, 21);
            txtNombre1.Name = "txtNombre1";
            txtNombre1.Size = new Size(125, 27);
            txtNombre1.TabIndex = 2;
            // 
            // txtNombre2
            // 
            txtNombre2.Location = new Point(150, 93);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(125, 27);
            txtNombre2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 21);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese su nombre ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 100);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 5;
            label2.Text = "Ingrese su nombre ";
            // 
            // button1
            // 
            button1.Location = new Point(9, 159);
            button1.Name = "button1";
            button1.Size = new Size(266, 77);
            button1.TabIndex = 6;
            button1.Text = "Diferencia de Edad, Meses Años";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(328, 159);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "label3";
            lblResultado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre2);
            Controls.Add(txtNombre1);
            Controls.Add(dtpNombre2);
            Controls.Add(dtpNombre1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNombre1;
        private DateTimePicker dtpNombre2;
        private TextBox txtNombre1;
        private TextBox txtNombre2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label lblResultado;
    }
}
