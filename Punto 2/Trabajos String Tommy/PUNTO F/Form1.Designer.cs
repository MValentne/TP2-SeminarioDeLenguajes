namespace PUNTO_F
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxcaracteres = new System.Windows.Forms.TextBox();
            this.txtBoxmodif1 = new System.Windows.Forms.TextBox();
            this.txtBoxmodif2 = new System.Windows.Forms.TextBox();
            this.bttnProcesar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(38, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"Ingrese una cadena de caracteres\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"Ingrese un caracter a reemplazar\"";
            // 
            // txtBoxcaracteres
            // 
            this.txtBoxcaracteres.Location = new System.Drawing.Point(265, 96);
            this.txtBoxcaracteres.Name = "txtBoxcaracteres";
            this.txtBoxcaracteres.Size = new System.Drawing.Size(303, 20);
            this.txtBoxcaracteres.TabIndex = 3;
            // 
            // txtBoxmodif1
            // 
            this.txtBoxmodif1.Location = new System.Drawing.Point(265, 131);
            this.txtBoxmodif1.Name = "txtBoxmodif1";
            this.txtBoxmodif1.Size = new System.Drawing.Size(303, 20);
            this.txtBoxmodif1.TabIndex = 4;
            // 
            // txtBoxmodif2
            // 
            this.txtBoxmodif2.Location = new System.Drawing.Point(265, 165);
            this.txtBoxmodif2.Name = "txtBoxmodif2";
            this.txtBoxmodif2.Size = new System.Drawing.Size(303, 20);
            this.txtBoxmodif2.TabIndex = 5;
            // 
            // bttnProcesar
            // 
            this.bttnProcesar.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.bttnProcesar.Location = new System.Drawing.Point(265, 204);
            this.bttnProcesar.Name = "bttnProcesar";
            this.bttnProcesar.Size = new System.Drawing.Size(112, 30);
            this.bttnProcesar.TabIndex = 6;
            this.bttnProcesar.Text = "Procesar";
            this.bttnProcesar.UseVisualStyleBackColor = true;
            this.bttnProcesar.Click += new System.EventHandler(this.bttnProcesar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.bttnEliminar.Location = new System.Drawing.Point(456, 204);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(112, 30);
            this.bttnEliminar.TabIndex = 7;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "\"Ingrese el caracter a ser reemplazado: \"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnProcesar);
            this.Controls.Add(this.txtBoxmodif2);
            this.Controls.Add(this.txtBoxmodif1);
            this.Controls.Add(this.txtBoxcaracteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxcaracteres;
        private System.Windows.Forms.TextBox txtBoxmodif1;
        private System.Windows.Forms.TextBox txtBoxmodif2;
        private System.Windows.Forms.Button bttnProcesar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Label label4;
    }
}

