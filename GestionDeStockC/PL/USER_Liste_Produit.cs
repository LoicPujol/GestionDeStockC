using System;
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
            combocategorie.DisplayMember = "Nom_Categorie";
            combocategorie.ValueMember = "ID_Categorie";
            combocategorie.SelectedIndex = -1;

            //afficher type selon table dans combobox
            combotype.DataSource = db.Types.ToList();
            combotype.DisplayMember = "Nom_Type";
            combotype.ValueMember = "ID_Type";
            combotype.SelectedIndex = -1;

        }
        public void Actualiserdvg()
        {

            dvgProduit.Visible = false;
            dvgProduit.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            db = new dbStockContext();
            var listerecherche = db.Produits.ToList();
            dvgProduit.Rows.Clear();

            if (combocategorie.SelectedItem == null && combotype.SelectedItem == null)
            {
                listerecherche = listerecherche.Where(s => s.NumInventaire.IndexOf(txtrechercheInvProd.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && s.Nom_Produit.IndexOf(txtrechercheNom.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            }
            //dvgProduit.Rows.Clear();

            Categorie cat = new Categorie();
            Type typ = new Type();//ajout pout type
            foreach (var l in listerecherche)
            {
                cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == l.ID_Categorie);
                typ = db.Types.SingleOrDefault(s => s.ID_Type == l.ID_Type);//ajout type
                dvgProduit.Rows.Add(l.ID_Produit, cat.Nom_Categorie, typ.Nom_Type, l.NumInventaire, l.Nom_Produit,l.Stock_Alerte, l.Prix_Produit, l.Date_Controle, l.N_Serie, l.Poids, l.Marge, l.Tarif_Achat);
            }
            //colorer stock vide en rouge
            dvgProduit.ClearSelection();
            dvgProduit.Visible = true;
        }
        /**dvgProduit.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
        db = new dbStockContext();
        var listerecherche = db.Produits.ToList();
        dvgProduit.Rows.Clear();

                Categorie cat = new Categorie();
                Type typ = new Type();//ajout pout type
                foreach (var l in listerecherche)
                {
                    cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == l.ID_Categorie);
                    typ = db.Types.SingleOrDefault(s => s.ID_Type == l.ID_Type);//ajout type
                    dvgProduit.Rows.Add(l.ID_Produit, cat.Nom_Categorie, typ.Nom_Type, l.NumInventaire, l.Nom_Produit, l.Quantité_Produit, l.Stock_Alerte, l.Prix_Produit,  l.Date_Controle, l.N_Serie, l.Poids, l.Marge, l.Tarif_Achat);
                }
        if (txtrechercheInvProd.Text.ToString() != "")
        {
            foreach (System.Windows.Forms.DataGridViewRow r in dvgProduit.Rows)
            {
                if ((r.Cells[3].Value).ToString().ToUpper().Contains(txtrechercheInvProd.Text.ToString().ToUpper()))
                {
                    //dvgAffectationProduit.Rows[r.Index].Visible = true;
                    //dvgAffectationProduit.Rows[r.Index].Selected = true;
                }
                else
                {
                    dvgProduit.CurrentCell = null;
                    dvgProduit.Rows[r.Index].Visible = false;
                }
            }
        }
        if (txtrechercheNom.Text.ToString() != "")
        {
            foreach (System.Windows.Forms.DataGridViewRow r in dvgProduit.Rows)
            {
                if ((r.Cells[4].Value).ToString().ToUpper().Contains(txtrechercheNom.Text.ToString().ToUpper()))
                {
                    //dvgAffectationProduit.Rows[r.Index].Visible = true;
                    //dvgAffectationProduit.Rows[r.Index].Selected = true;
                }
                else
                {
                    dvgProduit.CurrentCell = null;
                    dvgProduit.Rows[r.Index].Visible = false;
                }
            }
        }
        if (combocategorie.SelectedItem != null)
        {
            foreach (System.Windows.Forms.DataGridViewRow r in dvgProduit.Rows)
            {
                if ((r.Cells[1].Value).ToString().ToUpper().Contains(combocategorie.Text.ToString().ToUpper()))
                {
                    //dvgAffectationProduit.Rows[r.Index].Visible = true;
                    //dvgAffectationProduit.Rows[r.Index].Selected = true;
                }
                else
                {
                    dvgProduit.CurrentCell = null;
                    dvgProduit.Rows[r.Index].Visible = false;
                }
            }
        }
        if (combotype.SelectedItem != null)
        {
            foreach (System.Windows.Forms.DataGridViewRow r in dvgProduit.Rows)
            {
                if ((r.Cells[2].Value).ToString().ToUpper().Contains(combotype.Text.ToString().ToUpper()))
                {
                    //dvgAffectationProduit.Rows[r.Index].Visible = true;
                    //dvgAffectationProduit.Rows[r.Index].Selected = true;
                }
                else
                {
                    dvgProduit.CurrentCell = null;
                    dvgProduit.Rows[r.Index].Visible = false;
                }
            }
        }**/


        private void btnajouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Porduit frmProduit = new PL.FRM_Ajouter_Modifier_Porduit(this);
            frmProduit.grpUnitaire.Visible = false;
            frmProduit.ShowDialog();
        }
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            PL.FRM_Ajouter_Modifier_Porduit frmproduit = new PL.FRM_Ajouter_Modifier_Porduit(this);
            //if ((dvgProduit.CurrentRow != null) && (dvgProduit.Rows.Count != 0))
            if (dvgProduit.SelectedRows.Count != 0 && (dvgProduit.Rows.Count != 0))
            {

                frmproduit.lblTitre.Text = "Modifier Produit";
                    frmproduit.IDPRODUIT = (int)dvgProduit.CurrentRow.Cells[0].Value;
                    frmproduit.combocategorie.Text = dvgProduit.CurrentRow.Cells[1].Value.ToString();
                    frmproduit.combotype.Text = dvgProduit.CurrentRow.Cells[2].Value.ToString();
                    frmproduit.combotype.Enabled = false;
                    frmproduit.txtInventaireProd.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                    frmproduit.txtInventaireProd.ForeColor = Color.Silver;
                    frmproduit.txtInventaireProd.Enabled = false;
                    frmproduit.txtNomP.Text = dvgProduit.CurrentRow.Cells[4].Value.ToString();
                    frmproduit.txtQuantite.Text = dvgProduit.CurrentRow.Cells[5].Value.ToString();
                    frmproduit.txtStockAlerte.Text = dvgProduit.CurrentRow.Cells[6].Value.ToString();
                    frmproduit.txtTarifAchat.Text = dvgProduit.CurrentRow.Cells[10].Value.ToString();
                    frmproduit.txtPrix.Text = dvgProduit.CurrentRow.Cells[7].Value.ToString();
                    frmproduit.txtNumSerie.Text = dvgProduit.CurrentRow.Cells[9].Value.ToString();

                    //frmproduit.txtMarge.Text = dvgProduit.CurrentRow.Cells[12].Value.ToString();
                    frmproduit.txtPoids.Text = dvgProduit.CurrentRow.Cells[10].Value.ToString();
                    
                    if (dvgProduit.CurrentRow.Cells[2].Value.ToString() == "Unitaire")
                    {
                        frmproduit.grpUnitaire.Visible = true;
                    }
                    else
                    {
                        frmproduit.grpUnitaire.Visible = false;
                    }
                    //Afficher date controle
                    if (dvgProduit.CurrentRow.Cells[8].Value != null)
                    {
                        frmproduit.checkDate.Visible = true;
                        frmproduit.checkDate.Checked = true;
                        frmproduit.btnDate.Visible = true;
                        frmproduit.txtDateCtrl.Visible = true;
                        frmproduit.txtDateCtrl.Text = dvgProduit.CurrentRow.Cells[8].Value.ToString();
                    }
                        //Afficher image produit
                    int MYIDSELECT = (int)dvgProduit.CurrentRow.Cells[0].Value;
                    PR = db.Produits.SingleOrDefault(s => s.ID_Produit == MYIDSELECT);
                    if (PR.Image_Produit != null)
                    {
                        MemoryStream MS = new MemoryStream(PR.Image_Produit);
                        frmproduit.picProduit.Image = Image.FromStream(MS);
                    }
                    frmproduit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun article selectionnee", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {
           Actualiserdvg();
        }
        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dvgProduit.CurrentRow.Cells[0].Value.ToString());
            if ((dvgProduit.CurrentRow != null) || (dvgProduit.Rows.Count != 0))
            {
                DialogResult R = MessageBox.Show("Voulez vous vraiment supprimer un produit", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    BL.CLS_Produit clproduit = new BL.CLS_Produit();

                    int idselect = (int)dvgProduit.CurrentRow.Cells[0].Value;// id de la ligne cocher
                    int NbreProd = db.Affectations.Count(s => s.ID_Produit == idselect);
                    if (NbreProd == 0)
                    {
                        clproduit.Supprimer_Produit(idselect);
                        Actualiserdvg();
                        MessageBox.Show("suppression avec succe", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        DialogResult PDR = MessageBox.Show("Il y a " + NbreProd + " affectatins pour ce produit vous ne pouvez pas le supprimer", "Supprime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun client selectionnee", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ws.Cells[1, 1] = "Numero Inventaire";
                    ws.Cells[1, 2] = "Categorie";
                    ws.Cells[1, 3] = "Type";
                    ws.Cells[1, 4] = "Designation";
                    ws.Cells[1, 5] = "Tarif achat";
                    ws.Cells[1, 6] = "Tarif vente";
                    ws.Cells[1, 7] = "Marge";
                    ws.Cells[1, 8] = "Stock alerte";
                    ws.Cells[1, 9] = "Date contrôle";
                    ws.Cells[1, 10] = "Numero serie";
                    ws.Cells[1, 11] = "Poids";
                    
                    //liste des produits
                    var ListeProduit = db.Produits.ToList();
                    int i = 2;
                    Categorie cat = new Categorie();
                    Type typ = new Type();
                    foreach (var L in ListeProduit)
                    {
                        ws.Cells[i, 1] = L.NumInventaire;
                        cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == L.ID_Categorie);
                        ws.Cells[i, 2] = cat.Nom_Categorie;
                        typ = db.Types.SingleOrDefault(s => s.ID_Type == L.ID_Type);
                        ws.Cells[i, 3] = typ.Nom_Type;
                        ws.Cells[i, 4] = L.Nom_Produit;
                        ws.Cells[i, 5] = L.Tarif_Achat;
                        ws.Cells[i, 6] = L.Prix_Produit;
                        ws.Cells[i, 7] = L.Marge;
                        ws.Cells[i, 8] = L.Stock_Alerte;
                        ws.Cells[i, 9] = L.Date_Controle;
                        ws.Cells[i, 10] = L.N_Serie;
                        ws.Cells[i, 11] = L.Poids;
                        i++;
                    }
                    //Mise en forme de l'excel
                    ws.Range["A1:K1"].Interior.Color = Color.Blue;
                    ws.Range["A1:K1"].Font.Color = Color.White;
                    ws.Range["A1:K1"].Font.Size = 15;
                    ws.Range["A:K"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Range["A1:K1"].ColumnWidth = 16;



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
            txtrechercheInvProd.Text = "";
            txtrechercheNom.Text = "";
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
        public byte[] byteimageP;
        private void dvgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCat.Text = "";
            txtTyp.Text = "";
            txtInventaireProd.Text = "";
            txtNomP.Text = "";
            txtStockAlerte.Text = "";
            txtPrix.Text = "";
            txtDateCtrl.Text = "";
            txtNumSerie.Text = "";
            txtPoids.Text = "";
            txtMarge.Text = "";
            txtTarifAchat.Text = "";
            picProduit.Image = null;

            Produit PR = new Produit();
                
                txtCat.Text = dvgProduit.CurrentRow.Cells[1].Value.ToString();
                //txtCat.ForeColor = Color.Silver;
                //txtCat.Enabled = false;
                txtTyp.Text = dvgProduit.CurrentRow.Cells[2].Value.ToString();
                //txtTyp.ForeColor = Color.Silver;
                //txtTyp.Enabled = false;
                txtInventaireProd.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                //txtInventaireProd.ForeColor = Color.Silver;
                //txtInventaireProd.Enabled = false;
                txtNomP.Text = dvgProduit.CurrentRow.Cells[4].Value.ToString();
                //txtNomP.ForeColor = Color.Silver;
                //txtNomP.Enabled = false;
                txtStockAlerte.Text = dvgProduit.CurrentRow.Cells[5].Value.ToString();
                //txtStockAlerte.ForeColor = Color.Silver;
                //txtStockAlerte.Enabled = false;
                txtPrix.Text = dvgProduit.CurrentRow.Cells[6].Value.ToString();
                //txtPrix.ForeColor = Color.Silver;
                //txtPrix.Enabled = false;
                txtDateCtrl.Text = dvgProduit.CurrentRow.Cells[7].Value.ToString();
                txtNumSerie.Text = dvgProduit.CurrentRow.Cells[8].Value.ToString();
                //txtNumSerie.ForeColor = Color.Silver;
                //txtNumSerie.Enabled = false;
                txtPoids.Text = dvgProduit.CurrentRow.Cells[9].Value.ToString();
                //txtPoids.ForeColor = Color.Silver;
                //txtPoids.Enabled = false;
                txtMarge.Text = dvgProduit.CurrentRow.Cells[10].Value.ToString();
                //txtMarge.ForeColor = Color.Silver;
                //txtMarge.Enabled = false;
                txtTarifAchat.Text = dvgProduit.CurrentRow.Cells[11].Value.ToString();
                //txtTarifAchat.ForeColor = Color.Silver;
                //txtTarifAchat.Enabled = false;
                int MYIDSELECT = (int)dvgProduit.CurrentRow.Cells[0].Value;
                PR = db.Produits.SingleOrDefault(s => s.ID_Produit == MYIDSELECT);
                if (PR.Image_Produit != null)
                {
                    MemoryStream MS = new MemoryStream(PR.Image_Produit);
                    picProduit.Image = Image.FromStream(MS);
                }
        }
    }
}
