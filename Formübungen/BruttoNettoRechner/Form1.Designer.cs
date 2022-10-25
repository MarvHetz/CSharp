namespace BruttoNettoRechner
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
            this.labelPreis = new System.Windows.Forms.Label();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.groupBoxMwSt = new System.Windows.Forms.GroupBox();
            this.radioButton19prozent = new System.Windows.Forms.RadioButton();
            this.radioButton7prozent = new System.Windows.Forms.RadioButton();
            this.labelErgebnis = new System.Windows.Forms.Label();
            this.textBoxErgebnis = new System.Windows.Forms.TextBox();
            this.buttonNettoBerechnen = new System.Windows.Forms.Button();
            this.buttonBruttoBerechnen = new System.Windows.Forms.Button();
            this.groupBoxMwSt.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPreis
            // 
            this.labelPreis.AutoSize = true;
            this.labelPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreis.Location = new System.Drawing.Point(146, 62);
            this.labelPreis.Name = "labelPreis";
            this.labelPreis.Size = new System.Drawing.Size(67, 25);
            this.labelPreis.TabIndex = 0;
            this.labelPreis.Text = "Preis:";
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreis.Location = new System.Drawing.Point(351, 62);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(100, 31);
            this.textBoxPreis.TabIndex = 1;
            // 
            // groupBoxMwSt
            // 
            this.groupBoxMwSt.Controls.Add(this.radioButton19prozent);
            this.groupBoxMwSt.Controls.Add(this.radioButton7prozent);
            this.groupBoxMwSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMwSt.Location = new System.Drawing.Point(151, 139);
            this.groupBoxMwSt.Name = "groupBoxMwSt";
            this.groupBoxMwSt.Size = new System.Drawing.Size(304, 78);
            this.groupBoxMwSt.TabIndex = 4;
            this.groupBoxMwSt.TabStop = false;
            this.groupBoxMwSt.Text = "Mehrwertsteuersatz auswählen";
            // 
            // radioButton19prozent
            // 
            this.radioButton19prozent.AutoSize = true;
            this.radioButton19prozent.Location = new System.Drawing.Point(200, 39);
            this.radioButton19prozent.Name = "radioButton19prozent";
            this.radioButton19prozent.Size = new System.Drawing.Size(63, 28);
            this.radioButton19prozent.TabIndex = 1;
            this.radioButton19prozent.TabStop = true;
            this.radioButton19prozent.Text = "19%";
            this.radioButton19prozent.UseVisualStyleBackColor = true;
            // 
            // radioButton7prozent
            // 
            this.radioButton7prozent.AutoSize = true;
            this.radioButton7prozent.Location = new System.Drawing.Point(58, 39);
            this.radioButton7prozent.Name = "radioButton7prozent";
            this.radioButton7prozent.Size = new System.Drawing.Size(53, 28);
            this.radioButton7prozent.TabIndex = 0;
            this.radioButton7prozent.TabStop = true;
            this.radioButton7prozent.Text = "7%";
            this.radioButton7prozent.UseVisualStyleBackColor = true;
            // 
            // labelErgebnis
            // 
            this.labelErgebnis.AutoSize = true;
            this.labelErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErgebnis.Location = new System.Drawing.Point(146, 277);
            this.labelErgebnis.Name = "labelErgebnis";
            this.labelErgebnis.Size = new System.Drawing.Size(103, 25);
            this.labelErgebnis.TabIndex = 5;
            this.labelErgebnis.Text = "Ergebnis:";
            // 
            // textBoxErgebnis
            // 
            this.textBoxErgebnis.CausesValidation = false;
            this.textBoxErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxErgebnis.Location = new System.Drawing.Point(351, 281);
            this.textBoxErgebnis.Name = "textBoxErgebnis";
            this.textBoxErgebnis.Size = new System.Drawing.Size(100, 31);
            this.textBoxErgebnis.TabIndex = 6;
            // 
            // buttonNettoBerechnen
            // 
            this.buttonNettoBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNettoBerechnen.Location = new System.Drawing.Point(556, 100);
            this.buttonNettoBerechnen.Name = "buttonNettoBerechnen";
            this.buttonNettoBerechnen.Size = new System.Drawing.Size(216, 73);
            this.buttonNettoBerechnen.TabIndex = 7;
            this.buttonNettoBerechnen.Text = "Netto Berechnen";
            this.buttonNettoBerechnen.UseVisualStyleBackColor = true;
            this.buttonNettoBerechnen.Click += new System.EventHandler(this.buttonNettoBerechnen_Click);
            // 
            // buttonBruttoBerechnen
            // 
            this.buttonBruttoBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBruttoBerechnen.Location = new System.Drawing.Point(556, 208);
            this.buttonBruttoBerechnen.Name = "buttonBruttoBerechnen";
            this.buttonBruttoBerechnen.Size = new System.Drawing.Size(216, 73);
            this.buttonBruttoBerechnen.TabIndex = 8;
            this.buttonBruttoBerechnen.Text = "Brutto Berechnen";
            this.buttonBruttoBerechnen.UseVisualStyleBackColor = true;
            this.buttonBruttoBerechnen.Click += new System.EventHandler(this.buttonBruttoBerechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBruttoBerechnen);
            this.Controls.Add(this.buttonNettoBerechnen);
            this.Controls.Add(this.textBoxErgebnis);
            this.Controls.Add(this.labelErgebnis);
            this.Controls.Add(this.groupBoxMwSt);
            this.Controls.Add(this.textBoxPreis);
            this.Controls.Add(this.labelPreis);
            this.Name = "Form1";
            this.Text = "Netto->Brutto Rechner";
            this.groupBoxMwSt.ResumeLayout(false);
            this.groupBoxMwSt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPreis;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.GroupBox groupBoxMwSt;
        private System.Windows.Forms.RadioButton radioButton19prozent;
        private System.Windows.Forms.RadioButton radioButton7prozent;
        private System.Windows.Forms.Label labelErgebnis;
        private System.Windows.Forms.TextBox textBoxErgebnis;
        private System.Windows.Forms.Button buttonNettoBerechnen;
        private System.Windows.Forms.Button buttonBruttoBerechnen;
    }
}

