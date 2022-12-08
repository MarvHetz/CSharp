namespace WindowsFormsAppEimer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHinzufuegen = new System.Windows.Forms.Button();
            this.textBoxEingabe = new System.Windows.Forms.TextBox();
            this.labelFuellstand = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonEimerLeeren = new System.Windows.Forms.Button();
            this.panelMaxFuellstand = new System.Windows.Forms.Panel();
            this.panelFuellstand = new System.Windows.Forms.Panel();
            this.panelMaxFuellstand.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHinzufuegen
            // 
            this.buttonHinzufuegen.Location = new System.Drawing.Point(64, 61);
            this.buttonHinzufuegen.Name = "buttonHinzufuegen";
            this.buttonHinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.buttonHinzufuegen.TabIndex = 0;
            this.buttonHinzufuegen.Text = "Hinzufügen";
            this.buttonHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonHinzufuegen.Click += new System.EventHandler(this.buttonHinzufuegen_Click);
            // 
            // textBoxEingabe
            // 
            this.textBoxEingabe.Location = new System.Drawing.Point(189, 64);
            this.textBoxEingabe.Name = "textBoxEingabe";
            this.textBoxEingabe.Size = new System.Drawing.Size(100, 20);
            this.textBoxEingabe.TabIndex = 1;
            // 
            // labelFuellstand
            // 
            this.labelFuellstand.AutoSize = true;
            this.labelFuellstand.Location = new System.Drawing.Point(198, 145);
            this.labelFuellstand.Name = "labelFuellstand";
            this.labelFuellstand.Size = new System.Drawing.Size(70, 13);
            this.labelFuellstand.TabIndex = 2;
            this.labelFuellstand.Text = "akt. Füllstand";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(201, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttonEimerLeeren
            // 
            this.buttonEimerLeeren.Location = new System.Drawing.Point(12, 415);
            this.buttonEimerLeeren.Name = "buttonEimerLeeren";
            this.buttonEimerLeeren.Size = new System.Drawing.Size(309, 23);
            this.buttonEimerLeeren.TabIndex = 4;
            this.buttonEimerLeeren.Text = "Eimer leeren";
            this.buttonEimerLeeren.UseVisualStyleBackColor = true;
            this.buttonEimerLeeren.Click += new System.EventHandler(this.buttonEimerLeeren_Click);
            // 
            // panelMaxFuellstand
            // 
            this.panelMaxFuellstand.BackColor = System.Drawing.Color.Red;
            this.panelMaxFuellstand.Controls.Add(this.panelFuellstand);
            this.panelMaxFuellstand.Location = new System.Drawing.Point(34, 102);
            this.panelMaxFuellstand.Name = "panelMaxFuellstand";
            this.panelMaxFuellstand.Size = new System.Drawing.Size(161, 307);
            this.panelMaxFuellstand.TabIndex = 5;
            // 
            // panelFuellstand
            // 
            this.panelFuellstand.BackColor = System.Drawing.Color.White;
            this.panelFuellstand.Location = new System.Drawing.Point(0, 0);
            this.panelFuellstand.Name = "panelFuellstand";
            this.panelFuellstand.Size = new System.Drawing.Size(161, 307);
            this.panelFuellstand.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.panelMaxFuellstand);
            this.Controls.Add(this.buttonEimerLeeren);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFuellstand);
            this.Controls.Add(this.textBoxEingabe);
            this.Controls.Add(this.buttonHinzufuegen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMaxFuellstand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHinzufuegen;
        private System.Windows.Forms.TextBox textBoxEingabe;
        private System.Windows.Forms.Label labelFuellstand;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonEimerLeeren;
        private System.Windows.Forms.Panel panelMaxFuellstand;
        private System.Windows.Forms.Panel panelFuellstand;
    }
}

