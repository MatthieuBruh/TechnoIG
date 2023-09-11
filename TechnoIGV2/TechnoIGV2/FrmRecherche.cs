using System;
using System.Windows.Forms;

namespace TechnoIGV2
{
    public partial class FrmRecherche : Form
    {
        public FrmRecherche()
        {
            InitializeComponent();
        }

        private void FrmRecherche_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_CATEGORIE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_CATEGORIETableAdapter.Fill(this.dataSet.VW_CATEGORIE);
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_MARQUES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_MARQUESTableAdapter.Fill(this.dataSet.VW_MARQUES);
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_RECHERCHE_PRODUITS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cboMarque.Text = "";
            this.cboCategorie.Text = "";
            this.vW_RECHERCHE_PRODUITSTableAdapter.Fill(this.dataSet.VW_RECHERCHE_PRODUITS);
            WindowState = FormWindowState.Maximized;
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void grpFiltresPrix_Enter(object sender, EventArgs e)
        {

        }

        // Permet de rechercher des produits par le nom, la catégorie ou la marque.
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            this.cboMarque.Text = "";
            this.cboCategorie.Text = "";
            this.nudPrixMax.Value = 0;
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvProduits.DataSource;
            bs.Filter = "Nom like '%" + txtRecherche.Text + "%' or " + "Categorie like '%" + txtRecherche.Text + "%' or " + "Marque like '%" + txtRecherche.Text + "%'";
            dgvProduits.DataSource = bs;
        }

        // Permet de filtrer les produits par marque
        private void cboMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrer();
        }


        // Permet de filtrer les produits par catégorie
        private void cboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrer();
        }

        // Permet d'ajouter le produit au panier
        private void dgvProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProduit;
            bool parseIdOk = int.TryParse(dgvProduits.Rows[e.RowIndex].Cells[0].Value.ToString(), out idProduit);
            decimal prixVente;
            bool parsePrixVenteOk = decimal.TryParse(dgvProduits.Rows[e.RowIndex].Cells[4].Value.ToString(), out prixVente);
            int stockRestant;
            bool parseStockOk = int.TryParse(dgvProduits.Rows[e.RowIndex].Cells[5].Value.ToString(), out stockRestant);


            // Vérification que la quantité n'est pas null
            if (dgvProduits.Rows[e.RowIndex].Cells[6].Value == null)
            {
                MessageBox.Show("La quantité du produit doit être renseignée sous format numérique.", "Erreur de type de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int quantiteSelect;
                bool parseQteOk = int.TryParse(dgvProduits.Rows[e.RowIndex].Cells[6].Value.ToString(), out quantiteSelect);

                // Vérification que les parse sont bien passé
                if (!parseIdOk || !parseQteOk || !parseStockOk || !parsePrixVenteOk)
                {
                    MessageBox.Show("Le numéro de produit, le stock ou la quantité n'est pas une valeur numérique.", "Erreur de type de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (stockRestant >= quantiteSelect)
                    {
                        // On ajoute le produit au panier
                        FrmPanier frmPanier = FrmPanier.getInstance();
                        bool ajoute = frmPanier.addArticle(idProduit, dgvProduits.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvProduits.Rows[e.RowIndex].Cells[2].Value.ToString(),
                            dgvProduits.Rows[e.RowIndex].Cells[3].Value.ToString(), prixVente, quantiteSelect);
                        if (ajoute)
                        {
                            MessageBox.Show("Le produit a été ajouté au panier.", "Produit ajouté !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le produit " + dgvProduits.Rows[e.RowIndex].Cells[1].Value.ToString() + " a un stock inférieur à la quantité demandée.",
                            "Mauvaise quantité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Permet de filtrer les produits par prix
        private void filtreDePrix(object sender, EventArgs e)
        {
            this.filtrer();
        }

        private void onFormClick(object sender, EventArgs e)
        {
            this.vW_RECHERCHE_PRODUITSTableAdapter.Fill(this.dataSet.VW_RECHERCHE_PRODUITS);
            this.filtrer();
        }

        private void filtrer()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvProduits.DataSource;
            String filtre = "";

            if (this.cboMarque.Text != "")
            {
                filtre += " Marque like '%" + cboMarque.Text + "%'";
            }
            if (this.cboCategorie.Text != "")
            {
                if (filtre.Length > 0)
                {
                    filtre += " and ";
                }
                filtre += "Categorie like '%" + cboCategorie.Text + "%'";
            }

            if (nudPrixMin.Value > nudPrixMax.Value && nudPrixMax.Value != 0)
            {
                MessageBox.Show("La valeur de prix minimum doit être inférieur à la valeur maximale.", "Mauvaise valeur de filtre de prix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (this.nudPrixMax.Value > 0)
                {
                    if (filtre.Length > 0)
                    {
                        filtre += " and ";
                    }
                    filtre += " prix_vente_unitaire >=" + (int)nudPrixMin.Value + " and " + "prix_vente_unitaire <=" + (int)nudPrixMax.Value;
                }
                else
                {
                    this.nudPrixMin.Value = 0;
                    this.nudPrixMax.Value = 0;
                    bs.Filter = null;
                }
                dgvProduits.DataSource = bs;

            }

            bs.Filter = filtre;
            dgvProduits.DataSource = bs;
        }
    }
}
