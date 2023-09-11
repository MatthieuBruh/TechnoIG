using System;
using System.Windows.Forms;

namespace TechnoIGV2
{
    public partial class FrmProfil : Form
    {
        static FrmProfil frmProfile = null;
        private String nomUtil = "";
        private FrmProfil(String nomUtil)
        {
            InitializeComponent();
            this.nomUtil = nomUtil;
        }

        public static FrmProfil getInstance(String nomUtil)
        {
            if (frmProfile == null || frmProfile.IsDisposed)
            {
                frmProfile = new FrmProfil(nomUtil);
            }
            return frmProfile;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_PERSONNEL_DETAILS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_PERSONNEL_DETAILSTableAdapter.Fill(this.dataSet.VW_PERSONNEL_DETAILS);
            this.vW_PERSONNEL_DETAILSTableAdapter.FillByUsername(this.dataSet.VW_PERSONNEL_DETAILS, this.nomUtil);
            this.vW_PERSONNEL_COMMANDESTableAdapter.FillByUsername(this.dataSet.VW_PERSONNEL_COMMANDES, this.nomUtil);
            WindowState = FormWindowState.Maximized;
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void dgvCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Dans le cas ou la cellule sélectionée est celle qui contient le boutton supprimer
            if (e.ColumnIndex == 7)
            {
                try
                {
                    decimal? resultat = 0;
                    DataSetTableAdapters.QueriesTableAdapter MaRequete = new DataSetTableAdapters.QueriesTableAdapter();

                    // Suppression de la commande
                    MaRequete.PKG_GESTIONCMDCLIENTS_DELETECOMMANDECLIENT((int) dgvCommandes.Rows[e.RowIndex].Cells[2].Value);

                    // On rempli la DataGridView à nouveau
                    MessageBox.Show("La commande a été supprimée avec succès", "Commande supprimée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.vW_PERSONNEL_COMMANDESTableAdapter.FillByUsername(this.dataSet.VW_PERSONNEL_COMMANDES, this.nomUtil);

                }
                // Gestion des erreurs Oracle
                catch (Oracle.DataAccess.Client.OracleException ex)
                {
                    if (ex.Number == 20003)
                    {
                        this.messageError("Aucune commande n'a été trouvée avec ce numéro de commande", "Numéro de commande invalide !");
                    }
                    else if (ex.Number == 20004)
                    {
                        this.messageError("Le délai de suppresion de la commande a été dépassé (délai de 24H). La commande ne peut plus être supprimée", "Délai de suppresion dépassé !");
                    }
                    else
                    {
                        this.messageError("Une erreur innatendue est arrivée, (Code : " + ex.Number + ", Message : " + ex.Message + ") ", "Numéro de commande invalide");
                    }
                }
            }
        }

        private void messageError(String message, String raison)
        {
            MessageBox.Show(message, raison, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Recherche de commandes par le nom ou prénom du client
        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvCommandes.DataSource;
            bs.Filter = "nomClient like '%" + txtRechercher.Text + "%' or " + "prenomClient like '%" + txtRechercher.Text + "%'";
            dgvCommandes.DataSource = bs;
        }

        private void onFormClick(object sender, EventArgs e)
        {
            this.vW_PERSONNEL_COMMANDESTableAdapter.FillByUsername(this.dataSet.VW_PERSONNEL_COMMANDES, this.nomUtil);
        }
    }
}
