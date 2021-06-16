
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
            // USER_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHeure);
            this.Name = "USER_Dashboard";
            this.Size = new System.Drawing.Size(997, 571);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}
