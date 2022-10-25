namespace Pokemon
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
            this.labelPokedex = new System.Windows.Forms.Label();
            this.comboBoxPokemons = new System.Windows.Forms.ComboBox();
            this.pictureBoxPokemons = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPokedex
            // 
            this.labelPokedex.AutoSize = true;
            this.labelPokedex.Font = new System.Drawing.Font("72 Monospace", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPokedex.Location = new System.Drawing.Point(53, 79);
            this.labelPokedex.Name = "labelPokedex";
            this.labelPokedex.Size = new System.Drawing.Size(133, 32);
            this.labelPokedex.TabIndex = 0;
            this.labelPokedex.Text = "Pokedex";
            // 
            // comboBoxPokemons
            // 
            this.comboBoxPokemons.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPokemons.FormattingEnabled = true;
            this.comboBoxPokemons.Location = new System.Drawing.Point(59, 128);
            this.comboBoxPokemons.Name = "comboBoxPokemons";
            this.comboBoxPokemons.Size = new System.Drawing.Size(177, 41);
            this.comboBoxPokemons.TabIndex = 1;
            this.comboBoxPokemons.SelectedIndexChanged += new System.EventHandler(this.comboBoxPokemons_SelectedIndexChanged);
            // 
            // pictureBoxPokemons
            // 
            this.pictureBoxPokemons.Location = new System.Drawing.Point(327, 37);
            this.pictureBoxPokemons.Name = "pictureBoxPokemons";
            this.pictureBoxPokemons.Size = new System.Drawing.Size(437, 388);
            this.pictureBoxPokemons.TabIndex = 2;
            this.pictureBoxPokemons.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPokemons);
            this.Controls.Add(this.comboBoxPokemons);
            this.Controls.Add(this.labelPokedex);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPokedex;
        private System.Windows.Forms.ComboBox comboBoxPokemons;
        private System.Windows.Forms.PictureBox pictureBoxPokemons;
    }
}

