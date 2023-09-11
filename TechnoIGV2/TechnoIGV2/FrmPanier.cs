using System;
using System.Windows.Forms;

namespace TechnoIGV2
{
    public partial class FrmPanier : Form
    {
        static FrmPanier frmPanierHolder = null;
        private int idClient;
        private FrmPanier()
        {
            this.idClient = -1;
            InitializeComponent();
            txtNomValue.Visible = false;
            txtPrenomValue.Visible = false;
            lblNom.Visible = false;
            lblPrenom.Visible = false;
        }

        public static FrmPanier getInstance()
        {
            if (frmPanierHolder == null || frmPanierHolder.IsDisposed)
            {
                frmPanierHolder = new FrmPanier();
            }
            return frmPanierHolder;
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        // Rénitialisation du panier
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            FrmPanier.getInstance().MdiParent = MDIContainer.getInstance();
            FrmPanier.getInstance().Show();
        }

        private void FrmPanier_Load(object sender, EventArgs e)
        {
            cboReductions.Enabled = false;
            WindowState = FormWindowState.Maximized;
        }

        // Lors de la validation de la commande
        private void btnValidation_Click(object sender, EventArgs e)
        {
            // Pas de client lié à la commande
            if (txtNomValue.Text.Equals("") || txtPrenomValue.Text.Equals(""))
            {
                MessageBox.Show("Merci de bien sélectionner un client", "Erreur client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Pas de produit sélectionné
            else if (dgvProduits.Rows.Count < 1)
            {
                MessageBox.Show("Merci de sélectionner un ou plusieurs produits", "Erreur de produits", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Dans le cas où la commande est bon
                decimal? numeroCommande = 0;
                DataSetTableAdapters.QueriesTableAdapter MaRequete = new DataSetTableAdapters.QueriesTableAdapter();

                try
                {
                    decimal? personnelId;
                    personnelId = MaRequete.PKG_GESTIONPERSONNEL_GETPERSONNELID(MDIContainer.getInstance().getPersonnelUsername());
                    if (cboReductions.Items.Count < 1 || chkActiveReduc.Checked == false)
                    {
                        // Création de la commande sans bon
                        numeroCommande = MaRequete.PKG_GESTIONCMDCLIENTS_CRTNEWCLIENTCMD(idClient, personnelId, null);
                    }
                    else
                    {
                        // Création de la commande avec un bon
                        System.Data.DataRowView dt = (System.Data.DataRowView)this.cboReductions.Items[this.cboReductions.SelectedIndex];
                        int bonid;
                        bool remiseOk = int.TryParse(dt["BONID"].ToString(), out bonid);
                        numeroCommande = MaRequete.PKG_GESTIONCMDCLIENTS_CRTNEWCLIENTCMD(idClient, personnelId, bonid);
                    }

                    // Ajout de chaque ligne de commandes
                    foreach (DataGridViewRow row in dgvProduits.Rows)
                    {
                        MaRequete.PKG_GESTIONCMDCLIENTS_ADDLIGNECMDCLIENT(numeroCommande, (int) row.Cells[0].Value, (int) row.Cells[5].Value);
                    }

                    MessageBox.Show("La commande " + numeroCommande + " a été validée avec succès.", "Commande client validée", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmPanier.getInstance().Close();
                    FrmPanier.getInstance().Dispose();

                }
                // Gestion des erreurs Oracle
                catch (Oracle.DataAccess.Client.OracleException ex)
                {
                    if (ex.Number == 20001)
                    {
                        this.errorMessage("Aucun élément ne correspond à un client, un membre du personnel ou une commande. La commande est annulée", "Élement non trouvé");
                    }
                    else if (ex.Number == 20006 || ex.Number == 20007)
                    {
                        this.errorMessage("Le bon n'appartient pas au client demandé ou ce dernier l'a déjà utilisé. La commande est annulée", "Erreur de bon");
                    }
                    else if (ex.Number == 20002)
                    {
                        this.errorMessage("Le stock restant d'un produit est insuffisant. La commande est annulée", "Stock insuffisant");
                    }
                    else if (ex.Number == 20005)
                    {
                        this.errorMessage("Un problème critique est arrivé. La commande est annulée", "Erreur inattendue");
                    }
                    else if (ex.Number == 20054 || ex.Number == 20055)
                    {
                        this.errorMessage("Impossible de trouver le personnel avec le nom d''utilisateur saisi.", "Erreur avec le membre du personnel");
                    }
                    else
                    {
                        this.errorMessage(ex.Message + " Erreur numéro : " + ex.Number.ToString(), "Erreur critique");
                    }
                }
            }
        }

        private void errorMessage(String message, String raison)
        {
            MessageBox.Show(message, raison, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Lier un client au panier (affiche la recherche de client)
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            FrmRechercherClient frmRechercherClient = new FrmRechercherClient();
            frmRechercherClient.MdiParent = MDIContainer.getInstance();
            frmRechercherClient.Show();
        }

        private void txtNomValue_TextChanged(object sender, EventArgs e)
        {

        }

        // Ajouter le client
        public void setClient(int id, String nom, String prenom, decimal tauxRemise)
        {
            this.idClient = id;
            txtNomValue.Visible = true;
            txtPrenomValue.Visible = true;
            lblNom.Visible = true;
            lblPrenom.Visible = true;
            txtNomValue.Text = nom;
            txtPrenomValue.Text = prenom;
            btnAjouterClient.Visible = false;
            this.vW_RECHERCHE_BONS_CLIENTSTableAdapter.FillByClientID(this.dataSet.VW_RECHERCHE_BONS_CLIENTS, id);
        }

        // Ajouter un article au panier
        public bool addArticle(int idProduit, String nom, String marque, String categorie, decimal prixUnitaire, int quantite)
        {
            // Vérifiaction que le produit n'est pas déjà dans le panier
            bool noSet = true;
            foreach (DataGridViewRow row in dgvProduits.Rows)
            {
                if (row.Cells[0].Value.ToString() == idProduit.ToString())
                {
                    noSet = false;
                    break;
                }
            }

            if (noSet)
            {
                this.dgvProduits.Rows.Add(idProduit, nom, marque, categorie, prixUnitaire, quantite, prixUnitaire * quantite);
                this.calculerTotal();
                return true;
            }
            else
            {
                MessageBox.Show("Le produit " + nom + " que vous avez essayez d'ajouter est déjà présent dans le panier. Pour le mettre à jour, merci de le supprimer du panier et de le remettre.",
                    "Produit déjà dans le panier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void dgvProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduits.Rows.RemoveAt(e.RowIndex);
            this.calculerTotal();
        }

        // Permet de claculer le total du panier
        private void calculerTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvProduits.Rows)
            {
                decimal prix;
                bool prixOk = decimal.TryParse(row.Cells[6].Value.ToString(), out prix);

                if (prixOk)
                {
                    total += prix;
                }
            }

            // Dans le cas où des réductions sont disponibles
            if (this.cboReductions.Items.Count > 0 && chkActiveReduc.Checked)
            {
                System.Data.DataRowView dt = (System.Data.DataRowView)this.cboReductions.Items[this.cboReductions.SelectedIndex];

                decimal remise;
                bool remiseOk = decimal.TryParse(dt["TAUX"].ToString(), out remise);

                // Dans le cas où il y a un bon "valide" pour le client
                if (remiseOk)
                {
                    txtTotalPanier.Text = (total - (total * remise)).ToString();
                }
                else
                {
                    MessageBox.Show("La valeur de la remise est incorrecte, aucune remise ne peut donc être appliquée", "Remise incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTotalPanier.Text = total.ToString();
                }
            }
            else
            {
                txtTotalPanier.Text = total.ToString();
            }
        }

        private void lblRemise_Click(object sender, EventArgs e)
        {

        }

        // Permet d'activer ou non la comboBox des clients
        private void chkActiveReduc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActiveReduc.Checked && btnAjouterClient.Visible == false)
            {
                cboReductions.Enabled = true;
            }
            else
            {
                cboReductions.Enabled = false;
            }

            this.calculerTotal();
        }
    }
}
