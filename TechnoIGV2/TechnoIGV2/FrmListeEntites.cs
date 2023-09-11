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
    public partial class FrmListeEntites : Form
    {
        private int type;
        public FrmListeEntites(int type)
        {
            InitializeComponent();
            this.type = type;

            if (this.type == 0) // Dans le cas de la liste des fournisseurs
            {
                setColumnFournisseur();
            }
            else if (this.type == 1) // Dans le cas de la liste des employés
            {
                setColumnEmployes();
            }
            else
            {
                this.Close();
                this.Dispose();
            }
            lblTitre.Left = (lblTitre.Parent.Width - lblTitre.Width) / 2;
        }

        private void FrmListeEntites_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_LISTE_FOURNISSEURS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_LISTE_FOURNISSEURSTableAdapter.Fill(this.dataSet.VW_LISTE_FOURNISSEURS);
            // TODO: cette ligne de code charge les données dans la table 'dataSet.VW_LISTE_PERSONNELS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vW_LISTE_PERSONNELSTableAdapter.Fill(this.dataSet.VW_LISTE_PERSONNELS);
            WindowState = FormWindowState.Maximized;
        }

        private void setColumnFournisseur()
        {
            // Informations pour les fournisseurs
            lblTitre.Text = "Liste des fournisseurs";
            dgvEmployes.Visible = false;
            dgvFournisseurs.Visible = true;
        }

        private void setColumnEmployes()
        {
            // Informations pour les employés 
            lblTitre.Text = "Liste des employés";
            dgvEmployes.Visible = true;

            dgvFournisseurs.Visible = false;
        }

        // Click simple sur la DataGridView des employés
        private void dgvEmployes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Dans le cas ou le click a été fait sur la cellule 5, pour la modification
            if (e.ColumnIndex == 5)
            {
                FrmGestionEmploye gestionEmploye = new FrmGestionEmploye(2);
                gestionEmploye.set_dataForModification(dgvEmployes.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvEmployes.Rows[e.RowIndex].Cells[2].Value.ToString(), dgvEmployes.Rows[e.RowIndex].Cells[3].Value.ToString());
                gestionEmploye.ShowDialog();
                this.vW_LISTE_PERSONNELSTableAdapter.Fill(this.dataSet.VW_LISTE_PERSONNELS);
            } else if (e.ColumnIndex == 6) // Dans le cas ou le click a été fait sur la cellule 6, pour la suppression
            {
                decimal? resultat = 0;
                DataSetTableAdapters.QueriesTableAdapter MaRequete = new DataSetTableAdapters.QueriesTableAdapter();

                try
                {
                    // Suppression du personnel (désactivation du compte en Oracle)
                    String lastName = dgvEmployes.Rows[e.RowIndex].Cells[1].Value.ToString();
                    String firstName = dgvEmployes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    resultat = MaRequete.PKG_GESTIONPERSONNEL_SUPPRIMERPERSONNEL(firstName, lastName);

                    MessageBox.Show("Le membre du personnel a bien été mis en inactif.",
                                    "Désactivation réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.vW_LISTE_PERSONNELSTableAdapter.Fill(this.dataSet.VW_LISTE_PERSONNELS);
                }
                // Gestion des erreurs Oracle
                catch (Oracle.DataAccess.Client.OracleException ex)
                {
                    if (ex.Number == 20053)
                    {
                        MessageBox.Show("Impossible de trouver un membre du personnel avec les données entrées.", "Echec de la désactivation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Une erreur spéciale est survenue. Réessayez à nouveau", "Echec de la désactivation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        // Double click sur la DataGridView des employés ==> consultation des statistiques
        private void dgvEmployes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmStatistiques frmStatistiques = new FrmStatistiques((int) dgvEmployes.Rows[e.RowIndex].Cells[0].Value,
                dgvEmployes.Rows[e.RowIndex].Cells[1].Value.ToString().ToUpper(), dgvEmployes.Rows[e.RowIndex].Cells[2].Value.ToString());

            frmStatistiques.MdiParent = MDIContainer.getInstance();
            frmStatistiques.Show();
        }


        // Double click sur la DataGridView des fournisseurs ==> consultation des statistiques
        private void dgvFourni_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmStatistiques frmStatistiques = new FrmStatistiques(dgvFournisseurs.Rows[e.RowIndex].Cells[0].Value.ToString());
            frmStatistiques.MdiParent = MDIContainer.getInstance();
            frmStatistiques.Show();
        }

        private void dgvFourni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (type == 0) // Fournisseurs
            {
                // Permet de rechercher sur le nom du fournisseur, le mail et le nom du référant
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvFournisseurs.DataSource;
                bs.Filter = "Nom like '%" + txtRecherche.Text + "%' or " + "EMAIL like '%" + txtRecherche.Text + "%' or " + "Referant like '%" + txtRecherche.Text + "%'";
                dgvFournisseurs.DataSource = bs;
            }
            else if (type == 1) // Employés
            {
                // Permet de rechercher sur le nom / prénom de l'employé ou de la fonction
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvEmployes.DataSource;
                bs.Filter = "Nom like '%" + txtRecherche.Text + "%' or " + "Prenom like '%" + txtRecherche.Text + "%' or " + "Fonction like '%" + txtRecherche.Text + "%'";
                dgvEmployes.DataSource = bs;
            }
        }

        private void onFormClick(object sender, EventArgs e)
        {
            if (type == 1) // Employés
            {
                this.vW_LISTE_PERSONNELSTableAdapter.Fill(this.dataSet.VW_LISTE_PERSONNELS);
            }
            else
            {
                this.vW_LISTE_FOURNISSEURSTableAdapter.Fill(this.dataSet.VW_LISTE_FOURNISSEURS);
            }
            this.txtRecherche_TextChanged(null, null);
        }
    }
}
