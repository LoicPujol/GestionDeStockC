
namespace GestionDeStockC.PL
{
    partial class USER_Liste_Commande
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
            this.btnimprimertout = new System.Windows.Forms.Button();
            this.detailsCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_DE_STOCKDataSet = new GestionDeStockC.GESTION_DE_STOCKDataSet();
            this.txtNumCde = new System.Windows.Forms.TextBox();
            this.details_CommandeTableAdapter = new GestionDeStockC.GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter();
            this.dvgCommande = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgDetailCde = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtNumCommande = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detailsCommandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailCde)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnimprimertout.Location = new System.Drawing.Point(1079, 3);
            this.btnimprimertout.Name = "btnimprimertout";
            this.btnimprimertout.Size = new System.Drawing.Size(55, 48);
            this.btnimprimertout.TabIndex = 32;
            this.btnimprimertout.UseVisualStyleBackColor = false;
            // 
            // detailsCommandeBindingSource
            // 
            this.detailsCommandeBindingSource.DataMember = "Details_Commande";
            this.detailsCommandeBindingSource.DataSource = this.gESTION_DE_STOCKDataSet;
            // 
            // gESTION_DE_STOCKDataSet
            // 
            this.gESTION_DE_STOCKDataSet.DataSetName = "GESTION_DE_STOCKDataSet";
            this.gESTION_DE_STOCKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumCde
            // 
            this.txtNumCde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumCde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCde.Location = new System.Drawing.Point(820, 16);
            this.txtNumCde.Multiline = true;
            this.txtNumCde.Name = "txtNumCde";
            this.txtNumCde.Size = new System.Drawing.Size(107, 29);
            this.txtNumCde.TabIndex = 35;
            this.txtNumCde.Visible = false;
            this.txtNumCde.TextChanged += new System.EventHandler(this.txtNumCde_TextChanged);
            // 
            // details_CommandeTableAdapter
            // 
            this.details_CommandeTableAdapter.ClearBeforeFill = true;
            // 
            // dvgCommande
            // 
            this.dvgCommande.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgCommande.AllowUserToAddRows = false;
            this.dvgCommande.AllowUserToDeleteRows = false;
            this.dvgCommande.AllowUserToResizeRows = false;
            this.dvgCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCommande.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dvgCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.Column8,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCommande.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgCommande.EnableHeadersVisualStyles = false;
            this.dvgCommande.Location = new System.Drawing.Point(18, 82);
            this.dvgCommande.MultiSelect = false;
            this.dvgCommande.Name = "dvgCommande";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCommande.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgCommande.RowHeadersVisible = false;
            this.dvgCommande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCommande.Size = new System.Drawing.Size(514, 621);
            this.dvgCommande.TabIndex = 64;
            this.dvgCommande.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCommande_CellContentClick);
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Total Ht";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dvgDetailCde
            // 
            this.dvgDetailCde.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgDetailCde.AllowUserToAddRows = false;
            this.dvgDetailCde.AllowUserToDeleteRows = false;
            this.dvgDetailCde.AllowUserToResizeRows = false;
            this.dvgDetailCde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDetailCde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDetailCde.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dvgDetailCde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgDetailCde.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDetailCde.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgDetailCde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetailCde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn12});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDetailCde.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgDetailCde.EnableHeadersVisualStyles = false;
            this.dvgDetailCde.Location = new System.Drawing.Point(548, 82);
            this.dvgDetailCde.MultiSelect = false;
            this.dvgDetailCde.Name = "dvgDetailCde";
            this.dvgDetailCde.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDetailCde.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgDetailCde.RowHeadersVisible = false;
            this.dvgDetailCde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgDetailCde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDetailCde.Size = new System.Drawing.Size(575, 621);
            this.dvgDetailCde.TabIndex = 65;
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
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Remise";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.SystemColors.Control;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtClient.ForeColor = System.Drawing.Color.DimGray;
            this.txtClient.Location = new System.Drawing.Point(321, 29);
            this.txtClient.Multiline = true;
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(140, 32);
            this.txtClient.TabIndex = 67;
            this.txtClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // txtNumCommande
            // 
            this.txtNumCommande.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtNumCommande.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumCommande.Location = new System.Drawing.Point(9, 29);
            this.txtNumCommande.Multiline = true;
            this.txtNumCommande.Name = "txtNumCommande";
            this.txtNumCommande.Size = new System.Drawing.Size(140, 32);
            this.txtNumCommande.TabIndex = 66;
            this.txtNumCommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumCommande.TextChanged += new System.EventHandler(this.txtNumCommande_TextChanged);
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
            this.btnajouter.Location = new System.Drawing.Point(943, 12);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(130, 32);
            this.btnajouter.TabIndex = 68;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPeriode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtClient);
            this.groupBox1.Controls.Add(this.txtNumCommande);
            this.groupBox1.Location = new System.Drawing.Point(18, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 69);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
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
            this.txtPeriode.BackColor = System.Drawing.SystemColors.Control;
            this.txtPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtPeriode.ForeColor = System.Drawing.Color.DimGray;
            this.txtPeriode.Location = new System.Drawing.Point(164, 29);
            this.txtPeriode.Multiline = true;
            this.txtPeriode.Name = "txtPeriode";
            this.txtPeriode.Size = new System.Drawing.Size(140, 32);
            this.txtPeriode.TabIndex = 72;
            this.txtPeriode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeriode.TextChanged += new System.EventHandler(this.txtPeriode_TextChanged);
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
            // USER_Liste_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.dvgDetailCde);
            this.Controls.Add(this.dvgCommande);
            this.Controls.Add(this.txtNumCde);
            this.Controls.Add(this.btnimprimertout);
            this.Name = "USER_Liste_Commande";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailsCommandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailCde)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnimprimertout;
        private System.Windows.Forms.TextBox txtNumCde;
        private System.Windows.Forms.BindingSource detailsCommandeBindingSource;
        private GESTION_DE_STOCKDataSet gESTION_DE_STOCKDataSet;
        private GESTION_DE_STOCKDataSetTableAdapters.Details_CommandeTableAdapter details_CommandeTableAdapter;
        private System.Windows.Forms.DataGridView dvgCommande;
        private System.Windows.Forms.DataGridView dvgDetailCde;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtNumCommande;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeriode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}
