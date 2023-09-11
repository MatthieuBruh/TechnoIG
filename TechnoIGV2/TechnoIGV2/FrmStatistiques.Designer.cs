
namespace TechnoIGV2
{
    partial class FrmStatistiques
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.lblTitreStat = new System.Windows.Forms.Label();
            this.chrStatFournisseur = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtNomEntite = new System.Windows.Forms.TextBox();
            this.chrtStatEmp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vWSTATISTIQUESFOURNISSEURSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TechnoIGV2.DataSet();
            this.vWSTATISTIQUESEMPLOYESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_STATISTIQUES_EMPLOYESTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_STATISTIQUES_EMPLOYESTableAdapter();
            this.vW_STATISTIQUES_FOURNISSEURSTableAdapter = new TechnoIGV2.DataSetTableAdapters.VW_STATISTIQUES_FOURNISSEURSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chrStatFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtStatEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSTATISTIQUESFOURNISSEURSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSTATISTIQUESEMPLOYESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitreStat
            // 
            this.lblTitreStat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitreStat.AutoSize = true;
            this.lblTitreStat.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreStat.Location = new System.Drawing.Point(390, 9);
            this.lblTitreStat.Name = "lblTitreStat";
            this.lblTitreStat.Size = new System.Drawing.Size(157, 32);
            this.lblTitreStat.TabIndex = 0;
            this.lblTitreStat.Text = "Statistiques";
            // 
            // chrStatFournisseur
            // 
            this.chrStatFournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrStatFournisseur.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrStatFournisseur.Legends.Add(legend1);
            this.chrStatFournisseur.Location = new System.Drawing.Point(165, 142);
            this.chrStatFournisseur.Name = "chrStatFournisseur";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Commandes";
            this.chrStatFournisseur.Series.Add(series1);
            this.chrStatFournisseur.Size = new System.Drawing.Size(606, 407);
            this.chrStatFournisseur.TabIndex = 2;
            this.chrStatFournisseur.Text = "Statistiques";
            // 
            // txtNomEntite
            // 
            this.txtNomEntite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomEntite.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomEntite.Location = new System.Drawing.Point(243, 73);
            this.txtNomEntite.Name = "txtNomEntite";
            this.txtNomEntite.ReadOnly = true;
            this.txtNomEntite.Size = new System.Drawing.Size(451, 35);
            this.txtNomEntite.TabIndex = 1;
            this.txtNomEntite.Text = "Nom";
            this.txtNomEntite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chrtStatEmp
            // 
            this.chrtStatEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chrtStatEmp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtStatEmp.Legends.Add(legend2);
            this.chrtStatEmp.Location = new System.Drawing.Point(12, 142);
            this.chrtStatEmp.Name = "chrtStatEmp";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Ventes";
            series2.Points.Add(dataPoint1);
            this.chrtStatEmp.Series.Add(series2);
            this.chrtStatEmp.Size = new System.Drawing.Size(912, 407);
            this.chrtStatEmp.TabIndex = 2;
            this.chrtStatEmp.Text = "Statistiques";
            this.chrtStatEmp.Click += new System.EventHandler(this.chrtStatEmp_Click);
            // 
            // vWSTATISTIQUESFOURNISSEURSBindingSource
            // 
            this.vWSTATISTIQUESFOURNISSEURSBindingSource.DataMember = "VW_STATISTIQUES_FOURNISSEURS";
            this.vWSTATISTIQUESFOURNISSEURSBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWSTATISTIQUESEMPLOYESBindingSource
            // 
            this.vWSTATISTIQUESEMPLOYESBindingSource.DataMember = "VW_STATISTIQUES_EMPLOYES";
            this.vWSTATISTIQUESEMPLOYESBindingSource.DataSource = this.dataSet;
            // 
            // vW_STATISTIQUES_EMPLOYESTableAdapter
            // 
            this.vW_STATISTIQUES_EMPLOYESTableAdapter.ClearBeforeFill = true;
            // 
            // vW_STATISTIQUES_FOURNISSEURSTableAdapter
            // 
            this.vW_STATISTIQUES_FOURNISSEURSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 600);
            this.Controls.Add(this.chrtStatEmp);
            this.Controls.Add(this.txtNomEntite);
            this.Controls.Add(this.chrStatFournisseur);
            this.Controls.Add(this.lblTitreStat);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FrmStatistiques";
            this.ShowIcon = false;
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.FrmStatistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrStatFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtStatEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSTATISTIQUESFOURNISSEURSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSTATISTIQUESEMPLOYESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreStat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrStatFournisseur;
        private System.Windows.Forms.TextBox txtNomEntite;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtStatEmp;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource vWSTATISTIQUESEMPLOYESBindingSource;
        private DataSetTableAdapters.VW_STATISTIQUES_EMPLOYESTableAdapter vW_STATISTIQUES_EMPLOYESTableAdapter;
        private System.Windows.Forms.BindingSource vWSTATISTIQUESFOURNISSEURSBindingSource;
        private DataSetTableAdapters.VW_STATISTIQUES_FOURNISSEURSTableAdapter vW_STATISTIQUES_FOURNISSEURSTableAdapter;
    }
}