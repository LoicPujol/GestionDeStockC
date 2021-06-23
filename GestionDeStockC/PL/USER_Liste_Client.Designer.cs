
namespace GestionDeStockC.PL
{
    partial class USER_Liste_Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.comborecherche = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvgclient = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsupprimerclient = new System.Windows.Forms.Button();
            this.btnajouteclient = new System.Windows.Forms.Button();
            this.btnmodifierclient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrecherche
            // 
            this.txtrecherche.BackColor = System.Drawing.SystemColors.Control;
            this.txtrecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtrecherche.ForeColor = System.Drawing.Color.DimGray;
            this.txtrecherche.Location = new System.Drawing.Point(162, 29);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(140, 32);
            this.txtrecherche.TabIndex = 5;
            this.txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            // 
            // comborecherche
            // 
            this.comborecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborecherche.FormattingEnabled = true;
            this.comborecherche.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
            this.comborecherche.Location = new System.Drawing.Point(6, 29);
            this.comborecherche.Name = "comborecherche";
            this.comborecherche.Size = new System.Drawing.Size(140, 33);
            this.comborecherche.TabIndex = 6;
            this.comborecherche.SelectedIndexChanged += new System.EventHandler(this.comborecherche_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 48);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = global::GestionDeStockC.Properties.Resources.k;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::GestionDeStockC.Properties.Resources.Deconnecte;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column7,
            this.Column5,
            this.Column6,
            this.Column12,
            this.Column10,
            this.Column11,
            this.Column8,
            this.Column4,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgclient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgclient.EnableHeadersVisualStyles = false;
            this.dvgclient.Location = new System.Drawing.Point(18, 78);
            this.dvgclient.MultiSelect = false;
            this.dvgclient.Name = "dvgclient";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgclient.RowHeadersVisible = false;
            this.dvgclient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgclient.Size = new System.Drawing.Size(1107, 640);
            this.dvgclient.TabIndex = 17;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "N° client";
            this.Column7.Name = "Column7";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nom";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prenom";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Rabais";
            this.Column12.Name = "Column12";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Adresse";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Code postal";
            this.Column11.Name = "Column11";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ville";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pays";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Telephone";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // btnsupprimerclient
            // 
            this.btnsupprimerclient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsupprimerclient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsupprimerclient.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnsupprimerclient.FlatAppearance.BorderSize = 0;
            this.btnsupprimerclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnsupprimerclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnsupprimerclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimerclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnsupprimerclient.ForeColor = System.Drawing.Color.White;
            this.btnsupprimerclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimerclient.Location = new System.Drawing.Point(995, 31);
            this.btnsupprimerclient.Name = "btnsupprimerclient";
            this.btnsupprimerclient.Size = new System.Drawing.Size(130, 32);
            this.btnsupprimerclient.TabIndex = 20;
            this.btnsupprimerclient.Text = "Supprimer";
            this.btnsupprimerclient.UseVisualStyleBackColor = false;
            this.btnsupprimerclient.Click += new System.EventHandler(this.btnsupprimerclient_Click);
            // 
            // btnajouteclient
            // 
            this.btnajouteclient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnajouteclient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnajouteclient.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnajouteclient.FlatAppearance.BorderSize = 0;
            this.btnajouteclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnajouteclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnajouteclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouteclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnajouteclient.ForeColor = System.Drawing.Color.White;
            this.btnajouteclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouteclient.Location = new System.Drawing.Point(720, 31);
            this.btnajouteclient.Name = "btnajouteclient";
            this.btnajouteclient.Size = new System.Drawing.Size(130, 32);
            this.btnajouteclient.TabIndex = 18;
            this.btnajouteclient.Text = "Ajouter";
            this.btnajouteclient.UseVisualStyleBackColor = false;
            this.btnajouteclient.Click += new System.EventHandler(this.btnajouteclient_Click);
            // 
            // btnmodifierclient
            // 
            this.btnmodifierclient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodifierclient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnmodifierclient.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnmodifierclient.FlatAppearance.BorderSize = 0;
            this.btnmodifierclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnmodifierclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnmodifierclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifierclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnmodifierclient.ForeColor = System.Drawing.Color.White;
            this.btnmodifierclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifierclient.Location = new System.Drawing.Point(859, 30);
            this.btnmodifierclient.Name = "btnmodifierclient";
            this.btnmodifierclient.Size = new System.Drawing.Size(130, 32);
            this.btnmodifierclient.TabIndex = 19;
            this.btnmodifierclient.Text = "Modifier";
            this.btnmodifierclient.UseVisualStyleBackColor = false;
            this.btnmodifierclient.Click += new System.EventHandler(this.btnmodifierclient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comborecherche);
            this.groupBox1.Controls.Add(this.txtrecherche);
            this.groupBox1.Location = new System.Drawing.Point(18, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 69);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(159, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Type";
            // 
            // USER_Liste_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsupprimerclient);
            this.Controls.Add(this.btnmodifierclient);
            this.Controls.Add(this.btnajouteclient);
            this.Controls.Add(this.dvgclient);
            this.Name = "USER_Liste_Client";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Client_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.ComboBox comborecherche;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.DataGridView dvgclient;
        private System.Windows.Forms.Button btnsupprimerclient;
        private System.Windows.Forms.Button btnajouteclient;
        private System.Windows.Forms.Button btnmodifierclient;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
