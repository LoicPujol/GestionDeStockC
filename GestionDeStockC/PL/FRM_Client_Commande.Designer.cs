
namespace GestionDeStockC.PL
{
    partial class FRM_Client_Commande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.txtNumeroClient = new System.Windows.Forms.TextBox();
            this.dvgclient = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(586, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 9;
            this.txtID.Visible = false;
            // 
            // txtNomClient
            // 
            this.txtNomClient.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtNomClient.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomClient.Location = new System.Drawing.Point(163, 16);
            this.txtNomClient.Multiline = true;
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(140, 32);
            this.txtNomClient.TabIndex = 65;
            this.txtNomClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomClient.TextChanged += new System.EventHandler(this.txtrechercheNom_TextChanged);
            // 
            // txtNumeroClient
            // 
            this.txtNumeroClient.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumeroClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtNumeroClient.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumeroClient.Location = new System.Drawing.Point(12, 16);
            this.txtNumeroClient.Multiline = true;
            this.txtNumeroClient.Name = "txtNumeroClient";
            this.txtNumeroClient.Size = new System.Drawing.Size(140, 32);
            this.txtNumeroClient.TabIndex = 64;
            this.txtNumeroClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroClient.TextChanged += new System.EventHandler(this.txtrechercheInv_TextChanged);
            // 
            // dvgclient
            // 
            this.dvgclient.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgclient.AllowUserToAddRows = false;
            this.dvgclient.AllowUserToDeleteRows = false;
            this.dvgclient.AllowUserToResizeRows = false;
            this.dvgclient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgclient.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dvgclient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgclient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.dataGridViewTextBoxColumn6,
            this.Column10,
            this.Column3,
            this.Column2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgclient.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgclient.EnableHeadersVisualStyles = false;
            this.dvgclient.Location = new System.Drawing.Point(12, 54);
            this.dvgclient.MultiSelect = false;
            this.dvgclient.Name = "dvgclient";
            this.dvgclient.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgclient.RowHeadersVisible = false;
            this.dvgclient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgclient.Size = new System.Drawing.Size(671, 545);
            this.dvgclient.TabIndex = 66;
            this.dvgclient.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgclient_CellDoubleClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID_Client";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Telephone";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ville";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rabais";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FRM_Client_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 611);
            this.Controls.Add(this.dvgclient);
            this.Controls.Add(this.txtNomClient);
            this.Controls.Add(this.txtNumeroClient);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Client_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste_Client";
            this.Load += new System.EventHandler(this.FRM_Client_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.TextBox txtNumeroClient;
        public System.Windows.Forms.DataGridView dvgclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}