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
    public partial class FrmRechercherClient : Form
    {
        public FrmRechercherClient()
        {
            InitializeComponent();
        }

        private void FrmRechercherClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_NPA_CLIENTS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_NPA_CLIENTSTableAdapter.Fill(this.dataSet.VW_NPA_CLIENTS);
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_RECHERCHE_CLIENTS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_RECHERCHE_CLIENTSTableAdapter.Fill(this.dataSet.VW_RECHERCHE_CLIENTS);
            this.cboNPA.Text = "";
            WindowState = FormWindowState.Maximized;
        }

            private void btnNewClient_Click(object sender, EventArgs e)
        {
            FrmGestionClients newClient = new FrmGestionClients(0);
            newClient.ShowDialog();
            this.vW_RECHERCHE_CLIENTSTableAdapter.Fill(this.dataSet.VW_RECHERCHE_CLIENTS);
        }

        // Permet de lier le client au panier
        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvClients.Rows[e.RowIndex].Cells[0].Value;
            String lastName = dgvClients.Rows[e.RowIndex].Cells[1].Value.ToString();
            String firstName = dgvClients.Rows[e.RowIndex].Cells[2].Value.ToString();
            FrmPanier.getInstance().setClient(id, lastName, firstName, 0);
            FrmPanier.getInstance().MdiParent = MDIContainer.getInstance();
            if (Application.OpenForms[FrmPanier.getInstance().Name] == null)
            {
                FrmPanier.getInstance().Show();
                FrmPanier.getInstance().Focus();
            }
            else
            {
                Application.OpenForms[FrmPanier.getInstance().Name].Focus();
                // FrmPanier.getInstance().Activate();
            }
            FrmPanier.getInstance().Show();
            FrmPanier.getInstance().Focus();
            FrmPanier.getInstance().TopMost = true;
            this.Close();
        }

        // Permet de faire apparaître la vue pour modifier le client

        private void dgvClients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvClients.Rows[e.RowIndex].Cells[0].Value;
            String lastName = dgvClients.Rows[e.RowIndex].Cells[1].Value.ToString();
            String firstName = dgvClients.Rows[e.RowIndex].Cells[2].Value.ToString();
            String sexe = dgvClients.Rows[e.RowIndex].Cells[3].Value.ToString();
            String noRue = dgvClients.Rows[e.RowIndex].Cells[4].Value.ToString();
            String nomRue = dgvClients.Rows[e.RowIndex].Cells[5].Value.ToString();
            String npa = dgvClients.Rows[e.RowIndex].Cells[6].Value.ToString();
            String localite = dgvClients.Rows[e.RowIndex].Cells[7].Value.ToString();
            String pays = dgvClients.Rows[e.RowIndex].Cells[8].Value.ToString();

            FrmGestionClients frmNewClient = new FrmGestionClients(1);
            frmNewClient.setDataClient(id, lastName, firstName, sexe, noRue, nomRue, npa, localite, pays);
            frmNewClient.ShowDialog();
            this.vW_RECHERCHE_CLIENTSTableAdapter.Fill(this.dataSet.VW_RECHERCHE_CLIENTS);
        }

        // Permet de rechercher dans les clients par nom, prénom ou par nom de rue
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            this.cboNPA.Text = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvClients.DataSource;
            bs.Filter = "Nom like '%" + txtRecherche.Text + "%' or " + "Prenom like '%" + txtRecherche.Text + "%' or " + "NOMRUE like '%" + txtRecherche.Text + "%'";
            dgvClients.DataSource = bs;
        }

        // Permet de filtrer par NPA
        private void cboNPA_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvClients.DataSource;
            int npa;
            bool res = int.TryParse(cboNPA.Text, out npa);
            if (res && npa != 0)
            {
                bs.Filter = "NPA = " + npa;
            }
            else
            {
                bs.Filter = null;
            }
            dgvClients.DataSource = bs;
        }

        private void onFormClick(object sender, EventArgs e)
        {
            this.vW_RECHERCHE_CLIENTSTableAdapter.Fill(this.dataSet.VW_RECHERCHE_CLIENTS);
        }
    }
}
