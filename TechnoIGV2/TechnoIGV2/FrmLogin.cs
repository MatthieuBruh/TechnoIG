using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TechnoIGV2
{
    public partial class FrmLogin : Form
    {
        static FrmLogin frmLoginHolder = null;

        private FrmLogin()
        {
            InitializeComponent();
        }

        public static FrmLogin getInstance()
        {
            if (frmLoginHolder == null || frmLoginHolder.IsDisposed) {
                frmLoginHolder = new FrmLogin();
            }
            return frmLoginHolder;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        // Connexion à TechnoIG_data
        private void button1_Click(object sender, EventArgs e)
        {

            if (!txtUsername.Text.Equals("") && !txtPasswordValue.Text.Equals(""))
            {
                decimal? resultat = 0;
                DataSetTableAdapters.QueriesTableAdapter MaRequete = new DataSetTableAdapters.QueriesTableAdapter();
                String password = txtPasswordValue.Text;
                try
                {
                    // Encryption du mot de passe
                    StringBuilder builder;
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        // ComputeHash - returns byte array
                        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                        // Convert byte array to a string
                        builder = new StringBuilder();
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            builder.Append(bytes[i].ToString("x2"));
                        }
                    }
                    // Vérification des données auprès de la BDD
                    resultat = MaRequete.PKG_GESTIONPERSONNEL_PERSONNELCONNECT(txtUsername.Text, builder.ToString());
                    MDIContainer mdi = MDIContainer.getInstance();
                    // Gestion des informations retournées
                    if (resultat == 1) // Connexion réussie pour un manager
                    {
                        mdi.setNiveauAutorisation(1, txtUsername.Text);
                        authValid();
                    }
                    else if (resultat == 2) // Connexion réussie pour un vendeur
                    {
                        mdi.setNiveauAutorisation(2, txtUsername.Text);
                        authValid();
                    } else
                    {
                        // Connexion échouée
                        this.messageErrorLogin("Le nom d'utilisateur et le mot de passe ne corresponde pas.", "Echec de la connexion");
                    }
                }
                // Gestion des erreurs Oracle
                catch (Oracle.DataAccess.Client.OracleException ex)
                {
                    if (ex.Number == 20050)
                    {
                        this.messageErrorLogin("Le nom d'utilisateur qui a été saisi est erronné", "Nom d'utilisateur erroné");
                    }
                    else if (ex.Number == 20056)
                    {
                        this.messageErrorLogin("Le nom d'utilisateur appartient à un compte désactivé", "Connexion impossible");
                    }
                    else
                    {
                        this.messageErrorLogin("Un problème inattendu est survenu. Réessayez", "Erreur inattendue");
                    }
                }
                
            }
            else
            {
                this.messageErrorLogin("Votre nom d'utilisateur ou votre mot de passe est vide. Remplissez-les pour vous connecter", "Renseignement incomplet");
            }

        }

        // Permet d'afficher des messages erreurs.
        private void messageErrorLogin(String message, String raison)
        {
            MessageBox.Show(message, raison, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Permet de fermer la fenêtre de connexion
        private void authValid()
        {
            this.Close();
            this.Dispose();
        }

        // Permet de modifier le mot de passe
        private void button2_Click(object sender, EventArgs e)
        {
            FrmGestionEmploye frmGestionEmploye = new FrmGestionEmploye(1);
            frmGestionEmploye.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
