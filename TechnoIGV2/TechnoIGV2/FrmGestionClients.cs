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
    public partial class FrmGestionClients : Form
    {
        private int action;
        private int idClient;
        
        public FrmGestionClients(int action)
        {
            this.action = action;
            InitializeComponent();
            if (this.action == 1) // Dans le cas ou on veut modifier un client existant
            {
                lblTitre.Text = "Modifier un client";
                btnValider.Text = "Modifier client";
                lblTitre.Left = (lblTitre.Parent.Width - lblTitre.Width) / 2;
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
            }
            else if (this.action == 0) // Dans le cas ou l'on veut ajouter un nouveau client
            {
                lblTitre.Text = "Nouveau client";
                btnValider.Text = "Valider client";
                lblTitre.Left = (lblTitre.Parent.Width - lblTitre.Width) / 2;
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
            }
            else
            {
                Close(); // Si le chiffre ne correspond pas, on ferme le formulaire
            }
        }
        private void FrmNewClient_Load(object sender, EventArgs e)
        {

        }

        // Permet d'ajouter les informations liés à un client dans le cas de la modification
        public void setDataClient(int id, String nom, String prenom, String sexe, String noRue, String nomRue, String npa, String localite, String pays)
        {
            this.idClient = id;
            this.txtNom.Text = nom;
            this.txtPrenom.Text = prenom;
            // Permet de sélectionner le bon genre lié à la personne.
            if (sexe.ToUpper() == "M")
            {
                this.cboSexe.SelectedIndex = 2;
            } else if (sexe.ToUpper() == "F")
            {
                this.cboSexe.SelectedIndex = 1;
            } else
            {
                this.cboSexe.SelectedIndex = 0;
            }

            this.txtNoRue.Text = noRue;
            this.txtNomRue.Text = nomRue;
            this.txtNPA.Text = npa;
            this.txtNomLocalite.Text = localite;
            this.txtPays.Text = pays;
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        // Valide la modification ou l'ajout du nouveau client
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals(""))
            {
                // Récupérations et vérification des données clients
                String nom = txtNom.Text;
                String prenom = txtPrenom.Text;
                String sexe = "A";
                if (cboSexe.SelectedIndex == 2)
                {
                    sexe = "M";
                }
                else if (cboSexe.SelectedIndex == 1)
                {
                    sexe = "F";
                }
                int noRue = -1;
                bool noRueCorrect = int.TryParse(txtNoRue.Text, out noRue);
                if (txtNoRue.Text == "")
                {
                    noRueCorrect = true;
                }
                String nomRue = txtNomRue.Text;
                String localite = txtNomLocalite.Text;
                int npa = -1;
                bool npaCorrect = int.TryParse(txtNPA.Text, out npa);
                if (txtNPA.Text == "")
                {
                    npaCorrect = true;
                }
                String pays = txtPays.Text;

                decimal? resultat = 0;
                DataSetTableAdapters.QueriesTableAdapter MaRequete = new DataSetTableAdapters.QueriesTableAdapter();

                if (noRueCorrect && npaCorrect)
                {
                    // Dans le cas d'un ajout de client
                    if (this.action == 0)
                    {
                        try
                        {
                            // Appel de la procédure d'ajout
                            resultat = MaRequete.PKG_GESTIONCLIENT_CREERCLIENT(nom, prenom, sexe, noRue, nomRue, npa, localite, pays);
                            MessageBox.Show("Personne enregistrée", "Client ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        // Gestion des erreurs retourné par Oracle
                        catch (Oracle.DataAccess.Client.OracleException ex)
                        {
                            if (ex.Number == 20015)
                            {
                                MessageBox.Show("Impossible d'enregistrer le client. Vérifiez que le genre sélectionné soit correcte.",
                                "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else if (ex.Number == 00001)
                            {
                                MessageBox.Show("Impossible d'enregistrer le client. Un client est déjà enregistré avec ce nom et ce prénom.",
                                "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else
                            {
                                MessageBox.Show("Impossible d'enregistrer le client. Vérifiez que la personne n'existe pas ou que ses valeurs soient correctes.",
                                "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (this.action == 1) // DAns le cas de la modification
                    {
                        try
                        {
                            // Appel de la procédure de modification
                            resultat = MaRequete.PKG_GESTIONCLIENT_MODIFIERCLIENT(this.idClient, sexe, noRue, nomRue, npa, localite, pays);
                            this.Close();
                        }
                        // Gestion des erreurs retourné par Oracle
                        catch (Oracle.DataAccess.Client.OracleException ex)
                        {
                            if (ex.Number == 20015)
                            {
                                MessageBox.Show("Impossible de modifier le client. Vérifiez que le genre sélectionné soit correcte.",
                                "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (ex.Number == 20016)
                            {
                                MessageBox.Show("Impossible de modifier le client car il n'a pas été trouvé dans la base de données.",
                                "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else if (ex.Number == 20012) 
                            {
                                MessageBox.Show("Impossible de modifier le client car le nom ou le prenom ne peuvent pas être modifiés.",
                                "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else
                            {
                                MessageBox.Show("Impossible d'enregistrer la modification du le client." +
                                "Vérifiez que la personne existe ou que ses valeurs soient correctes.",
                                "Enregistrement de la modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }
                    }
                    else
                    {
                        // Dans le cas ou le numéro d'action est mauvais on quitte la page.
                        // Evite d'apporter de fausses modifications
                        this.Close();
                    }

                }
                else
                {
                    // Dans le cas où la convertion d'une donnée en numérique n'a pas fonctionné.
                    MessageBox.Show("Impossible d'enregistrer la personne car le numéro de rue ou le NPA est incorrect!",
                        "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                // Dans le cas ou le nom et le prénom de la personne est vide
                MessageBox.Show("Impossible d'enregistrer la personne. Vérifiez que les informations de la personnes soient complètes.",
                                "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSexe_Click(object sender, EventArgs e)
        {

        }
    }
}
