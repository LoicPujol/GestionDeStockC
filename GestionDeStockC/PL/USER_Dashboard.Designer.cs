
namespace GestionDeStockC.PL
{
    partial class USER_Dashboard
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
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNbreDateCtrlAlerte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNbreStockAlerte = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeure
            // 
            this.lblHeure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHeure.Location = new System.Drawing.Point(387, 190);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(256, 91);
            this.lblHeure.TabIndex = 0;
            this.lblHeure.Text = "Heure";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDate.Location = new System.Drawing.Point(462, 281);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(104, 46);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNbreStockAlerte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNbreDateCtrlAlerte);
            this.groupBox1.Location = new System.Drawing.Point(14, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 194);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Article en alerte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Contrôle :";
            // 
            // txtNbreDateCtrlAlerte
            // 
            this.txtNbreDateCtrlAlerte.BackColor = System.Drawing.SystemColors.Control;
            this.txtNbreDateCtrlAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtNbreDateCtrlAlerte.ForeColor = System.Drawing.Color.DimGray;
            this.txtNbreDateCtrlAlerte.Location = new System.Drawing.Point(18, 46);
            this.txtNbreDateCtrlAlerte.Multiline = true;
            this.txtNbreDateCtrlAlerte.Name = "txtNbreDateCtrlAlerte";
            this.txtNbreDateCtrlAlerte.Size = new System.Drawing.Size(140, 32);
            this.txtNbreDateCtrlAlerte.TabIndex = 71;
            this.txtNbreDateCtrlAlerte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Stock :";
            // 
            // txtNbreStockAlerte
            // 
            this.txtNbreStockAlerte.BackColor = System.Drawing.SystemColors.Control;
            this.txtNbreStockAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtNbreStockAlerte.ForeColor = System.Drawing.Color.DimGray;
            this.txtNbreStockAlerte.Location = new System.Drawing.Point(18, 130);
            this.txtNbreStockAlerte.Multiline = true;
            this.txtNbreStockAlerte.Name = "txtNbreStockAlerte";
            this.txtNbreStockAlerte.Size = new System.Drawing.Size(140, 32);
            this.txtNbreStockAlerte.TabIndex = 73;
            this.txtNbreStockAlerte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // USER_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHeure);
            this.Name = "USER_Dashboard";
            this.Size = new System.Drawing.Size(997, 571);
            this.Load += new System.EventHandler(this.USER_Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNbreStockAlerte;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNbreDateCtrlAlerte;
    }
}
