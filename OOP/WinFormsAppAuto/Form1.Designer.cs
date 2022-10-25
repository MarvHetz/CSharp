namespace WinFormsAppAuto
{
    partial class FormAutos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAutoVerwalten = new System.Windows.Forms.GroupBox();
            this.textBoxFüllmenge = new System.Windows.Forms.TextBox();
            this.textBoxKM = new System.Windows.Forms.TextBox();
            this.textBoxVerbrauch = new System.Windows.Forms.TextBox();
            this.textBoxKZ = new System.Windows.Forms.TextBox();
            this.buttonAutoErzeugen = new System.Windows.Forms.Button();
            this.labelFüllmenge = new System.Windows.Forms.Label();
            this.labelKM = new System.Windows.Forms.Label();
            this.labelVerbrauch = new System.Windows.Forms.Label();
            this.labelKZ = new System.Windows.Forms.Label();
            this.groupBoxAutosAnzeigen = new System.Windows.Forms.GroupBox();
            this.buttonAutoAnzeigen = new System.Windows.Forms.Button();
            this.listBoxAutos = new System.Windows.Forms.ListBox();
            this.groupBoxAutoVerwalten.SuspendLayout();
            this.groupBoxAutosAnzeigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAutoVerwalten
            // 
            this.groupBoxAutoVerwalten.Controls.Add(this.textBoxFüllmenge);
            this.groupBoxAutoVerwalten.Controls.Add(this.textBoxKM);
            this.groupBoxAutoVerwalten.Controls.Add(this.textBoxVerbrauch);
            this.groupBoxAutoVerwalten.Controls.Add(this.textBoxKZ);
            this.groupBoxAutoVerwalten.Controls.Add(this.buttonAutoErzeugen);
            this.groupBoxAutoVerwalten.Controls.Add(this.labelFüllmenge);
            this.groupBoxAutoVerwalten.Controls.Add(this.labelKM);
            this.groupBoxAutoVerwalten.Controls.Add(this.labelVerbrauch);
            this.groupBoxAutoVerwalten.Controls.Add(this.labelKZ);
            this.groupBoxAutoVerwalten.Location = new System.Drawing.Point(51, 64);
            this.groupBoxAutoVerwalten.Name = "groupBoxAutoVerwalten";
            this.groupBoxAutoVerwalten.Size = new System.Drawing.Size(228, 259);
            this.groupBoxAutoVerwalten.TabIndex = 0;
            this.groupBoxAutoVerwalten.TabStop = false;
            this.groupBoxAutoVerwalten.Text = "Autos verwalten";
            // 
            // textBoxFüllmenge
            // 
            this.textBoxFüllmenge.Location = new System.Drawing.Point(112, 128);
            this.textBoxFüllmenge.Name = "textBoxFüllmenge";
            this.textBoxFüllmenge.Size = new System.Drawing.Size(100, 23);
            this.textBoxFüllmenge.TabIndex = 8;
            // 
            // textBoxKM
            // 
            this.textBoxKM.Location = new System.Drawing.Point(112, 99);
            this.textBoxKM.Name = "textBoxKM";
            this.textBoxKM.Size = new System.Drawing.Size(100, 23);
            this.textBoxKM.TabIndex = 7;
            // 
            // textBoxVerbrauch
            // 
            this.textBoxVerbrauch.Location = new System.Drawing.Point(112, 70);
            this.textBoxVerbrauch.Name = "textBoxVerbrauch";
            this.textBoxVerbrauch.Size = new System.Drawing.Size(100, 23);
            this.textBoxVerbrauch.TabIndex = 6;
            // 
            // textBoxKZ
            // 
            this.textBoxKZ.Location = new System.Drawing.Point(112, 38);
            this.textBoxKZ.Name = "textBoxKZ";
            this.textBoxKZ.Size = new System.Drawing.Size(100, 23);
            this.textBoxKZ.TabIndex = 5;
            // 
            // buttonAutoErzeugen
            // 
            this.buttonAutoErzeugen.Location = new System.Drawing.Point(13, 216);
            this.buttonAutoErzeugen.Name = "buttonAutoErzeugen";
            this.buttonAutoErzeugen.Size = new System.Drawing.Size(199, 23);
            this.buttonAutoErzeugen.TabIndex = 4;
            this.buttonAutoErzeugen.Text = "Autoobjekt erzeugen";
            this.buttonAutoErzeugen.UseVisualStyleBackColor = true;
            this.buttonAutoErzeugen.Click += new System.EventHandler(this.buttonAutoErzeugen_Click);
            // 
            // labelFüllmenge
            // 
            this.labelFüllmenge.AutoSize = true;
            this.labelFüllmenge.Location = new System.Drawing.Point(23, 124);
            this.labelFüllmenge.Name = "labelFüllmenge";
            this.labelFüllmenge.Size = new System.Drawing.Size(63, 15);
            this.labelFüllmenge.TabIndex = 3;
            this.labelFüllmenge.Text = "Füllmenge";
            // 
            // labelKM
            // 
            this.labelKM.AutoSize = true;
            this.labelKM.Location = new System.Drawing.Point(23, 99);
            this.labelKM.Name = "labelKM";
            this.labelKM.Size = new System.Drawing.Size(54, 15);
            this.labelKM.TabIndex = 2;
            this.labelKM.Text = "KMstand";
            // 
            // labelVerbrauch
            // 
            this.labelVerbrauch.AutoSize = true;
            this.labelVerbrauch.Location = new System.Drawing.Point(23, 70);
            this.labelVerbrauch.Name = "labelVerbrauch";
            this.labelVerbrauch.Size = new System.Drawing.Size(60, 15);
            this.labelVerbrauch.TabIndex = 1;
            this.labelVerbrauch.Text = "Verbrauch";
            // 
            // labelKZ
            // 
            this.labelKZ.AutoSize = true;
            this.labelKZ.Location = new System.Drawing.Point(23, 38);
            this.labelKZ.Name = "labelKZ";
            this.labelKZ.Size = new System.Drawing.Size(74, 15);
            this.labelKZ.TabIndex = 0;
            this.labelKZ.Text = "Kennzeichen";
            // 
            // groupBoxAutosAnzeigen
            // 
            this.groupBoxAutosAnzeigen.Controls.Add(this.buttonAutoAnzeigen);
            this.groupBoxAutosAnzeigen.Controls.Add(this.listBoxAutos);
            this.groupBoxAutosAnzeigen.Location = new System.Drawing.Point(431, 64);
            this.groupBoxAutosAnzeigen.Name = "groupBoxAutosAnzeigen";
            this.groupBoxAutosAnzeigen.Size = new System.Drawing.Size(334, 259);
            this.groupBoxAutosAnzeigen.TabIndex = 1;
            this.groupBoxAutosAnzeigen.TabStop = false;
            this.groupBoxAutosAnzeigen.Text = "Autos anzeigen";
            // 
            // buttonAutoAnzeigen
            // 
            this.buttonAutoAnzeigen.Location = new System.Drawing.Point(6, 231);
            this.buttonAutoAnzeigen.Name = "buttonAutoAnzeigen";
            this.buttonAutoAnzeigen.Size = new System.Drawing.Size(322, 23);
            this.buttonAutoAnzeigen.TabIndex = 1;
            this.buttonAutoAnzeigen.Text = "Auto anzeigen";
            this.buttonAutoAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAutoAnzeigen.Click += new System.EventHandler(this.buttonAutoAnzeigen_Click);
            // 
            // listBoxAutos
            // 
            this.listBoxAutos.FormattingEnabled = true;
            this.listBoxAutos.ItemHeight = 15;
            this.listBoxAutos.Location = new System.Drawing.Point(8, 20);
            this.listBoxAutos.Name = "listBoxAutos";
            this.listBoxAutos.Size = new System.Drawing.Size(320, 199);
            this.listBoxAutos.TabIndex = 0;
            this.listBoxAutos.SelectedIndexChanged += new System.EventHandler(this.listBoxAutos_SelectedIndexChanged);
            // 
            // FormAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 354);
            this.Controls.Add(this.groupBoxAutosAnzeigen);
            this.Controls.Add(this.groupBoxAutoVerwalten);
            this.Name = "FormAutos";
            this.Text = "Autos verwalten";
            this.groupBoxAutoVerwalten.ResumeLayout(false);
            this.groupBoxAutoVerwalten.PerformLayout();
            this.groupBoxAutosAnzeigen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxAutoVerwalten;
        private Button buttonAutoErzeugen;
        private Label labelFüllmenge;
        private Label labelKM;
        private Label labelVerbrauch;
        private Label labelKZ;
        private TextBox textBoxFüllmenge;
        private TextBox textBoxKM;
        private TextBox textBoxVerbrauch;
        private TextBox textBoxKZ;
        private GroupBox groupBoxAutosAnzeigen;
        private Button buttonAutoAnzeigen;
        private ListBox listBoxAutos;
    }
}