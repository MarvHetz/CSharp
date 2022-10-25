namespace Farbauswahl
{
    partial class FormFarbauswahl
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
            this.labelFarbauswahl = new System.Windows.Forms.Label();
            this.comboBoxFarbe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelFarbauswahl
            // 
            this.labelFarbauswahl.AutoSize = true;
            this.labelFarbauswahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFarbauswahl.Location = new System.Drawing.Point(91, 89);
            this.labelFarbauswahl.Name = "labelFarbauswahl";
            this.labelFarbauswahl.Size = new System.Drawing.Size(135, 25);
            this.labelFarbauswahl.TabIndex = 0;
            this.labelFarbauswahl.Text = "Farbauswahl";
            // 
            // comboBoxFarbe
            // 
            this.comboBoxFarbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFarbe.FormattingEnabled = true;
            this.comboBoxFarbe.Location = new System.Drawing.Point(96, 169);
            this.comboBoxFarbe.Name = "comboBoxFarbe";
            this.comboBoxFarbe.Size = new System.Drawing.Size(121, 33);
            this.comboBoxFarbe.TabIndex = 1;
            this.comboBoxFarbe.SelectedIndexChanged += new System.EventHandler(this.comboBoxFarbe_SelectedIndexChanged);
            // 
            // FormFarbauswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxFarbe);
            this.Controls.Add(this.labelFarbauswahl);
            this.Name = "FormFarbauswahl";
            this.Text = "Farbauswahl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFarbauswahl;
        private System.Windows.Forms.ComboBox comboBoxFarbe;
    }
}

