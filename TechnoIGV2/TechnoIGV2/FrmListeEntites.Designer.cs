
namespace TechnoIGV2
{
    partial class FrmListeEntites
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
            this.dgvFournisseurs = new System.Windows.Forms.DataGridView();
            this.nOMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFERANTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDEPRODUITSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWLISTEFOURNISSEURSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TechnoIGV2.DataSet();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.dgvEmployes = new System.Windows.Forms.DataGridView();
            this.nUMERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fONCTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cli_supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vWLISTEPERSONNELSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_LISTE_PERSONNELSTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_LISTE_PERSONNELSTableAdapter();
            this.vW_LISTE_FOURNISSEURSTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_LISTE_FOURNISSEURSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWLISTEFOURNISSEURSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWLISTEPERSONNELSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFournisseurs
            // 
            this.dgvFournisseurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFournisseurs.AutoGenerateColumns = false;
            this.dgvFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFournisseurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMDataGridViewTextBoxColumn1,
            this.eMAILDataGridViewTextBoxColumn,
            this.rEFERANTDataGridViewTextBoxColumn,
            this.aDDRESSEDataGridViewTextBoxColumn,
            this.nPADataGridViewTextBoxColumn,
            this.pAYSDataGridViewTextBoxColumn,
            this.nOMBREDEPRODUITSDataGridViewTextBoxColumn});
            this.dgvFournisseurs.DataSource = this.vWLISTEFOURNISSEURSBindingSource;
            this.dgvFournisseurs.Location = new System.Drawing.Point(20, 166);
            this.dgvFournisseurs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvFournisseurs.Name = "dgvFournisseurs";
            this.dgvFournisseurs.RowHeadersWidth = 72;
            this.dgvFournisseurs.Size = new System.Drawing.Size(1577, 665);
            this.dgvFournisseurs.TabIndex = 4;
            this.dgvFournisseurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFourni_CellContentClick);
            this.dgvFournisseurs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFourni_CellContentDoubleClick);
            // 
            // nOMDataGridViewTextBoxColumn1
            // 
            this.nOMDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMDataGridViewTextBoxColumn1.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nOMDataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.nOMDataGridViewTextBoxColumn1.Name = "nOMDataGridViewTextBoxColumn1";
            this.nOMDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEFERANTDataGridViewTextBoxColumn
            // 
            this.rEFERANTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rEFERANTDataGridViewTextBoxColumn.DataPropertyName = "REFERANT";
            this.rEFERANTDataGridViewTextBoxColumn.HeaderText = "Personne référante";
            this.rEFERANTDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.rEFERANTDataGridViewTextBoxColumn.Name = "rEFERANTDataGridViewTextBoxColumn";
            this.rEFERANTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDRESSEDataGridViewTextBoxColumn
            // 
            this.aDDRESSEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aDDRESSEDataGridViewTextBoxColumn.DataPropertyName = "ADDRESSE";
            this.aDDRESSEDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.aDDRESSEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.aDDRESSEDataGridViewTextBoxColumn.Name = "aDDRESSEDataGridViewTextBoxColumn";
            this.aDDRESSEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nPADataGridViewTextBoxColumn
            // 
            this.nPADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nPADataGridViewTextBoxColumn.DataPropertyName = "NPA";
            this.nPADataGridViewTextBoxColumn.HeaderText = "NPA";
            this.nPADataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nPADataGridViewTextBoxColumn.Name = "nPADataGridViewTextBoxColumn";
            this.nPADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAYSDataGridViewTextBoxColumn
            // 
            this.pAYSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pAYSDataGridViewTextBoxColumn.DataPropertyName = "PAYS";
            this.pAYSDataGridViewTextBoxColumn.HeaderText = "Pays";
            this.pAYSDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pAYSDataGridViewTextBoxColumn.Name = "pAYSDataGridViewTextBoxColumn";
            this.pAYSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDEPRODUITSDataGridViewTextBoxColumn
            // 
            this.nOMBREDEPRODUITSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBREDEPRODUITSDataGridViewTextBoxColumn.DataPropertyName = "NOMBREDEPRODUITS";
            this.nOMBREDEPRODUITSDataGridViewTextBoxColumn.HeaderText = "Total de commandes";
            this.nOMBREDEPRODUITSDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nOMBREDEPRODUITSDataGridViewTextBoxColumn.Name = "nOMBREDEPRODUITSDataGridViewTextBoxColumn";
            this.nOMBREDEPRODUITSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWLISTEFOURNISSEURSBindingSource
            // 
            this.vWLISTEFOURNISSEURSBindingSource.DataMember = "VW_LISTE_FOURNISSEURS";
            this.vWLISTEFOURNISSEURSBindingSource.DataSource = this.dataSet;
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
            this.lblTitre.Location = new System.Drawing.Point(744, 18);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(125, 55);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Liste";
            // 
            // lblRechercher
            // 
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercher.Location = new System.Drawing.Point(22, 68);
            this.lblRechercher.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(158, 32);
            this.lblRechercher.TabIndex = 1;
            this.lblRechercher.Text = "&Rechercher";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(28, 107);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(561, 40);
            this.txtRecherche.TabIndex = 2;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // dgvEmployes
            // 
            this.dgvEmployes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployes.AutoGenerateColumns = false;
            this.dgvEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMERODataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pRENOMDataGridViewTextBoxColumn,
            this.fONCTIONDataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn,
            this.Modifier,
            this.cli_supprimer});
            this.dgvEmployes.DataSource = this.vWLISTEPERSONNELSBindingSource;
            this.dgvEmployes.Location = new System.Drawing.Point(20, 166);
            this.dgvEmployes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvEmployes.Name = "dgvEmployes";
            this.dgvEmployes.RowHeadersWidth = 72;
            this.dgvEmployes.Size = new System.Drawing.Size(1577, 665);
            this.dgvEmployes.TabIndex = 3;
            this.dgvEmployes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployes_CellContentClick);
            this.dgvEmployes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployes_CellContentDoubleClick);
            // 
            // nUMERODataGridViewTextBoxColumn
            // 
            this.nUMERODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nUMERODataGridViewTextBoxColumn.DataPropertyName = "NUMERO";
            this.nUMERODataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.nUMERODataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nUMERODataGridViewTextBoxColumn.Name = "nUMERODataGridViewTextBoxColumn";
            this.nUMERODataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMERODataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nOMDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            this.nOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRENOMDataGridViewTextBoxColumn
            // 
            this.pRENOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRENOMDataGridViewTextBoxColumn.DataPropertyName = "PRENOM";
            this.pRENOMDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.pRENOMDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pRENOMDataGridViewTextBoxColumn.Name = "pRENOMDataGridViewTextBoxColumn";
            this.pRENOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fONCTIONDataGridViewTextBoxColumn
            // 
            this.fONCTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fONCTIONDataGridViewTextBoxColumn.DataPropertyName = "FONCTION";
            this.fONCTIONDataGridViewTextBoxColumn.HeaderText = "Fonction";
            this.fONCTIONDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.fONCTIONDataGridViewTextBoxColumn.Name = "fONCTIONDataGridViewTextBoxColumn";
            this.fONCTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "Total de commandes";
            this.tOTALDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Modifier
            // 
            this.Modifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.MinimumWidth = 9;
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            // 
            // cli_supprimer
            // 
            this.cli_supprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_supprimer.HeaderText = "Supprimer";
            this.cli_supprimer.MinimumWidth = 9;
            this.cli_supprimer.Name = "cli_supprimer";
            this.cli_supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cli_supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // vWLISTEPERSONNELSBindingSource
            // 
            this.vWLISTEPERSONNELSBindingSource.DataMember = "VW_LISTE_PERSONNELS";
            this.vWLISTEPERSONNELSBindingSource.DataSource = this.dataSet;
            // 
            // vW_LISTE_PERSONNELSTableAdapter
            // 
            this.vW_LISTE_PERSONNELSTableAdapter.ClearBeforeFill = true;
            // 
            // vW_LISTE_FOURNISSEURSTableAdapter
            // 
            this.vW_LISTE_FOURNISSEURSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListeEntites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1621, 851);
            this.Controls.Add(this.dgvEmployes);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblRechercher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.dgvFournisseurs);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1080, 352);
            this.Name = "FrmListeEntites";
            this.ShowIcon = false;
            this.Text = "Liste";
            this.Activated += new System.EventHandler(this.onFormClick);
            this.Load += new System.EventHandler(this.FrmListeEntites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWLISTEFOURNISSEURSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWLISTEPERSONNELSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFournisseurs;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.DataGridView dgvEmployes;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource vWLISTEPERSONNELSBindingSource;
        private DataSetTableAdapters.VW_LISTE_PERSONNELSTableAdapter vW_LISTE_PERSONNELSTableAdapter;
        private System.Windows.Forms.BindingSource vWLISTEFOURNISSEURSBindingSource;
        private DataSetTableAdapters.VW_LISTE_FOURNISSEURSTableAdapter vW_LISTE_FOURNISSEURSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFERANTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDEPRODUITSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fONCTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn cli_supprimer;
    }
}