﻿namespace Gsb
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.t_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_mdp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_valide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.e_login = new System.Windows.Forms.ErrorProvider(this.components);
            this.e_mdp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.e_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_mdp)).BeginInit();
            this.SuspendLayout();
            // 
            // t_login
            // 
            this.t_login.Location = new System.Drawing.Point(193, 86);
            this.t_login.Name = "t_login";
            this.t_login.Size = new System.Drawing.Size(136, 20);
            this.t_login.TabIndex = 0;
            this.t_login.TextChanged += new System.EventHandler(this.t_login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // t_mdp
            // 
            this.t_mdp.Location = new System.Drawing.Point(193, 155);
            this.t_mdp.Name = "t_mdp";
            this.t_mdp.Size = new System.Drawing.Size(136, 20);
            this.t_mdp.TabIndex = 2;
            this.t_mdp.TextChanged += new System.EventHandler(this.t_mdp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // b_valide
            // 
            this.b_valide.Location = new System.Drawing.Point(231, 212);
            this.b_valide.Name = "b_valide";
            this.b_valide.Size = new System.Drawing.Size(75, 23);
            this.b_valide.TabIndex = 4;
            this.b_valide.Text = "Valider";
            this.b_valide.UseVisualStyleBackColor = true;
            this.b_valide.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identifiez-vous";
            // 
            // e_login
            // 
            this.e_login.ContainerControl = this;
            // 
            // e_mdp
            // 
            this.e_mdp.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gsb.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(490, 316);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_valide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_mdp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_login);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_mdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_mdp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_valide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider e_login;
        private System.Windows.Forms.ErrorProvider e_mdp;
    }
}

