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
    public partial class USER_Liste_Livraison : UserControl
    {
        private static USER_Liste_Livraison Userclient;
        private dbStockContext db;
        public static USER_Liste_Livraison Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Liste_Livraison();
                }
                return Userclient;
            }
        }
        public USER_Liste_Livraison()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        public void Actualisedatagrid()
        {
            dvgLivraison.Visible = false;
            dvgLivraison.Rows.Clear();
            dvgLivraison.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            var listelivraison = db.Livraisons.ToList();
            Client c = new Client();
            string NomPrenom;
            listelivraison = listelivraison.Where(s => (s.ID_Livraison).ToString().IndexOf(txtNumLivraison.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && (s.Date_Livraison).ToString().IndexOf(txtPeriode.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && s.Num_Document.IndexOf(txtDocument.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && s.Fournisseur.IndexOf(txtFournisseur.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

            foreach (var LC in listelivraison)
            {
                c = db.Clients.Single(s => s.ID_Client == LC.ID_Client);
                NomPrenom = c.Nom_Client + " " + c.Prenom_Client;

                dvgLivraison.Rows.Add(LC.ID_Livraison, LC.Date_Livraison, NomPrenom, LC.Fournisseur, LC.Num_Document);
            }
            ListSortDirection TryDirection = ListSortDirection.Descending;
            dvgLivraison.Sort(dvgLivraison.Columns[0], TryDirection);
            dvgLivraison.ClearSelection();

            if (txtClient.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgLivraison.Rows)
                {
                    if ((r.Cells[2].Value).ToString().ToUpper().Contains(txtClient.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgLivraison.CurrentCell = null;
                        dvgLivraison.Rows[r.Index].Visible = false;
                    }
                }
            }
            dvgLivraison.Visible = true;
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            //afficher formulaire ajout client
            PL.FRM_Detail_Livraison frmL = new FRM_Detail_Livraison(this);
            frmL.ShowDialog();
        }

        private void USER_Liste_Livraison_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }
        private void txtNumLiv_TextChanged(object sender, EventArgs e)
        {
            dvgDetailLiv.Rows.Clear();
            var listerecherche = db.Details_Livraison.ToList();
            Produit Inventaire = new Produit();
            listerecherche = listerecherche.Where(s => s.ID_Livraison.ToString() == txtNumLiv.Text).ToList();

            foreach (var LV in listerecherche)
            {
                Inventaire = db.Produits.SingleOrDefault(s => s.ID_Produit == LV.ID_Produit);
                dvgDetailLiv.Rows.Add(Inventaire.NumInventaire, LV.Nom_Produit, LV.Quantite);
            }
            dvgDetailLiv.ClearSelection();
        }
        private void dvgCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtNumLiv.Text = dvgLivraison.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtNumLivraison_TextChanged(object sender, EventArgs e)
        {
          //  txtNumLiv.Text = "";
            Actualisedatagrid();
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {
         //   txtNumLiv.Text = "";
            Actualisedatagrid();
        }

        private void txtPeriode_TextChanged(object sender, EventArgs e)
        {
          //  txtNumLiv.Text = "";
            Actualisedatagrid();
        }

        private void dvgLivraison_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNumLiv.Text = dvgLivraison.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtFournisseur_TextChanged(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }

        private void txtDocument_TextChanged(object sender, EventArgs e)
        {
            Actualisedatagrid();
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
                    ws.Cells[1, 1] = "Numero";
                    ws.Cells[1, 2] = "Date";
                    ws.Cells[1, 3] = "Nom Client";
                    ws.Cells[1, 4] = "Fournisseur";
                    ws.Cells[1, 5] = "Document";
                    
                    //liste des produits
                    var ListeLivraison = db.Livraisons.ToList();
                    int i = 2;
                    Client Clt = new Client();
                    foreach (var L in ListeLivraison)
                    {
                        ws.Cells[i, 1] = L.ID_Livraison;
                        ws.Cells[i, 2] = L.Date_Livraison;
                        Clt = db.Clients.SingleOrDefault(s => s.ID_Client == L.ID_Client);
                        ws.Cells[i, 3] = Clt.Nom_Client + " " + Clt.Prenom_Client;
                        ws.Cells[i, 4] = L.Fournisseur;
                        ws.Cells[i, 5] = L.Num_Document;
                        
                        i++;
                    }
                    //Mise en forme de l'excel
                    ws.Range["A1:E1"].Interior.Color = Color.Blue;
                    ws.Range["A1:E1"].Font.Color = Color.White;
                    ws.Range["A1:E1"].Font.Size = 15;
                    ws.Range["A:E"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Range["A1:E1"].ColumnWidth = 16;



                    //Fermer classeur
                    wb.SaveAs(SDF.FileName);
                    app.Quit();
                    MessageBox.Show("Sauvegarde ok", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}