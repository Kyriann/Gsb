namespace Gsb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.t_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_mdp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_valide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.e_login = new System.Windows.Forms.ErrorProvider(this.components);
            this.e_mdp = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.e_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_mdp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // t_login
            // 
            this.t_login.Location = new System.Drawing.Point(178, 95);
            this.t_login.Name = "t_login";
            this.t_login.Size = new System.Drawing.Size(136, 20);
            this.t_login.TabIndex = 0;
            this.t_login.TextChanged += new System.EventHandler(this.t_login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // t_mdp
            // 
            this.t_mdp.Location = new System.Drawing.Point(178, 164);
            this.t_mdp.Name = "t_mdp";
            this.t_mdp.Size = new System.Drawing.Size(136, 20);
            this.t_mdp.TabIndex = 2;
            this.t_mdp.TextChanged += new System.EventHandler(this.t_mdp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // b_valide
            // 
            this.b_valide.Location = new System.Drawing.Point(216, 221);
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
            this.label3.Location = new System.Drawing.Point(213, 43);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Gsb.Properties.Resources.logo_gsb;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(297, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 101);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(490, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_valide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_mdp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Connexion au système de gestion de compte rendus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_mdp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

