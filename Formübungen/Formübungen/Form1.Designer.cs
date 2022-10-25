namespace Formübungen
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
            this.labelÜberschrift = new System.Windows.Forms.Label();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.textBoxQuadratzahl = new System.Windows.Forms.TextBox();
            this.textBoxEingabe = new System.Windows.Forms.TextBox();
            this.labelQuadratzahl = new System.Windows.Forms.Label();
            this.labelEingabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelÜberschrift
            // 
            this.labelÜberschrift.AutoSize = true;
            this.labelÜberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelÜberschrift.Location = new System.Drawing.Point(196, 35);
            this.labelÜberschrift.Name = "labelÜberschrift";
            this.labelÜberschrift.Size = new System.Drawing.Size(273, 33);
            this.labelÜberschrift.TabIndex = 0;
            this.labelÜberschrift.Text = "Quadratzahlrechner";
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBerechnen.Location = new System.Drawing.Point(264, 310);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(155, 43);
            this.buttonBerechnen.TabIndex = 1;
            this.buttonBerechnen.Text = "Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // textBoxQuadratzahl
            // 
            this.textBoxQuadratzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuadratzahl.Location = new System.Drawing.Point(502, 196);
            this.textBoxQuadratzahl.Name = "textBoxQuadratzahl";
            this.textBoxQuadratzahl.Size = new System.Drawing.Size(100, 31);
            this.textBoxQuadratzahl.TabIndex = 2;
            // 
            // textBoxEingabe
            // 
            this.textBoxEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEingabe.Location = new System.Drawing.Point(107, 196);
            this.textBoxEingabe.Name = "textBoxEingabe";
            this.textBoxEingabe.Size = new System.Drawing.Size(100, 31);
            this.textBoxEingabe.TabIndex = 3;
            // 
            // labelQuadratzahl
            // 
            this.labelQuadratzahl.AutoSize = true;
            this.labelQuadratzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuadratzahl.Location = new System.Drawing.Point(488, 150);
            this.labelQuadratzahl.Name = "labelQuadratzahl";
            this.labelQuadratzahl.Size = new System.Drawing.Size(129, 25);
            this.labelQuadratzahl.TabIndex = 4;
            this.labelQuadratzahl.Text = "Quadratzahl";
            // 
            // labelEingabe
            // 
            this.labelEingabe.AutoSize = true;
            this.labelEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEingabe.Location = new System.Drawing.Point(116, 150);
            this.labelEingabe.Name = "labelEingabe";
            this.labelEingabe.Size = new System.Drawing.Size(91, 25);
            this.labelEingabe.TabIndex = 5;
            this.labelEingabe.Text = "Eingabe";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(718, 497);
            this.Controls.Add(this.labelEingabe);
            this.Controls.Add(this.labelQuadratzahl);
            this.Controls.Add(this.textBoxEingabe);
            this.Controls.Add(this.textBoxQuadratzahl);
            this.Controls.Add(this.buttonBerechnen);
            this.Controls.Add(this.labelÜberschrift);
            this.Name = "Form1";
            this.Text = "Voll Cooler Quadratzahlenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelÜberschrift;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.TextBox textBoxQuadratzahl;
        private System.Windows.Forms.TextBox textBoxEingabe;
        private System.Windows.Forms.Label labelQuadratzahl;
        private System.Windows.Forms.Label labelEingabe;
    }
}

