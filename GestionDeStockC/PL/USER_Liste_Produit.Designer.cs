
namespace GestionDeStockC.PL
{
    partial class USER_Liste_Produit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtrechercheInvProd = new System.Windows.Forms.TextBox();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.txtrechercheNom = new System.Windows.Forms.TextBox();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.btnSupCombo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgProduit
            // 
            this.dvgProduit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgProduit.AllowUserToAddRows = false;
            this.dvgProduit.AllowUserToDeleteRows = false;
            this.dvgProduit.AllowUserToResizeRows = false;
            this.dvgProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgProduit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column4,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProduit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgProduit.EnableHeadersVisualStyles = false;
            this.dvgProduit.Location = new System.Drawing.Point(18, 52);
            this.dvgProduit.MultiSelect = false;
            this.dvgProduit.Name = "dvgProduit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProduit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgProduit.RowHeadersVisible = false;
            this.dvgProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProduit.Size = new System.Drawing.Size(1434, 650);
            this.dvgProduit.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Catégorie";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "N° Inventaire";
            this.Column10.Name = "Column10";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Désignation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Stock Alerte";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Contrôle";
            this.Column7.Name = "Column7";
            // 
            // txtrechercheInvProd
            // 
            this.txtrechercheInvProd.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheInvProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtrechercheInvProd.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercheInvProd.Location = new System.Drawing.Point(324, 13);
            this.txtrechercheInvProd.Multiline = true;
            this.txtrechercheInvProd.Name = "txtrechercheInvProd";
            this.txtrechercheInvProd.Size = new System.Drawing.Size(152, 28);
            this.txtrechercheInvProd.TabIndex = 14;
            this.txtrechercheInvProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheInvProd.TextChanged += new System.EventHandler(this.txtrechercheInvProd_TextChanged);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsupprimer.BackColor = System.Drawing.SystemColors.Control;
            this.btnsupprimer.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnsupprimer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnsupprimer.FlatAppearance.BorderSize = 2;
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnsupprimer.ForeColor = System.Drawing.Color.Gray;
            this.btnsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimer.Location = new System.Drawing.Point(1266, 12);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(122, 29);
            this.btnsupprimer.TabIndex = 10;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodifier.BackColor = System.Drawing.SystemColors.Control;
            this.btnmodifier.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnmodifier.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnmodifier.FlatAppearance.BorderSize = 2;
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnmodifier.ForeColor = System.Drawing.Color.Gray;
            this.btnmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifier.Location = new System.Drawing.Point(1126, 13);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(134, 29);
            this.btnmodifier.TabIndex = 9;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnajouter.BackColor = System.Drawing.SystemColors.Control;
            this.btnajouter.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnajouter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnajouter.FlatAppearance.BorderSize = 2;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.Gray;
            this.btnajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter.Location = new System.Drawing.Point(991, 12);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(129, 29);
            this.btnajouter.TabIndex = 8;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnexcel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnexcel.FlatAppearance.BorderSize = 0;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexcel.Image = global::GestionDeStockC.Properties.Resources.Excel_icon;
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(1407, 12);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(45, 33);
            this.btnexcel.TabIndex = 20;
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // txtrechercheNom
            // 
            this.txtrechercheNom.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtrechercheNom.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercheNom.Location = new System.Drawing.Point(482, 13);
            this.txtrechercheNom.Multiline = true;
            this.txtrechercheNom.Name = "txtrechercheNom";
            this.txtrechercheNom.Size = new System.Drawing.Size(149, 28);
            this.txtrechercheNom.TabIndex = 22;
            this.txtrechercheNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheNom.TextChanged += new System.EventHandler(this.txtrechercheNom_TextChanged);
            // 
            // combocategorie
            // 
            this.combocategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combocategorie.FormattingEnabled = true;
            this.combocategorie.Location = new System.Drawing.Point(18, 13);
            this.combocategorie.Name = "combocategorie";
            this.combocategorie.Size = new System.Drawing.Size(166, 28);
            this.combocategorie.TabIndex = 52;
            this.combocategorie.SelectionChangeCommitted += new System.EventHandler(this.combocategorie_SelectionChangeCommitted);
            // 
            // combotype
            // 
            this.combotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combotype.FormattingEnabled = true;
            this.combotype.Location = new System.Drawing.Point(190, 13);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(128, 28);
            this.combotype.TabIndex = 53;
            this.combotype.SelectionChangeCommitted += new System.EventHandler(this.combotype_SelectionChangeCommitted);
            // 
            // btnSupCombo
            // 
            this.btnSupCombo.BackColor = System.Drawing.SystemColors.Control;
            this.btnSupCombo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnSupCombo.FlatAppearance.BorderSize = 0;
            this.btnSupCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupCombo.ForeColor = System.Drawing.Color.Gray;
            this.btnSupCombo.Image = global::GestionDeStockC.Properties.Resources.Button_Delete_icon;
            this.btnSupCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupCombo.Location = new System.Drawing.Point(631, 9);
            this.btnSupCombo.Name = "btnSupCombo";
            this.btnSupCombo.Size = new System.Drawing.Size(41, 33);
            this.btnSupCombo.TabIndex = 54;
            this.btnSupCombo.UseVisualStyleBackColor = false;
            this.btnSupCombo.Click += new System.EventHandler(this.btnSupCombo_Click);
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSupCombo);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.combocategorie);
            this.Controls.Add(this.txtrechercheNom);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.dvgProduit);
            this.Controls.Add(this.txtrechercheInvProd);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnajouter);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1474, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.TextBox txtrechercheInvProd;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.TextBox txtrechercheNom;
        public System.Windows.Forms.ComboBox combocategorie;
        public System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Button btnSupCombo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
