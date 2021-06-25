
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.details_CommandeTableAdapter = new GestionDeStockC.GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter();
            this.gESTION_DE_STOCKDataSet = new GestionDeStockC.GESTION_DE_STOCKDataSet();
            this.detailsCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtNumLivraison = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.dvgLivraison = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details_CommandeTableAdapter1 = new GestionDeStockC.GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter();
            this.txtNumLiv = new System.Windows.Forms.TextBox();
            this.gestioN_DE_STOCKDataSet1 = new GestionDeStockC.GESTION_DE_STOCKDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dvgDetailLiv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnimprimertout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsCommandeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLivraison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioN_DE_STOCKDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailLiv)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(161, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Periode";
            // 
            // txtPeriode
            // 
            this.txtPeriode.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtPeriode.ForeColor = System.Drawing.Color.DimGray;
            this.txtPeriode.Location = new System.Drawing.Point(164, 29);
            this.txtPeriode.Multiline = true;
            this.txtPeriode.Name = "txtPeriode";
            this.txtPeriode.Size = new System.Drawing.Size(140, 32);
            this.txtPeriode.TabIndex = 72;
            this.txtPeriode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Numero";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPeriode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtClient);
            this.groupBox1.Controls.Add(this.txtNumLivraison);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 69);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(318, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Client";
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtClient.ForeColor = System.Drawing.Color.DimGray;
            this.txtClient.Location = new System.Drawing.Point(321, 29);
            this.txtClient.Multiline = true;
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(140, 32);
            this.txtClient.TabIndex = 67;
            this.txtClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumLivraison
            // 
            this.txtNumLivraison.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumLivraison.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtNumLivraison.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumLivraison.Location = new System.Drawing.Point(9, 29);
            this.txtNumLivraison.Multiline = true;
            this.txtNumLivraison.Name = "txtNumLivraison";
            this.txtNumLivraison.Size = new System.Drawing.Size(140, 32);
            this.txtNumLivraison.TabIndex = 66;
            this.txtNumLivraison.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter.Location = new System.Drawing.Point(935, 19);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(130, 32);
            this.btnajouter.TabIndex = 75;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgLivraison.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgLivraison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLivraison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgLivraison.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgLivraison.EnableHeadersVisualStyles = false;
            this.dvgLivraison.Location = new System.Drawing.Point(10, 89);
            this.dvgLivraison.MultiSelect = false;
            this.dvgLivraison.Name = "dvgLivraison";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgLivraison.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgLivraison.RowHeadersVisible = false;
            this.dvgLivraison.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgLivraison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgLivraison.Size = new System.Drawing.Size(514, 621);
            this.dvgLivraison.TabIndex = 73;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Client";
            this.Column8.Name = "Column8";
            // 
            // details_CommandeTableAdapter1
            // 
            this.details_CommandeTableAdapter1.ClearBeforeFill = true;
            // 
            // txtNumLiv
            // 
            this.txtNumLiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumLiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumLiv.Location = new System.Drawing.Point(812, 23);
            this.txtNumLiv.Multiline = true;
            this.txtNumLiv.Name = "txtNumLiv";
            this.txtNumLiv.Size = new System.Drawing.Size(107, 29);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDetailLiv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgDetailLiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetailLiv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDetailLiv.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgDetailLiv.EnableHeadersVisualStyles = false;
            this.dvgDetailLiv.Location = new System.Drawing.Point(540, 89);
            this.dvgDetailLiv.MultiSelect = false;
            this.dvgDetailLiv.Name = "dvgDetailLiv";
            this.dvgDetailLiv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDetailLiv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgDetailLiv.RowHeadersVisible = false;
            this.dvgDetailLiv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgDetailLiv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDetailLiv.Size = new System.Drawing.Size(575, 621);
            this.dvgDetailLiv.TabIndex = 74;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "N° Inventaire";
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
            // btnimprimertout
            // 
            this.btnimprimertout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimprimertout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnimprimertout.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnimprimertout.FlatAppearance.BorderSize = 0;
            this.btnimprimertout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimertout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimertout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimprimertout.Image = global::GestionDeStockC.Properties.Resources.Imprimer;
            this.btnimprimertout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimertout.Location = new System.Drawing.Point(1071, 10);
            this.btnimprimertout.Name = "btnimprimertout";
            this.btnimprimertout.Size = new System.Drawing.Size(55, 48);
            this.btnimprimertout.TabIndex = 71;
            this.btnimprimertout.UseVisualStyleBackColor = false;
            // 
            // USER_Liste_Livraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.dvgLivraison);
            this.Controls.Add(this.txtNumLiv);
            this.Controls.Add(this.dvgDetailLiv);
            this.Controls.Add(this.btnimprimertout);
            this.Name = "USER_Liste_Livraison";
            this.Size = new System.Drawing.Size(1137, 720);
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsCommandeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLivraison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioN_DE_STOCKDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailLiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter details_CommandeTableAdapter;
        private GESTION_DE_STOCKDataSet gESTION_DE_STOCKDataSet;
        private System.Windows.Forms.BindingSource detailsCommandeBindingSource;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeriode;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtNumLivraison;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.DataGridView dvgLivraison;
        private GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter details_CommandeTableAdapter1;
        private System.Windows.Forms.TextBox txtNumLiv;
        private GESTION_DE_STOCKDataSet gestioN_DE_STOCKDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dvgDetailLiv;
        private System.Windows.Forms.Button btnimprimertout;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}
