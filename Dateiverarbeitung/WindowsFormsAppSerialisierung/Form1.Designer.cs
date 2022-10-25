namespace WindowsFormsAppSerialisierung
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
            this.buttonLaden = new System.Windows.Forms.Button();
            this.labelVorname = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGeburtsdatum = new System.Windows.Forms.TextBox();
            this.labelGeburtsdatum = new System.Windows.Forms.Label();
            this.buttonHinzufügen = new System.Windows.Forms.Button();
            this.listBoxInhalt = new System.Windows.Forms.ListBox();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLaden
            // 
            this.buttonLaden.Location = new System.Drawing.Point(12, 31);
            this.buttonLaden.Name = "buttonLaden";
            this.buttonLaden.Size = new System.Drawing.Size(225, 23);
            this.buttonLaden.TabIndex = 0;
            this.buttonLaden.Text = "Laden";
            this.buttonLaden.UseVisualStyleBackColor = true;
            this.buttonLaden.Click += new System.EventHandler(this.buttonLaden_Click);
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Location = new System.Drawing.Point(13, 80);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(49, 13);
            this.labelVorname.TabIndex = 1;
            this.labelVorname.Text = "Vorname";
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(84, 80);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(153, 20);
            this.textBoxVorname.TabIndex = 2;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(84, 106);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(153, 20);
            this.textBoxNachname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nachname";
            // 
            // textBoxGeburtsdatum
            // 
            this.textBoxGeburtsdatum.Location = new System.Drawing.Point(84, 132);
            this.textBoxGeburtsdatum.Name = "textBoxGeburtsdatum";
            this.textBoxGeburtsdatum.Size = new System.Drawing.Size(153, 20);
            this.textBoxGeburtsdatum.TabIndex = 6;
            // 
            // labelGeburtsdatum
            // 
            this.labelGeburtsdatum.AutoSize = true;
            this.labelGeburtsdatum.Location = new System.Drawing.Point(13, 132);
            this.labelGeburtsdatum.Name = "labelGeburtsdatum";
            this.labelGeburtsdatum.Size = new System.Drawing.Size(73, 13);
            this.labelGeburtsdatum.TabIndex = 5;
            this.labelGeburtsdatum.Text = "Geburtsdatum";
            // 
            // buttonHinzufügen
            // 
            this.buttonHinzufügen.Location = new System.Drawing.Point(12, 170);
            this.buttonHinzufügen.Name = "buttonHinzufügen";
            this.buttonHinzufügen.Size = new System.Drawing.Size(225, 23);
            this.buttonHinzufügen.TabIndex = 7;
            this.buttonHinzufügen.Text = "Erstellen + Hinzufügen";
            this.buttonHinzufügen.UseVisualStyleBackColor = true;
            this.buttonHinzufügen.Click += new System.EventHandler(this.buttonHinzufügen_Click);
            // 
            // listBoxInhalt
            // 
            this.listBoxInhalt.FormattingEnabled = true;
            this.listBoxInhalt.Location = new System.Drawing.Point(12, 223);
            this.listBoxInhalt.Name = "listBoxInhalt";
            this.listBoxInhalt.Size = new System.Drawing.Size(225, 225);
            this.listBoxInhalt.TabIndex = 8;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(12, 468);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(225, 23);
            this.buttonSpeichern.TabIndex = 9;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 534);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.listBoxInhalt);
            this.Controls.Add(this.buttonHinzufügen);
            this.Controls.Add(this.textBoxGeburtsdatum);
            this.Controls.Add(this.labelGeburtsdatum);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.labelVorname);
            this.Controls.Add(this.buttonLaden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLaden;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGeburtsdatum;
        private System.Windows.Forms.Label labelGeburtsdatum;
        private System.Windows.Forms.Button buttonHinzufügen;
        private System.Windows.Forms.ListBox listBoxInhalt;
        private System.Windows.Forms.Button buttonSpeichern;
    }
}

