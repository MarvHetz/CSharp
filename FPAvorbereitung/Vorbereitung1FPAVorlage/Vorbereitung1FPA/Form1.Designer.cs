namespace Vorbereitung1FPA
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
            this.comboBoxArtikel = new System.Windows.Forms.ComboBox();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.textBoxArtikelbezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxArtikelnummer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAufnehmen = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxArtikelanzahl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLaden
            // 
            this.buttonLaden.Location = new System.Drawing.Point(38, 48);
            this.buttonLaden.Name = "buttonLaden";
            this.buttonLaden.Size = new System.Drawing.Size(388, 44);
            this.buttonLaden.TabIndex = 0;
            this.buttonLaden.Text = "Artikel laden";
            this.buttonLaden.UseVisualStyleBackColor = true;
            this.buttonLaden.Click += new System.EventHandler(this.buttonLaden_Click);
            // 
            // comboBoxArtikel
            // 
            this.comboBoxArtikel.FormattingEnabled = true;
            this.comboBoxArtikel.Location = new System.Drawing.Point(38, 108);
            this.comboBoxArtikel.Name = "comboBoxArtikel";
            this.comboBoxArtikel.Size = new System.Drawing.Size(388, 37);
            this.comboBoxArtikel.TabIndex = 1;
            this.comboBoxArtikel.SelectedIndexChanged += new System.EventHandler(this.comboBoxArtikel_SelectedIndexChanged);
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(38, 238);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(388, 44);
            this.buttonSpeichern.TabIndex = 2;
            this.buttonSpeichern.Text = "Artikel speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPreis);
            this.groupBox1.Controls.Add(this.textBoxArtikelbezeichnung);
            this.groupBox1.Controls.Add(this.textBoxArtikelnummer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAufnehmen);
            this.groupBox1.Location = new System.Drawing.Point(528, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 420);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artikel";
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Location = new System.Drawing.Point(268, 227);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(200, 35);
            this.textBoxPreis.TabIndex = 10;
            // 
            // textBoxArtikelbezeichnung
            // 
            this.textBoxArtikelbezeichnung.Location = new System.Drawing.Point(268, 142);
            this.textBoxArtikelbezeichnung.Name = "textBoxArtikelbezeichnung";
            this.textBoxArtikelbezeichnung.Size = new System.Drawing.Size(200, 35);
            this.textBoxArtikelbezeichnung.TabIndex = 9;
            // 
            // textBoxArtikelnummer
            // 
            this.textBoxArtikelnummer.Enabled = false;
            this.textBoxArtikelnummer.Location = new System.Drawing.Point(268, 56);
            this.textBoxArtikelnummer.Name = "textBoxArtikelnummer";
            this.textBoxArtikelnummer.Size = new System.Drawing.Size(200, 35);
            this.textBoxArtikelnummer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Artikelbezeichnung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Artikelnummer";
            // 
            // buttonAufnehmen
            // 
            this.buttonAufnehmen.Location = new System.Drawing.Point(60, 323);
            this.buttonAufnehmen.Name = "buttonAufnehmen";
            this.buttonAufnehmen.Size = new System.Drawing.Size(388, 44);
            this.buttonAufnehmen.TabIndex = 4;
            this.buttonAufnehmen.Text = "Artikel aufnehmen";
            this.buttonAufnehmen.UseVisualStyleBackColor = true;
            this.buttonAufnehmen.Click += new System.EventHandler(this.buttonAufnehmen_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(38, 169);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(388, 44);
            this.buttonLoeschen.TabIndex = 4;
            this.buttonLoeschen.Text = "Artikel löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Artikelanzahl";
            // 
            // textBoxArtikelanzahl
            // 
            this.textBoxArtikelanzahl.Enabled = false;
            this.textBoxArtikelanzahl.Location = new System.Drawing.Point(270, 390);
            this.textBoxArtikelanzahl.Name = "textBoxArtikelanzahl";
            this.textBoxArtikelanzahl.Size = new System.Drawing.Size(100, 35);
            this.textBoxArtikelanzahl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 512);
            this.Controls.Add(this.textBoxArtikelanzahl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.comboBoxArtikel);
            this.Controls.Add(this.buttonLaden);
            this.Name = "Form1";
            this.Text = "Lagerverwaltung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLaden;
        private System.Windows.Forms.ComboBox comboBoxArtikel;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.TextBox textBoxArtikelbezeichnung;
        private System.Windows.Forms.TextBox textBoxArtikelnummer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAufnehmen;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxArtikelanzahl;
    }
}

