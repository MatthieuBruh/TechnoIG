
namespace TechnoIGV2
{
    partial class FrmProduitLimites
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
            this.dgvCommandes = new System.Windows.Forms.DataGridView();
            this.fOURNISSEURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUITIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIXACHATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEUILSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKRESTANTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOTPARCOMMANDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vWPRODUITSLIMITESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TechnoIGV2.DataSet();
            this.btnCommander = new System.Windows.Forms.Button();
            this.cboFournisseur = new System.Windows.Forms.ComboBox();
            this.vWFOURNISSEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboMarque = new System.Windows.Forms.ComboBox();
            this.vWMARQUESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.tECCATEGORIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpFiltres = new System.Windows.Forms.GroupBox();
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.vW_PRODUITS_LIMITESTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_PRODUITS_LIMITESTableAdapter();
            this.vW_FOURNISSEURTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_FOURNISSEURTableAdapter();
            this.vW_MARQUESTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_MARQUESTableAdapter();
            this.tEC_CATEGORIETableAdapter = new TechnoIGV2.DataSetTableAdapters.TEC_CATEGORIETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPRODUITSLIMITESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWFOURNISSEURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMARQUESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tECCATEGORIEBindingSource)).BeginInit();
            this.grpFiltres.SuspendLayout();
            this.grpRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(556, 17);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(601, 55);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Produits en quantité limitée";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // dgvCommandes
            // 
            this.dgvCommandes.AllowUserToAddRows = false;
            this.dgvCommandes.AllowUserToDeleteRows = false;
            this.dgvCommandes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCommandes.AutoGenerateColumns = false;
            this.dgvCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOURNISSEURDataGridViewTextBoxColumn,
            this.pRODUITIDDataGridViewTextBoxColumn,
            this.pRODUITDataGridViewTextBoxColumn,
            this.mARQUEDataGridViewTextBoxColumn,
            this.cATEGORIEDataGridViewTextBoxColumn,
            this.pRIXACHATDataGridViewTextBoxColumn,
            this.sEUILSTOCKDataGridViewTextBoxColumn,
            this.sTOCKRESTANTDataGridViewTextBoxColumn,
            this.lOTPARCOMMANDEDataGridViewTextBoxColumn,
            this.pro_selection});
            this.dgvCommandes.DataSource = this.vWPRODUITSLIMITESBindingSource;
            this.dgvCommandes.Location = new System.Drawing.Point(22, 207);
            this.dgvCommandes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvCommandes.Name = "dgvCommandes";
            this.dgvCommandes.RowHeadersWidth = 72;
            this.dgvCommandes.Size = new System.Drawing.Size(1668, 554);
            this.dgvCommandes.TabIndex = 3;
            this.dgvCommandes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommandes_CellContentClick);
            // 
            // fOURNISSEURDataGridViewTextBoxColumn
            // 
            this.fOURNISSEURDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fOURNISSEURDataGridViewTextBoxColumn.DataPropertyName = "FOURNISSEUR";
            this.fOURNISSEURDataGridViewTextBoxColumn.HeaderText = "Fournisseur";
            this.fOURNISSEURDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.fOURNISSEURDataGridViewTextBoxColumn.Name = "fOURNISSEURDataGridViewTextBoxColumn";
            this.fOURNISSEURDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUITIDDataGridViewTextBoxColumn
            // 
            this.pRODUITIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRODUITIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUITID";
            this.pRODUITIDDataGridViewTextBoxColumn.HeaderText = "ProduitId";
            this.pRODUITIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pRODUITIDDataGridViewTextBoxColumn.Name = "pRODUITIDDataGridViewTextBoxColumn";
            this.pRODUITIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUITIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRODUITDataGridViewTextBoxColumn
            // 
            this.pRODUITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRODUITDataGridViewTextBoxColumn.DataPropertyName = "PRODUIT";
            this.pRODUITDataGridViewTextBoxColumn.HeaderText = "Produit";
            this.pRODUITDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pRODUITDataGridViewTextBoxColumn.Name = "pRODUITDataGridViewTextBoxColumn";
            this.pRODUITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mARQUEDataGridViewTextBoxColumn
            // 
            this.mARQUEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mARQUEDataGridViewTextBoxColumn.DataPropertyName = "MARQUE";
            this.mARQUEDataGridViewTextBoxColumn.HeaderText = "Marque";
            this.mARQUEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.mARQUEDataGridViewTextBoxColumn.Name = "mARQUEDataGridViewTextBoxColumn";
            this.mARQUEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEGORIEDataGridViewTextBoxColumn
            // 
            this.cATEGORIEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cATEGORIEDataGridViewTextBoxColumn.DataPropertyName = "CATEGORIE";
            this.cATEGORIEDataGridViewTextBoxColumn.HeaderText = "Catégorie";
            this.cATEGORIEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.cATEGORIEDataGridViewTextBoxColumn.Name = "cATEGORIEDataGridViewTextBoxColumn";
            this.cATEGORIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRIXACHATDataGridViewTextBoxColumn
            // 
            this.pRIXACHATDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRIXACHATDataGridViewTextBoxColumn.DataPropertyName = "PRIXACHAT";
            this.pRIXACHATDataGridViewTextBoxColumn.HeaderText = "Prix d\'achat";
            this.pRIXACHATDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pRIXACHATDataGridViewTextBoxColumn.Name = "pRIXACHATDataGridViewTextBoxColumn";
            this.pRIXACHATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEUILSTOCKDataGridViewTextBoxColumn
            // 
            this.sEUILSTOCKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sEUILSTOCKDataGridViewTextBoxColumn.DataPropertyName = "SEUILSTOCK";
            this.sEUILSTOCKDataGridViewTextBoxColumn.HeaderText = "Seuil du stock";
            this.sEUILSTOCKDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.sEUILSTOCKDataGridViewTextBoxColumn.Name = "sEUILSTOCKDataGridViewTextBoxColumn";
            this.sEUILSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTOCKRESTANTDataGridViewTextBoxColumn
            // 
            this.sTOCKRESTANTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTOCKRESTANTDataGridViewTextBoxColumn.DataPropertyName = "STOCKRESTANT";
            this.sTOCKRESTANTDataGridViewTextBoxColumn.HeaderText = "Stock restant";
            this.sTOCKRESTANTDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.sTOCKRESTANTDataGridViewTextBoxColumn.Name = "sTOCKRESTANTDataGridViewTextBoxColumn";
            this.sTOCKRESTANTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOTPARCOMMANDEDataGridViewTextBoxColumn
            // 
            this.lOTPARCOMMANDEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lOTPARCOMMANDEDataGridViewTextBoxColumn.DataPropertyName = "LOTPARCOMMANDE";
            this.lOTPARCOMMANDEDataGridViewTextBoxColumn.HeaderText = "Qte par lot";
            this.lOTPARCOMMANDEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.lOTPARCOMMANDEDataGridViewTextBoxColumn.Name = "lOTPARCOMMANDEDataGridViewTextBoxColumn";
            this.lOTPARCOMMANDEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pro_selection
            // 
            this.pro_selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pro_selection.HeaderText = "Commander";
            this.pro_selection.MinimumWidth = 9;
            this.pro_selection.Name = "pro_selection";
            this.pro_selection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pro_selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // vWPRODUITSLIMITESBindingSource
            // 
            this.vWPRODUITSLIMITESBindingSource.DataMember = "VW_PRODUITS_LIMITES";
            this.vWPRODUITSLIMITESBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCommander
            // 
            this.btnCommander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommander.BackColor = System.Drawing.Color.Green;
            this.btnCommander.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommander.ForeColor = System.Drawing.Color.White;
            this.btnCommander.Location = new System.Drawing.Point(1377, 772);
            this.btnCommander.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(314, 57);
            this.btnCommander.TabIndex = 5;
            this.btnCommander.Text = "&Commander";
            this.btnCommander.UseVisualStyleBackColor = false;
            this.btnCommander.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboFournisseur
            // 
            this.cboFournisseur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboFournisseur.DataSource = this.vWFOURNISSEURBindingSource;
            this.cboFournisseur.DisplayMember = "NOM";
            this.cboFournisseur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFournisseur.FormattingEnabled = true;
            this.cboFournisseur.Location = new System.Drawing.Point(50, 42);
            this.cboFournisseur.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboFournisseur.Name = "cboFournisseur";
            this.cboFournisseur.Size = new System.Drawing.Size(250, 40);
            this.cboFournisseur.TabIndex = 0;
            this.cboFournisseur.ValueMember = "NOM";
            this.cboFournisseur.SelectedIndexChanged += new System.EventHandler(this.cboFournisseur_SelectedIndexChanged);
            this.cboFournisseur.TextChanged += new System.EventHandler(this.cboFournisseur_SelectedIndexChanged);
            // 
            // vWFOURNISSEURBindingSource
            // 
            this.vWFOURNISSEURBindingSource.DataMember = "VW_FOURNISSEUR";
            this.vWFOURNISSEURBindingSource.DataSource = this.dataSet;
            // 
            // cboMarque
            // 
            this.cboMarque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboMarque.DataSource = this.vWMARQUESBindingSource;
            this.cboMarque.DisplayMember = "NOM";
            this.cboMarque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarque.FormattingEnabled = true;
            this.cboMarque.Location = new System.Drawing.Point(376, 42);
            this.cboMarque.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboMarque.Name = "cboMarque";
            this.cboMarque.Size = new System.Drawing.Size(250, 40);
            this.cboMarque.TabIndex = 1;
            this.cboMarque.ValueMember = "NOM";
            this.cboMarque.SelectedIndexChanged += new System.EventHandler(this.cboMarque_SelectedIndexChanged);
            this.cboMarque.TextChanged += new System.EventHandler(this.cboMarque_SelectedIndexChanged);
            // 
            // vWMARQUESBindingSource
            // 
            this.vWMARQUESBindingSource.DataMember = "VW_MARQUES";
            this.vWMARQUESBindingSource.DataSource = this.dataSet;
            // 
            // cboCategorie
            // 
            this.cboCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategorie.DataSource = this.tECCATEGORIEBindingSource;
            this.cboCategorie.DisplayMember = "CAT_NOM";
            this.cboCategorie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(702, 42);
            this.cboCategorie.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(250, 40);
            this.cboCategorie.TabIndex = 2;
            this.cboCategorie.ValueMember = "CAT_NOM";
            this.cboCategorie.SelectedIndexChanged += new System.EventHandler(this.cboCategorie_SelectedIndexChanged);
            this.cboCategorie.TextChanged += new System.EventHandler(this.cboCategorie_SelectedIndexChanged);
            // 
            // tECCATEGORIEBindingSource
            // 
            this.tECCATEGORIEBindingSource.DataMember = "TEC_CATEGORIE";
            this.tECCATEGORIEBindingSource.DataSource = this.dataSet;
            // 
            // grpFiltres
            // 
            this.grpFiltres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltres.Controls.Add(this.cboMarque);
            this.grpFiltres.Controls.Add(this.cboCategorie);
            this.grpFiltres.Controls.Add(this.cboFournisseur);
            this.grpFiltres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltres.Location = new System.Drawing.Point(684, 81);
            this.grpFiltres.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpFiltres.Size = new System.Drawing.Size(1007, 118);
            this.grpFiltres.TabIndex = 2;
            this.grpFiltres.TabStop = false;
            this.grpFiltres.Text = "&Filtrer";
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.txtRecherche);
            this.grpRecherche.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecherche.Location = new System.Drawing.Point(22, 81);
            this.grpRecherche.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpRecherche.Size = new System.Drawing.Size(651, 118);
            this.grpRecherche.TabIndex = 1;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "&Recherche";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(11, 42);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(626, 40);
            this.txtRecherche.TabIndex = 0;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // vW_PRODUITS_LIMITESTableAdapter
            // 
            this.vW_PRODUITS_LIMITESTableAdapter.ClearBeforeFill = true;
            // 
            // vW_FOURNISSEURTableAdapter
            // 
            this.vW_FOURNISSEURTableAdapter.ClearBeforeFill = true;
            // 
            // vW_MARQUESTableAdapter
            // 
            this.vW_MARQUESTableAdapter.ClearBeforeFill = true;
            // 
            // tEC_CATEGORIETableAdapter
            // 
            this.tEC_CATEGORIETableAdapter.ClearBeforeFill = true;
            // 
            // FrmProduitLimites
            // 
            this.AcceptButton = this.btnCommander;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1712, 851);
            this.Controls.Add(this.grpRecherche);
            this.Controls.Add(this.grpFiltres);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.dgvCommandes);
            this.Controls.Add(this.lblTitre);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1722, 500);
            this.Name = "FrmProduitLimites";
            this.ShowIcon = false;
            this.Text = "Produits limités";
            this.Activated += new System.EventHandler(this.onFormClick);
            this.Load += new System.EventHandler(this.FrmCommandesFourni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPRODUITSLIMITESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWFOURNISSEURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMARQUESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tECCATEGORIEBindingSource)).EndInit();
            this.grpFiltres.ResumeLayout(false);
            this.grpRecherche.ResumeLayout(false);
            this.grpRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgvCommandes;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.ComboBox cboFournisseur;
        private System.Windows.Forms.ComboBox cboMarque;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.GroupBox grpFiltres;
        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource vWPRODUITSLIMITESBindingSource;
        private DataSetTableAdapters.VW_PRODUITS_LIMITESTableAdapter vW_PRODUITS_LIMITESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fOURNISSEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUITIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIXACHATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEUILSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKRESTANTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOTPARCOMMANDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pro_selection;
        private System.Windows.Forms.BindingSource vWFOURNISSEURBindingSource;
        private DataSetTableAdapters.VW_FOURNISSEURTableAdapter vW_FOURNISSEURTableAdapter;
        private System.Windows.Forms.BindingSource vWMARQUESBindingSource;
        private DataSetTableAdapters.VW_MARQUESTableAdapter vW_MARQUESTableAdapter;
        private System.Windows.Forms.BindingSource tECCATEGORIEBindingSource;
        private DataSetTableAdapters.TEC_CATEGORIETableAdapter tEC_CATEGORIETableAdapter;
    }
}