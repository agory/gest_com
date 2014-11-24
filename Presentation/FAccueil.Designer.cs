namespace Presentation
{
    partial class FAccueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interrogerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheVendeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liseArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.augmenterDiminuerLesPrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.interrogerToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // interrogerToolStripMenuItem
            // 
            this.interrogerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheClientToolStripMenuItem,
            this.ficheVendeurToolStripMenuItem,
            this.listCommandesToolStripMenuItem,
            this.liseArticlesToolStripMenuItem});
            this.interrogerToolStripMenuItem.Name = "interrogerToolStripMenuItem";
            this.interrogerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.interrogerToolStripMenuItem.Text = "Interroger";
            // 
            // ficheClientToolStripMenuItem
            // 
            this.ficheClientToolStripMenuItem.Name = "ficheClientToolStripMenuItem";
            this.ficheClientToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ficheClientToolStripMenuItem.Text = "Fiche client";
            // 
            // ficheVendeurToolStripMenuItem
            // 
            this.ficheVendeurToolStripMenuItem.Name = "ficheVendeurToolStripMenuItem";
            this.ficheVendeurToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ficheVendeurToolStripMenuItem.Text = "Fiche vendeur";
            // 
            // listCommandesToolStripMenuItem
            // 
            this.listCommandesToolStripMenuItem.Name = "listCommandesToolStripMenuItem";
            this.listCommandesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listCommandesToolStripMenuItem.Text = "Liste commandes";
            // 
            // liseArticlesToolStripMenuItem
            // 
            this.liseArticlesToolStripMenuItem.Name = "liseArticlesToolStripMenuItem";
            this.liseArticlesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.liseArticlesToolStripMenuItem.Text = "Lise articles";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesCommandesToolStripMenuItem,
            this.augmenterDiminuerLesPrixToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // gestionDesCommandesToolStripMenuItem
            // 
            this.gestionDesCommandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            this.gestionDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.gestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes";
            // 
            // augmenterDiminuerLesPrixToolStripMenuItem
            // 
            this.augmenterDiminuerLesPrixToolStripMenuItem.Name = "augmenterDiminuerLesPrixToolStripMenuItem";
            this.augmenterDiminuerLesPrixToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.augmenterDiminuerLesPrixToolStripMenuItem.Text = "Augmenter/Diminuer les prix";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // FAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FAccueil";
            this.Text = "Accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interrogerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheVendeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liseArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem augmenterDiminuerLesPrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

