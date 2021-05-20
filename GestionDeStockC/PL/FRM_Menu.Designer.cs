
namespace GestionDeStockC.PL
{
    partial class FRM_Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBut = new System.Windows.Forms.Panel();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btncommande = new System.Windows.Forms.Button();
            this.btnproduit = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.btncategorie = new System.Windows.Forms.Button();
            this.pnlparammetrer = new System.Windows.Forms.Panel();
            this.pnlaficher = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlparammetrer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pnlBut);
            this.panel1.Controls.Add(this.btnmenu);
            this.panel1.Controls.Add(this.btncommande);
            this.panel1.Controls.Add(this.btnproduit);
            this.panel1.Controls.Add(this.btnclient);
            this.panel1.Controls.Add(this.btncategorie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 619);
            this.panel1.TabIndex = 0;
            // 
            // pnlBut
            // 
            this.pnlBut.BackColor = System.Drawing.Color.Gray;
            this.pnlBut.Location = new System.Drawing.Point(3, 80);
            this.pnlBut.Name = "pnlBut";
            this.pnlBut.Size = new System.Drawing.Size(10, 45);
            this.pnlBut.TabIndex = 6;
            // 
            // btnmenu
            // 
            this.btnmenu.FlatAppearance.BorderSize = 0;
            this.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmenu.Image = global::GestionDeStockC.Properties.Resources.Menu_32;
            this.btnmenu.Location = new System.Drawing.Point(3, 3);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(56, 43);
            this.btnmenu.TabIndex = 6;
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btncommande
            // 
            this.btncommande.FlatAppearance.BorderSize = 0;
            this.btncommande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btncommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncommande.ForeColor = System.Drawing.Color.Gray;
            this.btncommande.Image = global::GestionDeStockC.Properties.Resources.shopping_icon;
            this.btncommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncommande.Location = new System.Drawing.Point(3, 404);
            this.btncommande.Name = "btncommande";
            this.btncommande.Size = new System.Drawing.Size(194, 45);
            this.btncommande.TabIndex = 12;
            this.btncommande.Text = "          Commande";
            this.btncommande.UseVisualStyleBackColor = true;
            this.btncommande.Click += new System.EventHandler(this.btpcommande_Click);
            // 
            // btnproduit
            // 
            this.btnproduit.FlatAppearance.BorderSize = 0;
            this.btnproduit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduit.ForeColor = System.Drawing.Color.Gray;
            this.btnproduit.Image = global::GestionDeStockC.Properties.Resources.shop_cart_add_icon;
            this.btnproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduit.Location = new System.Drawing.Point(3, 188);
            this.btnproduit.Name = "btnproduit";
            this.btnproduit.Size = new System.Drawing.Size(194, 45);
            this.btnproduit.TabIndex = 11;
            this.btnproduit.Text = "   Produit";
            this.btnproduit.UseVisualStyleBackColor = true;
            this.btnproduit.Click += new System.EventHandler(this.btnproduit_Click);
            // 
            // btnclient
            // 
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.Color.Gray;
            this.btnclient.Image = global::GestionDeStockC.Properties.Resources.Office_Client_Male_Light_icon;
            this.btnclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.Location = new System.Drawing.Point(3, 80);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(194, 45);
            this.btnclient.TabIndex = 9;
            this.btnclient.Text = " Client";
            this.btnclient.UseVisualStyleBackColor = true;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // btncategorie
            // 
            this.btncategorie.FlatAppearance.BorderSize = 0;
            this.btncategorie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btncategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorie.ForeColor = System.Drawing.Color.Gray;
            this.btncategorie.Image = global::GestionDeStockC.Properties.Resources.Categorie;
            this.btncategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorie.Location = new System.Drawing.Point(3, 296);
            this.btncategorie.Name = "btncategorie";
            this.btncategorie.Size = new System.Drawing.Size(194, 45);
            this.btncategorie.TabIndex = 10;
            this.btncategorie.Text = "       Categorie";
            this.btncategorie.UseVisualStyleBackColor = true;
            this.btncategorie.Click += new System.EventHandler(this.btncategorie_Click);
            // 
            // pnlparammetrer
            // 
            this.pnlparammetrer.Controls.Add(this.pnlaficher);
            this.pnlparammetrer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlparammetrer.Location = new System.Drawing.Point(188, 0);
            this.pnlparammetrer.Name = "pnlparammetrer";
            this.pnlparammetrer.Size = new System.Drawing.Size(968, 619);
            this.pnlparammetrer.TabIndex = 2;
            // 
            // pnlaficher
            // 
            this.pnlaficher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlaficher.BackColor = System.Drawing.SystemColors.Control;
            this.pnlaficher.Location = new System.Drawing.Point(0, 0);
            this.pnlaficher.Name = "pnlaficher";
            this.pnlaficher.Size = new System.Drawing.Size(968, 619);
            this.pnlaficher.TabIndex = 12;
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 619);
            this.Controls.Add(this.pnlparammetrer);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Menu";
            this.Text = "FRM_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.pnlparammetrer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnmenu;
        internal System.Windows.Forms.Button btncommande;
        internal System.Windows.Forms.Button btnproduit;
        internal System.Windows.Forms.Button btnclient;
        internal System.Windows.Forms.Button btncategorie;
        private System.Windows.Forms.Panel pnlBut;
        private System.Windows.Forms.Panel pnlparammetrer;
        private System.Windows.Forms.Panel pnlaficher;
    }
}