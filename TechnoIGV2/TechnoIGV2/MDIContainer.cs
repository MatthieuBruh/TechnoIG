using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoIGV2
{
    public partial class MDIContainer : Form
    {
        private static MDIContainer mdiContainerHolder = null;
        private int niveauAutorisation = -1;
        private String nomUtilisateur;

        private MDIContainer()
        {
            InitializeComponent();
        }

        private void MDIContainer_Load(object sender, EventArgs e)
        {
            this.setMDIInactive();
            FrmLogin frmLogin = FrmLogin.getInstance();
            frmLogin.MdiParent = this;
            frmLogin.Show();
            frmLogin.Focus();
            
            WindowState = FormWindowState.Maximized;
        }

        // Autres
        public static MDIContainer getInstance() 
        {
            if (mdiContainerHolder == null || mdiContainerHolder.IsDisposed) {
                mdiContainerHolder = new MDIContainer();
            }
            
            return mdiContainerHolder;
        }

        public void setNiveauAutorisation(int niveauAutorisation, String nomUtilisateur)
        {
            this.niveauAutorisation = niveauAutorisation;
            this.nomUtilisateur = nomUtilisateur;
            if (niveauAutorisation == 2) // 2 == Initialisation des menus pour les vendeurs.
            {
                this.setMDIActive();
                tsmiFournisseurs.Enabled = false;
                tsmiFournisseurs.Visible = false;
                tsmiGestionEmp.Enabled = false;
                tsmiGestionEmp.Visible = false;
            }
            else if (this.niveauAutorisation == 1) // 1 == Initialisation des menus pou les managers.
            {
                // Accès autorisé à la gestion des employés et de la gestion des commandes fournisseurs.
                this.setMDIActive();
                tsmiFournisseurs.Enabled = true;
                tsmiFournisseurs.Visible = true;
                tsmiGestionEmp.Enabled = true;
                tsmiGestionEmp.Visible = true;
            }
        }

        private void setMDIActive()
        {
            tsmiConnect.Enabled = false;
            tsmiConnect.Visible = false;
            tsmiOrganisation.Visible = true;
            tsmiDeconnexion.Enabled = true;
            mnsPrincipale.Enabled = true;
        }

        private void setMDIInactive()
        {
            tsmiConnect.Enabled = true;
            tsmiConnect.Visible = true;
            tsmiOrganisation.Visible = false;
            tsmiDeconnexion.Enabled = false;
            mnsPrincipale.Enabled = false;
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
            }
        }

        private void mnsPrincipale_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        // Recherche
        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecherche frmRecherche = new FrmRecherche();
            frmRecherche.MdiParent = this;
            frmRecherche.Show();
        }

        // Panier
        private void pAnierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPanier frmPanier = FrmPanier.getInstance();
            frmPanier.MdiParent = this;
            if (Application.OpenForms[frmPanier.Name] == null)
            {
                frmPanier.Show();
            }
            else
            {
                Application.OpenForms[frmPanier.Name].Focus();
            }
        }

        // Clients
        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void rechercherDeClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRechercherClient frmRechercherClient = new FrmRechercherClient();
            frmRechercherClient.MdiParent = this;
            frmRechercherClient.Show();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionClients frmNewClient = new FrmGestionClients(0);
            frmNewClient.ShowDialog();
        }

        // Fournisseurs
        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void commandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduitLimites frmCommandesFourni = FrmProduitLimites.getInstance();
            frmCommandesFourni.MdiParent = this;
            if (Application.OpenForms[frmCommandesFourni.Name] == null)
            {
                frmCommandesFourni.Show();
            }
            else
            {
                Application.OpenForms[frmCommandesFourni.Name].Focus();
            }
        }

        private void historiqueDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistoriqueCommandesFourni frmHistoriqueCommandes = FrmHistoriqueCommandesFourni.getInstance();
            frmHistoriqueCommandes.MdiParent = this;
            if (Application.OpenForms[frmHistoriqueCommandes.Name] == null)
            {
                frmHistoriqueCommandes.Show();
            }
            else
            {
                Application.OpenForms[frmHistoriqueCommandes.Name].Focus();
            }
        }

        private void tsmListeFournisseurs_Click(object sender, EventArgs e)
        {
            FrmListeEntites frmListeFournisseurs = new FrmListeEntites(0);
            frmListeFournisseurs.MdiParent = this;
            frmListeFournisseurs.Show();
        }

        // Gestion employés
        private void tmsAddEmploye_Click(object sender, EventArgs e)
        {
            FrmGestionEmploye frmGestionEmploye = new FrmGestionEmploye(0);
            frmGestionEmploye.ShowDialog();
        }
        private void tsmiListeEmployes_Click(object sender, EventArgs e)
        {
            FrmListeEntites frmListeEmployes = new FrmListeEntites(1);
            frmListeEmployes.MdiParent = this;
            frmListeEmployes.Show();
        }


        // Profil
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfil frmProfile = FrmProfil.getInstance(this.nomUtilisateur);
            frmProfile.MdiParent = this;
            if (Application.OpenForms[frmProfile.Name] == null)
            {
                frmProfile.Show();
            }
            else
            {
                Application.OpenForms[frmProfile.Name].Focus();
            }
        }

        // Déconnexion
        private void tsmiConnect_Click(object sender, EventArgs e)
        {
            this.setMDIInactive();
            FrmLogin frmLogin = FrmLogin.getInstance();
            frmLogin.MdiParent = this;
            if (Application.OpenForms[frmLogin.Name] == null)
            {
                frmLogin.Show();
            }
            else
            {
                Application.OpenForms[frmLogin.Name].Focus();
            }
        }

        private void tsmiDeconnexion_Click(object sender, EventArgs e)
        {
            this.setMDIInactive();
            FrmLogin frmLogin = FrmLogin.getInstance();
            frmLogin.MdiParent = this;
            if (Application.OpenForms[frmLogin.Name] == null)
            {
                frmLogin.Show();
            }
            else
            {
                Application.OpenForms[frmLogin.Name].Focus();
            }
        }

        private void tsmiRetourBureau_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Organisation des fenêtres
        private void tsmiCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void tsmiTileHorizon_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void tsmiTileVerti_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        // Permet de d'ajouter le nom d'utilisateur du personnel connecté
        public String getPersonnelUsername()
        {
            return this.nomUtilisateur;
        }
    }
}
