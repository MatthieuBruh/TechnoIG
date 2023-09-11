
namespace TechnoIGV2
{
    partial class FrmRechercherClient
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
            this.btnNewClient = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nORUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMRUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCALITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_lier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vWRECHERCHECLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TechnoIGV2.DataSet();
            this.cboNPA = new System.Windows.Forms.ComboBox();
            this.vWNPACLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.grpEnregisterClients = new System.Windows.Forms.GroupBox();
            this.vW_RECHERCHE_CLIENTSTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_RECHERCHE_CLIENTSTableAdapter();
            this.vW_NPA_CLIENTSTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_NPA_CLIENTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRECHERCHECLIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWNPACLIENTSBindingSource)).BeginInit();
            this.grpFiltre.SuspendLayout();
            this.grpRecherche.SuspendLayout();
            this.grpEnregisterClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(493, 17);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(473, 55);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Recherche de clients";
            // 
            // btnNewClient
            // 
            this.btnNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClient.Location = new System.Drawing.Point(73, 59);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(321, 55);
            this.btnNewClient.TabIndex = 0;
            this.btnNewClient.Text = "&Nouveau client";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pRENOMDataGridViewTextBoxColumn,
            this.sEXEDataGridViewTextBoxColumn,
            this.nORUEDataGridViewTextBoxColumn,
            this.nOMRUEDataGridViewTextBoxColumn,
            this.nPADataGridViewTextBoxColumn,
            this.lOCALITEDataGridViewTextBoxColumn,
            this.pAYSDataGridViewTextBoxColumn,
            this.cli_lier});
            this.dgvClients.DataSource = this.vWRECHERCHECLIENTSBindingSource;
            this.dgvClients.Location = new System.Drawing.Point(22, 234);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 72;
            this.dgvClients.Size = new System.Drawing.Size(1439, 594);
            this.dgvClients.TabIndex = 4;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            this.dgvClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentDoubleClick);
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENTID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.cLIENTIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            this.cLIENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTIDDataGridViewTextBoxColumn.Visible = false;
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
            // sEXEDataGridViewTextBoxColumn
            // 
            this.sEXEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sEXEDataGridViewTextBoxColumn.DataPropertyName = "SEXE";
            this.sEXEDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.sEXEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.sEXEDataGridViewTextBoxColumn.Name = "sEXEDataGridViewTextBoxColumn";
            this.sEXEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nORUEDataGridViewTextBoxColumn
            // 
            this.nORUEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nORUEDataGridViewTextBoxColumn.DataPropertyName = "NORUE";
            this.nORUEDataGridViewTextBoxColumn.HeaderText = "N° rue";
            this.nORUEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nORUEDataGridViewTextBoxColumn.Name = "nORUEDataGridViewTextBoxColumn";
            this.nORUEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMRUEDataGridViewTextBoxColumn
            // 
            this.nOMRUEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMRUEDataGridViewTextBoxColumn.DataPropertyName = "NOMRUE";
            this.nOMRUEDataGridViewTextBoxColumn.HeaderText = "Nom rue";
            this.nOMRUEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nOMRUEDataGridViewTextBoxColumn.Name = "nOMRUEDataGridViewTextBoxColumn";
            this.nOMRUEDataGridViewTextBoxColumn.ReadOnly = true;
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
            // lOCALITEDataGridViewTextBoxColumn
            // 
            this.lOCALITEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lOCALITEDataGridViewTextBoxColumn.DataPropertyName = "LOCALITE";
            this.lOCALITEDataGridViewTextBoxColumn.HeaderText = "LOCALITE";
            this.lOCALITEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.lOCALITEDataGridViewTextBoxColumn.Name = "lOCALITEDataGridViewTextBoxColumn";
            this.lOCALITEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOCALITEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pAYSDataGridViewTextBoxColumn
            // 
            this.pAYSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pAYSDataGridViewTextBoxColumn.DataPropertyName = "PAYS";
            this.pAYSDataGridViewTextBoxColumn.HeaderText = "Pays";
            this.pAYSDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pAYSDataGridViewTextBoxColumn.Name = "pAYSDataGridViewTextBoxColumn";
            this.pAYSDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAYSDataGridViewTextBoxColumn.Visible = false;
            // 
            // cli_lier
            // 
            this.cli_lier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_lier.HeaderText = "Lier au panier";
            this.cli_lier.MinimumWidth = 9;
            this.cli_lier.Name = "cli_lier";
            this.cli_lier.ReadOnly = true;
            this.cli_lier.Text = "Lier";
            this.cli_lier.ToolTipText = "Lier";
            this.cli_lier.UseColumnTextForButtonValue = true;
            // 
            // vWRECHERCHECLIENTSBindingSource
            // 
            this.vWRECHERCHECLIENTSBindingSource.DataMember = "VW_RECHERCHE_CLIENTS";
            this.vWRECHERCHECLIENTSBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboNPA
            // 
            this.cboNPA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNPA.DataSource = this.vWNPACLIENTSBindingSource;
            this.cboNPA.DisplayMember = "NPA";
            this.cboNPA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNPA.FormattingEnabled = true;
            this.cboNPA.Location = new System.Drawing.Point(108, 63);
            this.cboNPA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboNPA.Name = "cboNPA";
            this.cboNPA.Size = new System.Drawing.Size(246, 41);
            this.cboNPA.TabIndex = 0;
            this.cboNPA.ValueMember = "NPA";
            this.cboNPA.SelectedIndexChanged += new System.EventHandler(this.cboNPA_SelectedIndexChanged);
            this.cboNPA.TextChanged += new System.EventHandler(this.cboNPA_SelectedIndexChanged);
            // 
            // vWNPACLIENTSBindingSource
            // 
            this.vWNPACLIENTSBindingSource.DataMember = "VW_NPA_CLIENTS";
            this.vWNPACLIENTSBindingSource.DataSource = this.dataSet;
            // 
            // grpFiltre
            // 
            this.grpFiltre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpFiltre.Controls.Add(this.cboNPA);
            this.grpFiltre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltre.Location = new System.Drawing.Point(508, 94);
            this.grpFiltre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpFiltre.Size = new System.Drawing.Size(466, 129);
            this.grpFiltre.TabIndex = 2;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "&Filtre";
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.txtRecherche);
            this.grpRecherche.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecherche.Location = new System.Drawing.Point(24, 94);
            this.grpRecherche.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpRecherche.Size = new System.Drawing.Size(466, 129);
            this.grpRecherche.TabIndex = 1;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "&Recherche";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(11, 63);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(440, 40);
            this.txtRecherche.TabIndex = 0;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // grpEnregisterClients
            // 
            this.grpEnregisterClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEnregisterClients.Controls.Add(this.btnNewClient);
            this.grpEnregisterClients.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEnregisterClients.Location = new System.Drawing.Point(994, 94);
            this.grpEnregisterClients.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpEnregisterClients.Name = "grpEnregisterClients";
            this.grpEnregisterClients.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpEnregisterClients.Size = new System.Drawing.Size(466, 129);
            this.grpEnregisterClients.TabIndex = 3;
            this.grpEnregisterClients.TabStop = false;
            this.grpEnregisterClients.Text = "&Enregistrer";
            // 
            // vW_RECHERCHE_CLIENTSTableAdapter
            // 
            this.vW_RECHERCHE_CLIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // vW_NPA_CLIENTSTableAdapter
            // 
            this.vW_NPA_CLIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRechercherClient
            // 
            this.AcceptButton = this.btnNewClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1483, 851);
            this.Controls.Add(this.grpEnregisterClients);
            this.Controls.Add(this.grpRecherche);
            this.Controls.Add(this.grpFiltre);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.lblTitre);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1493, 407);
            this.Name = "FrmRechercherClient";
            this.ShowIcon = false;
            this.Text = "Rechercher un client";
            this.Activated += new System.EventHandler(this.onFormClick);
            this.Load += new System.EventHandler(this.FrmRechercherClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRECHERCHECLIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWNPACLIENTSBindingSource)).EndInit();
            this.grpFiltre.ResumeLayout(false);
            this.grpRecherche.ResumeLayout(false);
            this.grpRecherche.PerformLayout();
            this.grpEnregisterClients.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.ComboBox cboNPA;
        private System.Windows.Forms.GroupBox grpFiltre;
        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.GroupBox grpEnregisterClients;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource vWRECHERCHECLIENTSBindingSource;
        private DataSetTableAdapters.VW_RECHERCHE_CLIENTSTableAdapter vW_RECHERCHE_CLIENTSTableAdapter;
        private System.Windows.Forms.BindingSource vWNPACLIENTSBindingSource;
        private DataSetTableAdapters.VW_NPA_CLIENTSTableAdapter vW_NPA_CLIENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nORUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMRUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCALITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn cli_lier;
    }
}