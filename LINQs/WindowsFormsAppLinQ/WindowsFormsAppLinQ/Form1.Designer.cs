namespace WindowsFormsAppLinQ
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
            this.listBoxKleinerGleich3 = new System.Windows.Forms.ListBox();
            this.listBoxGroesser3 = new System.Windows.Forms.ListBox();
            this.labelGroesser3 = new System.Windows.Forms.Label();
            this.labelKleinerGleich3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxKleinerGleich3
            // 
            this.listBoxKleinerGleich3.FormattingEnabled = true;
            this.listBoxKleinerGleich3.Location = new System.Drawing.Point(31, 55);
            this.listBoxKleinerGleich3.Name = "listBoxKleinerGleich3";
            this.listBoxKleinerGleich3.Size = new System.Drawing.Size(220, 212);
            this.listBoxKleinerGleich3.TabIndex = 0;
            // 
            // listBoxGroesser3
            // 
            this.listBoxGroesser3.FormattingEnabled = true;
            this.listBoxGroesser3.Location = new System.Drawing.Point(288, 55);
            this.listBoxGroesser3.Name = "listBoxGroesser3";
            this.listBoxGroesser3.Size = new System.Drawing.Size(220, 212);
            this.listBoxGroesser3.TabIndex = 1;
            // 
            // labelGroesser3
            // 
            this.labelGroesser3.AutoSize = true;
            this.labelGroesser3.Location = new System.Drawing.Point(401, 36);
            this.labelGroesser3.Name = "labelGroesser3";
            this.labelGroesser3.Size = new System.Drawing.Size(19, 13);
            this.labelGroesser3.TabIndex = 2;
            this.labelGroesser3.Text = ">3";
            this.labelGroesser3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelKleinerGleich3
            // 
            this.labelKleinerGleich3.AutoSize = true;
            this.labelKleinerGleich3.Location = new System.Drawing.Point(133, 39);
            this.labelKleinerGleich3.Name = "labelKleinerGleich3";
            this.labelKleinerGleich3.Size = new System.Drawing.Size(25, 13);
            this.labelKleinerGleich3.TabIndex = 3;
            this.labelKleinerGleich3.Text = "<=3";
            this.labelKleinerGleich3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKleinerGleich3);
            this.Controls.Add(this.labelGroesser3);
            this.Controls.Add(this.listBoxGroesser3);
            this.Controls.Add(this.listBoxKleinerGleich3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKleinerGleich3;
        private System.Windows.Forms.ListBox listBoxGroesser3;
        private System.Windows.Forms.Label labelGroesser3;
        private System.Windows.Forms.Label labelKleinerGleich3;
    }
}

