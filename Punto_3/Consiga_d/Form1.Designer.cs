namespace Consiga_d
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
            components = new System.ComponentModel.Container();
            tmrTimer = new System.Windows.Forms.Timer(components);
            btnPlay = new Button();
            btnStop = new Button();
            btnReiniciar = new Button();
            lblCronometro = new Label();
            SuspendLayout();
            // 
            // tmrTimer
            // 
            tmrTimer.Tick += tmrTimer_Tick;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(216, 199);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(94, 29);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(331, 199);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 1;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(441, 199);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(94, 29);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "REINICIAR";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblCronometro
            // 
            lblCronometro.AutoSize = true;
            lblCronometro.Font = new Font("Verdana", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCronometro.Location = new Point(277, 72);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(208, 34);
            lblCronometro.TabIndex = 3;
            lblCronometro.Text = "00:00:00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCronometro);
            Controls.Add(btnReiniciar);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrTimer;
        private Button btnPlay;
        private Button btnStop;
        private Button btnReiniciar;
        private Label lblCronometro;
    }
}
