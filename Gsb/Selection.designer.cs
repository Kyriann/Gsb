namespace Gsb
{
    partial class Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selection));
            this.menu_selection1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportDeVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_selection = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.l_showusername = new System.Windows.Forms.Label();
            this.b_quit = new System.Windows.Forms.Button();
            this.menu_selection.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_selection1
            // 
            this.menu_selection1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportDeVisiteToolStripMenuItem});
            this.menu_selection1.Name = "menu_selection1";
            this.menu_selection1.Size = new System.Drawing.Size(101, 20);
            this.menu_selection1.Text = "Compte rendus";
            // 
            // rapportDeVisiteToolStripMenuItem
            // 
            this.rapportDeVisiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnRapportToolStripMenuItem,
            this.voirRapportToolStripMenuItem});
            this.rapportDeVisiteToolStripMenuItem.Name = "rapportDeVisiteToolStripMenuItem";
            this.rapportDeVisiteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rapportDeVisiteToolStripMenuItem.Text = "Rapport de visite";
            // 
            // créerUnRapportToolStripMenuItem
            // 
            this.créerUnRapportToolStripMenuItem.Name = "créerUnRapportToolStripMenuItem";
            this.créerUnRapportToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.créerUnRapportToolStripMenuItem.Text = "Créer un rapport";
            this.créerUnRapportToolStripMenuItem.Click += new System.EventHandler(this.créerUnRapportToolStripMenuItem_Click);
            // 
            // voirRapportToolStripMenuItem
            // 
            this.voirRapportToolStripMenuItem.Name = "voirRapportToolStripMenuItem";
            this.voirRapportToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.voirRapportToolStripMenuItem.Text = "Voir un rapport";
            this.voirRapportToolStripMenuItem.Click += new System.EventHandler(this.voirRapportToolStripMenuItem_Click);
            // 
            // menu_selection
            // 
            this.menu_selection.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_selection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_selection1});
            this.menu_selection.Location = new System.Drawing.Point(0, 0);
            this.menu_selection.Name = "menu_selection";
            this.menu_selection.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu_selection.Size = new System.Drawing.Size(600, 24);
            this.menu_selection.TabIndex = 7;
            this.menu_selection.Text = "menu_selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Utilisateur Connecté :";
            // 
            // l_showusername
            // 
            this.l_showusername.AutoSize = true;
            this.l_showusername.Location = new System.Drawing.Point(460, 7);
            this.l_showusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_showusername.Name = "l_showusername";
            this.l_showusername.Size = new System.Drawing.Size(37, 13);
            this.l_showusername.TabIndex = 9;
            this.l_showusername.Text = "23232";
            this.l_showusername.UseMnemonic = false;
            this.l_showusername.Click += new System.EventHandler(this.l_showusername_Click);
            // 
            // b_quit
            // 
            this.b_quit.Location = new System.Drawing.Point(513, 331);
            this.b_quit.Name = "b_quit";
            this.b_quit.Size = new System.Drawing.Size(75, 23);
            this.b_quit.TabIndex = 10;
            this.b_quit.Text = "Quitter";
            this.b_quit.UseVisualStyleBackColor = true;
            this.b_quit.Click += new System.EventHandler(this.b_quit_Click_1);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gsb.Properties.Resources.logo_gsb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.b_quit);
            this.Controls.Add(this.l_showusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menu_selection);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Selection";
            this.Text = "Séléction";
            this.Load += new System.EventHandler(this.Selection_Load);
            this.menu_selection.ResumeLayout(false);
            this.menu_selection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menu_selection1;
        private System.Windows.Forms.ToolStripMenuItem rapportDeVisiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUnRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirRapportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu_selection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_showusername;
        private System.Windows.Forms.Button b_quit;
    }
}