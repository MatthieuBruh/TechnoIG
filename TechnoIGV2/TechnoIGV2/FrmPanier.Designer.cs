
namespace TechnoIGV2
{
    partial class FrmPanier
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
            this.components = new System.ComponentModel.Container();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnRenitialisation = new System.Windows.Forms.Button();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.ProduitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mar_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_pri_unitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_qte_selection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnValidation = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpMontant = new System.Windows.Forms.GroupBox();
            this.chkActiveReduc = new System.Windows.Forms.CheckBox();
            this.txtTotalPanier = new System.Windows.Forms.TextBox();
            this.cboReductions = new System.Windows.Forms.ComboBox();
            this.vW_RECHERCHE_BONS_CLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TechnoIGV2.DataSet();
            this.lblRemise = new System.Windows.Forms.Label();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.txtPrenomValue = new System.Windows.Forms.TextBox();
            this.txtNomValue = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.vW_RECHERCHE_BONS_CLIENTSTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_RECHERCHE_BONS_CLIENTSTableAdapter();
            this.tableAdapterManager = new TechnoIGV2.DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.grpMontant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vW_RECHERCHE_BONS_CLIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.grpClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(365, 12);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(164, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Panier client";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // btnRenitialisation
            // 
            this.btnRenitialisation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenitialisation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenitialisation.Location = new System.Drawing.Point(707, 15);
            this.btnRenitialisation.Name = "btnRenitialisation";
            this.btnRenitialisation.Size = new System.Drawing.Size(175, 35);
            this.btnRenitialisation.TabIndex = 1;
            this.btnRenitialisation.Text = "Rénitialiser &le panier";
            this.btnRenitialisation.UseVisualStyleBackColor = true;
            this.btnRenitialisation.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProduits
            // 
            this.dgvProduits.AllowUserToAddRows = false;
            this.dgvProduits.AllowUserToDeleteRows = false;
            this.dgvProduits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProduitID,
            this.pro_nom,
            this.mar_nom,
            this.cat_nom,
            this.pro_pri_unitaire,
            this.pro_qte_selection,
            this.pro_total,
            this.pro_delete});
            this.dgvProduits.Location = new System.Drawing.Point(12, 56);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.ReadOnly = true;
            this.dgvProduits.Size = new System.Drawing.Size(870, 299);
            this.dgvProduits.TabIndex = 2;
            this.dgvProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduits_CellContentClick);
            // 
            // ProduitID
            // 
            this.ProduitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProduitID.HeaderText = "Numéro de produit";
            this.ProduitID.Name = "ProduitID";
            this.ProduitID.ReadOnly = true;
            // 
            // pro_nom
            // 
            this.pro_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pro_nom.HeaderText = "Produit";
            this.pro_nom.Name = "pro_nom";
            this.pro_nom.ReadOnly = true;
            // 
            // mar_nom
            // 
            this.mar_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mar_nom.HeaderText = "Marque";
            this.mar_nom.Name = "mar_nom";
            this.mar_nom.ReadOnly = true;
            // 
            // cat_nom
            // 
            this.cat_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cat_nom.HeaderText = "Catégorie";
            this.cat_nom.Name = "cat_nom";
            this.cat_nom.ReadOnly = true;
            // 
            // pro_pri_unitaire
            // 
            this.pro_pri_unitaire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pro_pri_unitaire.HeaderText = "Prix unitaire";
            this.pro_pri_unitaire.Name = "pro_pri_unitaire";
            this.pro_pri_unitaire.ReadOnly = true;
            // 
            // pro_qte_selection
            // 
            this.pro_qte_selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pro_qte_selection.HeaderText = "Quantité sélectionné";
            this.pro_qte_selection.Name = "pro_qte_selection";
            this.pro_qte_selection.ReadOnly = true;
            // 
            // pro_total
            // 
            this.pro_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pro_total.HeaderText = "Total";
            this.pro_total.Name = "pro_total";
            this.pro_total.ReadOnly = true;
            // 
            // pro_delete
            // 
            this.pro_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pro_delete.HeaderText = "Supprimer";
            this.pro_delete.Name = "pro_delete";
            this.pro_delete.ReadOnly = true;
            this.pro_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pro_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnValidation
            // 
            this.btnValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidation.BackColor = System.Drawing.Color.Green;
            this.btnValidation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidation.ForeColor = System.Drawing.Color.White;
            this.btnValidation.Location = new System.Drawing.Point(748, 361);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(134, 88);
            this.btnValidation.TabIndex = 5;
            this.btnValidation.Text = "&Valider panier";
            this.btnValidation.UseVisualStyleBackColor = false;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 60);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 18);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "&Total du panier :";
            // 
            // grpMontant
            // 
            this.grpMontant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMontant.Controls.Add(this.chkActiveReduc);
            this.grpMontant.Controls.Add(this.txtTotalPanier);
            this.grpMontant.Controls.Add(this.cboReductions);
            this.grpMontant.Controls.Add(this.lblRemise);
            this.grpMontant.Controls.Add(this.lblTotal);
            this.grpMontant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMontant.Location = new System.Drawing.Point(12, 361);
            this.grpMontant.Name = "grpMontant";
            this.grpMontant.Size = new System.Drawing.Size(375, 88);
            this.grpMontant.TabIndex = 3;
            this.grpMontant.TabStop = false;
            this.grpMontant.Text = "Montants";
            // 
            // chkActiveReduc
            // 
            this.chkActiveReduc.AutoSize = true;
            this.chkActiveReduc.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActiveReduc.Location = new System.Drawing.Point(350, 26);
            this.chkActiveReduc.Name = "chkActiveReduc";
            this.chkActiveReduc.Size = new System.Drawing.Size(15, 14);
            this.chkActiveReduc.TabIndex = 7;
            this.chkActiveReduc.UseVisualStyleBackColor = true;
            this.chkActiveReduc.CheckedChanged += new System.EventHandler(this.chkActiveReduc_CheckedChanged);
            // 
            // txtTotalPanier
            // 
            this.txtTotalPanier.Location = new System.Drawing.Point(144, 57);
            this.txtTotalPanier.Name = "txtTotalPanier";
            this.txtTotalPanier.ReadOnly = true;
            this.txtTotalPanier.Size = new System.Drawing.Size(200, 26);
            this.txtTotalPanier.TabIndex = 3;
            // 
            // cboReductions
            // 
            this.cboReductions.DataSource = this.vW_RECHERCHE_BONS_CLIENTSBindingSource;
            this.cboReductions.DisplayMember = "TAUX";
            this.cboReductions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReductions.FormattingEnabled = true;
            this.cboReductions.Location = new System.Drawing.Point(144, 20);
            this.cboReductions.Name = "cboReductions";
            this.cboReductions.Size = new System.Drawing.Size(200, 26);
            this.cboReductions.TabIndex = 6;
            this.cboReductions.ValueMember = "BONID";
            // 
            // vW_RECHERCHE_BONS_CLIENTSBindingSource
            // 
            this.vW_RECHERCHE_BONS_CLIENTSBindingSource.DataMember = "VW_RECHERCHE_BONS_CLIENTS";
            this.vW_RECHERCHE_BONS_CLIENTSBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRemise
            // 
            this.lblRemise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemise.AutoSize = true;
            this.lblRemise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemise.Location = new System.Drawing.Point(6, 28);
            this.lblRemise.Name = "lblRemise";
            this.lblRemise.Size = new System.Drawing.Size(94, 18);
            this.lblRemise.TabIndex = 0;
            this.lblRemise.Text = "&Réductions :";
            this.lblRemise.Click += new System.EventHandler(this.lblRemise_Click);
            // 
            // grpClient
            // 
            this.grpClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpClient.Controls.Add(this.btnAjouterClient);
            this.grpClient.Controls.Add(this.txtPrenomValue);
            this.grpClient.Controls.Add(this.txtNomValue);
            this.grpClient.Controls.Add(this.lblPrenom);
            this.grpClient.Controls.Add(this.lblNom);
            this.grpClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClient.Location = new System.Drawing.Point(393, 361);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(350, 88);
            this.grpClient.TabIndex = 4;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client";
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAjouterClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterClient.ForeColor = System.Drawing.Color.White;
            this.btnAjouterClient.Location = new System.Drawing.Point(88, 25);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(175, 50);
            this.btnAjouterClient.TabIndex = 1;
            this.btnAjouterClient.Text = "&Ajouter Client";
            this.btnAjouterClient.UseVisualStyleBackColor = false;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // txtPrenomValue
            // 
            this.txtPrenomValue.Location = new System.Drawing.Point(79, 57);
            this.txtPrenomValue.Name = "txtPrenomValue";
            this.txtPrenomValue.ReadOnly = true;
            this.txtPrenomValue.Size = new System.Drawing.Size(265, 26);
            this.txtPrenomValue.TabIndex = 3;
            // 
            // txtNomValue
            // 
            this.txtNomValue.Location = new System.Drawing.Point(79, 25);
            this.txtNomValue.Name = "txtNomValue";
            this.txtNomValue.ReadOnly = true;
            this.txtNomValue.Size = new System.Drawing.Size(265, 26);
            this.txtNomValue.TabIndex = 2;
            this.txtNomValue.TextChanged += new System.EventHandler(this.txtNomValue_TextChanged);
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(6, 60);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(71, 18);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "&Prenom :";
            // 
            // lblNom
            // 
            this.lblNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(6, 28);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(49, 18);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "&Nom :";
            // 
            // vW_RECHERCHE_BONS_CLIENTSTableAdapter
            // 
            this.vW_RECHERCHE_BONS_CLIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TEC_BONTableAdapter = null;
            this.tableAdapterManager.TEC_CATEGORIETableAdapter = null;
            this.tableAdapterManager.TEC_CLIENTTableAdapter = null;
            this.tableAdapterManager.TEC_COMMANDE_CLITableAdapter = null;
            this.tableAdapterManager.TEC_COMMANDE_FOUTableAdapter = null;
            this.tableAdapterManager.TEC_FOURNISSEURTableAdapter = null;
            this.tableAdapterManager.TEC_LIGNE_COM_CLITableAdapter = null;
            this.tableAdapterManager.TEC_LIGNE_COM_FOUTableAdapter = null;
            this.tableAdapterManager.TEC_MARQUETableAdapter = null;
            this.tableAdapterManager.TEC_NIVEAU_HIERARCHIQUETableAdapter = null;
            this.tableAdapterManager.TEC_PERSONNELTableAdapter = null;
            this.tableAdapterManager.TEC_PRODUITTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TechnoIGV2.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmPanier
            // 
            this.AcceptButton = this.btnValidation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(894, 461);
            this.Controls.Add(this.btnValidation);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.btnRenitialisation);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.grpMontant);
            this.MinimumSize = new System.Drawing.Size(910, 275);
            this.Name = "FrmPanier";
            this.ShowIcon = false;
            this.Text = "Panier";
            this.Load += new System.EventHandler(this.FrmPanier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.grpMontant.ResumeLayout(false);
            this.grpMontant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vW_RECHERCHE_BONS_CLIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnRenitialisation;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.Button btnValidation;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpMontant;
        private System.Windows.Forms.Label lblRemise;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtPrenomValue;
        private System.Windows.Forms.TextBox txtNomValue;
        private System.Windows.Forms.TextBox txtTotalPanier;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn mar_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_pri_unitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_qte_selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_total;
        private System.Windows.Forms.DataGridViewButtonColumn pro_delete;
        private System.Windows.Forms.ComboBox cboReductions;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource vW_RECHERCHE_BONS_CLIENTSBindingSource;
        private DataSetTableAdapters.VW_RECHERCHE_BONS_CLIENTSTableAdapter vW_RECHERCHE_BONS_CLIENTSTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox chkActiveReduc;
    }
}