
namespace GestionDeStockC.PL
{
    partial class FRM_Ajoute_Date
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
            this.dateCtrl = new System.Windows.Forms.DateTimePicker();
            this.btnajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateCtrl
            // 
            this.dateCtrl.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCtrl.CustomFormat = "dd/MM/yyyy";
            this.dateCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCtrl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCtrl.Location = new System.Drawing.Point(12, 12);
            this.dateCtrl.Name = "dateCtrl";
            this.dateCtrl.Size = new System.Drawing.Size(127, 29);
            this.dateCtrl.TabIndex = 53;
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnajouter.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnajouter.FlatAppearance.BorderSize = 0;
            this.btnajouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter.Location = new System.Drawing.Point(12, 63);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(127, 32);
            this.btnajouter.TabIndex = 54;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // FRM_Ajoute_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 107);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.dateCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Ajoute_Date";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ajoute_Date";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateCtrl;
        private System.Windows.Forms.Button btnajouter;
    }
}