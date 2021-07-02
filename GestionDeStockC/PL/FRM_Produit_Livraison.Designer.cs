
namespace GestionDeStockC.PL
{
    partial class FRM_Produit_Livraison
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
            this.txtIdProduit = new System.Windows.Forms.TextBox();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.lblInv = new System.Windows.Forms.Label();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.txtIdClientAffect = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Black;
            this.lblTitre.Location = new System.Drawing.Point(27, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(250, 33);
            this.lblTitre.TabIndex = 62;
            this.lblTitre.Text = "Ajouter Livraison";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Désignation :";
            // 
            // txtIdProduit
            // 
            this.txtIdProduit.BackColor = System.Drawing.Color.White;
            this.txtIdProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProduit.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtIdProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtIdProduit.Location = new System.Drawing.Point(255, 8);
            this.txtIdProduit.Multiline = true;
            this.txtIdProduit.Name = "txtIdProduit";
            this.txtIdProduit.Size = new System.Drawing.Size(36, 34);
            this.txtIdProduit.TabIndex = 61;
            this.txtIdProduit.Visible = false;
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.White;
            this.btnenregistrer.Location = new System.Drawing.Point(44, 226);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(230, 39);
            this.btnenregistrer.TabIndex = 44;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInv.ForeColor = System.Drawing.Color.Black;
            this.lblInv.Location = new System.Drawing.Point(136, 68);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(18, 24);
            this.lblInv.TabIndex = 58;
            this.lblInv.Text = "II";
            // 
            // txtquantite
            // 
            this.txtquantite.BackColor = System.Drawing.Color.White;
            this.txtquantite.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtquantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantite.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtquantite.Location = new System.Drawing.Point(140, 167);
            this.txtquantite.Multiline = true;
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(122, 34);
            this.txtquantite.TabIndex = 45;
            this.txtquantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantite_KeyPress);
            // 
            // txtIdClientAffect
            // 
            this.txtIdClientAffect.BackColor = System.Drawing.Color.White;
            this.txtIdClientAffect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdClientAffect.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtIdClientAffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClientAffect.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtIdClientAffect.Location = new System.Drawing.Point(297, 8);
            this.txtIdClientAffect.Multiline = true;
            this.txtIdClientAffect.Name = "txtIdClientAffect";
            this.txtIdClientAffect.Size = new System.Drawing.Size(40, 34);
            this.txtIdClientAffect.TabIndex = 59;
            this.txtIdClientAffect.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(29, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 24);
            this.label8.TabIndex = 57;
            this.label8.Text = "Inventaire :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "Quantitée :";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.Color.Black;
            this.lblnom.Location = new System.Drawing.Point(136, 121);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(25, 24);
            this.lblnom.TabIndex = 54;
            this.lblnom.Text = "In";
            // 
            // FRM_Produit_Livraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 287);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdProduit);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.lblInv);
            this.Controls.Add(this.txtquantite);
            this.Controls.Add(this.txtIdClientAffect);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblnom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Produit_Livraison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitre;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIdProduit;
        private System.Windows.Forms.Button btnenregistrer;
        public System.Windows.Forms.Label lblInv;
        public System.Windows.Forms.TextBox txtquantite;
        public System.Windows.Forms.TextBox txtIdClientAffect;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblnom;
    }
}