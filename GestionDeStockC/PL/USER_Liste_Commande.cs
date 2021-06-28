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
    public partial class USER_Liste_Commande : UserControl
    {
        private static USER_Liste_Commande Userclient;
        private dbStockContext db;
        //creer instance pour le usercontrole
        public static USER_Liste_Commande Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Liste_Commande();
                }
                return Userclient;
            }
        }
        public USER_Liste_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        //Remplir datagrid commande
        public void Actualisedatagrid()
        {
            dvgCommande.Visible = false;
            dvgCommande.Rows.Clear();
            dvgCommande.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            var listecommande = db.Commandes.ToList();
            Client c = new Client();
            string NomPrenom;

             foreach (var LC in listecommande)
             {
                 c = db.Clients.Single(s => s.ID_Client == LC.ID_Client);
                 NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
            
                dvgCommande.Rows.Add(LC.ID_Commande, LC.DATE_Commande, NomPrenom, LC.Total_HT);
             }
                ListSortDirection TryDirection = ListSortDirection.Descending;
                dvgCommande.Sort(dvgCommande.Columns[0], TryDirection);
                dvgCommande.ClearSelection();

            if (txtNumCommande.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgCommande.Rows)
                {
                    if ((r.Cells[0].Value).ToString().ToUpper().Contains(txtNumCommande.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgCommande.CurrentCell = null;
                        dvgCommande.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (txtClient.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgCommande.Rows)
                {
                    if ((r.Cells[2].Value).ToString().ToUpper().Contains(txtClient.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgCommande.CurrentCell = null;
                        dvgCommande.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (txtPeriode.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgCommande.Rows)
                {
                    if ((r.Cells[1].Value).ToString().ToUpper().Contains(txtPeriode.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgCommande.CurrentCell = null;
                        dvgCommande.Rows[r.Index].Visible = false;
                    }
                }
            }
            dvgCommande.Visible = true;
        }
       
        private void btnajouter_Click(object sender, EventArgs e)
        {
            //afficher formulaire ajout client
            PL.FRM_Detail_Commande frmC = new FRM_Detail_Commande(this);
            frmC.ShowDialog();
        }

        private void USER_Liste_Commande_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }
        private void txtNumCde_TextChanged(object sender, EventArgs e)
        {
            dvgDetailCde.Rows.Clear();
            var listerecherche = db.Details_Commande.ToList();
            Produit Inventaire = new Produit();
            listerecherche = listerecherche.Where(s => s.ID_Commande.ToString() == txtNumCde.Text).ToList();
      
            foreach (var LC in listerecherche)
            {
                Inventaire = db.Produits.SingleOrDefault(s => s.ID_Produit == LC.ID_Produit);
                dvgDetailCde.Rows.Add(Inventaire.NumInventaire, LC.Nom_Produit, LC.Quantite, LC.Remise);
            }
            dvgDetailCde.ClearSelection();
        }
        private void dvgCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumCde.Text = dvgCommande.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtNumCommande_TextChanged(object sender, EventArgs e)
        {
           // txtNumCde.Text = "";
            Actualisedatagrid();
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {
          //  txtNumCde.Text = "";
            Actualisedatagrid();
        }

        private void txtPeriode_TextChanged(object sender, EventArgs e)
        {
          //  txtNumCde.Text = "";
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
                    ws.Cells[1, 4] = "Total HT";

                    //liste des produits
                    var ListeCommande = db.Commandes.ToList();
                    int i = 2;
                    Client Clt = new Client();
                    foreach (var L in ListeCommande)
                    {
                        ws.Cells[i, 1] = L.ID_Commande;
                        ws.Cells[i, 2] = L.DATE_Commande;
                        Clt = db.Clients.SingleOrDefault(s => s.ID_Client == L.ID_Client);
                        ws.Cells[i, 3] = Clt.Nom_Client + " " + Clt.Prenom_Client;
                        ws.Cells[i, 4] = L.Total_HT;


                        i++;
                    }
                    //Mise en forme de l'excel
                    ws.Range["A1:D1"].Interior.Color = Color.Blue;
                    ws.Range["A1:D1"].Font.Color = Color.White;
                    ws.Range["A1:D1"].Font.Size = 15;
                    ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Range["A1:D1"].ColumnWidth = 16;



                    //Fermer classeur
                    wb.SaveAs(SDF.FileName);
                    app.Quit();
                    MessageBox.Show("Sauvegarde ok", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
