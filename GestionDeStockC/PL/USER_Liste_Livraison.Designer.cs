
namespace GestionDeStockC.PL
{
    partial class USER_Liste_Livraison
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_Liste_Livraison));
            this.details_CommandeTableAdapter = new GestionDeStockC.GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter();
            this.gESTION_DE_STOCKDataSet = new GestionDeStockC.GESTION_DE_STOCKDataSet();
            this.detailsCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPeriode = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.txtFournisseur = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtNumLivraison = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.details_CommandeTableAdapter1 = new GestionDeStockC.GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter();
            this.txtNumLiv = new System.Windows.Forms.TextBox();
            this.gestioN_DE_STOCKDataSet1 = new GestionDeStockC.GESTION_DE_STOCKDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dvgDetailLiv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgLivraison = new System.Windows.Forms.DataGridView();
            this.btnexcel = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsCommandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioN_DE_STOCKDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailLiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLivraison)).BeginInit();
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
            // txtPeriode
            // 
            this.txtPeriode.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtPeriode.ForeColor = System.Drawing.Color.DimGray;
            this.txtPeriode.Location = new System.Drawing.Point(125, 20);
            this.txtPeriode.Multiline = true;
            this.txtPeriode.Name = "txtPeriode";
            this.txtPeriode.Size = new System.Drawing.Size(90, 32);
            this.txtPeriode.TabIndex = 72;
            this.txtPeriode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeriode.TextChanged += new System.EventHandler(this.txtPeriode_TextChanged);
            // 
            // txtDocument
            // 
            this.txtDocument.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtDocument.ForeColor = System.Drawing.Color.DimGray;
            this.txtDocument.Location = new System.Drawing.Point(645, 20);
            this.txtDocument.Multiline = true;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(90, 32);
            this.txtDocument.TabIndex = 76;
            this.txtDocument.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDocument.TextChanged += new System.EventHandler(this.txtDocument_TextChanged);
            // 
            // txtFournisseur
            // 
            this.txtFournisseur.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtFournisseur.ForeColor = System.Drawing.Color.DimGray;
            this.txtFournisseur.Location = new System.Drawing.Point(435, 20);
            this.txtFournisseur.Multiline = true;
            this.txtFournisseur.Name = "txtFournisseur";
            this.txtFournisseur.Size = new System.Drawing.Size(200, 32);
            this.txtFournisseur.TabIndex = 74;
            this.txtFournisseur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFournisseur.TextChanged += new System.EventHandler(this.txtFournisseur_TextChanged);
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtClient.ForeColor = System.Drawing.Color.DimGray;
            this.txtClient.Location = new System.Drawing.Point(225, 20);
            this.txtClient.Multiline = true;
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(200, 32);
            this.txtClient.TabIndex = 67;
            this.txtClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // txtNumLivraison
            // 
            this.txtNumLivraison.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumLivraison.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtNumLivraison.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumLivraison.Location = new System.Drawing.Point(25, 20);
            this.txtNumLivraison.Multiline = true;
            this.txtNumLivraison.Name = "txtNumLivraison";
            this.txtNumLivraison.Size = new System.Drawing.Size(90, 32);
            this.txtNumLivraison.TabIndex = 66;
            this.txtNumLivraison.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumLivraison.TextChanged += new System.EventHandler(this.txtNumLivraison_TextChanged);
            // 
            // btnajouter
            // 
            this.btnajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnajouter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnajouter.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnajouter.FlatAppearance.BorderSize = 0;
            this.btnajouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter.Location = new System.Drawing.Point(1280, 20);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(130, 32);
            this.btnajouter.TabIndex = 75;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // details_CommandeTableAdapter1
            // 
            this.details_CommandeTableAdapter1.ClearBeforeFill = true;
            // 
            // txtNumLiv
            // 
            this.txtNumLiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumLiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumLiv.Location = new System.Drawing.Point(1251, 20);
            this.txtNumLiv.Multiline = true;
            this.txtNumLiv.Name = "txtNumLiv";
            this.txtNumLiv.Size = new System.Drawing.Size(16, 29);
            this.txtNumLiv.TabIndex = 72;
            this.txtNumLiv.Visible = false;
            this.txtNumLiv.TextChanged += new System.EventHandler(this.txtNumLiv_TextChanged);
            // 
            // gestioN_DE_STOCKDataSet1
            // 
            this.gestioN_DE_STOCKDataSet1.DataSetName = "GESTION_DE_STOCKDataSet";
            this.gestioN_DE_STOCKDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Details_Commande";
            this.bindingSource1.DataSource = this.gestioN_DE_STOCKDataSet1;
            // 
            // dvgDetailLiv
            // 
            this.dvgDetailLiv.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgDetailLiv.AllowUserToAddRows = false;
            this.dvgDetailLiv.AllowUserToDeleteRows = false;
            this.dvgDetailLiv.AllowUserToResizeRows = false;
            this.dvgDetailLiv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDetailLiv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDetailLiv.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dvgDetailLiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgDetailLiv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDetailLiv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dvgDetailLiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetailLiv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDetailLiv.DefaultCellStyle = dataGridViewCellStyle26;
            this.dvgDetailLiv.Enabled = false;
            this.dvgDetailLiv.EnableHeadersVisualStyles = false;
            this.dvgDetailLiv.Location = new System.Drawing.Point(938, 58);
            this.dvgDetailLiv.MultiSelect = false;
            this.dvgDetailLiv.Name = "dvgDetailLiv";
            this.dvgDetailLiv.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDetailLiv.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dvgDetailLiv.RowHeadersVisible = false;
            this.dvgDetailLiv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgDetailLiv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDetailLiv.Size = new System.Drawing.Size(514, 790);
            this.dvgDetailLiv.TabIndex = 74;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Inventaire";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Désignation";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Quantité";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dvgLivraison
            // 
            this.dvgLivraison.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgLivraison.AllowUserToAddRows = false;
            this.dvgLivraison.AllowUserToDeleteRows = false;
            this.dvgLivraison.AllowUserToResizeRows = false;
            this.dvgLivraison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgLivraison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgLivraison.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dvgLivraison.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgLivraison.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgLivraison.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dvgLivraison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLivraison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column8,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgLivraison.DefaultCellStyle = dataGridViewCellStyle29;
            this.dvgLivraison.EnableHeadersVisualStyles = false;
            this.dvgLivraison.Location = new System.Drawing.Point(18, 58);
            this.dvgLivraison.MultiSelect = false;
            this.dvgLivraison.Name = "dvgLivraison";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgLivraison.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dvgLivraison.RowHeadersVisible = false;
            this.dvgLivraison.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgLivraison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgLivraison.Size = new System.Drawing.Size(900, 790);
            this.dvgLivraison.TabIndex = 77;
            this.dvgLivraison.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCommande_CellContentClick);
            this.dvgLivraison.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgLivraison_CellMouseClick);
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcel.BackColor = System.Drawing.Color.White;
            this.btnexcel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnexcel.FlatAppearance.BorderSize = 0;
            this.btnexcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnexcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.Color.LightGray;
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(1420, 20);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(32, 32);
            this.btnexcel.TabIndex = 78;
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "Client";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 210;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Fournisseur";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 210;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Document";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // USER_Liste_Livraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.dvgLivraison);
            this.Controls.Add(this.txtFournisseur);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.txtNumLiv);
            this.Controls.Add(this.txtPeriode);
            this.Controls.Add(this.dvgDetailLiv);
            this.Controls.Add(this.txtNumLivraison);
            this.Controls.Add(this.txtClient);
            this.Name = "USER_Liste_Livraison";
            this.Size = new System.Drawing.Size(1474, 865);
            this.Load += new System.EventHandler(this.USER_Liste_Livraison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsCommandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioN_DE_STOCKDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailLiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLivraison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter details_CommandeTableAdapter;
        private GESTION_DE_STOCKDataSet gESTION_DE_STOCKDataSet;
        private System.Windows.Forms.BindingSource detailsCommandeBindingSource;
        private System.Windows.Forms.TextBox txtPeriode;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtNumLivraison;
        private System.Windows.Forms.Button btnajouter;
        private GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter details_CommandeTableAdapter1;
        private System.Windows.Forms.TextBox txtNumLiv;
        private GESTION_DE_STOCKDataSet gestioN_DE_STOCKDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dvgDetailLiv;
        private System.Windows.Forms.DataGridView dvgLivraison;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.TextBox txtFournisseur;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
