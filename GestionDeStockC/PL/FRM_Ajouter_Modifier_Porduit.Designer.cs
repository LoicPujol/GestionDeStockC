
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
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtNomP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.btnactualiser = new System.Windows.Forms.Button();
            this.btnparcourir = new System.Windows.Forms.Button();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.btnquitter = new System.Windows.Forms.Button();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCtrl = new System.Windows.Forms.DateTimePicker();
            this.txtStockAlerte = new System.Windows.Forms.TextBox();
            this.checkDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Black;
            this.lblTitre.Location = new System.Drawing.Point(25, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(222, 33);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Ajouter Produit";
            // 
            // picProduit
            // 
            this.picProduit.BackColor = System.Drawing.Color.White;
            this.picProduit.Location = new System.Drawing.Point(31, 144);
            this.picProduit.Name = "picProduit";
            this.picProduit.Size = new System.Drawing.Size(236, 143);
            this.picProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduit.TabIndex = 7;
            this.picProduit.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Image";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GestionDeStockC.Properties.Resources.prix_32;
            this.pictureBox7.Location = new System.Drawing.Point(342, 355);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 36);
            this.pictureBox7.TabIndex = 43;
            this.pictureBox7.TabStop = false;
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.Color.White;
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrix.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.ForeColor = System.Drawing.Color.Silver;
            this.txtPrix.Location = new System.Drawing.Point(384, 355);
            this.txtPrix.Multiline = true;
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(230, 36);
            this.txtPrix.TabIndex = 42;
            this.txtPrix.Text = "Prix";
            this.txtPrix.Enter += new System.EventHandler(this.txtPrix_Enter);
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrix_KeyPress);
            this.txtPrix.Leave += new System.EventHandler(this.txtPrix_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GestionDeStockC.Properties.Resources.Quantie_32;
            this.pictureBox4.Location = new System.Drawing.Point(344, 251);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 36);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // txtQuantite
            // 
            this.txtQuantite.BackColor = System.Drawing.Color.White;
            this.txtQuantite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantite.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantite.ForeColor = System.Drawing.Color.Silver;
            this.txtQuantite.Location = new System.Drawing.Point(386, 251);
            this.txtQuantite.Multiline = true;
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(230, 36);
            this.txtQuantite.TabIndex = 40;
            this.txtQuantite.Text = "Quantite";
            this.txtQuantite.Enter += new System.EventHandler(this.txtQuantite_Enter);
            this.txtQuantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantite_KeyPress);
            this.txtQuantite.Leave += new System.EventHandler(this.txtQuantite_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestionDeStockC.Properties.Resources.product_32;
            this.pictureBox3.Location = new System.Drawing.Point(344, 196);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // txtNomP
            // 
            this.txtNomP.BackColor = System.Drawing.Color.White;
            this.txtNomP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomP.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtNomP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomP.ForeColor = System.Drawing.Color.Silver;
            this.txtNomP.Location = new System.Drawing.Point(384, 196);
            this.txtNomP.Multiline = true;
            this.txtNomP.Name = "txtNomP";
            this.txtNomP.Size = new System.Drawing.Size(230, 36);
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
            this.label2.Location = new System.Drawing.Point(439, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Categorie";
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.Gray;
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.Black;
            this.btnenregistrer.Location = new System.Drawing.Point(344, 433);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(230, 39);
            this.btnenregistrer.TabIndex = 46;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // btnactualiser
            // 
            this.btnactualiser.BackColor = System.Drawing.Color.Gray;
            this.btnactualiser.FlatAppearance.BorderSize = 0;
            this.btnactualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiser.ForeColor = System.Drawing.Color.Black;
            this.btnactualiser.Location = new System.Drawing.Point(37, 433);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(230, 39);
            this.btnactualiser.TabIndex = 45;
            this.btnactualiser.Text = "Actualiser";
            this.btnactualiser.UseVisualStyleBackColor = false;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // btnparcourir
            // 
            this.btnparcourir.BackColor = System.Drawing.Color.Gray;
            this.btnparcourir.FlatAppearance.BorderSize = 0;
            this.btnparcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparcourir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparcourir.ForeColor = System.Drawing.Color.Black;
            this.btnparcourir.Location = new System.Drawing.Point(37, 309);
            this.btnparcourir.Name = "btnparcourir";
            this.btnparcourir.Size = new System.Drawing.Size(230, 36);
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
            this.combocategorie.Location = new System.Drawing.Point(346, 73);
            this.combocategorie.Name = "combocategorie";
            this.combocategorie.Size = new System.Drawing.Size(270, 33);
            this.combocategorie.TabIndex = 48;
            // 
            // btnquitter
            // 
            this.btnquitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = global::GestionDeStockC.Properties.Resources.Button_Delete_icon;
            this.btnquitter.Location = new System.Drawing.Point(1078, 3);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(36, 36);
            this.btnquitter.TabIndex = 49;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
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
            this.combotype.Location = new System.Drawing.Point(346, 147);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(270, 33);
            this.combotype.TabIndex = 51;
            this.combotype.SelectionChangeCommitted += new System.EventHandler(this.combotype_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(454, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Type";
            // 
            // dateCtrl
            // 
            this.dateCtrl.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCtrl.CustomFormat = "dd-MM-yyyy";
            this.dateCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCtrl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCtrl.Location = new System.Drawing.Point(649, 181);
            this.dateCtrl.Name = "dateCtrl";
            this.dateCtrl.Size = new System.Drawing.Size(127, 29);
            this.dateCtrl.TabIndex = 52;
            this.dateCtrl.Visible = false;
            // 
            // txtStockAlerte
            // 
            this.txtStockAlerte.BackColor = System.Drawing.Color.White;
            this.txtStockAlerte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockAlerte.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtStockAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAlerte.ForeColor = System.Drawing.Color.Silver;
            this.txtStockAlerte.Location = new System.Drawing.Point(384, 309);
            this.txtStockAlerte.Multiline = true;
            this.txtStockAlerte.Name = "txtStockAlerte";
            this.txtStockAlerte.Size = new System.Drawing.Size(230, 36);
            this.txtStockAlerte.TabIndex = 53;
            this.txtStockAlerte.Text = "Stock Alerte";
            this.txtStockAlerte.Enter += new System.EventHandler(this.txtStockAlerte_Enter);
            this.txtStockAlerte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockAlerte_KeyPress);
            this.txtStockAlerte.Leave += new System.EventHandler(this.txtStockAlerte_Leave);
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Location = new System.Drawing.Point(637, 158);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(139, 17);
            this.checkDate.TabIndex = 54;
            this.checkDate.Text = "Ajouter date de controle";
            this.checkDate.UseVisualStyleBackColor = true;
            this.checkDate.Visible = false;
            this.checkDate.Click += new System.EventHandler(this.checkDate_Click);
            // 
            // FRM_Ajouter_Modifier_Porduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1117, 491);
            this.Controls.Add(this.checkDate);
            this.Controls.Add(this.txtStockAlerte);
            this.Controls.Add(this.dateCtrl);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.combocategorie);
            this.Controls.Add(this.btnparcourir);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btnactualiser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtNomP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picProduit);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajouter_Modifier_Porduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ajouter_Modifier_Porduit";
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitre;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox txtNomP;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenregistrer;
        public System.Windows.Forms.Button btnactualiser;
        public System.Windows.Forms.Button btnparcourir;
        private System.Windows.Forms.Button btnquitter;
        public System.Windows.Forms.PictureBox picProduit;
        public System.Windows.Forms.ComboBox combotype;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox combocategorie;
        public System.Windows.Forms.DateTimePicker dateCtrl;
        public System.Windows.Forms.TextBox txtStockAlerte;
        private System.Windows.Forms.CheckBox checkDate;
    }
}