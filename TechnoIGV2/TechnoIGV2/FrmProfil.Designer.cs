
namespace TechnoIGV2
{
    partial class FrmProfil
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
            this.vENDEURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATECOMMANDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bONCOMMANDEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vWPERSONNELCOMMANDESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TechnoIGV2.DataSet();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblFonction = new System.Windows.Forms.Label();
            this.gpbInformationPerso = new System.Windows.Forms.GroupBox();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.vW_PERSONNEL_DETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrenomValue = new System.Windows.Forms.TextBox();
            this.txtNomValue = new System.Windows.Forms.TextBox();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.vW_PERSONNEL_DETAILSTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_PERSONNEL_DETAILSTableAdapter();
            this.tableAdapterManager = new TechnoIGV2.DataSetTableAdapters.TableAdapterManager();
            this.vW_PERSONNEL_COMMANDESTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_PERSONNEL_COMMANDESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPERSONNELCOMMANDESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.gpbInformationPerso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vW_PERSONNEL_DETAILSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(429, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(144, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Votre profil";
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
            this.vENDEURDataGridViewTextBoxColumn,
            this.dATECOMMANDEDataGridViewTextBoxColumn,
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn,
            this.nOMCLIENTDataGridViewTextBoxColumn,
            this.pRENOMCLIENTDataGridViewTextBoxColumn,
            this.bONCOMMANDEDataGridViewTextBoxColumn,
            this.tOALDataGridViewTextBoxColumn,
            this.com_supprimer});
            this.dgvCommandes.DataSource = this.vWPERSONNELCOMMANDESBindingSource;
            this.dgvCommandes.Location = new System.Drawing.Point(16, 178);
            this.dgvCommandes.Name = "dgvCommandes";
            this.dgvCommandes.RowHeadersWidth = 72;
            this.dgvCommandes.Size = new System.Drawing.Size(946, 281);
            this.dgvCommandes.TabIndex = 4;
            this.dgvCommandes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommandes_CellContentClick);
            // 
            // vENDEURDataGridViewTextBoxColumn
            // 
            this.vENDEURDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vENDEURDataGridViewTextBoxColumn.DataPropertyName = "VENDEUR";
            this.vENDEURDataGridViewTextBoxColumn.HeaderText = "Vendeur";
            this.vENDEURDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.vENDEURDataGridViewTextBoxColumn.Name = "vENDEURDataGridViewTextBoxColumn";
            this.vENDEURDataGridViewTextBoxColumn.ReadOnly = true;
            this.vENDEURDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATECOMMANDEDataGridViewTextBoxColumn
            // 
            this.dATECOMMANDEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATECOMMANDEDataGridViewTextBoxColumn.DataPropertyName = "DATECOMMANDE";
            this.dATECOMMANDEDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dATECOMMANDEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.dATECOMMANDEDataGridViewTextBoxColumn.Name = "dATECOMMANDEDataGridViewTextBoxColumn";
            this.dATECOMMANDEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMEROCOMMANDEDataGridViewTextBoxColumn
            // 
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn.DataPropertyName = "NUMEROCOMMANDE";
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn.HeaderText = "Numéro de commande";
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn.Name = "nUMEROCOMMANDEDataGridViewTextBoxColumn";
            this.nUMEROCOMMANDEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMCLIENTDataGridViewTextBoxColumn
            // 
            this.nOMCLIENTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMCLIENTDataGridViewTextBoxColumn.DataPropertyName = "NOMCLIENT";
            this.nOMCLIENTDataGridViewTextBoxColumn.HeaderText = "Nom client";
            this.nOMCLIENTDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nOMCLIENTDataGridViewTextBoxColumn.Name = "nOMCLIENTDataGridViewTextBoxColumn";
            this.nOMCLIENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRENOMCLIENTDataGridViewTextBoxColumn
            // 
            this.pRENOMCLIENTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRENOMCLIENTDataGridViewTextBoxColumn.DataPropertyName = "PRENOMCLIENT";
            this.pRENOMCLIENTDataGridViewTextBoxColumn.HeaderText = "Prénom client";
            this.pRENOMCLIENTDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pRENOMCLIENTDataGridViewTextBoxColumn.Name = "pRENOMCLIENTDataGridViewTextBoxColumn";
            this.pRENOMCLIENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bONCOMMANDEDataGridViewTextBoxColumn
            // 
            this.bONCOMMANDEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bONCOMMANDEDataGridViewTextBoxColumn.DataPropertyName = "BONCOMMANDE";
            this.bONCOMMANDEDataGridViewTextBoxColumn.HeaderText = "Bon";
            this.bONCOMMANDEDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.bONCOMMANDEDataGridViewTextBoxColumn.Name = "bONCOMMANDEDataGridViewTextBoxColumn";
            this.bONCOMMANDEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOALDataGridViewTextBoxColumn
            // 
            this.tOALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tOALDataGridViewTextBoxColumn.DataPropertyName = "TOAL";
            this.tOALDataGridViewTextBoxColumn.HeaderText = "Total";
            this.tOALDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.tOALDataGridViewTextBoxColumn.Name = "tOALDataGridViewTextBoxColumn";
            this.tOALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // com_supprimer
            // 
            this.com_supprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.com_supprimer.HeaderText = "Supprimer";
            this.com_supprimer.MinimumWidth = 9;
            this.com_supprimer.Name = "com_supprimer";
            // 
            // vWPERSONNELCOMMANDESBindingSource
            // 
            this.vWPERSONNELCOMMANDESBindingSource.DataMember = "VW_PERSONNEL_COMMANDES";
            this.vWPERSONNELCOMMANDESBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(6, 32);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(64, 24);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "&Nom :";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(325, 32);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(94, 24);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "&Prénom :";
            // 
            // lblFonction
            // 
            this.lblFonction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFonction.AutoSize = true;
            this.lblFonction.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFonction.Location = new System.Drawing.Point(657, 32);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(103, 24);
            this.lblFonction.TabIndex = 4;
            this.lblFonction.Text = "&Fonction :";
            this.lblFonction.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpbInformationPerso
            // 
            this.gpbInformationPerso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbInformationPerso.Controls.Add(this.txtFonction);
            this.gpbInformationPerso.Controls.Add(this.txtPrenomValue);
            this.gpbInformationPerso.Controls.Add(this.txtNomValue);
            this.gpbInformationPerso.Controls.Add(this.lblFonction);
            this.gpbInformationPerso.Controls.Add(this.lblPrenom);
            this.gpbInformationPerso.Controls.Add(this.lblNom);
            this.gpbInformationPerso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformationPerso.Location = new System.Drawing.Point(16, 44);
            this.gpbInformationPerso.Name = "gpbInformationPerso";
            this.gpbInformationPerso.Size = new System.Drawing.Size(946, 79);
            this.gpbInformationPerso.TabIndex = 1;
            this.gpbInformationPerso.TabStop = false;
            this.gpbInformationPerso.Text = "Informations personnelles";
            // 
            // txtFonction
            // 
            this.txtFonction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFonction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vW_PERSONNEL_DETAILSBindingSource, "NIVEAUHIERARCHIQUE", true));
            this.txtFonction.Location = new System.Drawing.Point(766, 33);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.ReadOnly = true;
            this.txtFonction.Size = new System.Drawing.Size(174, 26);
            this.txtFonction.TabIndex = 5;
            // 
            // vW_PERSONNEL_DETAILSBindingSource
            // 
            this.vW_PERSONNEL_DETAILSBindingSource.DataMember = "VW_PERSONNEL_DETAILS";
            this.vW_PERSONNEL_DETAILSBindingSource.DataSource = this.dataSet;
            // 
            // txtPrenomValue
            // 
            this.txtPrenomValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrenomValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vW_PERSONNEL_DETAILSBindingSource, "PRENOM", true));
            this.txtPrenomValue.Location = new System.Drawing.Point(425, 33);
            this.txtPrenomValue.Name = "txtPrenomValue";
            this.txtPrenomValue.ReadOnly = true;
            this.txtPrenomValue.Size = new System.Drawing.Size(174, 26);
            this.txtPrenomValue.TabIndex = 3;
            // 
            // txtNomValue
            // 
            this.txtNomValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vW_PERSONNEL_DETAILSBindingSource, "NOM", true));
            this.txtNomValue.Location = new System.Drawing.Point(76, 33);
            this.txtNomValue.Name = "txtNomValue";
            this.txtNomValue.ReadOnly = true;
            this.txtNomValue.Size = new System.Drawing.Size(174, 26);
            this.txtNomValue.TabIndex = 1;
            this.txtNomValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtRechercher
            // 
            this.txtRechercher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.Location = new System.Drawing.Point(107, 146);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(250, 26);
            this.txtRechercher.TabIndex = 3;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            // 
            // lblRechercher
            // 
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercher.Location = new System.Drawing.Point(13, 149);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(88, 18);
            this.lblRechercher.TabIndex = 2;
            this.lblRechercher.Text = "&Rechercher";
            // 
            // vW_PERSONNEL_DETAILSTableAdapter
            // 
            this.vW_PERSONNEL_DETAILSTableAdapter.ClearBeforeFill = true;
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
            // vW_PERSONNEL_COMMANDESTableAdapter
            // 
            this.vW_PERSONNEL_COMMANDESTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 471);
            this.Controls.Add(this.lblRechercher);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.gpbInformationPerso);
            this.Controls.Add(this.dgvCommandes);
            this.Controls.Add(this.lblTitre);
            this.MinimumSize = new System.Drawing.Size(904, 319);
            this.Name = "FrmProfil";
            this.ShowIcon = false;
            this.Text = "Profil";
            this.Activated += new System.EventHandler(this.onFormClick);
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPERSONNELCOMMANDESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.gpbInformationPerso.ResumeLayout(false);
            this.gpbInformationPerso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vW_PERSONNEL_DETAILSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgvCommandes;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.GroupBox gpbInformationPerso;
        private System.Windows.Forms.TextBox txtNomValue;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.TextBox txtPrenomValue;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource vW_PERSONNEL_DETAILSBindingSource;
        private DataSetTableAdapters.VW_PERSONNEL_DETAILSTableAdapter vW_PERSONNEL_DETAILSTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vWPERSONNELCOMMANDESBindingSource;
        private DataSetTableAdapters.VW_PERSONNEL_COMMANDESTableAdapter vW_PERSONNEL_COMMANDESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATECOMMANDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROCOMMANDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bONCOMMANDEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn com_supprimer;
    }
}