
namespace GestionDeStockC.PL
{
    partial class FRM_Detail_Commande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Detail_Commande));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDest = new System.Windows.Forms.Button();
            this.txtNomDest = new System.Windows.Forms.TextBox();
            this.txtPrenomDest = new System.Windows.Forms.TextBox();
            this.txttotalht = new System.Windows.Forms.TextBox();
            this.txttva = new System.Windows.Forms.TextBox();
            this.txttotalttc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupCombo = new System.Windows.Forms.Button();
            this.txtrechercheNom = new System.Windows.Forms.TextBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.txtrechercheInvProd = new System.Windows.Forms.TextBox();
            this.commandedate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvgDetailCommande = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExp = new System.Windows.Forms.Button();
            this.txtPrenomExp = new System.Windows.Forms.TextBox();
            this.txtNomExp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailCommande)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::GestionDeStockC.Properties.Resources.Deconnecte;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.Black;
            this.btnenregistrer.Location = new System.Drawing.Point(1253, 8);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(133, 65);
            this.btnenregistrer.TabIndex = 47;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nom :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "Date Commande";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(363, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 24);
            this.label9.TabIndex = 57;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 24);
            this.label10.TabIndex = 57;
            this.label10.Text = "Total HT :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(213, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 24);
            this.label11.TabIndex = 58;
            this.label11.Text = "TVA :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(413, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 24);
            this.label12.TabIndex = 59;
            this.label12.Text = "Total TTC :";
            // 
            // btnDest
            // 
            this.btnDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDest.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDest.FlatAppearance.BorderSize = 0;
            this.btnDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDest.Location = new System.Drawing.Point(9, 23);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(53, 32);
            this.btnDest.TabIndex = 60;
            this.btnDest.Text = "...";
            this.btnDest.UseVisualStyleBackColor = false;
            this.btnDest.Click += new System.EventHandler(this.btnDst_Click);
            // 
            // txtNomDest
            // 
            this.txtNomDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomDest.BackColor = System.Drawing.Color.White;
            this.txtNomDest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomDest.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtNomDest.Enabled = false;
            this.txtNomDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomDest.ForeColor = System.Drawing.Color.Black;
            this.txtNomDest.Location = new System.Drawing.Point(143, 23);
            this.txtNomDest.Multiline = true;
            this.txtNomDest.Name = "txtNomDest";
            this.txtNomDest.Size = new System.Drawing.Size(119, 32);
            this.txtNomDest.TabIndex = 61;
            // 
            // txtPrenomDest
            // 
            this.txtPrenomDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenomDest.BackColor = System.Drawing.Color.White;
            this.txtPrenomDest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenomDest.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtPrenomDest.Enabled = false;
            this.txtPrenomDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomDest.ForeColor = System.Drawing.Color.Black;
            this.txtPrenomDest.Location = new System.Drawing.Point(268, 23);
            this.txtPrenomDest.Multiline = true;
            this.txtPrenomDest.Name = "txtPrenomDest";
            this.txtPrenomDest.Size = new System.Drawing.Size(106, 32);
            this.txtPrenomDest.TabIndex = 62;
            // 
            // txttotalht
            // 
            this.txttotalht.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalht.BackColor = System.Drawing.Color.White;
            this.txttotalht.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotalht.Cursor = System.Windows.Forms.Cursors.Help;
            this.txttotalht.Enabled = false;
            this.txttotalht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalht.ForeColor = System.Drawing.Color.Black;
            this.txttotalht.Location = new System.Drawing.Point(125, 19);
            this.txttotalht.Multiline = true;
            this.txttotalht.Name = "txttotalht";
            this.txttotalht.Size = new System.Drawing.Size(0, 32);
            this.txttotalht.TabIndex = 67;
            // 
            // txttva
            // 
            this.txttva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttva.BackColor = System.Drawing.Color.White;
            this.txttva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttva.Cursor = System.Windows.Forms.Cursors.Help;
            this.txttva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttva.ForeColor = System.Drawing.Color.Black;
            this.txttva.Location = new System.Drawing.Point(282, 19);
            this.txttva.Multiline = true;
            this.txttva.Name = "txttva";
            this.txttva.Size = new System.Drawing.Size(0, 32);
            this.txttva.TabIndex = 68;
            this.txttva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttva.TextChanged += new System.EventHandler(this.txttva_TextChanged);
            // 
            // txttotalttc
            // 
            this.txttotalttc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalttc.BackColor = System.Drawing.Color.White;
            this.txttotalttc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotalttc.Cursor = System.Windows.Forms.Cursors.Help;
            this.txttotalttc.Enabled = false;
            this.txttotalttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalttc.ForeColor = System.Drawing.Color.Black;
            this.txttotalttc.Location = new System.Drawing.Point(533, 16);
            this.txttotalttc.Multiline = true;
            this.txttotalttc.Name = "txttotalttc";
            this.txttotalttc.Size = new System.Drawing.Size(0, 32);
            this.txttotalttc.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dvgProduit);
            this.groupBox1.Controls.Add(this.btnSupCombo);
            this.groupBox1.Controls.Add(this.txtrechercheNom);
            this.groupBox1.Controls.Add(this.combotype);
            this.groupBox1.Controls.Add(this.combocategorie);
            this.groupBox1.Controls.Add(this.txtrechercheInvProd);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 704);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produit";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column10,
            this.Column2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProduit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgProduit.EnableHeadersVisualStyles = false;
            this.dvgProduit.Location = new System.Drawing.Point(6, 61);
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
            this.dvgProduit.Size = new System.Drawing.Size(856, 637);
            this.dvgProduit.TabIndex = 65;
            this.dvgProduit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProduit_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
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
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Contrôle";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
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
            this.btnSupCombo.Location = new System.Drawing.Point(609, 17);
            this.btnSupCombo.Name = "btnSupCombo";
            this.btnSupCombo.Size = new System.Drawing.Size(36, 32);
            this.btnSupCombo.TabIndex = 64;
            this.btnSupCombo.UseVisualStyleBackColor = false;
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
            // 
            // commandedate
            // 
            this.commandedate.Enabled = false;
            this.commandedate.Location = new System.Drawing.Point(12, 35);
            this.commandedate.Name = "commandedate";
            this.commandedate.Size = new System.Drawing.Size(200, 20);
            this.commandedate.TabIndex = 72;
            this.commandedate.Value = new System.DateTime(2021, 5, 22, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dvgDetailCommande);
            this.groupBox2.Controls.Add(this.txttotalttc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txttva);
            this.groupBox2.Controls.Add(this.txttotalht);
            this.groupBox2.Location = new System.Drawing.Point(886, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 704);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail";
            // 
            // dvgDetailCommande
            // 
            this.dvgDetailCommande.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgDetailCommande.AllowUserToAddRows = false;
            this.dvgDetailCommande.AllowUserToDeleteRows = false;
            this.dvgDetailCommande.AllowUserToResizeRows = false;
            this.dvgDetailCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDetailCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDetailCommande.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dvgDetailCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgDetailCommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDetailCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgDetailCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetailCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.Column4});
            this.dvgDetailCommande.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDetailCommande.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgDetailCommande.EnableHeadersVisualStyles = false;
            this.dvgDetailCommande.Location = new System.Drawing.Point(6, 61);
            this.dvgDetailCommande.MultiSelect = false;
            this.dvgDetailCommande.Name = "dvgDetailCommande";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDetailCommande.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgDetailCommande.RowHeadersVisible = false;
            this.dvgDetailCommande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgDetailCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDetailCommande.Size = new System.Drawing.Size(494, 637);
            this.dvgDetailCommande.TabIndex = 66;
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
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Remise";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // btnExp
            // 
            this.btnExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExp.FlatAppearance.BorderSize = 0;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExp.Location = new System.Drawing.Point(10, 28);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(53, 31);
            this.btnExp.TabIndex = 73;
            this.btnExp.Text = "...";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // txtPrenomExp
            // 
            this.txtPrenomExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenomExp.BackColor = System.Drawing.Color.White;
            this.txtPrenomExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenomExp.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtPrenomExp.Enabled = false;
            this.txtPrenomExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomExp.ForeColor = System.Drawing.Color.Black;
            this.txtPrenomExp.Location = new System.Drawing.Point(268, 28);
            this.txtPrenomExp.Multiline = true;
            this.txtPrenomExp.Name = "txtPrenomExp";
            this.txtPrenomExp.Size = new System.Drawing.Size(106, 32);
            this.txtPrenomExp.TabIndex = 77;
            // 
            // txtNomExp
            // 
            this.txtNomExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomExp.BackColor = System.Drawing.Color.White;
            this.txtNomExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomExp.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtNomExp.Enabled = false;
            this.txtNomExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomExp.ForeColor = System.Drawing.Color.Black;
            this.txtNomExp.Location = new System.Drawing.Point(144, 28);
            this.txtNomExp.Multiline = true;
            this.txtNomExp.Name = "txtNomExp";
            this.txtNomExp.Size = new System.Drawing.Size(119, 32);
            this.txtNomExp.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(72, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "Nom :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrenomDest);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnDest);
            this.groupBox3.Controls.Add(this.txtNomDest);
            this.groupBox3.Location = new System.Drawing.Point(855, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 68);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destinataire";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExp);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtPrenomExp);
            this.groupBox4.Controls.Add(this.txtNomExp);
            this.groupBox4.Location = new System.Drawing.Point(469, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 68);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Expediteur";
            // 
            // FRM_Detail_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1404, 795);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.commandedate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRM_Detail_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Detail_Commande";
            this.Load += new System.EventHandler(this.FRM_Detail_Commande_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailCommande)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnenregistrer;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDest;
        public System.Windows.Forms.TextBox txtNomDest;
        public System.Windows.Forms.TextBox txtPrenomDest;
        public System.Windows.Forms.TextBox txttotalht;
        public System.Windows.Forms.TextBox txttva;
        public System.Windows.Forms.TextBox txttotalttc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker commandedate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExp;
        public System.Windows.Forms.TextBox txtPrenomExp;
        public System.Windows.Forms.TextBox txtNomExp;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox combotype;
        public System.Windows.Forms.ComboBox combocategorie;
        private System.Windows.Forms.TextBox txtrechercheInvProd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtrechercheNom;
        private System.Windows.Forms.Button btnSupCombo;
        private System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView dvgDetailCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}