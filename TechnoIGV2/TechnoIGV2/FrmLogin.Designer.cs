
namespace TechnoIGV2
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPasswordValue = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnPasswordOublie = new System.Windows.Forms.Button();
            this.grpInformations = new System.Windows.Forms.GroupBox();
            this.grpInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(169, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(246, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Bienvenue à vous !";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(22, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(92, 22);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "&Utilisateur";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(153, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(237, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPasswordValue
            // 
            this.txtPasswordValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordValue.Location = new System.Drawing.Point(153, 74);
            this.txtPasswordValue.Name = "txtPasswordValue";
            this.txtPasswordValue.PasswordChar = '*';
            this.txtPasswordValue.Size = new System.Drawing.Size(237, 26);
            this.txtPasswordValue.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(22, 74);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(125, 22);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "&Mot de passe";
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.Green;
            this.btnConnexion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Location = new System.Drawing.Point(306, 249);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(130, 50);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "&Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPasswordOublie
            // 
            this.btnPasswordOublie.BackColor = System.Drawing.Color.Maroon;
            this.btnPasswordOublie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPasswordOublie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordOublie.ForeColor = System.Drawing.Color.White;
            this.btnPasswordOublie.Location = new System.Drawing.Point(148, 249);
            this.btnPasswordOublie.Name = "btnPasswordOublie";
            this.btnPasswordOublie.Size = new System.Drawing.Size(130, 50);
            this.btnPasswordOublie.TabIndex = 3;
            this.btnPasswordOublie.Text = "Mot de &passe oublié";
            this.btnPasswordOublie.UseVisualStyleBackColor = false;
            this.btnPasswordOublie.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpInformations
            // 
            this.grpInformations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpInformations.Controls.Add(this.txtPasswordValue);
            this.grpInformations.Controls.Add(this.lblPassword);
            this.grpInformations.Controls.Add(this.txtUsername);
            this.grpInformations.Controls.Add(this.lblUsername);
            this.grpInformations.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformations.Location = new System.Drawing.Point(94, 72);
            this.grpInformations.Name = "grpInformations";
            this.grpInformations.Size = new System.Drawing.Size(396, 119);
            this.grpInformations.TabIndex = 1;
            this.grpInformations.TabStop = false;
            this.grpInformations.Text = "&Informations";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.grpInformations);
            this.Controls.Add(this.btnPasswordOublie);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lblTitre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grpInformations.ResumeLayout(false);
            this.grpInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPasswordValue;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnPasswordOublie;
        private System.Windows.Forms.GroupBox grpInformations;
    }
}

