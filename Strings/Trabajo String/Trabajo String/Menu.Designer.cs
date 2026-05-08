namespace Trabajo_String
{
    partial class Menu_Inicio
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
            Btn_PuntoA = new Button();
            Btn_PuntoB = new Button();
            SuspendLayout();
            // 
            // Btn_PuntoA
            // 
            Btn_PuntoA.Location = new Point(12, 78);
            Btn_PuntoA.Name = "Btn_PuntoA";
            Btn_PuntoA.Size = new Size(109, 71);
            Btn_PuntoA.TabIndex = 0;
            Btn_PuntoA.Text = "PuntoA";
            Btn_PuntoA.UseVisualStyleBackColor = true;
            Btn_PuntoA.Click += Btn_PuntoA_Click;
            // 
            // Btn_PuntoB
            // 
            Btn_PuntoB.Location = new Point(144, 78);
            Btn_PuntoB.Name = "Btn_PuntoB";
            Btn_PuntoB.Size = new Size(109, 71);
            Btn_PuntoB.TabIndex = 1;
            Btn_PuntoB.Text = "PuntoB";
            Btn_PuntoB.UseVisualStyleBackColor = true;
            Btn_PuntoB.Click += Btn_PuntoB_Click;
            // 
            // Menu_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 218);
            Controls.Add(Btn_PuntoB);
            Controls.Add(Btn_PuntoA);
            Name = "Menu_Inicio";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_PuntoA;
        private Button Btn_PuntoB;
    }
}
