
namespace GestionDeStockC.PL
{
    partial class FRM_Produit_Commande
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
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.txtremise = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblprix = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpproduit = new System.Windows.Forms.GroupBox();
            this.txtIdClientAffect = new System.Windows.Forms.TextBox();
            this.txtIdExpediteur = new System.Windows.Forms.TextBox();
            this.grpproduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.Gray;
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.Black;
            this.btnenregistrer.Location = new System.Drawing.Point(159, 378);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(230, 39);
            this.btnenregistrer.TabIndex = 23;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // txtquantite
            // 
            this.txtquantite.BackColor = System.Drawing.Color.White;
            this.txtquantite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtquantite.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtquantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantite.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtquantite.Location = new System.Drawing.Point(390, 65);
            this.txtquantite.Multiline = true;
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(122, 34);
            this.txtquantite.TabIndex = 24;
            this.txtquantite.TextChanged += new System.EventHandler(this.txtquantite_TextChanged);
            this.txtquantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantite_KeyPress);
            // 
            // txtremise
            // 
            this.txtremise.BackColor = System.Drawing.Color.White;
            this.txtremise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtremise.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtremise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremise.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtremise.Location = new System.Drawing.Point(390, 149);
            this.txtremise.Multiline = true;
            this.txtremise.Name = "txtremise";
            this.txtremise.Size = new System.Drawing.Size(122, 34);
            this.txtremise.TabIndex = 25;
            this.txtremise.TextChanged += new System.EventHandler(this.txtremise_TextChanged);
            this.txtremise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtremise_KeyPress);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.White;
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Cursor = System.Windows.Forms.Cursors.Help;
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txttotal.Location = new System.Drawing.Point(390, 232);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(122, 31);
            this.txttotal.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 28;
            this.label2.Text = "Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "Prix :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(386, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Quantite :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(386, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Remise :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(386, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Total :";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.Color.Black;
            this.lblnom.Location = new System.Drawing.Point(126, 73);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(41, 33);
            this.lblnom.TabIndex = 33;
            this.lblnom.Text = "In";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.ForeColor = System.Drawing.Color.Black;
            this.lblstock.Location = new System.Drawing.Point(126, 161);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(40, 33);
            this.lblstock.TabIndex = 34;
            this.lblstock.Text = "Is";
            // 
            // lblprix
            // 
            this.lblprix.AutoSize = true;
            this.lblprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprix.ForeColor = System.Drawing.Color.Black;
            this.lblprix.Location = new System.Drawing.Point(126, 244);
            this.lblprix.Name = "lblprix";
            this.lblprix.Size = new System.Drawing.Size(41, 33);
            this.lblprix.TabIndex = 35;
            this.lblprix.Text = "Ip";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.Black;
            this.lblid.Location = new System.Drawing.Point(126, 17);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(33, 33);
            this.lblid.TabIndex = 37;
            this.lblid.Text = "II";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(61, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 33);
            this.label8.TabIndex = 36;
            this.label8.Text = "Id :";
            // 
            // grpproduit
            // 
            this.grpproduit.Controls.Add(this.label1);
            this.grpproduit.Controls.Add(this.btnenregistrer);
            this.grpproduit.Controls.Add(this.lblid);
            this.grpproduit.Controls.Add(this.txtquantite);
            this.grpproduit.Controls.Add(this.label8);
            this.grpproduit.Controls.Add(this.txtremise);
            this.grpproduit.Controls.Add(this.lblprix);
            this.grpproduit.Controls.Add(this.txttotal);
            this.grpproduit.Controls.Add(this.lblstock);
            this.grpproduit.Controls.Add(this.label2);
            this.grpproduit.Controls.Add(this.lblnom);
            this.grpproduit.Controls.Add(this.label3);
            this.grpproduit.Controls.Add(this.label6);
            this.grpproduit.Controls.Add(this.label4);
            this.grpproduit.Controls.Add(this.label5);
            this.grpproduit.ForeColor = System.Drawing.Color.Black;
            this.grpproduit.Location = new System.Drawing.Point(12, 47);
            this.grpproduit.Name = "grpproduit";
            this.grpproduit.Size = new System.Drawing.Size(526, 434);
            this.grpproduit.TabIndex = 39;
            this.grpproduit.TabStop = false;
            this.grpproduit.Text = "Vendre Produit";
            // 
            // txtIdClientAffect
            // 
            this.txtIdClientAffect.BackColor = System.Drawing.Color.White;
            this.txtIdClientAffect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdClientAffect.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtIdClientAffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClientAffect.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtIdClientAffect.Location = new System.Drawing.Point(318, 7);
            this.txtIdClientAffect.Multiline = true;
            this.txtIdClientAffect.Name = "txtIdClientAffect";
            this.txtIdClientAffect.Size = new System.Drawing.Size(122, 34);
            this.txtIdClientAffect.TabIndex = 40;
            // 
            // txtIdExpediteur
            // 
            this.txtIdExpediteur.BackColor = System.Drawing.Color.White;
            this.txtIdExpediteur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdExpediteur.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtIdExpediteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdExpediteur.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtIdExpediteur.Location = new System.Drawing.Point(171, 7);
            this.txtIdExpediteur.Multiline = true;
            this.txtIdExpediteur.Name = "txtIdExpediteur";
            this.txtIdExpediteur.Size = new System.Drawing.Size(122, 34);
            this.txtIdExpediteur.TabIndex = 41;
            // 
            // FRM_Produit_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(554, 493);
            this.Controls.Add(this.txtIdExpediteur);
            this.Controls.Add(this.txtIdClientAffect);
            this.Controls.Add(this.grpproduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Produit_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produit";
            this.grpproduit.ResumeLayout(false);
            this.grpproduit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnenregistrer;
        public System.Windows.Forms.TextBox txtquantite;
        public System.Windows.Forms.TextBox txtremise;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblnom;
        public System.Windows.Forms.Label lblstock;
        public System.Windows.Forms.Label lblprix;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox grpproduit;
        public System.Windows.Forms.TextBox txtIdClientAffect;
        public System.Windows.Forms.TextBox txtIdExpediteur;
    }
}