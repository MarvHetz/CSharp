namespace WindowsFormsAppListen
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelGeb = new System.Windows.Forms.Label();
            this.labelWohnort = new System.Windows.Forms.Label();
            this.listSchüler = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxGeb = new System.Windows.Forms.TextBox();
            this.textBoxWohnort = new System.Windows.Forms.TextBox();
            this.buttonAufnehmen = new System.Windows.Forms.Button();
            this.buttonEntlassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(60, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelGeb
            // 
            this.labelGeb.AutoSize = true;
            this.labelGeb.Location = new System.Drawing.Point(63, 128);
            this.labelGeb.Name = "labelGeb";
            this.labelGeb.Size = new System.Drawing.Size(73, 13);
            this.labelGeb.TabIndex = 1;
            this.labelGeb.Text = "Geburtsdatum";
            // 
            // labelWohnort
            // 
            this.labelWohnort.AutoSize = true;
            this.labelWohnort.Location = new System.Drawing.Point(63, 207);
            this.labelWohnort.Name = "labelWohnort";
            this.labelWohnort.Size = new System.Drawing.Size(48, 13);
            this.labelWohnort.TabIndex = 2;
            this.labelWohnort.Text = "Wohnort";
            // 
            // listSchüler
            // 
            this.listSchüler.FormattingEnabled = true;
            this.listSchüler.Location = new System.Drawing.Point(354, 51);
            this.listSchüler.Name = "listSchüler";
            this.listSchüler.Size = new System.Drawing.Size(411, 329);
            this.listSchüler.TabIndex = 3;
            this.listSchüler.SelectedIndexChanged += new System.EventHandler(this.listSchüler_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(63, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxGeb
            // 
            this.textBoxGeb.Location = new System.Drawing.Point(63, 158);
            this.textBoxGeb.Name = "textBoxGeb";
            this.textBoxGeb.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeb.TabIndex = 5;
            // 
            // textBoxWohnort
            // 
            this.textBoxWohnort.Location = new System.Drawing.Point(63, 237);
            this.textBoxWohnort.Name = "textBoxWohnort";
            this.textBoxWohnort.Size = new System.Drawing.Size(100, 20);
            this.textBoxWohnort.TabIndex = 6;
            // 
            // buttonAufnehmen
            // 
            this.buttonAufnehmen.Location = new System.Drawing.Point(63, 275);
            this.buttonAufnehmen.Name = "buttonAufnehmen";
            this.buttonAufnehmen.Size = new System.Drawing.Size(116, 60);
            this.buttonAufnehmen.TabIndex = 7;
            this.buttonAufnehmen.Text = "Schüler aufnehmen";
            this.buttonAufnehmen.UseVisualStyleBackColor = true;
            this.buttonAufnehmen.Click += new System.EventHandler(this.buttonAufnehmen_Click);
            // 
            // buttonEntlassen
            // 
            this.buttonEntlassen.Location = new System.Drawing.Point(63, 363);
            this.buttonEntlassen.Name = "buttonEntlassen";
            this.buttonEntlassen.Size = new System.Drawing.Size(116, 60);
            this.buttonEntlassen.TabIndex = 8;
            this.buttonEntlassen.Text = "Schüler entlassen";
            this.buttonEntlassen.UseVisualStyleBackColor = true;
            this.buttonEntlassen.Click += new System.EventHandler(this.buttonEntlassen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEntlassen);
            this.Controls.Add(this.buttonAufnehmen);
            this.Controls.Add(this.textBoxWohnort);
            this.Controls.Add(this.textBoxGeb);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listSchüler);
            this.Controls.Add(this.labelWohnort);
            this.Controls.Add(this.labelGeb);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGeb;
        private System.Windows.Forms.Label labelWohnort;
        private System.Windows.Forms.ListBox listSchüler;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxGeb;
        private System.Windows.Forms.TextBox textBoxWohnort;
        private System.Windows.Forms.Button buttonAufnehmen;
        private System.Windows.Forms.Button buttonEntlassen;
    }
}

