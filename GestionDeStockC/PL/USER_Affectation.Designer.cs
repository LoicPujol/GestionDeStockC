
namespace GestionDeStockC.PL
{
    partial class USER_Affectation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_Affectation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSupCombo = new System.Windows.Forms.Button();
            this.dvgAffectationProduit = new System.Windows.Forms.DataGridView();
            this.txtrechercheInvProd = new System.Windows.Forms.TextBox();
            this.txtrechercheNom = new System.Windows.Forms.TextBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.txtrechercheClient = new System.Windows.Forms.TextBox();
            this.btnexcel = new System.Windows.Forms.Button();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAffectationProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupCombo
            // 
            this.btnSupCombo.BackColor = System.Drawing.Color.White;
            this.btnSupCombo.CausesValidation = false;
            this.btnSupCombo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnSupCombo.FlatAppearance.BorderSize = 0;
            this.btnSupCombo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSupCombo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSupCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupCombo.ForeColor = System.Drawing.Color.LightGray;
            this.btnSupCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnSupCombo.Image")));
            this.btnSupCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupCombo.Location = new System.Drawing.Point(775, 20);
            this.btnSupCombo.Name = "btnSupCombo";
            this.btnSupCombo.Size = new System.Drawing.Size(36, 32);
            this.btnSupCombo.TabIndex = 62;
            this.btnSupCombo.UseVisualStyleBackColor = false;
            this.btnSupCombo.Click += new System.EventHandler(this.btnSupCombo_Click_1);
            // 
            // dvgAffectationProduit
            // 
            this.dvgAffectationProduit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgAffectationProduit.AllowUserToAddRows = false;
            this.dvgAffectationProduit.AllowUserToDeleteRows = false;
            this.dvgAffectationProduit.AllowUserToResizeRows = false;
            this.dvgAffectationProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgAffectationProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgAffectationProduit.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dvgAffectationProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgAffectationProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgAffectationProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgAffectationProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAffectationProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column8,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgAffectationProduit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgAffectationProduit.EnableHeadersVisualStyles = false;
            this.dvgAffectationProduit.Location = new System.Drawing.Point(18, 58);
            this.dvgAffectationProduit.MultiSelect = false;
            this.dvgAffectationProduit.Name = "dvgAffectationProduit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgAffectationProduit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgAffectationProduit.RowHeadersVisible = false;
            this.dvgAffectationProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgAffectationProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAffectationProduit.Size = new System.Drawing.Size(1434, 790);
            this.dvgAffectationProduit.TabIndex = 63;
            // 
            // txtrechercheInvProd
            // 
            this.txtrechercheInvProd.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheInvProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtrechercheInvProd.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercheInvProd.Location = new System.Drawing.Point(505, 20);
            this.txtrechercheInvProd.Multiline = true;
            this.txtrechercheInvProd.Name = "txtrechercheInvProd";
            this.txtrechercheInvProd.Size = new System.Drawing.Size(125, 32);
            this.txtrechercheInvProd.TabIndex = 55;
            this.txtrechercheInvProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheInvProd.TextChanged += new System.EventHandler(this.txtrechercheInvProd_TextChanged);
            // 
            // txtrechercheNom
            // 
            this.txtrechercheNom.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtrechercheNom.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercheNom.Location = new System.Drawing.Point(640, 20);
            this.txtrechercheNom.Multiline = true;
            this.txtrechercheNom.Name = "txtrechercheNom";
            this.txtrechercheNom.Size = new System.Drawing.Size(125, 32);
            this.txtrechercheNom.TabIndex = 57;
            this.txtrechercheNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheNom.TextChanged += new System.EventHandler(this.txtrechercheNom_TextChanged);
            // 
            // combotype
            // 
            this.combotype.BackColor = System.Drawing.SystemColors.Control;
            this.combotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.combotype.FormattingEnabled = true;
            this.combotype.Location = new System.Drawing.Point(160, 20);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(125, 32);
            this.combotype.TabIndex = 65;
            this.combotype.SelectionChangeCommitted += new System.EventHandler(this.combotype_SelectionChangeCommitted);
            // 
            // combocategorie
            // 
            this.combocategorie.BackColor = System.Drawing.SystemColors.Control;
            this.combocategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.combocategorie.FormattingEnabled = true;
            this.combocategorie.Location = new System.Drawing.Point(25, 20);
            this.combocategorie.Name = "combocategorie";
            this.combocategorie.Size = new System.Drawing.Size(125, 32);
            this.combocategorie.TabIndex = 64;
            this.combocategorie.Tag = "";
            this.combocategorie.SelectionChangeCommitted += new System.EventHandler(this.combocategorie_SelectionChangeCommitted);
            // 
            // txtrechercheClient
            // 
            this.txtrechercheClient.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtrechercheClient.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercheClient.Location = new System.Drawing.Point(295, 20);
            this.txtrechercheClient.Multiline = true;
            this.txtrechercheClient.Name = "txtrechercheClient";
            this.txtrechercheClient.Size = new System.Drawing.Size(200, 32);
            this.txtrechercheClient.TabIndex = 66;
            this.txtrechercheClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheClient.TextChanged += new System.EventHandler(this.txtrechercheClient_TextChanged);
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
            this.btnexcel.TabIndex = 80;
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Catégorie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 135;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 135;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "Client";
            this.Column8.Name = "Column8";
            this.Column8.Width = 210;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.HeaderText = "Inventaire";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 135;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Désignation";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantitée";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.HeaderText = "Contrôle";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // USER_Affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.dvgAffectationProduit);
            this.Controls.Add(this.txtrechercheNom);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.btnSupCombo);
            this.Controls.Add(this.combocategorie);
            this.Controls.Add(this.txtrechercheInvProd);
            this.Controls.Add(this.txtrechercheClient);
            this.Name = "USER_Affectation";
            this.Size = new System.Drawing.Size(1474, 865);
            this.Load += new System.EventHandler(this.USER_Affectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAffectationProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSupCombo;
        private System.Windows.Forms.DataGridView dvgAffectationProduit;
        private System.Windows.Forms.TextBox txtrechercheInvProd;
        private System.Windows.Forms.TextBox txtrechercheNom;
        public System.Windows.Forms.ComboBox combotype;
        public System.Windows.Forms.ComboBox combocategorie;
        private System.Windows.Forms.TextBox txtrechercheClient;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
