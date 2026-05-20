namespace Consigna_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAlice = new System.Windows.Forms.TextBox();
            this.dateTimePickerAlice = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBob = new System.Windows.Forms.DateTimePicker();
            this.textBoxBob = new System.Windows.Forms.TextBox();
            this.buttonComparar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dateTimePickerAlice);
            this.groupBox1.Controls.Add(this.textBoxAlice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persona 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxAlice
            // 
            this.textBoxAlice.Location = new System.Drawing.Point(6, 33);
            this.textBoxAlice.Name = "textBoxAlice";
            this.textBoxAlice.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlice.TabIndex = 0;
            this.textBoxAlice.Text = "Alice";
            // 
            // dateTimePickerAlice
            // 
            this.dateTimePickerAlice.Location = new System.Drawing.Point(112, 33);
            this.dateTimePickerAlice.Name = "dateTimePickerAlice";
            this.dateTimePickerAlice.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAlice.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dateTimePickerBob);
            this.groupBox2.Controls.Add(this.textBoxBob);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Persona 2";
            // 
            // dateTimePickerBob
            // 
            this.dateTimePickerBob.Location = new System.Drawing.Point(112, 33);
            this.dateTimePickerBob.Name = "dateTimePickerBob";
            this.dateTimePickerBob.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBob.TabIndex = 1;
            // 
            // textBoxBob
            // 
            this.textBoxBob.Location = new System.Drawing.Point(6, 33);
            this.textBoxBob.Name = "textBoxBob";
            this.textBoxBob.Size = new System.Drawing.Size(100, 20);
            this.textBoxBob.TabIndex = 0;
            this.textBoxBob.Text = "Bob";
            // 
            // buttonComparar
            // 
            this.buttonComparar.Location = new System.Drawing.Point(12, 162);
            this.buttonComparar.Name = "buttonComparar";
            this.buttonComparar.Size = new System.Drawing.Size(75, 23);
            this.buttonComparar.TabIndex = 3;
            this.buttonComparar.Text = "Comparar";
            this.buttonComparar.UseVisualStyleBackColor = true;
            this.buttonComparar.Click += new System.EventHandler(this.buttonComparar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 214);
            this.Controls.Add(this.buttonComparar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlice;
        private System.Windows.Forms.TextBox textBoxAlice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBob;
        private System.Windows.Forms.TextBox textBoxBob;
        private System.Windows.Forms.Button buttonComparar;
    }
}

