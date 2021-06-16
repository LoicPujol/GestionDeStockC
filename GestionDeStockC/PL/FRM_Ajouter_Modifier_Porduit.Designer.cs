
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
            this.picProduit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtNomP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.btnactualiser = new System.Windows.Forms.Button();
            this.btnparcourir = new System.Windows.Forms.Button();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCtrl = new System.Windows.Forms.DateTimePicker();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).BeginInit();
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
            // picProduit
            // 
            this.picProduit.BackColor = System.Drawing.Color.White;
            this.picProduit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProduit.Location = new System.Drawing.Point(20, 159);
            this.picProduit.Name = "picProduit";
            this.picProduit.Size = new System.Drawing.Size(262, 280);
            this.picProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduit.TabIndex = 7;
            this.picProduit.TabStop = false;
            this.picProduit.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Image";
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.Color.White;
            this.txtPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.ForeColor = System.Drawing.Color.Silver;
            this.txtPrix.Location = new System.Drawing.Point(319, 409);
            this.txtPrix.Multiline = true;
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(230, 30);
            this.txtPrix.TabIndex = 42;
            this.txtPrix.Text = "Prix";
            this.txtPrix.Enter += new System.EventHandler(this.txtPrix_Enter);
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrix_KeyPress);
            this.txtPrix.Leave += new System.EventHandler(this.txtPrix_Leave);
            // 
            // txtQuantite
            // 
            this.txtQuantite.BackColor = System.Drawing.Color.White;
            this.txtQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantite.ForeColor = System.Drawing.Color.Silver;
            this.txtQuantite.Location = new System.Drawing.Point(317, 279);
            this.txtQuantite.Multiline = true;
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(230, 30);
            this.txtQuantite.TabIndex = 40;
            this.txtQuantite.Text = "Quantite";
            this.txtQuantite.Enter += new System.EventHandler(this.txtQuantite_Enter);
            this.txtQuantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantite_KeyPress);
            this.txtQuantite.Leave += new System.EventHandler(this.txtQuantite_Leave);
            // 
            // txtNomP
            // 
            this.txtNomP.BackColor = System.Drawing.Color.White;
            this.txtNomP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomP.ForeColor = System.Drawing.Color.Silver;
            this.txtNomP.Location = new System.Drawing.Point(319, 208);
            this.txtNomP.Multiline = true;
            this.txtNomP.Name = "txtNomP";
            this.txtNomP.Size = new System.Drawing.Size(230, 30);
            this.txtNomP.TabIndex = 38;
            this.txtNomP.Text = "Nom Produit";
            this.txtNomP.Enter += new System.EventHandler(this.txtNomP_Enter);
            this.txtNomP.Leave += new System.EventHandler(this.txtNomP_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(315, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
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
            this.btnenregistrer.Location = new System.Drawing.Point(584, 454);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(230, 36);
            this.btnenregistrer.TabIndex = 46;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // btnactualiser
            // 
            this.btnactualiser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnactualiser.FlatAppearance.BorderSize = 0;
            this.btnactualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnactualiser.ForeColor = System.Drawing.Color.White;
            this.btnactualiser.Location = new System.Drawing.Point(317, 454);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(230, 36);
            this.btnactualiser.TabIndex = 45;
            this.btnactualiser.Text = "Vider tout les champs";
            this.btnactualiser.UseVisualStyleBackColor = false;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // btnparcourir
            // 
            this.btnparcourir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnparcourir.FlatAppearance.BorderSize = 0;
            this.btnparcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparcourir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnparcourir.ForeColor = System.Drawing.Color.White;
            this.btnparcourir.Location = new System.Drawing.Point(20, 454);
            this.btnparcourir.Name = "btnparcourir";
            this.btnparcourir.Size = new System.Drawing.Size(262, 36);
            this.btnparcourir.TabIndex = 47;
            this.btnparcourir.Text = "Parcourir";
            this.btnparcourir.UseVisualStyleBackColor = false;
            this.btnparcourir.Click += new System.EventHandler(this.btnparcourir_Click);
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
            this.combocategorie.Location = new System.Drawing.Point(319, 55);
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
            this.combotype.Location = new System.Drawing.Point(319, 129);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(232, 33);
            this.combotype.TabIndex = 51;
            this.combotype.SelectionChangeCommitted += new System.EventHandler(this.combotype_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(315, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Type *";
            // 
            // dateCtrl
            // 
            this.dateCtrl.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCtrl.CustomFormat = "dd/MM/yyyy";
            this.dateCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCtrl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCtrl.Location = new System.Drawing.Point(586, 129);
            this.dateCtrl.Name = "dateCtrl";
            this.dateCtrl.Size = new System.Drawing.Size(127, 29);
            this.dateCtrl.TabIndex = 52;
            // 
            // txtStockAlerte
            // 
            this.txtStockAlerte.BackColor = System.Drawing.Color.White;
            this.txtStockAlerte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAlerte.ForeColor = System.Drawing.Color.Silver;
            this.txtStockAlerte.Location = new System.Drawing.Point(584, 344);
            this.txtStockAlerte.Multiline = true;
            this.txtStockAlerte.Name = "txtStockAlerte";
            this.txtStockAlerte.Size = new System.Drawing.Size(230, 30);
            this.txtStockAlerte.TabIndex = 53;
            this.txtStockAlerte.Text = "Stock Alerte";
            this.txtStockAlerte.Enter += new System.EventHandler(this.txtStockAlerte_Enter);
            this.txtStockAlerte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockAlerte_KeyPress);
            this.txtStockAlerte.Leave += new System.EventHandler(this.txtStockAlerte_Leave);
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Location = new System.Drawing.Point(586, 89);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(139, 17);
            this.checkDate.TabIndex = 54;
            this.checkDate.Text = "Ajouter date de controle";
            this.checkDate.UseVisualStyleBackColor = true;
            this.checkDate.Visible = false;
            this.checkDate.Click += new System.EventHandler(this.checkDate_Click);
            // 
            // txtInventaireProd
            // 
            this.txtInventaireProd.BackColor = System.Drawing.Color.White;
            this.txtInventaireProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInventaireProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventaireProd.ForeColor = System.Drawing.Color.Silver;
            this.txtInventaireProd.Location = new System.Drawing.Point(20, 89);
            this.txtInventaireProd.Multiline = true;
            this.txtInventaireProd.Name = "txtInventaireProd";
            this.txtInventaireProd.Size = new System.Drawing.Size(262, 28);
            this.txtInventaireProd.TabIndex = 55;
            this.txtInventaireProd.Text = "N° Inventaire";
            this.txtInventaireProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInventaireProd.Enter += new System.EventHandler(this.txtInventaireProd_Enter);
            this.txtInventaireProd.Leave += new System.EventHandler(this.txtInventaireProd_Leave);
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.BackColor = System.Drawing.Color.White;
            this.txtNumSerie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.ForeColor = System.Drawing.Color.Silver;
            this.txtNumSerie.Location = new System.Drawing.Point(586, 208);
            this.txtNumSerie.Multiline = true;
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(230, 30);
            this.txtNumSerie.TabIndex = 56;
            this.txtNumSerie.Text = "Numero de serie";
            // 
            // txtPoids
            // 
            this.txtPoids.BackColor = System.Drawing.Color.White;
            this.txtPoids.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoids.ForeColor = System.Drawing.Color.Silver;
            this.txtPoids.Location = new System.Drawing.Point(584, 279);
            this.txtPoids.Multiline = true;
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(230, 30);
            this.txtPoids.TabIndex = 57;
            this.txtPoids.Text = "Poids en kilogramme";
            // 
            // txtTarifAchat
            // 
            this.txtTarifAchat.BackColor = System.Drawing.Color.White;
            this.txtTarifAchat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTarifAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarifAchat.ForeColor = System.Drawing.Color.Silver;
            this.txtTarifAchat.Location = new System.Drawing.Point(317, 344);
            this.txtTarifAchat.Multiline = true;
            this.txtTarifAchat.Name = "txtTarifAchat";
            this.txtTarifAchat.Size = new System.Drawing.Size(230, 30);
            this.txtTarifAchat.TabIndex = 58;
            this.txtTarifAchat.Text = "Tarif achat";
            // 
            // txtMarge
            // 
            this.txtMarge.BackColor = System.Drawing.Color.White;
            this.txtMarge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarge.ForeColor = System.Drawing.Color.Silver;
            this.txtMarge.Location = new System.Drawing.Point(584, 409);
            this.txtMarge.Multiline = true;
            this.txtMarge.Name = "txtMarge";
            this.txtMarge.Size = new System.Drawing.Size(230, 30);
            this.txtMarge.TabIndex = 59;
            this.txtMarge.Text = "Marge en %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(315, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 61;
            this.label4.Text = "Prix de vente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(580, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "Marge en %";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(580, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 64;
            this.label6.Text = "Stock alerte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(315, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 63;
            this.label7.Text = "Tarif achat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(580, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "Poids en kg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(315, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 24);
            this.label9.TabIndex = 65;
            this.label9.Text = "Quantite stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(580, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 24);
            this.label10.TabIndex = 68;
            this.label10.Text = "Numero de serie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(315, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 24);
            this.label11.TabIndex = 67;
            this.label11.Text = "Nom produit *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(698, 501);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "* : champs obligatoires";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(16, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 24);
            this.label13.TabIndex = 70;
            this.label13.Text = "Numero Inventaire *";
            // 
            // FRM_Ajouter_Modifier_Porduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(842, 523);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarge);
            this.Controls.Add(this.txtTarifAchat);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.txtInventaireProd);
            this.Controls.Add(this.checkDate);
            this.Controls.Add(this.txtStockAlerte);
            this.Controls.Add(this.dateCtrl);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combocategorie);
            this.Controls.Add(this.btnparcourir);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btnactualiser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtNomP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picProduit);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Ajouter_Modifier_Porduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ajouter_Modifier_Porduit";
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitre;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPrix;
        public System.Windows.Forms.TextBox txtQuantite;
        public System.Windows.Forms.TextBox txtNomP;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenregistrer;
        public System.Windows.Forms.Button btnactualiser;
        public System.Windows.Forms.Button btnparcourir;
        public System.Windows.Forms.PictureBox picProduit;
        public System.Windows.Forms.ComboBox combotype;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox combocategorie;
        public System.Windows.Forms.DateTimePicker dateCtrl;
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
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
    }
}