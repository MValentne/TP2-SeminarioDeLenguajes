namespace TP2_SeminarioLenguajes1
{
    partial class Form1
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
            this.labelRespuesta = new System.Windows.Forms.Label();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBoxUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRespuesta
            // 
            this.labelRespuesta.AutoSize = true;
            this.labelRespuesta.Location = new System.Drawing.Point(276, 187);
            this.labelRespuesta.Name = "labelRespuesta";
            this.labelRespuesta.Size = new System.Drawing.Size(81, 13);
            this.labelRespuesta.TabIndex = 0;
            this.labelRespuesta.Text = "Respuesta aqui";
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(this.buttonAceptar);
            this.groupBoxUsuario.Controls.Add(this.textBoxNombre);
            this.groupBoxUsuario.Controls.Add(this.dateTimePickerNacimiento);
            this.groupBoxUsuario.Location = new System.Drawing.Point(33, 52);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(339, 101);
            this.groupBoxUsuario.TabIndex = 2;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Ingrese nombre y fecha de nacimiento";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(19, 55);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(19, 29);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 4;
            this.textBoxNombre.Text = "John";
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(125, 29);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(199, 20);
            this.dateTimePickerNacimiento.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.groupBoxUsuario);
            this.Controls.Add(this.labelRespuesta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRespuesta;
        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}

