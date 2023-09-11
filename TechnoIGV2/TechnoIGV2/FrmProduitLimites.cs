using System;
using System.Windows.Forms;

namespace TechnoIGV2
{
    public partial class FrmProduitLimites : Form
    {
        static FrmProduitLimites frmProdLimites;
        private FrmProduitLimites()
        {
            InitializeComponent();
        }

        public static FrmProduitLimites getInstance()
        {
            if (frmProdLimites == null || frmProdLimites.IsDisposed)
            {
                frmProdLimites = new FrmProduitLimites();
            }
            return frmProdLimites;
        }

        private void FrmCommandesFourni_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet.TEC_CATEGORIE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tEC_CATEGORIETableAdapter.Fill(this.dataSet.TEC_CATEGORIE);
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_MARQUES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_MARQUESTableAdapter.Fill(this.dataSet.VW_MARQUES);
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_FOURNISSEURTableAdapter.Fill(this.dataSet.VW_FOURNISSEUR);
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_PRODUITS_LIMITES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_PRODUITS_LIMITESTableAdapter.Fill(this.dataSet.VW_PRODUITS_LIMITES);
            this.cboFournisseur.Text = "";
            this.cboMarque.Text = "";
            this.cboCategorie.Text = "";
            WindowState = FormWindowState.Maximized;
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        // Validation de la commande fournisseur
        private void button1_Click(object sender, EventArgs e)
        {
            decimal? numeroCommande;
            decimal? resultatLigne;
            
            DataSetTableAdapters.QueriesTableAdapter MaRequete = new DataSetTableAdapters.QueriesTableAdapter();

            // Vérification qu'il y a au moins un produit sélectionné
            bool commandePossible = false;

            foreach (DataGridViewRow row in dgvCommandes.Rows)
            {
                DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell) row.Cells[9];
                if (chkCell.Value != null && chkCell.Value != "")
                {
                    commandePossible = true;
                    break;
                }
            }

            if (commandePossible)
            {
                // Création de la commande
                numeroCommande = MaRequete.PKG_GESTIONCMDFOURNISSEUR_CRTNEWCMDFOU();
                try
                {
                    // Insertion des lignes de commandes
                    foreach (DataGridViewRow row in dgvCommandes.Rows)
                    {
                        bool okayProd = false;
                        if (row.Cells[9].Value != null)
                        {
                            okayProd = (bool)row.Cells[9].Value;
                        }
                        
                        if (okayProd)
                        {
                            int produitId;
                            bool correct = int.TryParse(row.Cells[1].Value.ToString(), out produitId);
                            if (correct)
                            {
                                resultatLigne = MaRequete.PKG_GESTIONCMDFOURNISSEUR_ADDLIGNECMDFOU(numeroCommande, produitId);
                            }
                        }
                    }
                }
                // Gestion des erreurs Oracle
                catch (Oracle.DataAccess.Client.OracleException ex)
                {
                    if (ex.Number == 20040)
                    {
                        this.errorMessage("Impossible de créer la commande demandée. Commande annulée", "Erreur de création");
                    }
                    else if (ex.Number == 20041)
                    {
                        this.errorMessage("Un problème est survenu avec le numéro de commande. Commande annulée", "Erreur d'ajout de la ligne decommande");
                    }
                    else if (ex.Number == 20042)
                    {
                        this.errorMessage("Un problème est survenu avec le numéro de commande. Commande annulée", "Erreur d'ajout de la ligne de commande");
                    }
                    else if (ex.Number == 20045)
                    {
                        this.errorMessage("Un problème critique est arrivé avec la ligne de commande. Commande annulée.", "Erreur inattendue d'ajout de la ligne de commande");
                    }
                }
                // Commande réussie
                MessageBox.Show("La commande numéro " + numeroCommande + " a été passé avec succès", "Commande passée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.vW_PRODUITS_LIMITESTableAdapter.Fill(this.dataSet.VW_PRODUITS_LIMITES);
            }
            else
            {
                // Dans le cas ou il n'y a pas de produit sélectionné
                MessageBox.Show("Vous devez choisir au moins un produit à commander pour passer la commande.", "Commande impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void errorMessage(String message, String raison)
        {
            MessageBox.Show(message, raison, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Permet de rechercher les produits en quantité limités par le nom, la catégorie, a marque ou le fournisseur.
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            this.cboFournisseur.Text = "";
            this.cboMarque.Text = "";
            this.cboCategorie.Text = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvCommandes.DataSource;
            bs.Filter = "Produit like '%" + txtRecherche.Text + "%' or " + "Categorie like '%" + txtRecherche.Text + "%' or " + "Marque like '%"
                + txtRecherche.Text + "%' or " + "Fournisseur like '%" + txtRecherche.Text + "%'";
            dgvCommandes.DataSource = bs;
        }

        // Permet de filtrer les produits par le fournisseur
        private void cboFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrer();

        }

        // Permet de filtrer les produits par la marque
        private void cboMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrer();

        }

        // Permet de filtrer les produit par la catégorie
        private void cboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrer();

        }

        private void onFormClick(object sender, EventArgs e)
        {
            this.vW_PRODUITS_LIMITESTableAdapter.Fill(this.dataSet.VW_PRODUITS_LIMITES);
            this.filtrer();
        }

        private void filtrer()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvCommandes.DataSource;
            String filtre = "";

            if (cboMarque.Text != "")
            {
                filtre += "Marque like '%" + cboMarque.Text + "%'";
            }

            if (cboCategorie.Text != "")
            {
                if (filtre.Length > 0)
                {
                    filtre += " and ";
                }
                filtre += "Categorie like '%" + cboCategorie.Text + "%'";
            }

            if (cboFournisseur.Text != "")
            {
                if (filtre.Length > 0)
                {
                    filtre += " and ";
                }
                filtre += "Fournisseur like '%" + cboFournisseur.Text + "%'";
            }

            bs.Filter = filtre;
            dgvCommandes.DataSource = bs;
        }
    }
}
