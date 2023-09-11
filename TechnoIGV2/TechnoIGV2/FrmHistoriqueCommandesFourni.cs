using System;
using System.Windows.Forms;

namespace TechnoIGV2
{
    public partial class FrmHistoriqueCommandesFourni : Form
    {
        static FrmHistoriqueCommandesFourni frmHistoCommFourni;
        private FrmHistoriqueCommandesFourni()
        {
            InitializeComponent();
        }

        public static FrmHistoriqueCommandesFourni getInstance()
        {
            if (frmHistoCommFourni == null || frmHistoCommFourni.IsDisposed)
            {
                frmHistoCommFourni = new FrmHistoriqueCommandesFourni();
            }
            return frmHistoCommFourni;
        }

        private void FrmHistoriqueCommandesFourni_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_CATEGORIE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_CATEGORIETableAdapter.Fill(this.dataSet.VW_CATEGORIE);
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_MARQUES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_MARQUESTableAdapter.Fill(this.dataSet.VW_MARQUES);
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_FOURNISSEURTableAdapter.Fill(this.dataSet.VW_FOURNISSEUR);
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_HISTORIQUE_COMMANDES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_HISTORIQUE_COMMANDESTableAdapter.Fill(this.dataSet.VW_HISTORIQUE_COMMANDES);
            this.cboFournisseur.Text = "";
            this.cboMarque.Text = "";
            this.cboCategorie.Text = "";
            WindowState = FormWindowState.Maximized;
        }

        private void cboFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrer();
        }

        private void cboMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrer();
        }

        private void cboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrer();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            // Permet de trier les commandes par le nom de produit, le fournisseur ou le numéro de commande
            this.cboFournisseur.Text = "";
            this.cboMarque.Text = "";
            this.cboCategorie.Text = "";

            BindingSource bs = new BindingSource();
            bs.DataSource = dgvCommandes.DataSource;
            if (int.TryParse(txtRecherche.Text, out _))
            {
                bs.Filter = "Produit like '%" + txtRecherche.Text + "%' or " + "Fournisseur like '%" + txtRecherche.Text + "%' or Numero = " + txtRecherche.Text;
            }
            else
            {
                bs.Filter = "Produit like '%" + txtRecherche.Text + "%' or " + "Fournisseur like '%" + txtRecherche.Text + "%'";
            }

            dgvCommandes.DataSource = bs;
        }

        private void onFormClick(object sender, EventArgs e)
        {
            this.vW_HISTORIQUE_COMMANDESTableAdapter.Fill(this.dataSet.VW_HISTORIQUE_COMMANDES);
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
