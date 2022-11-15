namespace WindowsFormsAppReise
{
    partial class ReiseUI
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
            this.listBoxTeilnehmer = new System.Windows.Forms.ListBox();
            this.groupBoxNeuerTeilnehmer = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelVorname = new System.Windows.Forms.Label();
            this.labelNachname = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.buttonLöschen = new System.Windows.Forms.Button();
            this.buttonNeuerTeilnehmer = new System.Windows.Forms.Button();
            this.listBoxReisen = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelVon = new System.Windows.Forms.Label();
            this.labelPreis = new System.Windows.Forms.Label();
            this.labelZiel = new System.Windows.Forms.Label();
            this.textBoxVon = new System.Windows.Forms.TextBox();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.textBoxZiel = new System.Windows.Forms.TextBox();
            this.buttonReiseLoeschen = new System.Windows.Forms.Button();
            this.buttonReiseHinzufuegen = new System.Windows.Forms.Button();
            this.labelMaxTN = new System.Windows.Forms.Label();
            this.labelBis = new System.Windows.Forms.Label();
            this.textBoxMaxTN = new System.Windows.Forms.TextBox();
            this.textBoxBis = new System.Windows.Forms.TextBox();
            this.groupBoxNeuerTeilnehmer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTeilnehmer
            // 
            this.listBoxTeilnehmer.FormattingEnabled = true;
            this.listBoxTeilnehmer.Location = new System.Drawing.Point(20, 334);
            this.listBoxTeilnehmer.Name = "listBoxTeilnehmer";
            this.listBoxTeilnehmer.Size = new System.Drawing.Size(502, 212);
            this.listBoxTeilnehmer.TabIndex = 1;
            // 
            // groupBoxNeuerTeilnehmer
            // 
            this.groupBoxNeuerTeilnehmer.Controls.Add(this.labelEmail);
            this.groupBoxNeuerTeilnehmer.Controls.Add(this.labelVorname);
            this.groupBoxNeuerTeilnehmer.Controls.Add(this.labelNachname);
            this.groupBoxNeuerTeilnehmer.Controls.Add(this.textBoxEmail);
            this.groupBoxNeuerTeilnehmer.Controls.Add(this.textBoxVorname);
            this.groupBoxNeuerTeilnehmer.Controls.Add(this.textBoxNachname);
            this.groupBoxNeuerTeilnehmer.Controls.Add(this.buttonLöschen);
            this.groupBoxNeuerTeilnehmer.Controls.Add(this.buttonNeuerTeilnehmer);
            this.groupBoxNeuerTeilnehmer.Location = new System.Drawing.Point(574, 334);
            this.groupBoxNeuerTeilnehmer.Name = "groupBoxNeuerTeilnehmer";
            this.groupBoxNeuerTeilnehmer.Size = new System.Drawing.Size(501, 213);
            this.groupBoxNeuerTeilnehmer.TabIndex = 2;
            this.groupBoxNeuerTeilnehmer.TabStop = false;
            this.groupBoxNeuerTeilnehmer.Text = "Neuer Teilnehmer";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(293, 119);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 16);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "E-Mail";
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVorname.Location = new System.Drawing.Point(293, 80);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(62, 16);
            this.labelVorname.TabIndex = 6;
            this.labelVorname.Text = "Vorname";
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNachname.Location = new System.Drawing.Point(290, 39);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(73, 16);
            this.labelNachname.TabIndex = 5;
            this.labelNachname.Text = "Nachname";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(7, 119);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(276, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(7, 80);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(276, 20);
            this.textBoxVorname.TabIndex = 3;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(7, 39);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(276, 20);
            this.textBoxNachname.TabIndex = 2;
            // 
            // buttonLöschen
            // 
            this.buttonLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLöschen.Location = new System.Drawing.Point(7, 174);
            this.buttonLöschen.Name = "buttonLöschen";
            this.buttonLöschen.Size = new System.Drawing.Size(488, 33);
            this.buttonLöschen.TabIndex = 1;
            this.buttonLöschen.Text = "Teilnehmer löschen";
            this.buttonLöschen.UseVisualStyleBackColor = true;
            this.buttonLöschen.Click += new System.EventHandler(this.buttonLöschen_Click);
            // 
            // buttonNeuerTeilnehmer
            // 
            this.buttonNeuerTeilnehmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNeuerTeilnehmer.Location = new System.Drawing.Point(383, 39);
            this.buttonNeuerTeilnehmer.Name = "buttonNeuerTeilnehmer";
            this.buttonNeuerTeilnehmer.Size = new System.Drawing.Size(99, 101);
            this.buttonNeuerTeilnehmer.TabIndex = 0;
            this.buttonNeuerTeilnehmer.Text = "Neue Teilnehmer aufnehmen";
            this.buttonNeuerTeilnehmer.UseVisualStyleBackColor = true;
            this.buttonNeuerTeilnehmer.Click += new System.EventHandler(this.buttonNeuerTeilnehmer_Click);
            // 
            // listBoxReisen
            // 
            this.listBoxReisen.FormattingEnabled = true;
            this.listBoxReisen.Location = new System.Drawing.Point(20, 45);
            this.listBoxReisen.Name = "listBoxReisen";
            this.listBoxReisen.Size = new System.Drawing.Size(502, 212);
            this.listBoxReisen.TabIndex = 3;
            this.listBoxReisen.SelectedIndexChanged += new System.EventHandler(this.listBoxReisen_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMaxTN);
            this.groupBox1.Controls.Add(this.labelBis);
            this.groupBox1.Controls.Add(this.textBoxMaxTN);
            this.groupBox1.Controls.Add(this.textBoxBis);
            this.groupBox1.Controls.Add(this.labelVon);
            this.groupBox1.Controls.Add(this.labelPreis);
            this.groupBox1.Controls.Add(this.labelZiel);
            this.groupBox1.Controls.Add(this.textBoxVon);
            this.groupBox1.Controls.Add(this.textBoxPreis);
            this.groupBox1.Controls.Add(this.textBoxZiel);
            this.groupBox1.Controls.Add(this.buttonReiseLoeschen);
            this.groupBox1.Controls.Add(this.buttonReiseHinzufuegen);
            this.groupBox1.Location = new System.Drawing.Point(568, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 213);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuer Teilnehmer";
            // 
            // labelVon
            // 
            this.labelVon.AutoSize = true;
            this.labelVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVon.Location = new System.Drawing.Point(299, 83);
            this.labelVon.Name = "labelVon";
            this.labelVon.Size = new System.Drawing.Size(31, 16);
            this.labelVon.TabIndex = 7;
            this.labelVon.Text = "Von";
            // 
            // labelPreis
            // 
            this.labelPreis.AutoSize = true;
            this.labelPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreis.Location = new System.Drawing.Point(299, 57);
            this.labelPreis.Name = "labelPreis";
            this.labelPreis.Size = new System.Drawing.Size(38, 16);
            this.labelPreis.TabIndex = 6;
            this.labelPreis.Text = "Preis";
            // 
            // labelZiel
            // 
            this.labelZiel.AutoSize = true;
            this.labelZiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZiel.Location = new System.Drawing.Point(299, 32);
            this.labelZiel.Name = "labelZiel";
            this.labelZiel.Size = new System.Drawing.Size(29, 16);
            this.labelZiel.TabIndex = 5;
            this.labelZiel.Text = "Ziel";
            // 
            // textBoxVon
            // 
            this.textBoxVon.Location = new System.Drawing.Point(7, 83);
            this.textBoxVon.Name = "textBoxVon";
            this.textBoxVon.Size = new System.Drawing.Size(276, 20);
            this.textBoxVon.TabIndex = 4;
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Location = new System.Drawing.Point(8, 57);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(276, 20);
            this.textBoxPreis.TabIndex = 3;
            // 
            // textBoxZiel
            // 
            this.textBoxZiel.Location = new System.Drawing.Point(7, 31);
            this.textBoxZiel.Name = "textBoxZiel";
            this.textBoxZiel.Size = new System.Drawing.Size(276, 20);
            this.textBoxZiel.TabIndex = 2;
            // 
            // buttonReiseLoeschen
            // 
            this.buttonReiseLoeschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReiseLoeschen.Location = new System.Drawing.Point(7, 174);
            this.buttonReiseLoeschen.Name = "buttonReiseLoeschen";
            this.buttonReiseLoeschen.Size = new System.Drawing.Size(488, 33);
            this.buttonReiseLoeschen.TabIndex = 1;
            this.buttonReiseLoeschen.Text = "Reise löschen";
            this.buttonReiseLoeschen.UseVisualStyleBackColor = true;
            this.buttonReiseLoeschen.Click += new System.EventHandler(this.buttonReiseLoeschen_Click);
            // 
            // buttonReiseHinzufuegen
            // 
            this.buttonReiseHinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReiseHinzufuegen.Location = new System.Drawing.Point(396, 19);
            this.buttonReiseHinzufuegen.Name = "buttonReiseHinzufuegen";
            this.buttonReiseHinzufuegen.Size = new System.Drawing.Size(99, 149);
            this.buttonReiseHinzufuegen.TabIndex = 0;
            this.buttonReiseHinzufuegen.Text = "Neue Reise hinzufügen";
            this.buttonReiseHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonReiseHinzufuegen.Click += new System.EventHandler(this.buttonReiseHinzufuegen_Click);
            // 
            // labelMaxTN
            // 
            this.labelMaxTN.AutoSize = true;
            this.labelMaxTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTN.Location = new System.Drawing.Point(300, 135);
            this.labelMaxTN.Name = "labelMaxTN";
            this.labelMaxTN.Size = new System.Drawing.Size(51, 16);
            this.labelMaxTN.TabIndex = 12;
            this.labelMaxTN.Text = "MaxTN";
            // 
            // labelBis
            // 
            this.labelBis.AutoSize = true;
            this.labelBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBis.Location = new System.Drawing.Point(300, 110);
            this.labelBis.Name = "labelBis";
            this.labelBis.Size = new System.Drawing.Size(26, 16);
            this.labelBis.TabIndex = 11;
            this.labelBis.Text = "Bis";
            // 
            // textBoxMaxTN
            // 
            this.textBoxMaxTN.Location = new System.Drawing.Point(9, 135);
            this.textBoxMaxTN.Name = "textBoxMaxTN";
            this.textBoxMaxTN.Size = new System.Drawing.Size(276, 20);
            this.textBoxMaxTN.TabIndex = 9;
            // 
            // textBoxBis
            // 
            this.textBoxBis.Location = new System.Drawing.Point(8, 109);
            this.textBoxBis.Name = "textBoxBis";
            this.textBoxBis.Size = new System.Drawing.Size(276, 20);
            this.textBoxBis.TabIndex = 8;
            // 
            // ReiseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxReisen);
            this.Controls.Add(this.groupBoxNeuerTeilnehmer);
            this.Controls.Add(this.listBoxTeilnehmer);
            this.Name = "ReiseUI";
            this.Text = "Reise";
            this.groupBoxNeuerTeilnehmer.ResumeLayout(false);
            this.groupBoxNeuerTeilnehmer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTeilnehmer;
        private System.Windows.Forms.GroupBox groupBoxNeuerTeilnehmer;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Button buttonLöschen;
        private System.Windows.Forms.Button buttonNeuerTeilnehmer;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.ListBox listBoxReisen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMaxTN;
        private System.Windows.Forms.Label labelBis;
        private System.Windows.Forms.TextBox textBoxMaxTN;
        private System.Windows.Forms.TextBox textBoxBis;
        private System.Windows.Forms.Label labelVon;
        private System.Windows.Forms.Label labelPreis;
        private System.Windows.Forms.Label labelZiel;
        private System.Windows.Forms.TextBox textBoxVon;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.TextBox textBoxZiel;
        private System.Windows.Forms.Button buttonReiseLoeschen;
        private System.Windows.Forms.Button buttonReiseHinzufuegen;
    }
}

