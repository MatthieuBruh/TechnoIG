
namespace TechnoIGV2
{
    partial class FrmRecherche
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
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.pRODUITIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIXVENTEUNITAIREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_quantite_sel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_add_panier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vWRECHERCHEPRODUITSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TechnoIGV2.DataSet();
            this.lblTitre = new System.Windows.Forms.Label();
            this.grpFiltresPrix = new System.Windows.Forms.GroupBox();
            this.nudPrixMax = new System.Windows.Forms.NumericUpDown();
            this.nudPrixMin = new System.Windows.Forms.NumericUpDown();
            this.lblPrixMax = new System.Windows.Forms.Label();
            this.lblPrixMin = new System.Windows.Forms.Label();
            this.cboMarque = new System.Windows.Forms.ComboBox();
            this.vWMARQUESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.vWCATEGORIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.vW_RECHERCHE_PRODUITSTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_RECHERCHE_PRODUITSTableAdapter();
            this.vW_MARQUESTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_MARQUESTableAdapter();
            this.vW_CATEGORIETableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_CATEGORIETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRECHERCHEPRODUITSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.grpFiltresPrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMARQUESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCATEGORIEBindingSource)).BeginInit();
            this.grpFiltre.SuspendLayout();
            this.grpRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduits
            // 
            this.dgvProduits.AllowUserToAddRows = false;
            this.dgvProduits.AllowUserToDeleteRows = false;
            this.dgvProduits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduits.AutoGenerateColumns = false;
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODUITIDDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.mARQUEDataGridViewTextBoxColumn,
            this.cATEGORIEDataGridViewTextBoxColumn,
            this.pRIXVENTEUNITAIREDataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.pro_quantite_sel,
            this.pro_add_panier});
            this.dgvProduits.DataSource = this.vWRECHERCHEPRODUITSBindingSource;
            this.dgvProduits.Location = new System.Drawing.Point(22, 233);
            this.dgvProduits.Margin = new System.Windows.Forms.Padding(6);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.RowHeadersWidth = 72;
            this.dgvProduits.Size = new System.Drawing.Size(1668, 596);
            this.dgvProduits.TabIndex = 4;
            this.dgvProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduits_CellContentClick);
            // 
            // pRODUITIDDataGridViewTextBoxColumn
            // 
            this.pRODUITIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUITID";
            this.pRODUITIDDataGridViewTextBoxColumn.HeaderText = "ProduitId";
            this.pRODUITIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pRODUITIDDataGridViewTextBoxColumn.Name = "pRODUITIDDataGridViewTextBoxColumn";
            this.pRODUITIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUITIDDataGridViewTextBoxColumn.Visible = false;
            this.pRODUITIDDataGridViewTextBoxColumn.Width = 175;
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "Produit";
            this.nOMDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            this.nOMDataGridViewTextBoxColumn.ReadOnly = true;
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
            // pRIXVENTEUNITAIREDataGridViewTextBoxColumn
            // 
            this.pRIXVENTEUNITAIREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRIXVENTEUNITAIREDataGridViewTextBoxColumn.DataPropertyName = "PRIX_VENTE_UNITAIRE";
            this.pRIXVENTEUNITAIREDataGridViewTextBoxColumn.HeaderText = "Prix de vente";
            this.pRIXVENTEUNITAIREDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pRIXVENTEUNITAIREDataGridViewTextBoxColumn.Name = "pRIXVENTEUNITAIREDataGridViewTextBoxColumn";
            this.pRIXVENTEUNITAIREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTOCKDataGridViewTextBoxColumn
            // 
            this.sTOCKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTOCKDataGridViewTextBoxColumn.DataPropertyName = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "Stock restant";
            this.sTOCKDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.sTOCKDataGridViewTextBoxColumn.Name = "sTOCKDataGridViewTextBoxColumn";
            this.sTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pro_quantite_sel
            // 
            this.pro_quantite_sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pro_quantite_sel.HeaderText = "Qte sélectionnée";
            this.pro_quantite_sel.MinimumWidth = 9;
            this.pro_quantite_sel.Name = "pro_quantite_sel";
            // 
            // pro_add_panier
            // 
            this.pro_add_panier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pro_add_panier.HeaderText = "Ajouter panier";
            this.pro_add_panier.MinimumWidth = 9;
            this.pro_add_panier.Name = "pro_add_panier";
            // 
            // vWRECHERCHEPRODUITSBindingSource
            // 
            this.vWRECHERCHEPRODUITSBindingSource.DataMember = "VW_RECHERCHE_PRODUITS";
            this.vWRECHERCHEPRODUITSBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(590, 17);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(509, 55);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Recherche de produits";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // grpFiltresPrix
            // 
            this.grpFiltresPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltresPrix.Controls.Add(this.nudPrixMax);
            this.grpFiltresPrix.Controls.Add(this.nudPrixMin);
            this.grpFiltresPrix.Controls.Add(this.lblPrixMax);
            this.grpFiltresPrix.Controls.Add(this.lblPrixMin);
            this.grpFiltresPrix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltresPrix.Location = new System.Drawing.Point(1254, 81);
            this.grpFiltresPrix.Margin = new System.Windows.Forms.Padding(6);
            this.grpFiltresPrix.Name = "grpFiltresPrix";
            this.grpFiltresPrix.Padding = new System.Windows.Forms.Padding(6);
            this.grpFiltresPrix.Size = new System.Drawing.Size(436, 140);
            this.grpFiltresPrix.TabIndex = 3;
            this.grpFiltresPrix.TabStop = false;
            this.grpFiltresPrix.Text = "Filtres de pri&x";
            this.grpFiltresPrix.Enter += new System.EventHandler(this.grpFiltresPrix_Enter);
            // 
            // nudPrixMax
            // 
            this.nudPrixMax.Location = new System.Drawing.Point(224, 81);
            this.nudPrixMax.Margin = new System.Windows.Forms.Padding(6);
            this.nudPrixMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrixMax.Name = "nudPrixMax";
            this.nudPrixMax.Size = new System.Drawing.Size(189, 40);
            this.nudPrixMax.TabIndex = 3;
            this.nudPrixMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrixMax.ValueChanged += new System.EventHandler(this.filtreDePrix);
            // 
            // nudPrixMin
            // 
            this.nudPrixMin.Location = new System.Drawing.Point(26, 81);
            this.nudPrixMin.Margin = new System.Windows.Forms.Padding(6);
            this.nudPrixMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrixMin.Name = "nudPrixMin";
            this.nudPrixMin.Size = new System.Drawing.Size(182, 40);
            this.nudPrixMin.TabIndex = 1;
            this.nudPrixMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrixMin.ValueChanged += new System.EventHandler(this.filtreDePrix);
            // 
            // lblPrixMax
            // 
            this.lblPrixMax.AutoSize = true;
            this.lblPrixMax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixMax.Location = new System.Drawing.Point(220, 42);
            this.lblPrixMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrixMax.Name = "lblPrixMax";
            this.lblPrixMax.Size = new System.Drawing.Size(192, 32);
            this.lblPrixMax.TabIndex = 3;
            this.lblPrixMax.Text = "Prix maximum";
            // 
            // lblPrixMin
            // 
            this.lblPrixMin.AutoSize = true;
            this.lblPrixMin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixMin.Location = new System.Drawing.Point(22, 42);
            this.lblPrixMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrixMin.Name = "lblPrixMin";
            this.lblPrixMin.Size = new System.Drawing.Size(186, 32);
            this.lblPrixMin.TabIndex = 0;
            this.lblPrixMin.Text = "Prix minimum";
            // 
            // cboMarque
            // 
            this.cboMarque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboMarque.DataSource = this.vWMARQUESBindingSource;
            this.cboMarque.DisplayMember = "NOM";
            this.cboMarque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarque.FormattingEnabled = true;
            this.cboMarque.Location = new System.Drawing.Point(11, 79);
            this.cboMarque.Margin = new System.Windows.Forms.Padding(6);
            this.cboMarque.Name = "cboMarque";
            this.cboMarque.Size = new System.Drawing.Size(285, 40);
            this.cboMarque.TabIndex = 0;
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
            this.cboCategorie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCategorie.DataSource = this.vWCATEGORIEBindingSource;
            this.cboCategorie.DisplayMember = "NOM";
            this.cboCategorie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(334, 79);
            this.cboCategorie.Margin = new System.Windows.Forms.Padding(6);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(283, 40);
            this.cboCategorie.TabIndex = 2;
            this.cboCategorie.ValueMember = "NOM";
            this.cboCategorie.SelectedIndexChanged += new System.EventHandler(this.cboCategorie_SelectedIndexChanged);
            this.cboCategorie.TextChanged += new System.EventHandler(this.cboCategorie_SelectedIndexChanged);
            // 
            // vWCATEGORIEBindingSource
            // 
            this.vWCATEGORIEBindingSource.DataMember = "VW_CATEGORIE";
            this.vWCATEGORIEBindingSource.DataSource = this.dataSet;
            // 
            // grpFiltre
            // 
            this.grpFiltre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpFiltre.Controls.Add(this.cboCategorie);
            this.grpFiltre.Controls.Add(this.cboMarque);
            this.grpFiltre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltre.Location = new System.Drawing.Point(612, 81);
            this.grpFiltre.Margin = new System.Windows.Forms.Padding(6);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Padding = new System.Windows.Forms.Padding(6);
            this.grpFiltre.Size = new System.Drawing.Size(631, 140);
            this.grpFiltre.TabIndex = 2;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "&Filtres";
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.txtRecherche);
            this.grpRecherche.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecherche.Location = new System.Drawing.Point(22, 81);
            this.grpRecherche.Margin = new System.Windows.Forms.Padding(6);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Padding = new System.Windows.Forms.Padding(6);
            this.grpRecherche.Size = new System.Drawing.Size(579, 140);
            this.grpRecherche.TabIndex = 1;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "&Recherche";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(11, 78);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(554, 40);
            this.txtRecherche.TabIndex = 0;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // vW_RECHERCHE_PRODUITSTableAdapter
            // 
            this.vW_RECHERCHE_PRODUITSTableAdapter.ClearBeforeFill = true;
            // 
            // vW_MARQUESTableAdapter
            // 
            this.vW_MARQUESTableAdapter.ClearBeforeFill = true;
            // 
            // vW_CATEGORIETableAdapter
            // 
            this.vW_CATEGORIETableAdapter.ClearBeforeFill = true;
            // 
            // FrmRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1712, 851);
            this.Controls.Add(this.grpRecherche);
            this.Controls.Add(this.grpFiltre);
            this.Controls.Add(this.grpFiltresPrix);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.dgvProduits);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1722, 361);
            this.Name = "FrmRecherche";
            this.ShowIcon = false;
            this.Text = "Recherhe de produits";
            this.Activated += new System.EventHandler(this.onFormClick);
            this.Load += new System.EventHandler(this.FrmRecherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRECHERCHEPRODUITSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.grpFiltresPrix.ResumeLayout(false);
            this.grpFiltresPrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrixMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMARQUESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCATEGORIEBindingSource)).EndInit();
            this.grpFiltre.ResumeLayout(false);
            this.grpRecherche.ResumeLayout(false);
            this.grpRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox grpFiltresPrix;
        private System.Windows.Forms.Label lblPrixMin;
        private System.Windows.Forms.Label lblPrixMax;
        private System.Windows.Forms.NumericUpDown nudPrixMax;
        private System.Windows.Forms.NumericUpDown nudPrixMin;
        private System.Windows.Forms.ComboBox cboMarque;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.GroupBox grpFiltre;
        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource vWRECHERCHEPRODUITSBindingSource;
        private DataSetTableAdapters.VW_RECHERCHE_PRODUITSTableAdapter vW_RECHERCHE_PRODUITSTableAdapter;
        private System.Windows.Forms.BindingSource vWMARQUESBindingSource;
        private DataSetTableAdapters.VW_MARQUESTableAdapter vW_MARQUESTableAdapter;
        private System.Windows.Forms.BindingSource vWCATEGORIEBindingSource;
        private DataSetTableAdapters.VW_CATEGORIETableAdapter vW_CATEGORIETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUITIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIXVENTEUNITAIREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_quantite_sel;
        private System.Windows.Forms.DataGridViewButtonColumn pro_add_panier;
    }
}