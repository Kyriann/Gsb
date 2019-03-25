namespace Gsb
{
    partial class DetailsPraticien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.t_nom = new System.Windows.Forms.TextBox();
            this.t_prenom = new System.Windows.Forms.TextBox();
            this.t_adresse = new System.Windows.Forms.TextBox();
            this.t_codePostal = new System.Windows.Forms.TextBox();
            this.t_ville = new System.Windows.Forms.TextBox();
            this.t_coefNotoriete = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.Label();
            this.codepostal = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.Label();
            this.coefnotoriete = new System.Windows.Forms.Label();
            this.typepraticien = new System.Windows.Forms.Label();
            this.c_typePraticien = new System.Windows.Forms.ComboBox();
            this.b_validModif = new System.Windows.Forms.Button();
            this.b_retour = new System.Windows.Forms.Button();
            this.e_adresse = new System.Windows.Forms.ErrorProvider(this.components);
            this.e_codePostal = new System.Windows.Forms.ErrorProvider(this.components);
            this.e_ville = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.e_adresse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_codePostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ville)).BeginInit();
            this.SuspendLayout();
            // 
            // t_nom
            // 
            this.t_nom.Location = new System.Drawing.Point(176, 39);
            this.t_nom.Name = "t_nom";
            this.t_nom.Size = new System.Drawing.Size(150, 20);
            this.t_nom.TabIndex = 0;
            // 
            // t_prenom
            // 
            this.t_prenom.Location = new System.Drawing.Point(176, 96);
            this.t_prenom.Name = "t_prenom";
            this.t_prenom.Size = new System.Drawing.Size(150, 20);
            this.t_prenom.TabIndex = 1;
            this.t_prenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // t_adresse
            // 
            this.t_adresse.Location = new System.Drawing.Point(176, 147);
            this.t_adresse.Name = "t_adresse";
            this.t_adresse.Size = new System.Drawing.Size(150, 20);
            this.t_adresse.TabIndex = 2;
            this.t_adresse.TextChanged += new System.EventHandler(this.t_adresse_TextChanged);
            // 
            // t_codePostal
            // 
            this.t_codePostal.Location = new System.Drawing.Point(176, 219);
            this.t_codePostal.Name = "t_codePostal";
            this.t_codePostal.Size = new System.Drawing.Size(150, 20);
            this.t_codePostal.TabIndex = 3;
            this.t_codePostal.TextChanged += new System.EventHandler(this.t_codePostal_TextChanged);
            // 
            // t_ville
            // 
            this.t_ville.Location = new System.Drawing.Point(176, 279);
            this.t_ville.Name = "t_ville";
            this.t_ville.Size = new System.Drawing.Size(130, 20);
            this.t_ville.TabIndex = 4;
            this.t_ville.TextChanged += new System.EventHandler(this.t_ville_TextChanged);
            // 
            // t_coefNotoriete
            // 
            this.t_coefNotoriete.Location = new System.Drawing.Point(178, 342);
            this.t_coefNotoriete.Name = "t_coefNotoriete";
            this.t_coefNotoriete.Size = new System.Drawing.Size(130, 20);
            this.t_coefNotoriete.TabIndex = 5;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(50, 42);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(35, 13);
            this.nom.TabIndex = 7;
            this.nom.Text = "Nom :";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(50, 96);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(49, 13);
            this.prenom.TabIndex = 8;
            this.prenom.Text = "Prenom :";
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.Location = new System.Drawing.Point(50, 154);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(51, 13);
            this.adresse.TabIndex = 9;
            this.adresse.Text = "Adresse :";
            // 
            // codepostal
            // 
            this.codepostal.AutoSize = true;
            this.codepostal.Location = new System.Drawing.Point(50, 222);
            this.codepostal.Name = "codepostal";
            this.codepostal.Size = new System.Drawing.Size(69, 13);
            this.codepostal.TabIndex = 10;
            this.codepostal.Text = "Code postal :";
            // 
            // ville
            // 
            this.ville.AutoSize = true;
            this.ville.Location = new System.Drawing.Point(50, 282);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(32, 13);
            this.ville.TabIndex = 11;
            this.ville.Text = "Ville :";
            // 
            // coefnotoriete
            // 
            this.coefnotoriete.AutoSize = true;
            this.coefnotoriete.Location = new System.Drawing.Point(50, 345);
            this.coefnotoriete.Name = "coefnotoriete";
            this.coefnotoriete.Size = new System.Drawing.Size(122, 13);
            this.coefnotoriete.TabIndex = 12;
            this.coefnotoriete.Text = "Coefficient de notoriete :";
            // 
            // typepraticien
            // 
            this.typepraticien.AutoSize = true;
            this.typepraticien.Location = new System.Drawing.Point(50, 407);
            this.typepraticien.Name = "typepraticien";
            this.typepraticien.Size = new System.Drawing.Size(95, 13);
            this.typepraticien.TabIndex = 13;
            this.typepraticien.Text = "Type du praticien :";
            // 
            // c_typePraticien
            // 
            this.c_typePraticien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_typePraticien.FormattingEnabled = true;
            this.c_typePraticien.Location = new System.Drawing.Point(176, 404);
            this.c_typePraticien.Name = "c_typePraticien";
            this.c_typePraticien.Size = new System.Drawing.Size(150, 21);
            this.c_typePraticien.TabIndex = 14;
            // 
            // b_validModif
            // 
            this.b_validModif.Location = new System.Drawing.Point(243, 466);
            this.b_validModif.Name = "b_validModif";
            this.b_validModif.Size = new System.Drawing.Size(164, 23);
            this.b_validModif.TabIndex = 15;
            this.b_validModif.Text = "Valider les modifications";
            this.b_validModif.UseVisualStyleBackColor = true;
            this.b_validModif.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_retour
            // 
            this.b_retour.Location = new System.Drawing.Point(70, 466);
            this.b_retour.Name = "b_retour";
            this.b_retour.Size = new System.Drawing.Size(75, 23);
            this.b_retour.TabIndex = 16;
            this.b_retour.Text = "Retour";
            this.b_retour.UseVisualStyleBackColor = true;
            this.b_retour.Click += new System.EventHandler(this.button2_Click);
            // 
            // e_adresse
            // 
            this.e_adresse.ContainerControl = this;
            // 
            // e_codePostal
            // 
            this.e_codePostal.ContainerControl = this;
            // 
            // e_ville
            // 
            this.e_ville.ContainerControl = this;
            // 
            // DetailsPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 517);
            this.Controls.Add(this.b_retour);
            this.Controls.Add(this.b_validModif);
            this.Controls.Add(this.c_typePraticien);
            this.Controls.Add(this.typepraticien);
            this.Controls.Add(this.coefnotoriete);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.codepostal);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.t_coefNotoriete);
            this.Controls.Add(this.t_ville);
            this.Controls.Add(this.t_codePostal);
            this.Controls.Add(this.t_adresse);
            this.Controls.Add(this.t_prenom);
            this.Controls.Add(this.t_nom);
            this.Name = "DetailsPraticien";
            this.Text = "DetailsPraticien";
            this.Load += new System.EventHandler(this.DetailsPraticien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_adresse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_codePostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ville)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_nom;
        private System.Windows.Forms.TextBox t_prenom;
        private System.Windows.Forms.TextBox t_adresse;
        private System.Windows.Forms.TextBox t_codePostal;
        private System.Windows.Forms.TextBox t_ville;
        private System.Windows.Forms.TextBox t_coefNotoriete;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.Label codepostal;
        private System.Windows.Forms.Label ville;
        private System.Windows.Forms.Label coefnotoriete;
        private System.Windows.Forms.Label typepraticien;
        private System.Windows.Forms.ComboBox c_typePraticien;
        private System.Windows.Forms.Button b_validModif;
        private System.Windows.Forms.Button b_retour;
        private System.Windows.Forms.ErrorProvider e_adresse;
        private System.Windows.Forms.ErrorProvider e_codePostal;
        private System.Windows.Forms.ErrorProvider e_ville;
    }
}