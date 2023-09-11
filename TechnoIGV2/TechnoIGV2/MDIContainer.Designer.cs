
namespace TechnoIGV2
{
    partial class MDIContainer
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
            this.mnsPrincipale = new System.Windows.Forms.MenuStrip();
            this.tsmiRechercheProduits = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPanierClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRechercheClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjouterClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFournisseurs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProduitsLimites = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHistoriqueComFourni = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatistiquesFourni = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGestionEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiAddEmploye = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListeEmployes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsGestionMdi = new System.Windows.Forms.MenuStrip();
            this.tsmiConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrganisation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTileHorizon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTileVerti = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRetourBureau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipale.SuspendLayout();
            this.mnsGestionMdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipale
            // 
            this.mnsPrincipale.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mnsPrincipale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnsPrincipale.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsPrincipale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRechercheProduits,
            this.tsmiPanierClient,
            this.tsmiClients,
            this.tsmiFournisseurs,
            this.tsmiGestionEmp,
            this.tsmiProfil});
            this.mnsPrincipale.Location = new System.Drawing.Point(0, 27);
            this.mnsPrincipale.Name = "mnsPrincipale";
            this.mnsPrincipale.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnsPrincipale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnsPrincipale.Size = new System.Drawing.Size(1161, 32);
            this.mnsPrincipale.TabIndex = 0;
            this.mnsPrincipale.Text = "MenuPrincipale";
            this.mnsPrincipale.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsPrincipale_ItemClicked);
            // 
            // tsmiRechercheProduits
            // 
            this.tsmiRechercheProduits.Name = "tsmiRechercheProduits";
            this.tsmiRechercheProduits.Size = new System.Drawing.Size(107, 28);
            this.tsmiRechercheProduits.Text = "P&roduits";
            this.tsmiRechercheProduits.Click += new System.EventHandler(this.rechercheToolStripMenuItem_Click);
            // 
            // tsmiPanierClient
            // 
            this.tsmiPanierClient.Name = "tsmiPanierClient";
            this.tsmiPanierClient.Size = new System.Drawing.Size(86, 28);
            this.tsmiPanierClient.Text = "&Panier";
            this.tsmiPanierClient.Click += new System.EventHandler(this.pAnierToolStripMenuItem_Click);
            // 
            // tsmiClients
            // 
            this.tsmiClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRechercheClients,
            this.tsmiAjouterClient});
            this.tsmiClients.Name = "tsmiClients";
            this.tsmiClients.Size = new System.Drawing.Size(91, 28);
            this.tsmiClients.Text = "&Clients";
            this.tsmiClients.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // tsmiRechercheClients
            // 
            this.tsmiRechercheClients.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiRechercheClients.Name = "tsmiRechercheClients";
            this.tsmiRechercheClients.Size = new System.Drawing.Size(223, 22);
            this.tsmiRechercheClients.Text = "&Recherche de clients";
            this.tsmiRechercheClients.Click += new System.EventHandler(this.rechercherDeClientsToolStripMenuItem_Click);
            // 
            // tsmiAjouterClient
            // 
            this.tsmiAjouterClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAjouterClient.Name = "tsmiAjouterClient";
            this.tsmiAjouterClient.Size = new System.Drawing.Size(223, 22);
            this.tsmiAjouterClient.Text = "&Ajouter un client";
            this.tsmiAjouterClient.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // tsmiFournisseurs
            // 
            this.tsmiFournisseurs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProduitsLimites,
            this.tsmiHistoriqueComFourni,
            this.tsmiStatistiquesFourni});
            this.tsmiFournisseurs.Name = "tsmiFournisseurs";
            this.tsmiFournisseurs.Size = new System.Drawing.Size(156, 28);
            this.tsmiFournisseurs.Text = "Fourn&isseurs";
            this.tsmiFournisseurs.Click += new System.EventHandler(this.fournisseurToolStripMenuItem_Click);
            // 
            // tsmiProduitsLimites
            // 
            this.tsmiProduitsLimites.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiProduitsLimites.Name = "tsmiProduitsLimites";
            this.tsmiProduitsLimites.Size = new System.Drawing.Size(269, 22);
            this.tsmiProduitsLimites.Text = "&Produits limités";
            this.tsmiProduitsLimites.Click += new System.EventHandler(this.commandesToolStripMenuItem_Click);
            // 
            // tsmiHistoriqueComFourni
            // 
            this.tsmiHistoriqueComFourni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiHistoriqueComFourni.Name = "tsmiHistoriqueComFourni";
            this.tsmiHistoriqueComFourni.Size = new System.Drawing.Size(269, 22);
            this.tsmiHistoriqueComFourni.Text = "&Historique des commandes";
            this.tsmiHistoriqueComFourni.Click += new System.EventHandler(this.historiqueDesCommandesToolStripMenuItem_Click);
            // 
            // tsmiStatistiquesFourni
            // 
            this.tsmiStatistiquesFourni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiStatistiquesFourni.Name = "tsmiStatistiquesFourni";
            this.tsmiStatistiquesFourni.Size = new System.Drawing.Size(269, 22);
            this.tsmiStatistiquesFourni.Text = "&Liste des fournisseurs";
            this.tsmiStatistiquesFourni.Click += new System.EventHandler(this.tsmListeFournisseurs_Click);
            // 
            // tsmiGestionEmp
            // 
            this.tsmiGestionEmp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiAddEmploye,
            this.tsmiListeEmployes});
            this.tsmiGestionEmp.Name = "tsmiGestionEmp";
            this.tsmiGestionEmp.Size = new System.Drawing.Size(106, 28);
            this.tsmiGestionEmp.Text = "&Magasin";
            // 
            // tmsiAddEmploye
            // 
            this.tmsiAddEmploye.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmsiAddEmploye.Name = "tmsiAddEmploye";
            this.tmsiAddEmploye.Size = new System.Drawing.Size(213, 22);
            this.tmsiAddEmploye.Text = "&Ajouter un employé";
            this.tmsiAddEmploye.Click += new System.EventHandler(this.tmsAddEmploye_Click);
            // 
            // tsmiListeEmployes
            // 
            this.tsmiListeEmployes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiListeEmployes.Name = "tsmiListeEmployes";
            this.tsmiListeEmployes.Size = new System.Drawing.Size(213, 22);
            this.tsmiListeEmployes.Text = "&Liste des employés";
            this.tsmiListeEmployes.Click += new System.EventHandler(this.tsmiListeEmployes_Click);
            // 
            // tsmiProfil
            // 
            this.tsmiProfil.Name = "tsmiProfil";
            this.tsmiProfil.Size = new System.Drawing.Size(74, 28);
            this.tsmiProfil.Text = "Pr&ofil";
            this.tsmiProfil.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // mnsGestionMdi
            // 
            this.mnsGestionMdi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mnsGestionMdi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsGestionMdi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnect,
            this.tsmiOrganisation,
            this.tsmQuitter});
            this.mnsGestionMdi.Location = new System.Drawing.Point(0, 0);
            this.mnsGestionMdi.Name = "mnsGestionMdi";
            this.mnsGestionMdi.Size = new System.Drawing.Size(1161, 27);
            this.mnsGestionMdi.TabIndex = 3;
            this.mnsGestionMdi.Text = "msnGeneral";
            // 
            // tsmiConnect
            // 
            this.tsmiConnect.Name = "tsmiConnect";
            this.tsmiConnect.Size = new System.Drawing.Size(105, 23);
            this.tsmiConnect.Text = "Conne&xion";
            this.tsmiConnect.Click += new System.EventHandler(this.tsmiConnect_Click);
            // 
            // tsmiOrganisation
            // 
            this.tsmiOrganisation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCascade,
            this.tsmiTileHorizon,
            this.tsmiTileVerti});
            this.tsmiOrganisation.Name = "tsmiOrganisation";
            this.tsmiOrganisation.Size = new System.Drawing.Size(88, 23);
            this.tsmiOrganisation.Text = "F&enêtres";
            // 
            // tsmiCascade
            // 
            this.tsmiCascade.Name = "tsmiCascade";
            this.tsmiCascade.Size = new System.Drawing.Size(213, 24);
            this.tsmiCascade.Text = "Cascade";
            this.tsmiCascade.Click += new System.EventHandler(this.tsmiCascade_Click);
            // 
            // tsmiTileHorizon
            // 
            this.tsmiTileHorizon.Name = "tsmiTileHorizon";
            this.tsmiTileHorizon.Size = new System.Drawing.Size(213, 24);
            this.tsmiTileHorizon.Text = "Tuiles horizontale";
            this.tsmiTileHorizon.Click += new System.EventHandler(this.tsmiTileHorizon_Click);
            // 
            // tsmiTileVerti
            // 
            this.tsmiTileVerti.Name = "tsmiTileVerti";
            this.tsmiTileVerti.Size = new System.Drawing.Size(213, 24);
            this.tsmiTileVerti.Text = "Tuiles verticales";
            this.tsmiTileVerti.Click += new System.EventHandler(this.tsmiTileVerti_Click);
            // 
            // tsmQuitter
            // 
            this.tsmQuitter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeconnexion,
            this.tsmiRetourBureau});
            this.tsmQuitter.Name = "tsmQuitter";
            this.tsmQuitter.Size = new System.Drawing.Size(72, 23);
            this.tsmQuitter.Text = "&Quitter";
            // 
            // tsmiDeconnexion
            // 
            this.tsmiDeconnexion.Name = "tsmiDeconnexion";
            this.tsmiDeconnexion.Size = new System.Drawing.Size(211, 24);
            this.tsmiDeconnexion.Text = "&Se déconnecter";
            this.tsmiDeconnexion.Click += new System.EventHandler(this.tsmiDeconnexion_Click);
            // 
            // tsmiRetourBureau
            // 
            this.tsmiRetourBureau.Name = "tsmiRetourBureau";
            this.tsmiRetourBureau.Size = new System.Drawing.Size(211, 24);
            this.tsmiRetourBureau.Text = "&Retour au bureau";
            this.tsmiRetourBureau.Click += new System.EventHandler(this.tsmiRetourBureau_Click);
            // 
            // MDIContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 594);
            this.Controls.Add(this.mnsPrincipale);
            this.Controls.Add(this.mnsGestionMdi);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipale;
            this.MinimumSize = new System.Drawing.Size(1177, 633);
            this.Name = "MDIContainer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechnoIG";
            this.Load += new System.EventHandler(this.MDIContainer_Load);
            this.mnsPrincipale.ResumeLayout(false);
            this.mnsPrincipale.PerformLayout();
            this.mnsGestionMdi.ResumeLayout(false);
            this.mnsGestionMdi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipale;
        private System.Windows.Forms.ToolStripMenuItem tsmiRechercheProduits;
        private System.Windows.Forms.ToolStripMenuItem tsmiPanierClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiFournisseurs;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfil;
        private System.Windows.Forms.ToolStripMenuItem tsmiClients;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjouterClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduitsLimites;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatistiquesFourni;
        private System.Windows.Forms.ToolStripMenuItem tsmiRechercheClients;
        private System.Windows.Forms.ToolStripMenuItem tsmiHistoriqueComFourni;
        private System.Windows.Forms.ToolStripMenuItem tsmiGestionEmp;
        private System.Windows.Forms.ToolStripMenuItem tmsiAddEmploye;
        private System.Windows.Forms.ToolStripMenuItem tsmiListeEmployes;
        private System.Windows.Forms.MenuStrip mnsGestionMdi;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrganisation;
        private System.Windows.Forms.ToolStripMenuItem tsmiCascade;
        private System.Windows.Forms.ToolStripMenuItem tsmiTileHorizon;
        private System.Windows.Forms.ToolStripMenuItem tsmiTileVerti;
        private System.Windows.Forms.ToolStripMenuItem tsmQuitter;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeconnexion;
        private System.Windows.Forms.ToolStripMenuItem tsmiRetourBureau;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnect;
    }
}