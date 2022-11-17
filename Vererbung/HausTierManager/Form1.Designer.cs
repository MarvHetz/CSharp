namespace HausTierManager
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
            this.Haustier = new System.Windows.Forms.GroupBox();
            this.buttonFüttern = new System.Windows.Forms.Button();
            this.listBoxTiere = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxTiere = new System.Windows.Forms.ComboBox();
            this.radioButtonHund = new System.Windows.Forms.RadioButton();
            this.buttonImpfen = new System.Windows.Forms.Button();
            this.radioKatze = new System.Windows.Forms.RadioButton();
            this.radioButtonRasseKatze = new System.Windows.Forms.RadioButton();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxGewicht = new System.Windows.Forms.TextBox();
            this.textBoxHundesteuer = new System.Windows.Forms.TextBox();
            this.labelGewicht = new System.Windows.Forms.Label();
            this.labelHundesteuer = new System.Windows.Forms.Label();
            this.buttonNeuesTier = new System.Windows.Forms.Button();
            this.Haustier.SuspendLayout();
            this.SuspendLayout();
            // 
            // Haustier
            // 
            this.Haustier.Controls.Add(this.labelName);
            this.Haustier.Controls.Add(this.labelGewicht);
            this.Haustier.Controls.Add(this.labelHundesteuer);
            this.Haustier.Controls.Add(this.textBoxHundesteuer);
            this.Haustier.Controls.Add(this.textBoxGewicht);
            this.Haustier.Controls.Add(this.radioButtonRasseKatze);
            this.Haustier.Controls.Add(this.radioKatze);
            this.Haustier.Controls.Add(this.radioButtonHund);
            this.Haustier.Controls.Add(this.textBoxName);
            this.Haustier.Location = new System.Drawing.Point(12, 40);
            this.Haustier.Name = "Haustier";
            this.Haustier.Size = new System.Drawing.Size(304, 248);
            this.Haustier.TabIndex = 0;
            this.Haustier.TabStop = false;
            this.Haustier.Text = "Haustier";
            // 
            // buttonFüttern
            // 
            this.buttonFüttern.Location = new System.Drawing.Point(331, 229);
            this.buttonFüttern.Name = "buttonFüttern";
            this.buttonFüttern.Size = new System.Drawing.Size(92, 59);
            this.buttonFüttern.TabIndex = 1;
            this.buttonFüttern.Text = "Füttern";
            this.buttonFüttern.UseVisualStyleBackColor = true;
            // 
            // listBoxTiere
            // 
            this.listBoxTiere.FormattingEnabled = true;
            this.listBoxTiere.Location = new System.Drawing.Point(331, 76);
            this.listBoxTiere.Name = "listBoxTiere";
            this.listBoxTiere.Size = new System.Drawing.Size(206, 147);
            this.listBoxTiere.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(19, 91);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(173, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // comboBoxTiere
            // 
            this.comboBoxTiere.FormattingEnabled = true;
            this.comboBoxTiere.Location = new System.Drawing.Point(331, 49);
            this.comboBoxTiere.Name = "comboBoxTiere";
            this.comboBoxTiere.Size = new System.Drawing.Size(206, 21);
            this.comboBoxTiere.TabIndex = 4;
            // 
            // radioButtonHund
            // 
            this.radioButtonHund.AutoSize = true;
            this.radioButtonHund.Location = new System.Drawing.Point(19, 36);
            this.radioButtonHund.Name = "radioButtonHund";
            this.radioButtonHund.Size = new System.Drawing.Size(51, 17);
            this.radioButtonHund.TabIndex = 5;
            this.radioButtonHund.TabStop = true;
            this.radioButtonHund.Text = "Hund";
            this.radioButtonHund.UseVisualStyleBackColor = true;
            // 
            // buttonImpfen
            // 
            this.buttonImpfen.Location = new System.Drawing.Point(445, 229);
            this.buttonImpfen.Name = "buttonImpfen";
            this.buttonImpfen.Size = new System.Drawing.Size(92, 59);
            this.buttonImpfen.TabIndex = 6;
            this.buttonImpfen.Text = "Impfen";
            this.buttonImpfen.UseVisualStyleBackColor = true;
            // 
            // radioKatze
            // 
            this.radioKatze.AutoSize = true;
            this.radioKatze.Location = new System.Drawing.Point(110, 36);
            this.radioKatze.Name = "radioKatze";
            this.radioKatze.Size = new System.Drawing.Size(52, 17);
            this.radioKatze.TabIndex = 6;
            this.radioKatze.TabStop = true;
            this.radioKatze.Text = "Katze";
            this.radioKatze.UseVisualStyleBackColor = true;
            // 
            // radioButtonRasseKatze
            // 
            this.radioButtonRasseKatze.AutoSize = true;
            this.radioButtonRasseKatze.Location = new System.Drawing.Point(201, 36);
            this.radioButtonRasseKatze.Name = "radioButtonRasseKatze";
            this.radioButtonRasseKatze.Size = new System.Drawing.Size(81, 17);
            this.radioButtonRasseKatze.TabIndex = 7;
            this.radioButtonRasseKatze.TabStop = true;
            this.radioButtonRasseKatze.Text = "Rassekatze";
            this.radioButtonRasseKatze.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // textBoxGewicht
            // 
            this.textBoxGewicht.Location = new System.Drawing.Point(19, 142);
            this.textBoxGewicht.Name = "textBoxGewicht";
            this.textBoxGewicht.Size = new System.Drawing.Size(173, 20);
            this.textBoxGewicht.TabIndex = 8;
            // 
            // textBoxHundesteuer
            // 
            this.textBoxHundesteuer.Location = new System.Drawing.Point(19, 189);
            this.textBoxHundesteuer.Name = "textBoxHundesteuer";
            this.textBoxHundesteuer.Size = new System.Drawing.Size(173, 20);
            this.textBoxHundesteuer.TabIndex = 9;
            // 
            // labelGewicht
            // 
            this.labelGewicht.AutoSize = true;
            this.labelGewicht.Location = new System.Drawing.Point(16, 126);
            this.labelGewicht.Name = "labelGewicht";
            this.labelGewicht.Size = new System.Drawing.Size(46, 13);
            this.labelGewicht.TabIndex = 8;
            this.labelGewicht.Text = "Gewicht";
            // 
            // labelHundesteuer
            // 
            this.labelHundesteuer.AutoSize = true;
            this.labelHundesteuer.Location = new System.Drawing.Point(16, 173);
            this.labelHundesteuer.Name = "labelHundesteuer";
            this.labelHundesteuer.Size = new System.Drawing.Size(105, 13);
            this.labelHundesteuer.TabIndex = 9;
            this.labelHundesteuer.Text = "Hundesteuernummer";
            // 
            // buttonNeuesTier
            // 
            this.buttonNeuesTier.Location = new System.Drawing.Point(12, 294);
            this.buttonNeuesTier.Name = "buttonNeuesTier";
            this.buttonNeuesTier.Size = new System.Drawing.Size(131, 49);
            this.buttonNeuesTier.TabIndex = 7;
            this.buttonNeuesTier.Text = "Neues Haustier";
            this.buttonNeuesTier.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 357);
            this.Controls.Add(this.buttonNeuesTier);
            this.Controls.Add(this.buttonImpfen);
            this.Controls.Add(this.comboBoxTiere);
            this.Controls.Add(this.listBoxTiere);
            this.Controls.Add(this.buttonFüttern);
            this.Controls.Add(this.Haustier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Haustier.ResumeLayout(false);
            this.Haustier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Haustier;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGewicht;
        private System.Windows.Forms.Label labelHundesteuer;
        private System.Windows.Forms.TextBox textBoxHundesteuer;
        private System.Windows.Forms.TextBox textBoxGewicht;
        private System.Windows.Forms.RadioButton radioButtonRasseKatze;
        private System.Windows.Forms.RadioButton radioKatze;
        private System.Windows.Forms.RadioButton radioButtonHund;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonFüttern;
        private System.Windows.Forms.ListBox listBoxTiere;
        private System.Windows.Forms.ComboBox comboBoxTiere;
        private System.Windows.Forms.Button buttonImpfen;
        private System.Windows.Forms.Button buttonNeuesTier;
    }
}

