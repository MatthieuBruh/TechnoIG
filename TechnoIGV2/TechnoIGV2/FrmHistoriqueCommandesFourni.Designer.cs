
namespace TechnoIGV2
{
    partial class FrmHistoriqueCommandesFourni
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
            this.dgvCommandes = new System.Windows.Forms.DataGridView();
            this.nUMERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fOURNISSEURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIXACHATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWHISTORIQUECOMMANDESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TechnoIGV2.DataSet();
            this.lblTitre = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.cboFournisseur = new System.Windows.Forms.ComboBox();
            this.vWFOURNISSEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboMarque = new System.Windows.Forms.ComboBox();
            this.vWMARQUESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.vWCATEGORIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.vW_HISTORIQUE_COMMANDESTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_HISTORIQUE_COMMANDESTableAdapter();
            this.vW_FOURNISSEURTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_FOURNISSEURTableAdapter();
            this.vW_MARQUESTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_MARQUESTableAdapter();
            this.vW_CATEGORIETableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_CATEGORIETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWHISTORIQUECOMMANDESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWFOURNISSEURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMARQUESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCATEGORIEBindingSource)).BeginInit();
            this.grpFiltre.SuspendLayout();
            this.grpRecherche.SuspendLayout();
            this.SuspendLayout();
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
            this.nUMERODataGridViewTextBoxColumn,
            this.fOURNISSEURDataGridViewTextBoxColumn,
            this.pRODUITDataGridViewTextBoxColumn,
            this.mARQUEDataGridViewTextBoxColumn,
            this.cATEGORIEDataGridViewTextBoxColumn,
            this.pRIXACHATDataGridViewTextBoxColumn,
            this.qUANTITEDataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn});
            this.dgvCommandes.DataSource = this.vWHISTORIQUECOMMANDESBindingSource;
            this.dgvCommandes.Location = new System.Drawing.Point(22, 207);
            this.dgvCommandes.Margin = new System.Windows.Forms.Padding(6);
            this.dgvCommandes.Name = "dgvCommandes";
            this.dgvCommandes.ReadOnly = true;
            this.dgvCommandes.RowHeadersWidth = 72;
            this.dgvCommandes.Size = new System.Drawing.Size(1668, 622);
            this.dgvCommandes.TabIndex = 3;
            // 
            // nUMERODataGridViewTextBoxColumn
            // 
            this.nUMERODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nUMERODataGridViewTextBoxColumn.DataPropertyName = "NUMERO";
            this.nUMERODataGridViewTextBoxColumn.HeaderText = "Numéro";
            this.nUMERODataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nUMERODataGridViewTextBoxColumn.Name = "nUMERODataGridViewTextBoxColumn";
            this.nUMERODataGridViewTextBoxColumn.ReadOnly = true;
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
            // qUANTITEDataGridViewTextBoxColumn
            // 
            this.qUANTITEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qUANTITEDataGridViewTextBoxColumn.DataPropertyName = "QUANTITE";
            this.qUANTITEDataGridViewTextBoxColumn.HeaderText = "Quantité achetée";
            this.qUANTITEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.qUANTITEDataGridViewTextBoxColumn.Name = "qUANTITEDataGridViewTextBoxColumn";
            this.qUANTITEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "Total de la ligne";
            this.tOTALDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWHISTORIQUECOMMANDESBindingSource
            // 
            this.vWHISTORIQUECOMMANDESBindingSource.DataMember = "VW_HISTORIQUE_COMMANDES";
            this.vWHISTORIQUECOMMANDESBindingSource.DataSource = this.dataSet;
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
            this.lblTitre.Location = new System.Drawing.Point(541, 20);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(607, 55);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Historique des commandes";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(11, 57);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(626, 40);
            this.txtRecherche.TabIndex = 0;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // cboFournisseur
            // 
            this.cboFournisseur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboFournisseur.DataSource = this.vWFOURNISSEURBindingSource;
            this.cboFournisseur.DisplayMember = "NOM";
            this.cboFournisseur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFournisseur.FormattingEnabled = true;
            this.cboFournisseur.Location = new System.Drawing.Point(75, 59);
            this.cboFournisseur.Margin = new System.Windows.Forms.Padding(6);
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
            this.cboMarque.Location = new System.Drawing.Point(376, 59);
            this.cboMarque.Margin = new System.Windows.Forms.Padding(6);
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
            this.cboCategorie.DataSource = this.vWCATEGORIEBindingSource;
            this.cboCategorie.DisplayMember = "NOM";
            this.cboCategorie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(677, 59);
            this.cboCategorie.Margin = new System.Windows.Forms.Padding(6);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(250, 40);
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
            this.grpFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltre.Controls.Add(this.cboMarque);
            this.grpFiltre.Controls.Add(this.cboCategorie);
            this.grpFiltre.Controls.Add(this.cboFournisseur);
            this.grpFiltre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltre.Location = new System.Drawing.Point(684, 85);
            this.grpFiltre.Margin = new System.Windows.Forms.Padding(6);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Padding = new System.Windows.Forms.Padding(6);
            this.grpFiltre.Size = new System.Drawing.Size(1007, 118);
            this.grpFiltre.TabIndex = 2;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "&Filtres";
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.txtRecherche);
            this.grpRecherche.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecherche.Location = new System.Drawing.Point(22, 85);
            this.grpRecherche.Margin = new System.Windows.Forms.Padding(6);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Padding = new System.Windows.Forms.Padding(6);
            this.grpRecherche.Size = new System.Drawing.Size(651, 118);
            this.grpRecherche.TabIndex = 1;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "&Recherche";
            // 
            // vW_HISTORIQUE_COMMANDESTableAdapter
            // 
            this.vW_HISTORIQUE_COMMANDESTableAdapter.ClearBeforeFill = true;
            // 
            // vW_FOURNISSEURTableAdapter
            // 
            this.vW_FOURNISSEURTableAdapter.ClearBeforeFill = true;
            // 
            // vW_MARQUESTableAdapter
            // 
            this.vW_MARQUESTableAdapter.ClearBeforeFill = true;
            // 
            // vW_CATEGORIETableAdapter
            // 
            this.vW_CATEGORIETableAdapter.ClearBeforeFill = true;
            // 
            // FrmHistoriqueCommandesFourni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1712, 851);
            this.Controls.Add(this.grpRecherche);
            this.Controls.Add(this.grpFiltre);
            this.Controls.Add(this.dgvCommandes);
            this.Controls.Add(this.lblTitre);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1722, 361);
            this.Name = "FrmHistoriqueCommandesFourni";
            this.ShowIcon = false;
            this.Text = "FrmHistoriqueCommandesFourni";
            this.Activated += new System.EventHandler(this.onFormClick);
            this.Load += new System.EventHandler(this.FrmHistoriqueCommandesFourni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWHISTORIQUECOMMANDESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWFOURNISSEURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMARQUESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCATEGORIEBindingSource)).EndInit();
            this.grpFiltre.ResumeLayout(false);
            this.grpRecherche.ResumeLayout(false);
            this.grpRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCommandes;
        private System.Windows.Forms.Label lblTitre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.ComboBox cboFournisseur;
        private System.Windows.Forms.ComboBox cboMarque;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.GroupBox grpFiltre;
        private System.Windows.Forms.GroupBox grpRecherche;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource vWHISTORIQUECOMMANDESBindingSource;
        private DataSetTableAdapters.VW_HISTORIQUE_COMMANDESTableAdapter vW_HISTORIQUE_COMMANDESTableAdapter;
        private System.Windows.Forms.BindingSource vWFOURNISSEURBindingSource;
        private DataSetTableAdapters.VW_FOURNISSEURTableAdapter vW_FOURNISSEURTableAdapter;
        private System.Windows.Forms.BindingSource vWMARQUESBindingSource;
        private DataSetTableAdapters.VW_MARQUESTableAdapter vW_MARQUESTableAdapter;
        private System.Windows.Forms.BindingSource vWCATEGORIEBindingSource;
        private DataSetTableAdapters.VW_CATEGORIETableAdapter vW_CATEGORIETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fOURNISSEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIXACHATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
    }
}