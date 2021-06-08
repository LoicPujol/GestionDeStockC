﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace GestionDeStockC.PL
{

    public partial class USER_Liste_Produit : UserControl
    {
        private static USER_Liste_Produit Userclient;
        private dbStockContext db;
        //creer instance pour le usercontrole
        public static USER_Liste_Produit Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Liste_Produit();
                }
                return Userclient;
            }
        }
        public USER_Liste_Produit()
        {
            InitializeComponent();
            db = new dbStockContext();
            //afficher categorie selon table dans combobox
            combocategorie.DataSource = db.Categories.ToList();
            //pour filtrer seulement les nom de categorie
            combocategorie.DisplayMember = "Nom_Categorie";//afficher les nom des categorie
            combocategorie.ValueMember = "ID_Categorie";
            combocategorie.SelectedIndex = -1;

            //afficher type selon table dans combobox
            combotype.DataSource = db.Types.ToList();
            //pour filtrer seulement les nom de categorie
            combotype.DisplayMember = "Nom_Type";//afficher les nom des categorie
            combotype.ValueMember = "ID_Type";
            combotype.SelectedIndex = -1;
        }
        //actualiser datagrid
        public void Actualiserdvg()
        {
            dvgProduit.Columns[9].DefaultCellStyle.Format = "dd/MM/yyyy";
            db = new dbStockContext();
            var listerecherche = db.Produits.ToList();//liste de recherche = liste des clients

            if (combocategorie.SelectedItem != null && combotype.SelectedItem != null)
            {
                string CategRech = combocategorie.SelectedValue.ToString();
                int IdCat;
                bool testCat = Int32.TryParse(CategRech, out IdCat);

                string TypeRech = combotype.SelectedValue.ToString();
                int IdTyp;
                bool testTyp = Int32.TryParse(TypeRech, out IdTyp);

                string IdRech = txtrechercheInvProd.Text;
                int IdProd;
                bool testProd = Int32.TryParse(IdRech, out IdProd);

                listerecherche = listerecherche.Where(s => s.NumInventaire.IndexOf(txtrechercheInvProd.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && s.Nom_Produit.IndexOf(txtrechercheNom.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && IdTyp == s.ID_Type && IdCat == s.ID_Categorie).ToList();
            }

            if (combocategorie.SelectedItem != null)
            {
                string CategRecherche = combocategorie.SelectedValue.ToString();
                int IdCateg;
                bool testCateg = Int32.TryParse(CategRecherche, out IdCateg);

                listerecherche = listerecherche.Where(s => s.NumInventaire.IndexOf(txtrechercheInvProd.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && s.Nom_Produit.IndexOf(txtrechercheNom.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && IdCateg == s.ID_Categorie).ToList();
            }

            if (combotype.SelectedItem != null)
            {
                string TypeRecherche = combotype.SelectedValue.ToString();
                int IdType;
                bool testType = Int32.TryParse(TypeRecherche, out IdType);

                listerecherche = listerecherche.Where(s => s.NumInventaire.IndexOf(txtrechercheInvProd.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && s.Nom_Produit.IndexOf(txtrechercheNom.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && IdType == s.ID_Type).ToList();
            }
            if (combocategorie.SelectedItem == null && combotype.SelectedItem == null)

                listerecherche = listerecherche.Where(s => s.NumInventaire.IndexOf(txtrechercheInvProd.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && s.Nom_Produit.IndexOf(txtrechercheNom.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                    //vide datagrid
                    dvgProduit.Rows.Clear();
                    //ajouter listerecherche dans datagridview client
                    Categorie cat = new Categorie();
                    Type typ = new Type();//ajout pout type
                    foreach (var l in listerecherche)

                    {
                        cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == l.ID_Categorie);
                        typ = db.Types.SingleOrDefault(s => s.ID_Type == l.ID_Type);//ajout type
                        dvgProduit.Rows.Add(false, l.ID_Produit, cat.Nom_Categorie, typ.Nom_Type, l.NumInventaire, l.Nom_Produit, l.Quantité_Produit, l.Stock_Alerte, l.Prix_Produit,  l.Date_Controle);
                    }
            //colorer stock vide en rouge
            for (int i = 0; i < dvgProduit.Rows.Count; i++)
            {
                if ((int)dvgProduit.Rows[i].Cells[6].Value == 0)
                {
                    dvgProduit.Rows[i].Cells[6].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgProduit.Rows[i].Cells[6].Style.BackColor = Color.LightGreen;
                }
            }
        }
        
        /**public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgProduit.RowCount; i++)
            {
                if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)//si ligne est selectionner
                {
                    Nombreligneselect++;//nombre ligne +1
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner le Produit a modifier";
            }
            if (Nombreligneselect > 1)
            {
                return "Selectionner seulement 1 seul Produit";
            }
            return null;
        }**/
       

        private void btnajouter_Click(object sender, EventArgs e)
        {
            //afficher formulaire ajout produit
            PL.FRM_Ajouter_Modifier_Porduit frmProduit = new PL.FRM_Ajouter_Modifier_Porduit(this);
            frmProduit.ShowDialog();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            PL.FRM_Ajouter_Modifier_Porduit frmproduit = new PL.FRM_Ajouter_Modifier_Porduit(this);

            if (dvgProduit.CurrentRow != null)
            {
                frmproduit.lblTitre.Text = "Modifier Produit";
                frmproduit.btnactualiser.Visible = false;
                frmproduit.IDPRODUIT = (int)dvgProduit.CurrentRow.Cells[1].Value;
                frmproduit.combocategorie.Text = dvgProduit.CurrentRow.Cells[2].Value.ToString();
                frmproduit.combotype.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                frmproduit.combotype.Enabled = false;
                frmproduit.txtInventaireProd.Text = dvgProduit.CurrentRow.Cells[4].Value.ToString();
                frmproduit.txtInventaireProd.ForeColor = Color.Black;
                frmproduit.txtInventaireProd.Enabled = false;
                frmproduit.txtNomP.Text = dvgProduit.CurrentRow.Cells[5].Value.ToString();
                frmproduit.txtNomP.ForeColor = Color.Black;
                frmproduit.txtQuantite.Text = dvgProduit.CurrentRow.Cells[6].Value.ToString();
                frmproduit.txtQuantite.ForeColor = Color.Black;
                frmproduit.txtStockAlerte.Text = dvgProduit.CurrentRow.Cells[7].Value.ToString();
                frmproduit.txtStockAlerte.ForeColor = Color.Black;
                frmproduit.txtPrix.Text = dvgProduit.CurrentRow.Cells[8].Value.ToString();
                frmproduit.txtPrix.ForeColor = Color.Black;
                //Afficher date controle
                if (dvgProduit.CurrentRow.Cells[9].Value != null)
                {
                    frmproduit.checkDate.Visible = true;
                    frmproduit.checkDate.Checked = true;
                    frmproduit.dateCtrl.Visible = true;
                    DateTime dtctrl = DateTime.ParseExact(dvgProduit.CurrentRow.Cells[9].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    frmproduit.dateCtrl.Value = dtctrl;
                }
                //Afficher image produit
                int MYIDSELECT = (int)dvgProduit.CurrentRow.Cells[1].Value;
                PR = db.Produits.SingleOrDefault(s => s.ID_Produit == MYIDSELECT);
                if (PR != null)
                {
                    MemoryStream MS = new MemoryStream(PR.Image_Produit);
                    frmproduit.picProduit.Image = Image.FromStream(MS);
                }
                
            }
            frmproduit.ShowDialog();
        }

        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {
            Actualiserdvg();

        }

        
        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Voulez vous vraiment supprimer les supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                if (dvgProduit.CurrentRow != null)
                {
                        BL.CLS_Produit clproduit = new BL.CLS_Produit();
                        int idselect = (int)dvgProduit.CurrentRow.Cells[1].Value;// id de la ligne cocher
                        clproduit.Supprimer_Produit(idselect);
                    
                }
                //actualiser datagrid view
                Actualiserdvg();
                MessageBox.Show("suppression avec succe", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("suppression et annule", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SDF = new SaveFileDialog() { Filter = "Excel Workbook |*xlsx", ValidateNames = true })//filtrer seulement fichier excel
            {
                if (SDF.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    //Les noms des colones :
                    ws.Cells[1, 1] = "ID Produit";
                    ws.Cells[1, 2] = "Nom Produit";
                    ws.Cells[1, 3] = "Quantite Produit";
                    ws.Cells[1, 4] = "Prix Produit";
                    //liste des produits
                    var ListeProduit = db.Produits.ToList();
                    int i = 2;
                    foreach (var L in ListeProduit)
                    {
                        ws.Cells[i, 1] = L.ID_Produit;
                        ws.Cells[i, 2] = L.Nom_Produit;
                        ws.Cells[i, 3] = L.Quantité_Produit;
                        ws.Cells[i, 3] = L.Prix_Produit;
                        i++;
                    }
                    //Mise en forme de l'excel
                    ws.Range["A1:D1"].Interior.Color = Color.Teal;
                    ws.Range["A1:D1"].Font.Color = Color.White;
                    ws.Range["A1:D1"].Font.Size = 15;
                    ws.Range["A1:D1"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Range["A1:D1"].ColumnWidth = 16;
                    //Fermer classeur
                    wb.SaveAs(SDF.FileName);
                    app.Quit();
                    MessageBox.Show("Sauvegarde ok", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            Actualiserdvg();
        }
       
        private void btnSupCombo_Click(object sender, EventArgs e)
        {
            combocategorie.SelectedIndex = -1;
            combotype.SelectedIndex = -1;
            Actualiserdvg();
        }

        private void combotype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        private void txtrechercheInvProd_TextChanged(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        private void txtrechercheNom_TextChanged(object sender, EventArgs e)
        {
            Actualiserdvg();
        }
        private void combocategorie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        
    }

}
