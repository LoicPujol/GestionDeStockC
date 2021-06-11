
namespace GestionDeStockC.PL
{
    partial class USER_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_Dashboard));
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvStatClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDateLAerte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeure
            // 
            this.lblHeure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHeure.Location = new System.Drawing.Point(313, 0);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(256, 91);
            this.lblHeure.TabIndex = 0;
            this.lblHeure.Text = "Heure";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDate.Location = new System.Drawing.Point(388, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(104, 46);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvStatClient
            // 
            this.dgvStatClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvStatClient.Location = new System.Drawing.Point(607, 247);
            this.dgvStatClient.Name = "dgvStatClient";
            this.dgvStatClient.Size = new System.Drawing.Size(378, 310);
            this.dgvStatClient.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Designation";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nbre produit";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valeur vente";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 90.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(3, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 136);
            this.label1.TabIndex = 3;
            this.label1.Text = "    ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(175, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock alerte :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(175, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Controle :";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblStock.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblStock.Location = new System.Drawing.Point(354, 433);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(140, 31);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "                  ";
            // 
            // lblDateLAerte
            // 
            this.lblDateLAerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateLAerte.AutoSize = true;
            this.lblDateLAerte.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDateLAerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDateLAerte.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDateLAerte.Location = new System.Drawing.Point(352, 506);
            this.lblDateLAerte.Name = "lblDateLAerte";
            this.lblDateLAerte.Size = new System.Drawing.Size(140, 31);
            this.lblDateLAerte.TabIndex = 7;
            this.lblDateLAerte.Text = "                  ";
            // 
            // USER_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDateLAerte);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStatClient);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHeure);
            this.Name = "USER_Dashboard";
            this.Size = new System.Drawing.Size(997, 571);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvStatClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDateLAerte;
    }
}
