namespace TicTacToe
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
            this.tableLayoutPanelGameField = new System.Windows.Forms.TableLayoutPanel();
            this.labelAktuellerSpieler = new System.Windows.Forms.Label();
            this.labelGetAktuellerSpieler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGameField
            // 
            this.tableLayoutPanelGameField.ColumnCount = 3;
            this.tableLayoutPanelGameField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGameField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelGameField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelGameField.Location = new System.Drawing.Point(273, 107);
            this.tableLayoutPanelGameField.Name = "tableLayoutPanelGameField";
            this.tableLayoutPanelGameField.RowCount = 3;
            this.tableLayoutPanelGameField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGameField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGameField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGameField.Size = new System.Drawing.Size(518, 467);
            this.tableLayoutPanelGameField.TabIndex = 0;
            // 
            // labelAktuellerSpieler
            // 
            this.labelAktuellerSpieler.AutoSize = true;
            this.labelAktuellerSpieler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAktuellerSpieler.Location = new System.Drawing.Point(273, 683);
            this.labelAktuellerSpieler.Name = "labelAktuellerSpieler";
            this.labelAktuellerSpieler.Size = new System.Drawing.Size(181, 25);
            this.labelAktuellerSpieler.TabIndex = 1;
            this.labelAktuellerSpieler.Text = "Aktueller Spieler: ";
            // 
            // labelGetAktuellerSpieler
            // 
            this.labelGetAktuellerSpieler.AutoSize = true;
            this.labelGetAktuellerSpieler.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetAktuellerSpieler.Location = new System.Drawing.Point(448, 646);
            this.labelGetAktuellerSpieler.Name = "labelGetAktuellerSpieler";
            this.labelGetAktuellerSpieler.Size = new System.Drawing.Size(71, 108);
            this.labelGetAktuellerSpieler.TabIndex = 2;
            this.labelGetAktuellerSpieler.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1082, 781);
            this.Controls.Add(this.labelGetAktuellerSpieler);
            this.Controls.Add(this.labelAktuellerSpieler);
            this.Controls.Add(this.tableLayoutPanelGameField);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGameField;
        private System.Windows.Forms.Label labelAktuellerSpieler;
        private System.Windows.Forms.Label labelGetAktuellerSpieler;
    }
}

