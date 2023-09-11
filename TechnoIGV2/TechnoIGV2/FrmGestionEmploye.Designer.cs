
namespace TechnoIGV2
{
    partial class FrmGestionEmploye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.grpInformationsPerso = new System.Windows.Forms.GroupBox();
            this.cboFonction = new System.Windows.Forms.ComboBox();
            this.lblFonction = new System.Windows.Forms.Label();
            this.txtUtilisateurValue = new System.Windows.Forms.TextBox();
            this.txtPrenomValue = new System.Windows.Forms.TextBox();
            this.txtNomValue = new System.Windows.Forms.TextBox();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.txtPasswordValue2 = new System.Windows.Forms.TextBox();
            this.txtPasswordValue1 = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpInformationsPerso.SuspendLayout();
            this.grpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(92, 63);
            this.lblNom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(87, 39);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "&Nom";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.Location = new System.Drawing.Point(84, 126);
            this.lblPassword2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(362, 39);
            this.lblPassword2.TabIndex = 2;
            this.lblPassword2.Text = "Vérifier le mot de pa&sse";
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword1.Location = new System.Drawing.Point(97, 63);
            this.lblPassword1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(356, 39);
            this.lblPassword1.TabIndex = 0;
            this.lblPassword1.Text = "N&ouveau mot de passe";
            this.lblPassword1.Click += new System.EventHandler(this.lblPassword1_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(567, 63);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(134, 39);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "&Prénom";
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilisateur.Location = new System.Drawing.Point(15, 144);
            this.lblUtilisateur.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(160, 39);
            this.lblUtilisateur.TabIndex = 4;
            this.lblUtilisateur.Text = "&Identifiant";
            this.lblUtilisateur.Click += new System.EventHandler(this.lblMail_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(473, 17);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(116, 55);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Titre";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInformationsPerso
            // 
            this.grpInformationsPerso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInformationsPerso.Controls.Add(this.cboFonction);
            this.grpInformationsPerso.Controls.Add(this.lblFonction);
            this.grpInformationsPerso.Controls.Add(this.txtUtilisateurValue);
            this.grpInformationsPerso.Controls.Add(this.txtPrenomValue);
            this.grpInformationsPerso.Controls.Add(this.txtNomValue);
            this.grpInformationsPerso.Controls.Add(this.lblUtilisateur);
            this.grpInformationsPerso.Controls.Add(this.lblPrenom);
            this.grpInformationsPerso.Controls.Add(this.lblNom);
            this.grpInformationsPerso.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformationsPerso.Location = new System.Drawing.Point(22, 81);
            this.grpInformationsPerso.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpInformationsPerso.Name = "grpInformationsPerso";
            this.grpInformationsPerso.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpInformationsPerso.Size = new System.Drawing.Size(1027, 203);
            this.grpInformationsPerso.TabIndex = 1;
            this.grpInformationsPerso.TabStop = false;
            this.grpInformationsPerso.Text = "&Informations personnelles";
            // 
            // cboFonction
            // 
            this.cboFonction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFonction.FormattingEnabled = true;
            this.cboFonction.Items.AddRange(new object[] {
            "Vendeur",
            "Manager"});
            this.cboFonction.Location = new System.Drawing.Point(719, 144);
            this.cboFonction.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboFonction.Name = "cboFonction";
            this.cboFonction.Size = new System.Drawing.Size(294, 40);
            this.cboFonction.TabIndex = 7;
            this.cboFonction.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFonction.Location = new System.Drawing.Point(556, 144);
            this.lblFonction.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(145, 39);
            this.lblFonction.TabIndex = 6;
            this.lblFonction.Text = "&Fonction";
            // 
            // txtUtilisateurValue
            // 
            this.txtUtilisateurValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilisateurValue.Location = new System.Drawing.Point(194, 144);
            this.txtUtilisateurValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUtilisateurValue.Name = "txtUtilisateurValue";
            this.txtUtilisateurValue.Size = new System.Drawing.Size(294, 40);
            this.txtUtilisateurValue.TabIndex = 5;
            // 
            // txtPrenomValue
            // 
            this.txtPrenomValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomValue.Location = new System.Drawing.Point(719, 63);
            this.txtPrenomValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrenomValue.Name = "txtPrenomValue";
            this.txtPrenomValue.Size = new System.Drawing.Size(294, 40);
            this.txtPrenomValue.TabIndex = 3;
            // 
            // txtNomValue
            // 
            this.txtNomValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomValue.Location = new System.Drawing.Point(194, 63);
            this.txtNomValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNomValue.Name = "txtNomValue";
            this.txtNomValue.Size = new System.Drawing.Size(294, 40);
            this.txtNomValue.TabIndex = 1;
            // 
            // grpPassword
            // 
            this.grpPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPassword.Controls.Add(this.txtPasswordValue2);
            this.grpPassword.Controls.Add(this.txtPasswordValue1);
            this.grpPassword.Controls.Add(this.lblPassword1);
            this.grpPassword.Controls.Add(this.lblPassword2);
            this.grpPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPassword.Location = new System.Drawing.Point(22, 295);
            this.grpPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpPassword.Size = new System.Drawing.Size(1027, 192);
            this.grpPassword.TabIndex = 2;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "&Mot de passe";
            this.grpPassword.Enter += new System.EventHandler(this.grpPassword_Enter);
            // 
            // txtPasswordValue2
            // 
            this.txtPasswordValue2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordValue2.Location = new System.Drawing.Point(484, 126);
            this.txtPasswordValue2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPasswordValue2.Name = "txtPasswordValue2";
            this.txtPasswordValue2.PasswordChar = '*';
            this.txtPasswordValue2.Size = new System.Drawing.Size(528, 40);
            this.txtPasswordValue2.TabIndex = 3;
            // 
            // txtPasswordValue1
            // 
            this.txtPasswordValue1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordValue1.Location = new System.Drawing.Point(484, 63);
            this.txtPasswordValue1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPasswordValue1.Name = "txtPasswordValue1";
            this.txtPasswordValue1.PasswordChar = '*';
            this.txtPasswordValue1.Size = new System.Drawing.Size(528, 40);
            this.txtPasswordValue1.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Green;
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnValider.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(759, 498);
            this.btnValider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(235, 68);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Maroon;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(77, 498);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(235, 68);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annu&ler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // FrmGestionEmploye
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(1056, 576);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.grpPassword);
            this.Controls.Add(this.grpInformationsPerso);
            this.Controls.Add(this.lblTitre);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 640);
            this.Name = "FrmGestionEmploye";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de compte";
            this.Load += new System.EventHandler(this.FrmChangerPassword_Load);
            this.grpInformationsPerso.ResumeLayout(false);
            this.grpInformationsPerso.PerformLayout();
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox grpInformationsPerso;
        private System.Windows.Forms.TextBox txtNomValue;
        private System.Windows.Forms.TextBox txtPrenomValue;
        private System.Windows.Forms.TextBox txtUtilisateurValue;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.ComboBox cboFonction;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.TextBox txtPasswordValue2;
        private System.Windows.Forms.TextBox txtPasswordValue1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}