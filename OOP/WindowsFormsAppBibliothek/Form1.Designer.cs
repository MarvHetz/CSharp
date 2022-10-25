namespace WindowsFormsAppBibliothek
{
    partial class FormBibliothek
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
            this.comboBoxBücher = new System.Windows.Forms.ComboBox();
            this.buttonAusleihen = new System.Windows.Forms.Button();
            this.buttonZurückgeben = new System.Windows.Forms.Button();
            this.labelVerliehen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxBücher
            // 
            this.comboBoxBücher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBücher.FormattingEnabled = true;
            this.comboBoxBücher.Location = new System.Drawing.Point(4, 77);
            this.comboBoxBücher.Name = "comboBoxBücher";
            this.comboBoxBücher.Size = new System.Drawing.Size(444, 33);
            this.comboBoxBücher.TabIndex = 0;
            this.comboBoxBücher.SelectedIndexChanged += new System.EventHandler(this.comboBoxBücher_SelectedIndexChanged);
            // 
            // buttonAusleihen
            // 
            this.buttonAusleihen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAusleihen.Location = new System.Drawing.Point(480, 70);
            this.buttonAusleihen.Name = "buttonAusleihen";
            this.buttonAusleihen.Size = new System.Drawing.Size(164, 40);
            this.buttonAusleihen.TabIndex = 1;
            this.buttonAusleihen.Text = "Ausleihen";
            this.buttonAusleihen.UseVisualStyleBackColor = true;
            this.buttonAusleihen.Click += new System.EventHandler(this.buttonAusleihen_Click);
            // 
            // buttonZurückgeben
            // 
            this.buttonZurückgeben.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZurückgeben.Location = new System.Drawing.Point(480, 116);
            this.buttonZurückgeben.Name = "buttonZurückgeben";
            this.buttonZurückgeben.Size = new System.Drawing.Size(164, 37);
            this.buttonZurückgeben.TabIndex = 2;
            this.buttonZurückgeben.Text = "Zurückgeben";
            this.buttonZurückgeben.UseVisualStyleBackColor = true;
            this.buttonZurückgeben.Click += new System.EventHandler(this.buttonZurückgeben_Click);
            // 
            // labelVerliehen
            // 
            this.labelVerliehen.AutoSize = true;
            this.labelVerliehen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerliehen.Location = new System.Drawing.Point(52, 141);
            this.labelVerliehen.Name = "labelVerliehen";
            this.labelVerliehen.Size = new System.Drawing.Size(0, 25);
            this.labelVerliehen.TabIndex = 3;
            // 
            // FormBibliothek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 197);
            this.Controls.Add(this.labelVerliehen);
            this.Controls.Add(this.buttonZurückgeben);
            this.Controls.Add(this.buttonAusleihen);
            this.Controls.Add(this.comboBoxBücher);
            this.Name = "FormBibliothek";
            this.Text = "Bibliothek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBücher;
        private System.Windows.Forms.Button buttonAusleihen;
        private System.Windows.Forms.Button buttonZurückgeben;
        private System.Windows.Forms.Label labelVerliehen;
    }
}

