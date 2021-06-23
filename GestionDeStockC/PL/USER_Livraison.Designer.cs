
namespace GestionDeStockC.PL
{
    partial class USER_Livraison
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.details_CommandeTableAdapter = new GestionDeStockC.GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter();
            this.gESTION_DE_STOCKDataSet = new GestionDeStockC.GESTION_DE_STOCKDataSet();
            this.detailsCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsCommandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // details_CommandeTableAdapter
            // 
            this.details_CommandeTableAdapter.ClearBeforeFill = true;
            // 
            // gESTION_DE_STOCKDataSet
            // 
            this.gESTION_DE_STOCKDataSet.DataSetName = "GESTION_DE_STOCKDataSet";
            this.gESTION_DE_STOCKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailsCommandeBindingSource
            // 
            this.detailsCommandeBindingSource.DataMember = "Details_Commande";
            this.detailsCommandeBindingSource.DataSource = this.gESTION_DE_STOCKDataSet;
            // 
            // USER_Livraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "USER_Livraison";
            this.Size = new System.Drawing.Size(1274, 636);
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsCommandeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter details_CommandeTableAdapter;
        private GESTION_DE_STOCKDataSet gESTION_DE_STOCKDataSet;
        private System.Windows.Forms.BindingSource detailsCommandeBindingSource;
    }
}
