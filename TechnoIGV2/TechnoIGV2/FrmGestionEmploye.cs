using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TechnoIGV2
{
    public partial class FrmGestionEmploye : Form
    {
        private int action;
        public FrmGestionEmploye(int action)
        {
            this.action = action;
            InitializeComponent();
            // Action == 0 ==> new()
            // Action == 1 ==> changePassword
            // Action == 2 ==> Changer Fonction
            if (this.action == 0) // Dans le cas de l'ajout d'un nouveau personnel
            {
                lblTitre.Text = "Ajouter un nouvel employé";
                lblTitre.Left = (lblTitre.Parent.Width - lblTitre.Width) / 2;
                lblPassword2.Visible = false;
                txtPasswordValue2.Visible = false;
                lblPassword1.Left = 10;
                txtPasswordValue1.Left = lblPassword1.Right + 2;

                txtNomValue.Enabled = true;
                txtPrenomValue.Enabled = true;
                txtUtilisateurValue.Enabled = true;
                txtPasswordValue1.Enabled = true;
                txtPasswordValue2.Enabled = false;
                txtUtilisateurValue.Enabled = true;
            }
            else if (this.action == 1) // Dans le cas de la modification du mot de passe d'un personnel
            {
                lblTitre.Text = "Modifier votre mot de passe";
                lblTitre.Left = (lblTitre.Parent.Width - lblTitre.Width) / 2;
                lblFonction.Visible = false;
                cboFonction.Visible = false;


                txtNomValue.Enabled = true;
                txtPrenomValue.Enabled = true;
                txtUtilisateurValue.Enabled = true;
                txtPasswordValue1.Enabled = true;
                txtPasswordValue2.Enabled = true;

                txtUtilisateurValue.Enabled = true;

            }
            else if (this.action == 2) // Dans le cas de la modification d'une fonction d'un personnel
            {
                lblTitre.Text = "Modifier la fonction";
                lblTitre.Left = (lblTitre.Parent.Width - lblTitre.Width) / 2;
                lblFonction.Visible = true;
                cboFonction.Visible = true;

                txtNomValue.Enabled = false;
                txtPrenomValue.Enabled = false;
                txtUtilisateurValue.Enabled = false;
                txtPasswordValue1.Enabled = false;
                txtPasswordValue2.Enabled = false;
                txtUtilisateurValue.Enabled = false;
            }
        }

        // Permet de remplir les données d'un membre du personnel
        public void set_dataForModification(String nom, String prenom, String fonction)
        {
            txtNomValue.Text = nom;
            txtPrenomValue.Text = prenom;

            if (fonction == "Vendeur")
            {
                cboFonction.SelectedIndex = 0;
            } else if (fonction == "Manager")
            {
                cboFonction.SelectedIndex = 1;
            }
        }
        
        private void grpPassword_Enter(object sender, EventArgs e)
        {

        }

        private void FrmChangerPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            decimal? resultat = 0;
            DataSetTableAdapters.QueriesTableAdapter MaRequete = new DataSetTableAdapters.QueriesTableAdapter();

            StringBuilder builder = new StringBuilder();
            if (this.action == 0 || this.action == 1 && txtPasswordValue1.Text != "")
            {
                // Dans le cas de l'ajout d'un nouveau personnel ou de la modification du mot de passe
                // Permet d'encrypter le mot de passe
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    // ComputeHash - returns byte array
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(txtPasswordValue1.Text));

                    // Convert byte array to a string
                    builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                }
            }

            if (this.action == 0) // Création d'un nouveau membre du staff
            {
                try
                {
                    if (txtPasswordValue1.Text != "")
                    {
                        resultat = MaRequete.PKG_GESTIONPERSONNEL_CREERPERSONNEL(txtNomValue.Text, txtPrenomValue.Text, txtUtilisateurValue.Text, cboFonction.Text, builder.ToString());
                        MessageBox.Show("Personnel enregistrée correctement", "Nouveau validé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Impossible d'enregister le nouveau membre. Les mots de passes doivent correspondre.", "Vérifez les mots de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Gestion des erreurs Oracle.
                catch (Oracle.DataAccess.Client.OracleException ex)
                {
                    if (ex.Number == 00001)
                    {
                        MessageBox.Show("Impossible d'enregistrer le nouveau membre. Un autre membre est déjà enregistré avec ce nom et ce prénom ou nom d'utilisateur.",
                       "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (ex.Number == 20020)
                    {
                        MessageBox.Show("Impossible d'enregistrer le nouveau membre. La fonction spécifiée est incorrecte.",
                        "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Number == 20021)
                    {
                        MessageBox.Show("Impossible d'enregistrer le nouveau membre. Vérifiez que les données soient correctes.",
                        "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Impossible d'enregistrer le nouveau membre. Vérifiez que la personne n'existe pas ou que ses données soient complètes.",
                        "Enregistrement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (this.action == 1)  // Modification d'un membre
            {
                try
                {
                    resultat = MaRequete.PKG_GESTIONPERSONNEL_CHANGEPASSWORDPERSONNEL(txtNomValue.Text, txtPrenomValue.Text, txtUtilisateurValue.Text, builder.ToString());
                    MessageBox.Show("Votre nouveau mot de passe a bien été initialisé", "Mot de passe modifié", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                // Gestion des erreurs Oracle.
                catch (Oracle.DataAccess.Client.OracleException ex)
                {
                    if (ex.Number == 20050)
                    {
                        MessageBox.Show("Le nom d'utilisateur n'est pas attribué à un membre du staff.", "Modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Number == 20051)
                    {
                        MessageBox.Show("La recherche avec le nom d'utilisateur a donné plusieurs personnes. Merci de contacter l'administrateur système.", "Modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        MessageBox.Show("Une erreur innatendue est survenue. Réessayez", "Modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (this.action == 2) // Dans le cas du changement de fonction d'un memebre du personnel.
            {
                try
                {
                    resultat = MaRequete.PKG_GESTIONPERSONNEL_MODIFIERPERSONNEL(txtPrenomValue.Text, txtNomValue.Text, cboFonction.Text);
                    MessageBox.Show("Modification du personnel enregistrée", "Changement de fonction validé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                // Gestion des erreurs Oracle.
                catch (Oracle.DataAccess.Client.OracleException ex)
                {
                    if (ex.Number == 20020)
                    {
                        MessageBox.Show("Impossible de modifier la fonction du membre. La fonction spécifiée est incorrecte.",
                        "Modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Impossible de modifier le nouveau membre. Une erreur innatendue est survenue.",
                        "Modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword1_Click(object sender, EventArgs e)
        {

        }
    }
}
