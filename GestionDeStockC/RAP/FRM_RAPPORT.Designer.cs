
namespace GestionDeStockC.RAP
{
    partial class FRM_RAPPORT
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
            this.RPT_Afficher = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPT_Afficher
            // 
            this.RPT_Afficher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPT_Afficher.Location = new System.Drawing.Point(0, 0);
            this.RPT_Afficher.Name = "RPT_Afficher";
            this.RPT_Afficher.ServerReport.BearerToken = null;
            this.RPT_Afficher.Size = new System.Drawing.Size(639, 666);
            this.RPT_Afficher.TabIndex = 0;
            // 
            // FRM_RAPPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 666);
            this.Controls.Add(this.RPT_Afficher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_RAPPORT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapporte";
            this.Load += new System.EventHandler(this.FRM_RAPPORT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RPT_Afficher;
    }
}