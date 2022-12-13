namespace WindowsFormsAppQuiz
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
            this.comboBoxFragen = new System.Windows.Forms.ComboBox();
            this.listBoxAntworten = new System.Windows.Forms.ListBox();
            this.buttonAuswerten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFragen
            // 
            this.comboBoxFragen.FormattingEnabled = true;
            this.comboBoxFragen.Location = new System.Drawing.Point(30, 26);
            this.comboBoxFragen.Name = "comboBoxFragen";
            this.comboBoxFragen.Size = new System.Drawing.Size(510, 21);
            this.comboBoxFragen.TabIndex = 0;
            // 
            // listBoxAntworten
            // 
            this.listBoxAntworten.FormattingEnabled = true;
            this.listBoxAntworten.Location = new System.Drawing.Point(30, 72);
            this.listBoxAntworten.Name = "listBoxAntworten";
            this.listBoxAntworten.Size = new System.Drawing.Size(510, 173);
            this.listBoxAntworten.TabIndex = 1;
            // 
            // buttonAuswerten
            // 
            this.buttonAuswerten.Location = new System.Drawing.Point(30, 270);
            this.buttonAuswerten.Name = "buttonAuswerten";
            this.buttonAuswerten.Size = new System.Drawing.Size(514, 23);
            this.buttonAuswerten.TabIndex = 2;
            this.buttonAuswerten.Text = "Auswerten";
            this.buttonAuswerten.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 325);
            this.Controls.Add(this.buttonAuswerten);
            this.Controls.Add(this.listBoxAntworten);
            this.Controls.Add(this.comboBoxFragen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFragen;
        private System.Windows.Forms.ListBox listBoxAntworten;
        private System.Windows.Forms.Button buttonAuswerten;
    }
}

