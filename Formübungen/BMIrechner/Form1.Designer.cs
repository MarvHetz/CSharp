namespace BMIrechner
{
    partial class FormGUI
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
            this.labelÜberschrift = new System.Windows.Forms.Label();
            this.labelGewicht = new System.Windows.Forms.Label();
            this.labelGröße = new System.Windows.Forms.Label();
            this.textBoxGewicht = new System.Windows.Forms.TextBox();
            this.textBoxGröße = new System.Windows.Forms.TextBox();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.textBoxErgebnis = new System.Windows.Forms.TextBox();
            this.pictureBoxBild = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBild)).BeginInit();
            this.SuspendLayout();
            // 
            // labelÜberschrift
            // 
            this.labelÜberschrift.AutoSize = true;
            this.labelÜberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelÜberschrift.Location = new System.Drawing.Point(156, 30);
            this.labelÜberschrift.Name = "labelÜberschrift";
            this.labelÜberschrift.Size = new System.Drawing.Size(480, 33);
            this.labelÜberschrift.TabIndex = 0;
            this.labelÜberschrift.Text = "Lassen Sie sich ihr BMI ausrechnen";
            this.labelÜberschrift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGewicht
            // 
            this.labelGewicht.AutoSize = true;
            this.labelGewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGewicht.Location = new System.Drawing.Point(12, 132);
            this.labelGewicht.Name = "labelGewicht";
            this.labelGewicht.Size = new System.Drawing.Size(355, 25);
            this.labelGewicht.TabIndex = 1;
            this.labelGewicht.Text = "Hier bitte ihr Gewicht (kg) eingeben:";
            this.labelGewicht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGröße
            // 
            this.labelGröße.AutoSize = true;
            this.labelGröße.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGröße.Location = new System.Drawing.Point(17, 187);
            this.labelGröße.Name = "labelGröße";
            this.labelGröße.Size = new System.Drawing.Size(350, 25);
            this.labelGröße.TabIndex = 2;
            this.labelGröße.Text = "Hier bitte ihre Größe (m) eingeben: ";
            this.labelGröße.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxGewicht
            // 
            this.textBoxGewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGewicht.Location = new System.Drawing.Point(460, 129);
            this.textBoxGewicht.Name = "textBoxGewicht";
            this.textBoxGewicht.Size = new System.Drawing.Size(129, 31);
            this.textBoxGewicht.TabIndex = 3;
            // 
            // textBoxGröße
            // 
            this.textBoxGröße.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGröße.Location = new System.Drawing.Point(460, 184);
            this.textBoxGröße.Name = "textBoxGröße";
            this.textBoxGröße.Size = new System.Drawing.Size(129, 31);
            this.textBoxGröße.TabIndex = 4;
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBerechnen.Location = new System.Drawing.Point(292, 268);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(204, 38);
            this.buttonBerechnen.TabIndex = 5;
            this.buttonBerechnen.Text = "BMI berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // textBoxErgebnis
            // 
            this.textBoxErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxErgebnis.Location = new System.Drawing.Point(224, 395);
            this.textBoxErgebnis.Name = "textBoxErgebnis";
            this.textBoxErgebnis.Size = new System.Drawing.Size(379, 31);
            this.textBoxErgebnis.TabIndex = 6;
            // 
            // pictureBoxBild
            // 
            this.pictureBoxBild.Location = new System.Drawing.Point(13, 256);
            this.pictureBoxBild.Name = "pictureBoxBild";
            this.pictureBoxBild.Size = new System.Drawing.Size(180, 170);
            this.pictureBoxBild.TabIndex = 7;
            this.pictureBoxBild.TabStop = false;
            // 
            // FormGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxBild);
            this.Controls.Add(this.textBoxErgebnis);
            this.Controls.Add(this.buttonBerechnen);
            this.Controls.Add(this.textBoxGröße);
            this.Controls.Add(this.textBoxGewicht);
            this.Controls.Add(this.labelGröße);
            this.Controls.Add(this.labelGewicht);
            this.Controls.Add(this.labelÜberschrift);
            this.Name = "FormGUI";
            this.Text = "SuperDuper BMIrechner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelÜberschrift;
        private System.Windows.Forms.Label labelGewicht;
        private System.Windows.Forms.Label labelGröße;
        private System.Windows.Forms.TextBox textBoxGewicht;
        private System.Windows.Forms.TextBox textBoxGröße;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.TextBox textBoxErgebnis;
        private System.Windows.Forms.PictureBox pictureBoxBild;
    }
}

