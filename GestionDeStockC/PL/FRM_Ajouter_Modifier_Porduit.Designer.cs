
namespace GestionDeStockC.PL
{
    partial class FRM_Ajouter_Modifier_Porduit
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtNomP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.btnAjouterImage = new System.Windows.Forms.Button();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStockAlerte = new System.Windows.Forms.TextBox();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.txtInventaireProd = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.txtTarifAchat = new System.Windows.Forms.TextBox();
            this.txtMarge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDateCtrl = new System.Windows.Forms.TextBox();
            this.picProduit = new System.Windows.Forms.PictureBox();
            this.btnDate = new System.Windows.Forms.Button();
            this.grpUnitaire = new System.Windows.Forms.GroupBox();
            this.btnRetirerImage = new System.Windows.Forms.Button();
            this.grpNonUnitaire = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).BeginInit();
            this.grpUnitaire.SuspendLayout();
            this.grpNonUnitaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Black;
            this.lblTitre.Location = new System.Drawing.Point(14, 10);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(222, 33);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Ajouter Produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Image";
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.Color.White;
            this.txtPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.ForeColor = System.Drawing.Color.Black;
            this.txtPrix.Location = new System.Drawing.Point(319, 354);
            this.txtPrix.Multiline = true;
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(230, 30);
            this.txtPrix.TabIndex = 42;
            this.txtPrix.TextChanged += new System.EventHandler(this.txtPrix_TextChanged);
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrix_KeyPress);
            // 
            // txtNomP
            // 
            this.txtNomP.BackColor = System.Drawing.Color.White;
            this.txtNomP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomP.ForeColor = System.Drawing.Color.Black;
            this.txtNomP.Location = new System.Drawing.Point(319, 206);
            this.txtNomP.MaxLength = 30;
            this.txtNomP.Multiline = true;
            this.txtNomP.Name = "txtNomP";
            this.txtNomP.Size = new System.Drawing.Size(230, 30);
            this.txtNomP.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(315, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Categorie *";
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnenregistrer.ForeColor = System.Drawing.Color.White;
            this.btnenregistrer.Location = new System.Drawing.Point(589, 417);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(230, 37);
            this.btnenregistrer.TabIndex = 46;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // btnAjouterImage
            // 
            this.btnAjouterImage.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAjouterImage.FlatAppearance.BorderSize = 0;
            this.btnAjouterImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAjouterImage.ForeColor = System.Drawing.Color.White;
            this.btnAjouterImage.Location = new System.Drawing.Point(20, 424);
            this.btnAjouterImage.Name = "btnAjouterImage";
            this.btnAjouterImage.Size = new System.Drawing.Size(125, 36);
            this.btnAjouterImage.TabIndex = 47;
            this.btnAjouterImage.Text = "Ajouter";
            this.btnAjouterImage.UseVisualStyleBackColor = false;
            this.btnAjouterImage.Click += new System.EventHandler(this.btnAjouterImage_Click);
            // 
            // combocategorie
            // 
            this.combocategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocategorie.FormattingEnabled = true;
            this.combocategorie.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
            this.combocategorie.Location = new System.Drawing.Point(319, 60);
            this.combocategorie.Name = "combocategorie";
            this.combocategorie.Size = new System.Drawing.Size(232, 33);
            this.combocategorie.TabIndex = 48;
            // 
            // combotype
            // 
            this.combotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
            this.combotype.Location = new System.Drawing.Point(319, 133);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(232, 33);
            this.combotype.TabIndex = 51;
            this.combotype.SelectionChangeCommitted += new System.EventHandler(this.combotype_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(315, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Type *";
            // 
            // txtStockAlerte
            // 
            this.txtStockAlerte.BackColor = System.Drawing.Color.White;
            this.txtStockAlerte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAlerte.ForeColor = System.Drawing.Color.Black;
            this.txtStockAlerte.Location = new System.Drawing.Point(11, 36);
            this.txtStockAlerte.Multiline = true;
            this.txtStockAlerte.Name = "txtStockAlerte";
            this.txtStockAlerte.Size = new System.Drawing.Size(230, 30);
            this.txtStockAlerte.TabIndex = 53;
            this.txtStockAlerte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockAlerte_KeyPress);
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Location = new System.Drawing.Point(54, 24);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(139, 17);
            this.checkDate.TabIndex = 54;
            this.checkDate.Text = "Ajouter date de controle";
            this.checkDate.UseVisualStyleBackColor = true;
            this.checkDate.Click += new System.EventHandler(this.checkDate_Click);
            // 
            // txtInventaireProd
            // 
            this.txtInventaireProd.BackColor = System.Drawing.Color.White;
            this.txtInventaireProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInventaireProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventaireProd.ForeColor = System.Drawing.Color.Black;
            this.txtInventaireProd.Location = new System.Drawing.Point(20, 89);
            this.txtInventaireProd.MaxLength = 9;
            this.txtInventaireProd.Multiline = true;
            this.txtInventaireProd.Name = "txtInventaireProd";
            this.txtInventaireProd.Size = new System.Drawing.Size(262, 28);
            this.txtInventaireProd.TabIndex = 55;
            this.txtInventaireProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.BackColor = System.Drawing.Color.White;
            this.txtNumSerie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.ForeColor = System.Drawing.Color.Black;
            this.txtNumSerie.Location = new System.Drawing.Point(6, 177);
            this.txtNumSerie.Multiline = true;
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(230, 30);
            this.txtNumSerie.TabIndex = 56;
            // 
            // txtPoids
            // 
            this.txtPoids.BackColor = System.Drawing.Color.White;
            this.txtPoids.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoids.ForeColor = System.Drawing.Color.Black;
            this.txtPoids.Location = new System.Drawing.Point(583, 354);
            this.txtPoids.Multiline = true;
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(230, 30);
            this.txtPoids.TabIndex = 57;
            this.txtPoids.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoids_KeyPress);
            // 
            // txtTarifAchat
            // 
            this.txtTarifAchat.BackColor = System.Drawing.Color.White;
            this.txtTarifAchat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTarifAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarifAchat.ForeColor = System.Drawing.Color.Black;
            this.txtTarifAchat.Location = new System.Drawing.Point(317, 284);
            this.txtTarifAchat.Multiline = true;
            this.txtTarifAchat.Name = "txtTarifAchat";
            this.txtTarifAchat.Size = new System.Drawing.Size(230, 30);
            this.txtTarifAchat.TabIndex = 58;
            this.txtTarifAchat.TextChanged += new System.EventHandler(this.txtTarifAchat_TextChanged);
            this.txtTarifAchat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarifAchat_KeyPress);
            // 
            // txtMarge
            // 
            this.txtMarge.BackColor = System.Drawing.Color.White;
            this.txtMarge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarge.Enabled = false;
            this.txtMarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarge.ForeColor = System.Drawing.Color.Black;
            this.txtMarge.Location = new System.Drawing.Point(317, 424);
            this.txtMarge.MaxLength = 2;
            this.txtMarge.Multiline = true;
            this.txtMarge.Name = "txtMarge";
            this.txtMarge.Size = new System.Drawing.Size(230, 30);
            this.txtMarge.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(315, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 61;
            this.label4.Text = "Prix de vente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(313, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "Marge en %";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 64;
            this.label6.Text = "Stock alerte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(315, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 63;
            this.label7.Text = "Tarif achat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(579, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "Poids en kg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(0, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 24);
            this.label10.TabIndex = 68;
            this.label10.Text = "Numero de serie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(315, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 24);
            this.label11.TabIndex = 67;
            this.label11.Text = "Nom produit *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(710, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "* : champs obligatoires";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(16, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 24);
            this.label13.TabIndex = 70;
            this.label13.Text = "Numero Inventaire *";
            // 
            // txtDateCtrl
            // 
            this.txtDateCtrl.BackColor = System.Drawing.Color.White;
            this.txtDateCtrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateCtrl.Enabled = false;
            this.txtDateCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCtrl.ForeColor = System.Drawing.Color.Black;
            this.txtDateCtrl.Location = new System.Drawing.Point(6, 107);
            this.txtDateCtrl.Multiline = true;
            this.txtDateCtrl.Name = "txtDateCtrl";
            this.txtDateCtrl.Size = new System.Drawing.Size(230, 30);
            this.txtDateCtrl.TabIndex = 71;
            this.txtDateCtrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateCtrl.Visible = false;
            // 
            // picProduit
            // 
            this.picProduit.BackColor = System.Drawing.Color.White;
            this.picProduit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProduit.Location = new System.Drawing.Point(20, 159);
            this.picProduit.Name = "picProduit";
            this.picProduit.Size = new System.Drawing.Size(262, 257);
            this.picProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduit.TabIndex = 7;
            this.picProduit.TabStop = false;
            this.picProduit.Tag = "";
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDate.FlatAppearance.BorderSize = 0;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDate.ForeColor = System.Drawing.Color.White;
            this.btnDate.Location = new System.Drawing.Point(6, 52);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(230, 36);
            this.btnDate.TabIndex = 72;
            this.btnDate.Text = "Select Date";
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Visible = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // grpUnitaire
            // 
            this.grpUnitaire.Controls.Add(this.btnDate);
            this.grpUnitaire.Controls.Add(this.checkDate);
            this.grpUnitaire.Controls.Add(this.txtDateCtrl);
            this.grpUnitaire.Controls.Add(this.label10);
            this.grpUnitaire.Controls.Add(this.txtNumSerie);
            this.grpUnitaire.Location = new System.Drawing.Point(572, 28);
            this.grpUnitaire.Name = "grpUnitaire";
            this.grpUnitaire.Size = new System.Drawing.Size(247, 220);
            this.grpUnitaire.TabIndex = 73;
            this.grpUnitaire.TabStop = false;
            // 
            // btnRetirerImage
            // 
            this.btnRetirerImage.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRetirerImage.FlatAppearance.BorderSize = 0;
            this.btnRetirerImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirerImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnRetirerImage.ForeColor = System.Drawing.Color.White;
            this.btnRetirerImage.Location = new System.Drawing.Point(157, 424);
            this.btnRetirerImage.Name = "btnRetirerImage";
            this.btnRetirerImage.Size = new System.Drawing.Size(125, 36);
            this.btnRetirerImage.TabIndex = 74;
            this.btnRetirerImage.Text = "Supprimer";
            this.btnRetirerImage.UseVisualStyleBackColor = false;
            this.btnRetirerImage.Click += new System.EventHandler(this.btnRetirerImage_Click);
            // 
            // grpNonUnitaire
            // 
            this.grpNonUnitaire.Controls.Add(this.txtStockAlerte);
            this.grpNonUnitaire.Controls.Add(this.label6);
            this.grpNonUnitaire.Location = new System.Drawing.Point(571, 248);
            this.grpNonUnitaire.Name = "grpNonUnitaire";
            this.grpNonUnitaire.Size = new System.Drawing.Size(247, 75);
            this.grpNonUnitaire.TabIndex = 74;
            this.grpNonUnitaire.TabStop = false;
            // 
            // FRM_Ajouter_Modifier_Porduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(845, 486);
            this.Controls.Add(this.grpNonUnitaire);
            this.Controls.Add(this.btnRetirerImage);
            this.Controls.Add(this.grpUnitaire);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarge);
            this.Controls.Add(this.txtTarifAchat);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.txtInventaireProd);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combocategorie);
            this.Controls.Add(this.btnAjouterImage);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtNomP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picProduit);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Ajouter_Modifier_Porduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).EndInit();
            this.grpUnitaire.ResumeLayout(false);
            this.grpUnitaire.PerformLayout();
            this.grpNonUnitaire.ResumeLayout(false);
            this.grpNonUnitaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitre;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPrix;
        public System.Windows.Forms.TextBox txtNomP;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenregistrer;
        public System.Windows.Forms.Button btnAjouterImage;
        public System.Windows.Forms.PictureBox picProduit;
        public System.Windows.Forms.ComboBox combotype;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox combocategorie;
        public System.Windows.Forms.TextBox txtStockAlerte;
        public System.Windows.Forms.TextBox txtInventaireProd;
        public System.Windows.Forms.CheckBox checkDate;
        public System.Windows.Forms.TextBox txtNumSerie;
        public System.Windows.Forms.TextBox txtPoids;
        public System.Windows.Forms.TextBox txtTarifAchat;
        public System.Windows.Forms.TextBox txtMarge;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtDateCtrl;
        public System.Windows.Forms.Button btnDate;
        public System.Windows.Forms.GroupBox grpUnitaire;
        public System.Windows.Forms.Button btnRetirerImage;
        public System.Windows.Forms.GroupBox grpNonUnitaire;
    }
}