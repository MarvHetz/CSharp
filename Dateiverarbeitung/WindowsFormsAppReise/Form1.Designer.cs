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
            this.comboBoxReise = new System.Windows.Forms.ComboBox();
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
            this.groupBoxNeuerTeilnehmer.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxReise
            // 
            this.comboBoxReise.FormattingEnabled = true;
            this.comboBoxReise.Location = new System.Drawing.Point(40, 12);
            this.comboBoxReise.Name = "comboBoxReise";
            this.comboBoxReise.Size = new System.Drawing.Size(482, 21);
            this.comboBoxReise.TabIndex = 0;
            this.comboBoxReise.SelectedIndexChanged += new System.EventHandler(this.comboBoxReise_SelectedIndexChanged);
            // 
            // listBoxTeilnehmer
            // 
            this.listBoxTeilnehmer.FormattingEnabled = true;
            this.listBoxTeilnehmer.Location = new System.Drawing.Point(40, 56);
            this.listBoxTeilnehmer.Name = "listBoxTeilnehmer";
            this.listBoxTeilnehmer.Size = new System.Drawing.Size(482, 147);
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
            this.groupBoxNeuerTeilnehmer.Location = new System.Drawing.Point(40, 225);
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
            // ReiseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.groupBoxNeuerTeilnehmer);
            this.Controls.Add(this.listBoxTeilnehmer);
            this.Controls.Add(this.comboBoxReise);
            this.Name = "ReiseUI";
            this.Text = "Reise";
            this.groupBoxNeuerTeilnehmer.ResumeLayout(false);
            this.groupBoxNeuerTeilnehmer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReise;
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
    }
}

