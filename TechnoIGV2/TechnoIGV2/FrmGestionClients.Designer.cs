
namespace TechnoIGV2
{
    partial class FrmGestionClients
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpResidence = new System.Windows.Forms.GroupBox();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.txtNomLocalite = new System.Windows.Forms.TextBox();
            this.lblLocalite = new System.Windows.Forms.Label();
            this.txtNPA = new System.Windows.Forms.TextBox();
            this.lblNPA = new System.Windows.Forms.Label();
            this.txtNomRue = new System.Windows.Forms.TextBox();
            this.lblNomRue = new System.Windows.Forms.Label();
            this.txtNoRue = new System.Windows.Forms.TextBox();
            this.lblNoRue = new System.Windows.Forms.Label();
            this.grpPersonnelle = new System.Windows.Forms.GroupBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cboSexe = new System.Windows.Forms.ComboBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpResidence.SuspendLayout();
            this.grpPersonnelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(418, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(68, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Titre";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnValider.BackColor = System.Drawing.Color.Green;
            this.btnValider.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(536, 449);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(260, 36);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "&Valider client";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnnuler.BackColor = System.Drawing.Color.Maroon;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(109, 449);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(260, 36);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annu&ler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // grpResidence
            // 
            this.grpResidence.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpResidence.Controls.Add(this.txtPays);
            this.grpResidence.Controls.Add(this.lblPays);
            this.grpResidence.Controls.Add(this.txtNomLocalite);
            this.grpResidence.Controls.Add(this.lblLocalite);
            this.grpResidence.Controls.Add(this.txtNPA);
            this.grpResidence.Controls.Add(this.lblNPA);
            this.grpResidence.Controls.Add(this.txtNomRue);
            this.grpResidence.Controls.Add(this.lblNomRue);
            this.grpResidence.Controls.Add(this.txtNoRue);
            this.grpResidence.Controls.Add(this.lblNoRue);
            this.grpResidence.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResidence.Location = new System.Drawing.Point(98, 225);
            this.grpResidence.Name = "grpResidence";
            this.grpResidence.Size = new System.Drawing.Size(704, 180);
            this.grpResidence.TabIndex = 2;
            this.grpResidence.TabStop = false;
            this.grpResidence.Text = "In&formations de résidence";
            // 
            // txtPays
            // 
            this.txtPays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPays.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPays.Location = new System.Drawing.Point(575, 139);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(121, 26);
            this.txtPays.TabIndex = 9;
            // 
            // lblPays
            // 
            this.lblPays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPays.AutoSize = true;
            this.lblPays.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPays.Location = new System.Drawing.Point(573, 112);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(58, 24);
            this.lblPays.TabIndex = 8;
            this.lblPays.Text = "Pa&ys";
            this.lblPays.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNomLocalite
            // 
            this.txtNomLocalite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNomLocalite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomLocalite.Location = new System.Drawing.Point(12, 139);
            this.txtNomLocalite.Name = "txtNomLocalite";
            this.txtNomLocalite.Size = new System.Drawing.Size(121, 26);
            this.txtNomLocalite.TabIndex = 7;
            // 
            // lblLocalite
            // 
            this.lblLocalite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLocalite.AutoSize = true;
            this.lblLocalite.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalite.Location = new System.Drawing.Point(8, 112);
            this.lblLocalite.Name = "lblLocalite";
            this.lblLocalite.Size = new System.Drawing.Size(84, 24);
            this.lblLocalite.TabIndex = 6;
            this.lblLocalite.Text = "&Localite";
            this.lblLocalite.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNPA
            // 
            this.txtNPA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPA.Location = new System.Drawing.Point(577, 57);
            this.txtNPA.Name = "txtNPA";
            this.txtNPA.Size = new System.Drawing.Size(121, 26);
            this.txtNPA.TabIndex = 5;
            // 
            // lblNPA
            // 
            this.lblNPA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNPA.AutoSize = true;
            this.lblNPA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPA.Location = new System.Drawing.Point(571, 30);
            this.lblNPA.Name = "lblNPA";
            this.lblNPA.Size = new System.Drawing.Size(49, 24);
            this.lblNPA.TabIndex = 4;
            this.lblNPA.Text = "NP&A";
            this.lblNPA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNomRue
            // 
            this.txtNomRue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNomRue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomRue.Location = new System.Drawing.Point(265, 57);
            this.txtNomRue.Name = "txtNomRue";
            this.txtNomRue.Size = new System.Drawing.Size(174, 26);
            this.txtNomRue.TabIndex = 3;
            // 
            // lblNomRue
            // 
            this.lblNomRue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNomRue.AutoSize = true;
            this.lblNomRue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomRue.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNomRue.Location = new System.Drawing.Point(261, 30);
            this.lblNomRue.Name = "lblNomRue";
            this.lblNomRue.Size = new System.Drawing.Size(48, 24);
            this.lblNomRue.TabIndex = 2;
            this.lblNomRue.Text = "&Rue";
            this.lblNomRue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNoRue
            // 
            this.txtNoRue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNoRue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoRue.Location = new System.Drawing.Point(12, 57);
            this.txtNoRue.Name = "txtNoRue";
            this.txtNoRue.Size = new System.Drawing.Size(121, 26);
            this.txtNoRue.TabIndex = 1;
            // 
            // lblNoRue
            // 
            this.lblNoRue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNoRue.AutoSize = true;
            this.lblNoRue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRue.Location = new System.Drawing.Point(8, 30);
            this.lblNoRue.Name = "lblNoRue";
            this.lblNoRue.Size = new System.Drawing.Size(97, 24);
            this.lblNoRue.TabIndex = 0;
            this.lblNoRue.Text = "N° &de rue";
            this.lblNoRue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpPersonnelle
            // 
            this.grpPersonnelle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpPersonnelle.Controls.Add(this.lblGenre);
            this.grpPersonnelle.Controls.Add(this.cboSexe);
            this.grpPersonnelle.Controls.Add(this.txtPrenom);
            this.grpPersonnelle.Controls.Add(this.lblPrenom);
            this.grpPersonnelle.Controls.Add(this.txtNom);
            this.grpPersonnelle.Controls.Add(this.lblNom);
            this.grpPersonnelle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonnelle.Location = new System.Drawing.Point(98, 96);
            this.grpPersonnelle.Name = "grpPersonnelle";
            this.grpPersonnelle.Size = new System.Drawing.Size(704, 96);
            this.grpPersonnelle.TabIndex = 1;
            this.grpPersonnelle.TabStop = false;
            this.grpPersonnelle.Text = "&Informations personnelles";
            // 
            // lblGenre
            // 
            this.lblGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(573, 31);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(68, 24);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "&Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblGenre.Click += new System.EventHandler(this.lblSexe_Click);
            // 
            // cboSexe
            // 
            this.cboSexe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboSexe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexe.FormattingEnabled = true;
            this.cboSexe.Items.AddRange(new object[] {
            "Autre",
            "Femme",
            "Homme"});
            this.cboSexe.Location = new System.Drawing.Point(575, 58);
            this.cboSexe.Name = "cboSexe";
            this.cboSexe.Size = new System.Drawing.Size(121, 26);
            this.cboSexe.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPrenom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(11, 58);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(122, 26);
            this.txtPrenom.TabIndex = 1;
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(7, 31);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(82, 24);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "&Prenom";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(265, 58);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(174, 26);
            this.txtNom.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(261, 31);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(52, 24);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "&Nom";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmGestionClients
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(904, 501);
            this.Controls.Add(this.grpResidence);
            this.Controls.Add(this.grpPersonnelle);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 540);
            this.Name = "FrmGestionClients";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion client";
            this.Load += new System.EventHandler(this.FrmNewClient_Load);
            this.grpResidence.ResumeLayout(false);
            this.grpResidence.PerformLayout();
            this.grpPersonnelle.ResumeLayout(false);
            this.grpPersonnelle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox grpResidence;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.TextBox txtNomLocalite;
        private System.Windows.Forms.Label lblLocalite;
        private System.Windows.Forms.TextBox txtNPA;
        private System.Windows.Forms.Label lblNPA;
        private System.Windows.Forms.TextBox txtNomRue;
        private System.Windows.Forms.Label lblNomRue;
        private System.Windows.Forms.TextBox txtNoRue;
        private System.Windows.Forms.Label lblNoRue;
        private System.Windows.Forms.GroupBox grpPersonnelle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cboSexe;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
    }
}