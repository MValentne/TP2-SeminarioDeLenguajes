namespace TP2Seminario
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
            Btn_PuntoA = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // Btn_PuntoA
            // 
            Btn_PuntoA.Location = new Point(12, 91);
            Btn_PuntoA.Name = "Btn_PuntoA";
            Btn_PuntoA.Size = new Size(113, 58);
            Btn_PuntoA.TabIndex = 0;
            Btn_PuntoA.Text = "PuntoA";
            Btn_PuntoA.UseVisualStyleBackColor = true;
            Btn_PuntoA.Click += Btn_PuntoA_Click;
            // 
            // button2
            // 
            button2.Location = new Point(143, 91);
            button2.Name = "button2";
            button2.Size = new Size(113, 58);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(273, 91);
            button3.Name = "button3";
            button3.Size = new Size(113, 58);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(409, 91);
            button4.Name = "button4";
            button4.Size = new Size(113, 58);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(542, 91);
            button5.Name = "button5";
            button5.Size = new Size(113, 58);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(661, 91);
            button6.Name = "button6";
            button6.Size = new Size(113, 58);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(867, 596);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Btn_PuntoA);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_PuntoA;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
