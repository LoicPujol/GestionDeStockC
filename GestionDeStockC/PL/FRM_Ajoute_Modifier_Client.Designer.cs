
namespace GestionDeStockC.PL
{
    partial class FRM_Ajoute_Modifier_Client
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
            this.btnactualiser = new System.Windows.Forms.Button();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIncrementer = new System.Windows.Forms.Button();
            this.txtInventaireProd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Black;
            this.lblTitre.Location = new System.Drawing.Point(26, 13);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(204, 33);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Ajouter Client";
            // 
            // btnactualiser
            // 
            this.btnactualiser.BackColor = System.Drawing.Color.Gray;
            this.btnactualiser.FlatAppearance.BorderSize = 0;
            this.btnactualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiser.ForeColor = System.Drawing.Color.Black;
            this.btnactualiser.Location = new System.Drawing.Point(32, 415);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(230, 39);
            this.btnactualiser.TabIndex = 20;
            this.btnactualiser.Text = "Actualiser";
            this.btnactualiser.UseVisualStyleBackColor = false;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.White;
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelephone.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.ForeColor = System.Drawing.Color.Silver;
            this.txtTelephone.Location = new System.Drawing.Point(32, 270);
            this.txtTelephone.Multiline = true;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(230, 35);
            this.txtTelephone.TabIndex = 16;
            this.txtTelephone.Text = "Telephone Client";
            this.txtTelephone.Enter += new System.EventHandler(this.txtTelephone_Enter);
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephone_KeyPress);
            this.txtTelephone.Leave += new System.EventHandler(this.txtTelephone_Leave);
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.White;
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.ForeColor = System.Drawing.Color.Silver;
            this.txtPrenom.Location = new System.Drawing.Point(32, 213);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(230, 35);
            this.txtPrenom.TabIndex = 14;
            this.txtPrenom.Text = "Prenom de Client";
            this.txtPrenom.Enter += new System.EventHandler(this.txtPrenom_Enter);
            this.txtPrenom.Leave += new System.EventHandler(this.txtPrenom_Leave);
            // 
            // btnquitter
            // 
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = global::GestionDeStockC.Properties.Resources.Button_Delete_icon;
            this.btnquitter.Location = new System.Drawing.Point(494, 10);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(36, 36);
            this.btnquitter.TabIndex = 12;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.Gray;
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.Black;
            this.btnenregistrer.Location = new System.Drawing.Point(300, 415);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(230, 39);
            this.btnenregistrer.TabIndex = 21;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.White;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.Color.Silver;
            this.txtNom.Location = new System.Drawing.Point(32, 154);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(230, 35);
            this.txtNom.TabIndex = 22;
            this.txtNom.Text = "Nom de Client";
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // txtAdresse
            // 
            this.txtAdresse.BackColor = System.Drawing.Color.White;
            this.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdresse.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.ForeColor = System.Drawing.Color.Silver;
            this.txtAdresse.Location = new System.Drawing.Point(300, 68);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(230, 121);
            this.txtAdresse.TabIndex = 25;
            this.txtAdresse.Text = "Adresse Client";
            this.txtAdresse.Enter += new System.EventHandler(this.txtAdresse_Enter);
            this.txtAdresse.Leave += new System.EventHandler(this.txtAdresse_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(32, 325);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 35);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.Text = "Email Client";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtVille
            // 
            this.txtVille.BackColor = System.Drawing.Color.White;
            this.txtVille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVille.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.ForeColor = System.Drawing.Color.Silver;
            this.txtVille.Location = new System.Drawing.Point(300, 213);
            this.txtVille.Multiline = true;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(230, 35);
            this.txtVille.TabIndex = 31;
            this.txtVille.Text = "Ville Client";
            this.txtVille.Enter += new System.EventHandler(this.txtVille_Enter);
            this.txtVille.Leave += new System.EventHandler(this.txtVille_Leave);
            // 
            // txtPays
            // 
            this.txtPays.BackColor = System.Drawing.Color.White;
            this.txtPays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPays.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPays.ForeColor = System.Drawing.Color.Silver;
            this.txtPays.Location = new System.Drawing.Point(300, 270);
            this.txtPays.Multiline = true;
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(230, 35);
            this.txtPays.TabIndex = 34;
            this.txtPays.Text = "Pays Client";
            this.txtPays.Enter += new System.EventHandler(this.txtPays_Enter);
            this.txtPays.Leave += new System.EventHandler(this.txtPays_Leave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(300, 325);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 35);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "Rabais client en %";
            // 
            // btnIncrementer
            // 
            this.btnIncrementer.BackColor = System.Drawing.Color.Gray;
            this.btnIncrementer.FlatAppearance.BorderSize = 0;
            this.btnIncrementer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrementer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementer.ForeColor = System.Drawing.Color.Black;
            this.btnIncrementer.Location = new System.Drawing.Point(32, 102);
            this.btnIncrementer.Name = "btnIncrementer";
            this.btnIncrementer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnIncrementer.Size = new System.Drawing.Size(230, 33);
            this.btnIncrementer.TabIndex = 62;
            this.btnIncrementer.Text = "Incrementer";
            this.btnIncrementer.UseVisualStyleBackColor = false;
            // 
            // txtInventaireProd
            // 
            this.txtInventaireProd.BackColor = System.Drawing.Color.White;
            this.txtInventaireProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInventaireProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInventaireProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventaireProd.ForeColor = System.Drawing.Color.Silver;
            this.txtInventaireProd.Location = new System.Drawing.Point(32, 68);
            this.txtInventaireProd.Multiline = true;
            this.txtInventaireProd.Name = "txtInventaireProd";
            this.txtInventaireProd.Size = new System.Drawing.Size(230, 28);
            this.txtInventaireProd.TabIndex = 61;
            this.txtInventaireProd.Text = "N° Inventaire";
            this.txtInventaireProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_Ajoute_Modifier_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(572, 488);
            this.Controls.Add(this.btnIncrementer);
            this.Controls.Add(this.txtInventaireProd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btnactualiser);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajoute_Modifier_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ajoute_Modifier_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnenregistrer;
        public System.Windows.Forms.Label lblTitre;
        public System.Windows.Forms.Button btnactualiser;
        public System.Windows.Forms.TextBox txtTelephone;
        public System.Windows.Forms.TextBox txtPrenom;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtAdresse;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtVille;
        public System.Windows.Forms.TextBox txtPays;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnIncrementer;
        public System.Windows.Forms.TextBox txtInventaireProd;
    }
}