using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace GestionDeStockC.PL
{
    public partial class USER_Affectation : UserControl
    {
        private static USER_Affectation Userclient;
        private dbStockContext db;
        //creer instance pour le usercontrole
        public static USER_Affectation Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Affectation();
                }
                return Userclient;
            }
        }
        public USER_Affectation()
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
        public void Actualiserdvg()
        {
            dvgAffectationProduit.Rows.Clear();
            dvgAffectationProduit.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
            db = new dbStockContext();
            var listerecherche = db.Affectations.ToList();//liste de recherche = liste des affectations

            Produit Prod = new Produit();
            Produit CatProd = new Produit();
            Produit TypProd = new Produit();
            Produit DateCtrl = new Produit();
            Categorie Nomcat = new Categorie();
            Type NomType = new Type();
            Client Clt = new Client();
            foreach (var l in listerecherche)
            {
                Clt = db.Clients.SingleOrDefault(s => s.ID_Client == l.ID_Client);
                Prod = db.Produits.SingleOrDefault(s => s.ID_Produit == l.ID_Produit);
                CatProd = db.Produits.SingleOrDefault(s => s.ID_Produit == l.ID_Produit);
                Nomcat = db.Categories.SingleOrDefault(s => s.ID_Categorie == CatProd.ID_Categorie);
                TypProd = db.Produits.SingleOrDefault(s => s.ID_Produit == l.ID_Produit);
                NomType = db.Types.SingleOrDefault(s => s.ID_Type == TypProd.ID_Type);
                DateCtrl = db.Produits.SingleOrDefault(s => s.ID_Produit == l.ID_Produit);

                dvgAffectationProduit.Rows.Add(false, false, Nomcat.Nom_Categorie, NomType.Nom_Type, Clt.Nom_Client + " " + Clt.Prenom_Client, Prod.NumInventaire, Prod.Nom_Produit, l.Quantite_affectee, DateCtrl.Date_Controle);
            }

            if (txtrechercheInvProd.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgAffectationProduit.Rows)
                {
                    if ((r.Cells[5].Value).ToString().ToUpper().Contains(txtrechercheInvProd.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgAffectationProduit.CurrentCell = null;
                        dvgAffectationProduit.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (txtrechercheNom.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgAffectationProduit.Rows)
                {
                    if ((r.Cells[6].Value).ToString().ToUpper().Contains(txtrechercheNom.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgAffectationProduit.CurrentCell = null;
                        dvgAffectationProduit.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (txtrechercheClient.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgAffectationProduit.Rows)
                {
                    if ((r.Cells[4].Value).ToString().ToUpper().Contains(txtrechercheClient.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgAffectationProduit.CurrentCell = null;
                        dvgAffectationProduit.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (combocategorie.SelectedItem != null)
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgAffectationProduit.Rows)
                {
                    if ((r.Cells[2].Value).ToString().ToUpper().Contains(combocategorie.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgAffectationProduit.CurrentCell = null;
                        dvgAffectationProduit.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (combotype.SelectedItem != null)
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgAffectationProduit.Rows)
                {
                    if ((r.Cells[3].Value).ToString().ToUpper().Contains(combotype.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgAffectationProduit.CurrentCell = null;
                        dvgAffectationProduit.Rows[r.Index].Visible = false;
                    }
                }
            }
            dvgAffectationProduit.ClearSelection();
        }

        private void USER_Affectation_Load(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        private void combocategorie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        private void combotype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        private void comboclient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Actualiserdvg();
        }
               
        private void btnSupCombo_Click_1(object sender, EventArgs e)
        {
            combocategorie.SelectedIndex = -1;
            combotype.SelectedIndex = -1;
            txtrechercheClient.Text = "";
            txtrechercheInvProd.Text = "";
            txtrechercheNom.Text = "";
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

        private void txtrechercheClient_TextChanged(object sender, EventArgs e)
        {
            Actualiserdvg();
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
                    ws.Cells[1, 1] = "Categorie";
                    ws.Cells[1, 2] = "Type";
                    ws.Cells[1, 3] = "Client";
                    ws.Cells[1, 4] = "Num Inv";
                    ws.Cells[1, 5] = "Designation";
                    ws.Cells[1, 6] = "Quantite";
                    ws.Cells[1, 7] = "Controle";

                    //liste des produits
                    var ListeAffectation = db.Affectations.ToList();
                    int i = 2;
                    Produit Prod = new Produit();
                    Produit CatProd = new Produit();
                    Produit TypProd = new Produit();
                    Produit DateCtrl = new Produit();
                    Categorie Nomcat = new Categorie();
                    Type NomType = new Type();
                    Client Clt = new Client();
                    foreach (var L in ListeAffectation)
                    {
                        CatProd = db.Produits.SingleOrDefault(s => s.ID_Produit == L.ID_Produit);
                        Nomcat = db.Categories.SingleOrDefault(s => s.ID_Categorie == CatProd.ID_Categorie);
                        ws.Cells[i, 1] = Nomcat.Nom_Categorie;
                        TypProd = db.Produits.SingleOrDefault(s => s.ID_Produit == L.ID_Produit);
                        NomType = db.Types.SingleOrDefault(s => s.ID_Type == TypProd.ID_Type);
                        ws.Cells[i, 2] = NomType.Nom_Type;
                        Clt = db.Clients.SingleOrDefault(s => s.ID_Client == L.ID_Client);
                        ws.Cells[i, 3] = Clt.Nom_Client + " " + Clt.Prenom_Client;
                        Prod = db.Produits.SingleOrDefault(s => s.ID_Produit == L.ID_Produit);
                        ws.Cells[i, 4] = Prod.NumInventaire;
                        ws.Cells[i, 5] = Prod.Nom_Produit;
                        ws.Cells[i, 6] = L.Quantite_affectee;
                        ws.Cells[i, 7] = Prod.Date_Controle;


                        i++;
                    }
                    //Mise en forme de l'excel
                    ws.Range["A1:G1"].Interior.Color = Color.Blue;
                    ws.Range["A1:G1"].Font.Color = Color.White;
                    ws.Range["A1:G1"].Font.Size = 15;
                    ws.Range["A:G"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Range["A1:G1"].ColumnWidth = 16;



                    //Fermer classeur
                    wb.SaveAs(SDF.FileName);
                    app.Quit();
                    MessageBox.Show("Sauvegarde ok", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
