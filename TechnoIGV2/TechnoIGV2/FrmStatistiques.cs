using System;
using System.Windows.Forms;

namespace TechnoIGV2
{
    public partial class FrmStatistiques : Form
    {
        private int type;


        // Création de la vue de statistiques pour un employé
        public FrmStatistiques(int id, String nom, String prenom) // 0 ==> Employé
        {
            InitializeComponent();
            this.type = 0;

            lblTitreStat.Text = "Statistiques employé";
            txtNomEntite.Text = nom + " " + prenom;
            setChartEmploye(id);
            lblTitreStat.Left = (lblTitreStat.Parent.Width - lblTitreStat.Width) / 2;
            txtNomEntite.Left = (txtNomEntite.Parent.Width - txtNomEntite.Width) / 2;

            chrtStatEmp.Visible = true;
            chrStatFournisseur.Visible = false;
        }

        // Création de la vue de statistiques pour un fournisseur
        public FrmStatistiques(String nom) // 1 ==> Fournisseur
        {
            InitializeComponent();
            this.type = 1;
            lblTitreStat.Text = "Statistiques fournisseur";
            txtNomEntite.Text = nom;
            setChartFournisseur(nom);

            lblTitreStat.Left = (lblTitreStat.Parent.Width - lblTitreStat.Width) / 2;
            txtNomEntite.Left = (txtNomEntite.Parent.Width - txtNomEntite.Width) / 2;

            chrtStatEmp.Visible = false;
            chrStatFournisseur.Visible = true;
        }

        private void FrmStatistiques_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        // Remplissage des données de la vue pour un employé grâce à son ID
        private void setChartEmploye(int id)
        {
            this.vW_STATISTIQUES_EMPLOYESTableAdapter.FillByEmpID(this.dataSet.VW_STATISTIQUES_EMPLOYES, id);
            chrtStatEmp.Series["Ventes"].XValueMember = "MOIS";
            chrtStatEmp.Series["Ventes"].YValueMembers = "NBCOMMANDES";
            chrtStatEmp.DataSource = this.dataSet.VW_STATISTIQUES_EMPLOYES;
            chrtStatEmp.DataBind();

            chrStatFournisseur.Titles.Add("Nombre de commandes clients enregistrées par mois");
        }


        // Remplissage des données de la vue pour un fournisseur grâce à son nom
        private void setChartFournisseur(String nom)
        {
            this.vW_STATISTIQUES_FOURNISSEURSTableAdapter.FillByByNom(this.dataSet.VW_STATISTIQUES_FOURNISSEURS, nom);
            chrStatFournisseur.Series["Commandes"].XValueMember = "MOIS";
            chrStatFournisseur.Series["Commandes"].YValueMembers = "NBCOMMANDES";

            chrStatFournisseur.DataSource = this.dataSet.VW_STATISTIQUES_FOURNISSEURS;
            chrStatFournisseur.DataBind();

            chrStatFournisseur.Titles.Add("Nombre de commandes passées par mois");
        }

        private void chrtStatEmp_Click(object sender, EventArgs e)
        {

        }
    }
}
