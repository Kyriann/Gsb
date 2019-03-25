namespace Gsb
{
    partial class VoirRapportVisiteVisiteur
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
            this.e_detailsPraticien = new System.Windows.Forms.ErrorProvider(this.components);
            this.visiteur = new System.Windows.Forms.Label();
            this.numerorapport = new System.Windows.Forms.Label();
            this.c_numRapport = new System.Windows.Forms.ComboBox();
            this.praticienVisite = new System.Windows.Forms.Label();
            this.motif = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.Label();
            this.b_details = new System.Windows.Forms.Button();
            this.bilan = new System.Windows.Forms.Label();
            this.l_bilan = new System.Windows.Forms.Label();
            this.l_date = new System.Windows.Forms.Label();
            this.l_motif = new System.Windows.Forms.Label();
            this.l_numVisiteur = new System.Windows.Forms.Label();
            this.l_nom = new System.Windows.Forms.Label();
            this.l_prenom = new System.Windows.Forms.Label();
            this.l_nomPrenomPraticien = new System.Windows.Forms.Label();
            this.t_visiteur = new System.Windows.Forms.TextBox();
            this.b_retour = new System.Windows.Forms.Button();
            this.check_entre2Dates = new System.Windows.Forms.CheckBox();
            this.date_debutDate = new System.Windows.Forms.DateTimePicker();
            this.date_finDate = new System.Windows.Forms.DateTimePicker();
            this.b_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.e_detailsPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // e_detailsPraticien
            // 
            this.e_detailsPraticien.ContainerControl = this;
            // 
            // visiteur
            // 
            this.visiteur.AutoSize = true;
            this.visiteur.Location = new System.Drawing.Point(69, 57);
            this.visiteur.Name = "visiteur";
            this.visiteur.Size = new System.Drawing.Size(41, 13);
            this.visiteur.TabIndex = 4;
            this.visiteur.Text = "Visiteur";
            // 
            // numerorapport
            // 
            this.numerorapport.AutoSize = true;
            this.numerorapport.Location = new System.Drawing.Point(74, 212);
            this.numerorapport.Name = "numerorapport";
            this.numerorapport.Size = new System.Drawing.Size(95, 13);
            this.numerorapport.TabIndex = 6;
            this.numerorapport.Text = "Numéro de rapport";
            // 
            // c_numRapport
            // 
            this.c_numRapport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_numRapport.FormattingEnabled = true;
            this.c_numRapport.Location = new System.Drawing.Point(193, 204);
            this.c_numRapport.Name = "c_numRapport";
            this.c_numRapport.Size = new System.Drawing.Size(150, 21);
            this.c_numRapport.TabIndex = 7;
            this.c_numRapport.SelectedIndexChanged += new System.EventHandler(this.c_numRapport_SelectedIndexChanged);
            // 
            // praticienVisite
            // 
            this.praticienVisite.AutoSize = true;
            this.praticienVisite.Location = new System.Drawing.Point(74, 258);
            this.praticienVisite.Name = "praticienVisite";
            this.praticienVisite.Size = new System.Drawing.Size(76, 13);
            this.praticienVisite.TabIndex = 8;
            this.praticienVisite.Text = "Praticien Visité";
            // 
            // motif
            // 
            this.motif.AutoSize = true;
            this.motif.Location = new System.Drawing.Point(74, 335);
            this.motif.Name = "motif";
            this.motif.Size = new System.Drawing.Size(36, 13);
            this.motif.TabIndex = 9;
            this.motif.Text = "Motif :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 121);
            this.dataGridView1.TabIndex = 17;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(530, 110);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(36, 13);
            this.date.TabIndex = 18;
            this.date.Text = "Date :";
            // 
            // b_details
            // 
            this.b_details.Location = new System.Drawing.Point(512, 166);
            this.b_details.Name = "b_details";
            this.b_details.Size = new System.Drawing.Size(123, 23);
            this.b_details.TabIndex = 19;
            this.b_details.Text = "Détails du praticien";
            this.b_details.UseVisualStyleBackColor = true;
            this.b_details.Click += new System.EventHandler(this.b_details_Click);
            // 
            // bilan
            // 
            this.bilan.AutoSize = true;
            this.bilan.Location = new System.Drawing.Point(467, 270);
            this.bilan.Name = "bilan";
            this.bilan.Size = new System.Drawing.Size(36, 13);
            this.bilan.TabIndex = 20;
            this.bilan.Text = "Bilan :";
            // 
            // l_bilan
            // 
            this.l_bilan.Location = new System.Drawing.Point(509, 270);
            this.l_bilan.Name = "l_bilan";
            this.l_bilan.Size = new System.Drawing.Size(206, 78);
            this.l_bilan.TabIndex = 21;
            // 
            // l_date
            // 
            this.l_date.AutoSize = true;
            this.l_date.Location = new System.Drawing.Point(572, 110);
            this.l_date.Name = "l_date";
            this.l_date.Size = new System.Drawing.Size(0, 13);
            this.l_date.TabIndex = 22;
            // 
            // l_motif
            // 
            this.l_motif.AutoSize = true;
            this.l_motif.Location = new System.Drawing.Point(150, 335);
            this.l_motif.Name = "l_motif";
            this.l_motif.Size = new System.Drawing.Size(0, 13);
            this.l_motif.TabIndex = 23;
            // 
            // l_numVisiteur
            // 
            this.l_numVisiteur.AutoSize = true;
            this.l_numVisiteur.Location = new System.Drawing.Point(530, 54);
            this.l_numVisiteur.Name = "l_numVisiteur";
            this.l_numVisiteur.Size = new System.Drawing.Size(0, 13);
            this.l_numVisiteur.TabIndex = 24;
            // 
            // l_nom
            // 
            this.l_nom.AutoSize = true;
            this.l_nom.Location = new System.Drawing.Point(598, 54);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(0, 13);
            this.l_nom.TabIndex = 25;
            // 
            // l_prenom
            // 
            this.l_prenom.AutoSize = true;
            this.l_prenom.Location = new System.Drawing.Point(678, 54);
            this.l_prenom.Name = "l_prenom";
            this.l_prenom.Size = new System.Drawing.Size(0, 13);
            this.l_prenom.TabIndex = 26;
            // 
            // l_nomPrenomPraticien
            // 
            this.l_nomPrenomPraticien.AutoSize = true;
            this.l_nomPrenomPraticien.Location = new System.Drawing.Point(190, 258);
            this.l_nomPrenomPraticien.Name = "l_nomPrenomPraticien";
            this.l_nomPrenomPraticien.Size = new System.Drawing.Size(0, 13);
            this.l_nomPrenomPraticien.TabIndex = 27;
            // 
            // t_visiteur
            // 
            this.t_visiteur.Location = new System.Drawing.Point(183, 54);
            this.t_visiteur.Name = "t_visiteur";
            this.t_visiteur.Size = new System.Drawing.Size(160, 20);
            this.t_visiteur.TabIndex = 28;
            // 
            // b_retour
            // 
            this.b_retour.Location = new System.Drawing.Point(681, 477);
            this.b_retour.Name = "b_retour";
            this.b_retour.Size = new System.Drawing.Size(75, 23);
            this.b_retour.TabIndex = 29;
            this.b_retour.Text = "Retour";
            this.b_retour.UseVisualStyleBackColor = true;
            this.b_retour.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_entre2Dates
            // 
            this.check_entre2Dates.AutoSize = true;
            this.check_entre2Dates.Location = new System.Drawing.Point(236, 106);
            this.check_entre2Dates.Name = "check_entre2Dates";
            this.check_entre2Dates.Size = new System.Drawing.Size(150, 17);
            this.check_entre2Dates.TabIndex = 30;
            this.check_entre2Dates.Text = "Entre deux dates données";
            this.check_entre2Dates.UseVisualStyleBackColor = true;
            this.check_entre2Dates.CheckedChanged += new System.EventHandler(this.check_entre2Dates_CheckedChanged);
            // 
            // date_debutDate
            // 
            this.date_debutDate.Location = new System.Drawing.Point(27, 147);
            this.date_debutDate.Name = "date_debutDate";
            this.date_debutDate.Size = new System.Drawing.Size(200, 20);
            this.date_debutDate.TabIndex = 31;
            this.date_debutDate.ValueChanged += new System.EventHandler(this.date_debutDate_ValueChanged);
            // 
            // date_finDate
            // 
            this.date_finDate.Location = new System.Drawing.Point(270, 147);
            this.date_finDate.Name = "date_finDate";
            this.date_finDate.Size = new System.Drawing.Size(200, 20);
            this.date_finDate.TabIndex = 32;
            this.date_finDate.ValueChanged += new System.EventHandler(this.date_finDate_ValueChanged);
            // 
            // b_supprimer
            // 
            this.b_supprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_supprimer.Location = new System.Drawing.Point(325, 368);
            this.b_supprimer.Name = "b_supprimer";
            this.b_supprimer.Size = new System.Drawing.Size(123, 23);
            this.b_supprimer.TabIndex = 34;
            this.b_supprimer.Text = "Supprimer";
            this.b_supprimer.UseVisualStyleBackColor = true;
            this.b_supprimer.Click += new System.EventHandler(this.b_supprimer_Click_1);

            // 
            // VoirRapportVisiteVisiteur
            // 
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.b_supprimer);
            this.Controls.Add(this.date_finDate);
            this.Controls.Add(this.date_debutDate);
            this.Controls.Add(this.check_entre2Dates);
            this.Controls.Add(this.b_retour);
            this.Controls.Add(this.t_visiteur);
            this.Controls.Add(this.l_nomPrenomPraticien);
            this.Controls.Add(this.l_prenom);
            this.Controls.Add(this.l_nom);
            this.Controls.Add(this.l_numVisiteur);
            this.Controls.Add(this.l_motif);
            this.Controls.Add(this.l_date);
            this.Controls.Add(this.l_bilan);
            this.Controls.Add(this.bilan);
            this.Controls.Add(this.b_details);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.motif);
            this.Controls.Add(this.praticienVisite);
            this.Controls.Add(this.c_numRapport);
            this.Controls.Add(this.numerorapport);
            this.Controls.Add(this.visiteur);
            this.Name = "VoirRapportVisiteVisiteur";
            this.Text = "VoirRapportVisiteVisiteur";
            this.Load += new System.EventHandler(this.VoirRapportVisiteVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_detailsPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider e_detailsPraticien;
        private System.Windows.Forms.DateTimePicker date_finDate;
        private System.Windows.Forms.DateTimePicker date_debutDate;
        private System.Windows.Forms.CheckBox check_entre2Dates;
        private System.Windows.Forms.Button b_retour;
        private System.Windows.Forms.TextBox t_visiteur;
        private System.Windows.Forms.Label l_nomPrenomPraticien;
        private System.Windows.Forms.Label l_prenom;
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.Label l_numVisiteur;
        private System.Windows.Forms.Label l_motif;
        private System.Windows.Forms.Label l_date;
        private System.Windows.Forms.Label l_bilan;
        private System.Windows.Forms.Label bilan;
        private System.Windows.Forms.Button b_details;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label motif;
        private System.Windows.Forms.Label praticienVisite;
        private System.Windows.Forms.ComboBox c_numRapport;
        private System.Windows.Forms.Label numerorapport;
        private System.Windows.Forms.Label visiteur;
        private System.Windows.Forms.Button b_supprimer;
    }
}