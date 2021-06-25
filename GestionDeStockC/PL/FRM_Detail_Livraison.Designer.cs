
namespace GestionDeStockC.PL
{
    partial class FRM_Detail_Livraison
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Detail_Livraison));
            this.combotype = new System.Windows.Forms.ComboBox();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.txtrechercheInvProd = new System.Windows.Forms.TextBox();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.dvgDetailLivraison = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Livraisondate = new System.Windows.Forms.DateTimePicker();
            this.txtrechercheNom = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDest = new System.Windows.Forms.Button();
            this.txtNomDest = new System.Windows.Forms.TextBox();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdDest = new System.Windows.Forms.TextBox();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPoduit = new System.Windows.Forms.GroupBox();
            this.btnSupCombo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNomFournisseur = new System.Windows.Forms.TextBox();
            this.txtNumDocument = new System.Windows.Forms.TextBox();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailLivraison)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            this.grpPoduit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combotype
            // 
            this.combotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.combotype.FormattingEnabled = true;
            this.combotype.Location = new System.Drawing.Point(161, 16);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(140, 32);
            this.combotype.TabIndex = 62;
            this.combotype.SelectionChangeCommitted += new System.EventHandler(this.combotype_SelectionChangeCommitted);
            // 
            // combocategorie
            // 
            this.combocategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.combocategorie.FormattingEnabled = true;
            this.combocategorie.Location = new System.Drawing.Point(8, 16);
            this.combocategorie.Name = "combocategorie";
            this.combocategorie.Size = new System.Drawing.Size(140, 32);
            this.combocategorie.TabIndex = 61;
            this.combocategorie.SelectionChangeCommitted += new System.EventHandler(this.combocategorie_SelectionChangeCommitted);
            // 
            // txtrechercheInvProd
            // 
            this.txtrechercheInvProd.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheInvProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtrechercheInvProd.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercheInvProd.Location = new System.Drawing.Point(312, 16);
            this.txtrechercheInvProd.Multiline = true;
            this.txtrechercheInvProd.Name = "txtrechercheInvProd";
            this.txtrechercheInvProd.Size = new System.Drawing.Size(140, 32);
            this.txtrechercheInvProd.TabIndex = 60;
            this.txtrechercheInvProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheInvProd.TextChanged += new System.EventHandler(this.txtrechercheInvProd_TextChanged);
            // 
            // grpDetail
            // 
            this.grpDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetail.Controls.Add(this.dvgDetailLivraison);
            this.grpDetail.Location = new System.Drawing.Point(855, 81);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(538, 704);
            this.grpDetail.TabIndex = 73;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Detail";
            // 
            // dvgDetailLivraison
            // 
            this.dvgDetailLivraison.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgDetailLivraison.AllowUserToAddRows = false;
            this.dvgDetailLivraison.AllowUserToDeleteRows = false;
            this.dvgDetailLivraison.AllowUserToResizeRows = false;
            this.dvgDetailLivraison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDetailLivraison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDetailLivraison.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dvgDetailLivraison.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgDetailLivraison.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDetailLivraison.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgDetailLivraison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetailLivraison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dvgDetailLivraison.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDetailLivraison.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgDetailLivraison.EnableHeadersVisualStyles = false;
            this.dvgDetailLivraison.Location = new System.Drawing.Point(6, 61);
            this.dvgDetailLivraison.MultiSelect = false;
            this.dvgDetailLivraison.Name = "dvgDetailLivraison";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDetailLivraison.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgDetailLivraison.RowHeadersVisible = false;
            this.dvgDetailLivraison.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgDetailLivraison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDetailLivraison.Size = new System.Drawing.Size(526, 637);
            this.dvgDetailLivraison.TabIndex = 66;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Désignation";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Quantité";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 48);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = global::GestionDeStockC.Properties.Resources.k;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::GestionDeStockC.Properties.Resources.Deconnecte;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // Livraisondate
            // 
            this.Livraisondate.Enabled = false;
            this.Livraisondate.Location = new System.Drawing.Point(20, 36);
            this.Livraisondate.Name = "Livraisondate";
            this.Livraisondate.Size = new System.Drawing.Size(200, 20);
            this.Livraisondate.TabIndex = 80;
            this.Livraisondate.Value = new System.DateTime(2021, 5, 22, 0, 0, 0, 0);
            // 
            // txtrechercheNom
            // 
            this.txtrechercheNom.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtrechercheNom.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercheNom.Location = new System.Drawing.Point(463, 16);
            this.txtrechercheNom.Multiline = true;
            this.txtrechercheNom.Name = "txtrechercheNom";
            this.txtrechercheNom.Size = new System.Drawing.Size(140, 32);
            this.txtrechercheNom.TabIndex = 63;
            this.txtrechercheNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheNom.TextChanged += new System.EventHandler(this.txtrechercheNom_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnDest);
            this.groupBox3.Controls.Add(this.txtNomDest);
            this.groupBox3.Location = new System.Drawing.Point(855, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 60);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destinataire";
            // 
            // btnDest
            // 
            this.btnDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDest.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDest.FlatAppearance.BorderSize = 0;
            this.btnDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDest.Location = new System.Drawing.Point(6, 18);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(53, 32);
            this.btnDest.TabIndex = 60;
            this.btnDest.Text = "...";
            this.btnDest.UseVisualStyleBackColor = false;
            this.btnDest.Click += new System.EventHandler(this.btnDst_Click);
            // 
            // txtNomDest
            // 
            this.txtNomDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomDest.BackColor = System.Drawing.Color.White;
            this.txtNomDest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomDest.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtNomDest.Enabled = false;
            this.txtNomDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomDest.ForeColor = System.Drawing.Color.Black;
            this.txtNomDest.Location = new System.Drawing.Point(65, 18);
            this.txtNomDest.Multiline = true;
            this.txtNomDest.Name = "txtNomDest";
            this.txtNomDest.Size = new System.Drawing.Size(319, 32);
            this.txtNomDest.TabIndex = 61;
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnenregistrer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.Black;
            this.btnenregistrer.Location = new System.Drawing.Point(1254, 17);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(133, 46);
            this.btnenregistrer.TabIndex = 74;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 24);
            this.label8.TabIndex = 75;
            this.label8.Text = "Date Livraison";
            // 
            // txtIdDest
            // 
            this.txtIdDest.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtIdDest.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdDest.Location = new System.Drawing.Point(651, 15);
            this.txtIdDest.Multiline = true;
            this.txtIdDest.Name = "txtIdDest";
            this.txtIdDest.Size = new System.Drawing.Size(140, 32);
            this.txtIdDest.TabIndex = 66;
            this.txtIdDest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdDest.TextChanged += new System.EventHandler(this.txtNomDest_TextChanged);
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
            this.dvgProduit.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dvgProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column10,
            this.Column2,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProduit.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgProduit.EnableHeadersVisualStyles = false;
            this.dvgProduit.Location = new System.Drawing.Point(8, 61);
            this.dvgProduit.MultiSelect = false;
            this.dvgProduit.Name = "dvgProduit";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProduit.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgProduit.RowHeadersVisible = false;
            this.dvgProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProduit.Size = new System.Drawing.Size(823, 637);
            this.dvgProduit.TabIndex = 65;
            this.dvgProduit.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProduit_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "IdProduit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Catégorie";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Inventaire";
            this.Column10.Name = "Column10";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Désignation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Quantité";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // grpPoduit
            // 
            this.grpPoduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpPoduit.BackColor = System.Drawing.Color.Transparent;
            this.grpPoduit.Controls.Add(this.btnSupCombo);
            this.grpPoduit.Controls.Add(this.txtIdDest);
            this.grpPoduit.Controls.Add(this.dvgProduit);
            this.grpPoduit.Controls.Add(this.txtrechercheNom);
            this.grpPoduit.Controls.Add(this.combotype);
            this.grpPoduit.Controls.Add(this.combocategorie);
            this.grpPoduit.Controls.Add(this.txtrechercheInvProd);
            this.grpPoduit.ForeColor = System.Drawing.Color.Black;
            this.grpPoduit.Location = new System.Drawing.Point(12, 81);
            this.grpPoduit.Name = "grpPoduit";
            this.grpPoduit.Size = new System.Drawing.Size(837, 704);
            this.grpPoduit.TabIndex = 79;
            this.grpPoduit.TabStop = false;
            this.grpPoduit.Text = "Produit";
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
            this.btnSupCombo.Location = new System.Drawing.Point(609, 15);
            this.btnSupCombo.Name = "btnSupCombo";
            this.btnSupCombo.Size = new System.Drawing.Size(36, 32);
            this.btnSupCombo.TabIndex = 67;
            this.btnSupCombo.UseVisualStyleBackColor = false;
            this.btnSupCombo.Click += new System.EventHandler(this.btnSupCombo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtNomFournisseur);
            this.groupBox2.Controls.Add(this.txtNumDocument);
            this.groupBox2.Location = new System.Drawing.Point(357, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 60);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fournisseur";
            // 
            // txtNomFournisseur
            // 
            this.txtNomFournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomFournisseur.BackColor = System.Drawing.Color.White;
            this.txtNomFournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomFournisseur.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtNomFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomFournisseur.ForeColor = System.Drawing.Color.Black;
            this.txtNomFournisseur.Location = new System.Drawing.Point(13, 18);
            this.txtNomFournisseur.MaxLength = 30;
            this.txtNomFournisseur.Multiline = true;
            this.txtNomFournisseur.Name = "txtNomFournisseur";
            this.txtNomFournisseur.Size = new System.Drawing.Size(224, 32);
            this.txtNomFournisseur.TabIndex = 62;
            // 
            // txtNumDocument
            // 
            this.txtNumDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumDocument.BackColor = System.Drawing.Color.White;
            this.txtNumDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumDocument.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtNumDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDocument.ForeColor = System.Drawing.Color.Black;
            this.txtNumDocument.Location = new System.Drawing.Point(253, 18);
            this.txtNumDocument.MaxLength = 9;
            this.txtNumDocument.Multiline = true;
            this.txtNumDocument.Name = "txtNumDocument";
            this.txtNumDocument.Size = new System.Drawing.Size(224, 32);
            this.txtNumDocument.TabIndex = 61;
            // 
            // FRM_Detail_Livraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 795);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.Livraisondate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grpPoduit);
            this.Name = "FRM_Detail_Livraison";
            this.Text = "FRM_Detail_Livraison";
            this.Load += new System.EventHandler(this.FRM_Detail_Livraison_Load);
            this.grpDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailLivraison)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            this.grpPoduit.ResumeLayout(false);
            this.grpPoduit.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        public System.Windows.Forms.ComboBox combotype;
        public System.Windows.Forms.ComboBox combocategorie;
        private System.Windows.Forms.TextBox txtrechercheInvProd;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.DataGridView dvgDetailLivraison;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker Livraisondate;
        private System.Windows.Forms.TextBox txtrechercheNom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDest;
        public System.Windows.Forms.TextBox txtNomDest;
        private System.Windows.Forms.Button btnSupCombo;
        private System.Windows.Forms.Button btnenregistrer;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdDest;
        private System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.GroupBox grpPoduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtNomFournisseur;
        public System.Windows.Forms.TextBox txtNumDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}