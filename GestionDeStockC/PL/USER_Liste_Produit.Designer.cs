
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_Liste_Produit));
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.txtrechercheInvProd = new System.Windows.Forms.TextBox();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.txtrechercheNom = new System.Windows.Forms.TextBox();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.btnSupCombo = new System.Windows.Forms.Button();
            this.gESTION_DE_STOCKDataSet1 = new GestionDeStockC.GESTION_DE_STOCKDataSet1();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new GestionDeStockC.GESTION_DE_STOCKDataSet1TableAdapters.ProduitTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInventaireProd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomP = new System.Windows.Forms.TextBox();
            this.txtDateCtrl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMarge = new System.Windows.Forms.TextBox();
            this.txtTarifAchat = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtStockAlerte = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.picProduit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.grpUnitaire = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumAna = new System.Windows.Forms.TextBox();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).BeginInit();
            this.grpUnitaire.SuspendLayout();
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
            this.dvgProduit.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dvgProduit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column10,
            this.Column2,
            this.Column8,
            this.Column4,
            this.Column7,
            this.Column11,
            this.Column13,
            this.Column14,
            this.Column12});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProduit.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgProduit.EnableHeadersVisualStyles = false;
            this.dvgProduit.Location = new System.Drawing.Point(18, 58);
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
            this.dvgProduit.Size = new System.Drawing.Size(900, 790);
            this.dvgProduit.TabIndex = 16;
            this.dvgProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProduit_CellContentClick);
            // 
            // txtrechercheInvProd
            // 
            this.txtrechercheInvProd.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheInvProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrechercheInvProd.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercheInvProd.Location = new System.Drawing.Point(295, 20);
            this.txtrechercheInvProd.Multiline = true;
            this.txtrechercheInvProd.Name = "txtrechercheInvProd";
            this.txtrechercheInvProd.Size = new System.Drawing.Size(125, 32);
            this.txtrechercheInvProd.TabIndex = 14;
            this.txtrechercheInvProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheInvProd.TextChanged += new System.EventHandler(this.txtrechercheInvProd_TextChanged);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsupprimer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsupprimer.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnsupprimer.FlatAppearance.BorderSize = 0;
            this.btnsupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnsupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.Color.White;
            this.btnsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimer.Location = new System.Drawing.Point(1280, 20);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(130, 32);
            this.btnsupprimer.TabIndex = 10;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodifier.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnmodifier.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnmodifier.FlatAppearance.BorderSize = 0;
            this.btnmodifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnmodifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifier.Location = new System.Drawing.Point(1140, 20);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(130, 32);
            this.btnmodifier.TabIndex = 9;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
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
            this.btnajouter.Location = new System.Drawing.Point(1000, 20);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(130, 32);
            this.btnajouter.TabIndex = 8;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
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
            this.btnexcel.TabIndex = 20;
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // txtrechercheNom
            // 
            this.txtrechercheNom.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrechercheNom.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercheNom.Location = new System.Drawing.Point(430, 20);
            this.txtrechercheNom.Multiline = true;
            this.txtrechercheNom.Name = "txtrechercheNom";
            this.txtrechercheNom.Size = new System.Drawing.Size(171, 32);
            this.txtrechercheNom.TabIndex = 22;
            this.txtrechercheNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercheNom.TextChanged += new System.EventHandler(this.txtrechercheNom_TextChanged);
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
            this.combocategorie.TabIndex = 52;
            this.combocategorie.SelectionChangeCommitted += new System.EventHandler(this.combocategorie_SelectionChangeCommitted);
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
            this.combotype.TabIndex = 53;
            this.combotype.SelectionChangeCommitted += new System.EventHandler(this.combotype_SelectionChangeCommitted);
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
            this.btnSupCombo.Location = new System.Drawing.Point(610, 20);
            this.btnSupCombo.Name = "btnSupCombo";
            this.btnSupCombo.Size = new System.Drawing.Size(36, 32);
            this.btnSupCombo.TabIndex = 54;
            this.btnSupCombo.UseVisualStyleBackColor = false;
            this.btnSupCombo.Click += new System.EventHandler(this.btnSupCombo_Click);
            // 
            // gESTION_DE_STOCKDataSet1
            // 
            this.gESTION_DE_STOCKDataSet1.DataSetName = "GESTION_DE_STOCKDataSet1";
            this.gESTION_DE_STOCKDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.gESTION_DE_STOCKDataSet1;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(8, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 24);
            this.label13.TabIndex = 102;
            this.label13.Text = "Numero Inventaire";
            // 
            // txtInventaireProd
            // 
            this.txtInventaireProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInventaireProd.BackColor = System.Drawing.Color.White;
            this.txtInventaireProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInventaireProd.Enabled = false;
            this.txtInventaireProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventaireProd.ForeColor = System.Drawing.Color.Silver;
            this.txtInventaireProd.Location = new System.Drawing.Point(12, 46);
            this.txtInventaireProd.MaxLength = 9;
            this.txtInventaireProd.Multiline = true;
            this.txtInventaireProd.Name = "txtInventaireProd";
            this.txtInventaireProd.Size = new System.Drawing.Size(230, 30);
            this.txtInventaireProd.TabIndex = 101;
            this.txtInventaireProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 24);
            this.label11.TabIndex = 104;
            this.label11.Text = "Nom produit";
            // 
            // txtNomP
            // 
            this.txtNomP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomP.BackColor = System.Drawing.Color.White;
            this.txtNomP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomP.Enabled = false;
            this.txtNomP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomP.ForeColor = System.Drawing.Color.Silver;
            this.txtNomP.Location = new System.Drawing.Point(12, 120);
            this.txtNomP.MaxLength = 30;
            this.txtNomP.Multiline = true;
            this.txtNomP.Name = "txtNomP";
            this.txtNomP.Size = new System.Drawing.Size(230, 30);
            this.txtNomP.TabIndex = 103;
            this.txtNomP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateCtrl
            // 
            this.txtDateCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateCtrl.BackColor = System.Drawing.Color.White;
            this.txtDateCtrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateCtrl.Enabled = false;
            this.txtDateCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCtrl.ForeColor = System.Drawing.Color.Silver;
            this.txtDateCtrl.Location = new System.Drawing.Point(12, 494);
            this.txtDateCtrl.Multiline = true;
            this.txtDateCtrl.Name = "txtDateCtrl";
            this.txtDateCtrl.Size = new System.Drawing.Size(230, 30);
            this.txtDateCtrl.TabIndex = 71;
            this.txtDateCtrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 24);
            this.label10.TabIndex = 68;
            this.label10.Text = "Numero de serie";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumSerie.BackColor = System.Drawing.Color.White;
            this.txtNumSerie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumSerie.Enabled = false;
            this.txtNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.ForeColor = System.Drawing.Color.Silver;
            this.txtNumSerie.Location = new System.Drawing.Point(12, 568);
            this.txtNumSerie.Multiline = true;
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(230, 30);
            this.txtNumSerie.TabIndex = 56;
            this.txtNumSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(268, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 108;
            this.label1.Text = "Type";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(268, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 106;
            this.label5.Text = "Categorie";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 116;
            this.label7.Text = "Tarif achat";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 115;
            this.label6.Text = "Marge en %";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(8, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 24);
            this.label12.TabIndex = 114;
            this.label12.Text = "Prix de vente";
            // 
            // txtMarge
            // 
            this.txtMarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarge.BackColor = System.Drawing.Color.White;
            this.txtMarge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarge.Enabled = false;
            this.txtMarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarge.ForeColor = System.Drawing.Color.Silver;
            this.txtMarge.Location = new System.Drawing.Point(10, 341);
            this.txtMarge.MaxLength = 2;
            this.txtMarge.Multiline = true;
            this.txtMarge.Name = "txtMarge";
            this.txtMarge.Size = new System.Drawing.Size(230, 30);
            this.txtMarge.TabIndex = 113;
            this.txtMarge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTarifAchat
            // 
            this.txtTarifAchat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarifAchat.BackColor = System.Drawing.Color.White;
            this.txtTarifAchat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTarifAchat.Enabled = false;
            this.txtTarifAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarifAchat.ForeColor = System.Drawing.Color.Silver;
            this.txtTarifAchat.Location = new System.Drawing.Point(10, 193);
            this.txtTarifAchat.Multiline = true;
            this.txtTarifAchat.Name = "txtTarifAchat";
            this.txtTarifAchat.Size = new System.Drawing.Size(230, 30);
            this.txtTarifAchat.TabIndex = 112;
            this.txtTarifAchat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrix
            // 
            this.txtPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrix.BackColor = System.Drawing.Color.White;
            this.txtPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrix.Enabled = false;
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.ForeColor = System.Drawing.Color.Silver;
            this.txtPrix.Location = new System.Drawing.Point(12, 267);
            this.txtPrix.Multiline = true;
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(230, 30);
            this.txtPrix.TabIndex = 111;
            this.txtPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStockAlerte
            // 
            this.txtStockAlerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockAlerte.BackColor = System.Drawing.Color.White;
            this.txtStockAlerte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockAlerte.Enabled = false;
            this.txtStockAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAlerte.ForeColor = System.Drawing.Color.Silver;
            this.txtStockAlerte.Location = new System.Drawing.Point(265, 566);
            this.txtStockAlerte.Multiline = true;
            this.txtStockAlerte.Name = "txtStockAlerte";
            this.txtStockAlerte.Size = new System.Drawing.Size(230, 30);
            this.txtStockAlerte.TabIndex = 53;
            this.txtStockAlerte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(261, 534);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 24);
            this.label14.TabIndex = 64;
            this.label14.Text = "Stock alerte";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 24);
            this.label15.TabIndex = 119;
            this.label15.Text = "Poids en kg";
            // 
            // txtPoids
            // 
            this.txtPoids.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoids.BackColor = System.Drawing.Color.White;
            this.txtPoids.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoids.Enabled = false;
            this.txtPoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoids.ForeColor = System.Drawing.Color.Silver;
            this.txtPoids.Location = new System.Drawing.Point(10, 417);
            this.txtPoids.Multiline = true;
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(230, 30);
            this.txtPoids.TabIndex = 118;
            this.txtPoids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(261, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 24);
            this.label16.TabIndex = 122;
            this.label16.Text = "Image";
            // 
            // picProduit
            // 
            this.picProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picProduit.BackColor = System.Drawing.Color.White;
            this.picProduit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProduit.Enabled = false;
            this.picProduit.Location = new System.Drawing.Point(265, 46);
            this.picProduit.Name = "picProduit";
            this.picProduit.Size = new System.Drawing.Size(237, 224);
            this.picProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduit.TabIndex = 121;
            this.picProduit.TabStop = false;
            this.picProduit.Tag = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 125;
            this.label2.Text = "Date de controle";
            // 
            // txtTyp
            // 
            this.txtTyp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTyp.BackColor = System.Drawing.Color.White;
            this.txtTyp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTyp.Enabled = false;
            this.txtTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTyp.ForeColor = System.Drawing.Color.Silver;
            this.txtTyp.Location = new System.Drawing.Point(265, 417);
            this.txtTyp.Multiline = true;
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(230, 30);
            this.txtTyp.TabIndex = 127;
            this.txtTyp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCat
            // 
            this.txtCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCat.BackColor = System.Drawing.Color.White;
            this.txtCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCat.Enabled = false;
            this.txtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCat.ForeColor = System.Drawing.Color.Silver;
            this.txtCat.Location = new System.Drawing.Point(265, 341);
            this.txtCat.MaxLength = 2;
            this.txtCat.Multiline = true;
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(230, 30);
            this.txtCat.TabIndex = 126;
            this.txtCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpUnitaire
            // 
            this.grpUnitaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUnitaire.Controls.Add(this.label3);
            this.grpUnitaire.Controls.Add(this.txtNumAna);
            this.grpUnitaire.Controls.Add(this.txtInventaireProd);
            this.grpUnitaire.Controls.Add(this.txtTyp);
            this.grpUnitaire.Controls.Add(this.label13);
            this.grpUnitaire.Controls.Add(this.txtCat);
            this.grpUnitaire.Controls.Add(this.txtNomP);
            this.grpUnitaire.Controls.Add(this.label2);
            this.grpUnitaire.Controls.Add(this.label11);
            this.grpUnitaire.Controls.Add(this.txtStockAlerte);
            this.grpUnitaire.Controls.Add(this.label5);
            this.grpUnitaire.Controls.Add(this.label1);
            this.grpUnitaire.Controls.Add(this.label14);
            this.grpUnitaire.Controls.Add(this.txtPrix);
            this.grpUnitaire.Controls.Add(this.txtTarifAchat);
            this.grpUnitaire.Controls.Add(this.txtMarge);
            this.grpUnitaire.Controls.Add(this.label12);
            this.grpUnitaire.Controls.Add(this.txtDateCtrl);
            this.grpUnitaire.Controls.Add(this.label6);
            this.grpUnitaire.Controls.Add(this.label7);
            this.grpUnitaire.Controls.Add(this.label16);
            this.grpUnitaire.Controls.Add(this.txtPoids);
            this.grpUnitaire.Controls.Add(this.label10);
            this.grpUnitaire.Controls.Add(this.label15);
            this.grpUnitaire.Controls.Add(this.picProduit);
            this.grpUnitaire.Controls.Add(this.txtNumSerie);
            this.grpUnitaire.Location = new System.Drawing.Point(933, 52);
            this.grpUnitaire.Name = "grpUnitaire";
            this.grpUnitaire.Size = new System.Drawing.Size(514, 792);
            this.grpUnitaire.TabIndex = 128;
            this.grpUnitaire.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(262, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 129;
            this.label3.Text = "Numero analytique";
            // 
            // txtNumAna
            // 
            this.txtNumAna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumAna.BackColor = System.Drawing.Color.White;
            this.txtNumAna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumAna.Enabled = false;
            this.txtNumAna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAna.ForeColor = System.Drawing.Color.Silver;
            this.txtNumAna.Location = new System.Drawing.Point(265, 494);
            this.txtNumAna.Multiline = true;
            this.txtNumAna.Name = "txtNumAna";
            this.txtNumAna.Size = new System.Drawing.Size(230, 30);
            this.txtNumAna.TabIndex = 128;
            this.txtNumAna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.FillWeight = 85.27918F;
            this.Column5.HeaderText = "Catégorie";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 135;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.FillWeight = 85.27919F;
            this.Column6.HeaderText = "Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 135;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column10.FillWeight = 203.0457F;
            this.Column10.HeaderText = "Inventaire";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 135;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 85.27919F;
            this.Column2.HeaderText = "Désignation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 85.27919F;
            this.Column8.HeaderText = "Stock Alerte";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 85.27919F;
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.FillWeight = 85.27919F;
            this.Column7.HeaderText = "Contrôle";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Numero de serie";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Poids";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Marge";
            this.Column14.Name = "Column14";
            this.Column14.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Tarif achat";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.grpUnitaire);
            this.Controls.Add(this.btnSupCombo);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.combocategorie);
            this.Controls.Add(this.txtrechercheNom);
            this.Controls.Add(this.txtrechercheInvProd);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.dvgProduit);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnajouter);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1474, 865);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).EndInit();
            this.grpUnitaire.ResumeLayout(false);
            this.grpUnitaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtrechercheInvProd;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.TextBox txtrechercheNom;
        public System.Windows.Forms.ComboBox combocategorie;
        public System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Button btnSupCombo;
        public System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private GESTION_DE_STOCKDataSet1 gESTION_DE_STOCKDataSet1;
        private GESTION_DE_STOCKDataSet1TableAdapters.ProduitTableAdapter produitTableAdapter;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtInventaireProd;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtNomP;
        public System.Windows.Forms.TextBox txtDateCtrl;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtNumSerie;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtMarge;
        public System.Windows.Forms.TextBox txtTarifAchat;
        public System.Windows.Forms.TextBox txtPrix;
        public System.Windows.Forms.TextBox txtStockAlerte;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtPoids;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.PictureBox picProduit;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTyp;
        public System.Windows.Forms.TextBox txtCat;
        public System.Windows.Forms.GroupBox grpUnitaire;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNumAna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}
