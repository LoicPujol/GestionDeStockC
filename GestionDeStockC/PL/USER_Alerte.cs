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
    
    public partial class USER_Alerte : UserControl
    {
        private static USER_Alerte Userclient;
        private dbStockContext db;
        //creer instance pour le usercontrole
        public static USER_Alerte Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Alerte();
                }
                return Userclient;
            }
        }
        public USER_Alerte()
        {
            InitializeComponent();
            db = new dbStockContext();
            //afficher categorie selon table dans combobox
            combocategorieStock.DataSource = db.Categories.ToList();
            //pour filtrer seulement les nom de categorie
            combocategorieStock.DisplayMember = "Nom_Categorie";//afficher les nom des categorie
            combocategorieStock.ValueMember = "ID_Categorie";
            combocategorieStock.SelectedIndex = -1;

            //afficher type selon table dans combobox
            combotypeStock.DataSource = db.Types.ToList();
            //pour filtrer seulement les nom de categorie
            combotypeStock.DisplayMember = "Nom_Type";//afficher les nom des categorie
            combotypeStock.ValueMember = "ID_Type";
            combotypeStock.SelectedIndex = -1;

            //afficher categorie selon table dans combobox
            combocategorieCtrl.DataSource = db.Categories.ToList();
            //pour filtrer seulement les nom de categorie
            combocategorieCtrl.DisplayMember = "Nom_Categorie";//afficher les nom des categorie
            combocategorieCtrl.ValueMember = "ID_Categorie";
            combocategorieCtrl.SelectedIndex = -1;

        }
        public void ActualiserdvgStock()
        {
            db = new dbStockContext();
            dgvStock.Rows.Clear();
            Categorie Cat = new Categorie();
            Type Typ = new Type();
            Affectation IDAffect = new Affectation();
            foreach (var Lis in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == Lis.ID_Categorie);
                Typ = db.Types.SingleOrDefault(s => s.ID_Type == Lis.ID_Type);
                int Depot = 14;
                if (db.Affectations.SingleOrDefault(s => s.ID_Produit == Lis.ID_Produit && s.ID_Client == Depot) != null)// si produit affecte sur depot central ID = 10
                {
                    if ((Lis.Stock_Alerte) != "") // si un stock d'alerte est renseigne
                    {
                        if (Lis.ID_Type != 3)//si le produit n'est pas un unitaire
                        {
                            IDAffect = (db.Affectations.SingleOrDefault(s => s.ID_Produit == Lis.ID_Produit && s.ID_Client == Depot));
                            if (IDAffect.Quantite_affectee <= int.Parse(Lis.Stock_Alerte)) //si stock en alerte
                            {
                                dgvStock.Rows.Add(Lis.ID_Produit, Cat.Nom_Categorie, Typ.Nom_Type, Lis.NumInventaire, Lis.Nom_Produit, IDAffect.Quantite_affectee, Lis.Stock_Alerte);
                            }
                        }
                    }
                }
            }
            PL.USER_Dashboard.Instance.txtNbreStockAlerte.Text = (dgvStock.Rows.Count.ToString());

            if (txtrechercheInvProdStock.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dgvStock.Rows)
                {
                    if ((r.Cells[3].Value).ToString().ToUpper().Contains(txtrechercheInvProdStock.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dgvStock.CurrentCell = null;
                        dgvStock.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (txtrechercheNomStock.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dgvStock.Rows)
                {
                    if ((r.Cells[4].Value).ToString().ToUpper().Contains(txtrechercheNomStock.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dgvStock.CurrentCell = null;
                        dgvStock.Rows[r.Index].Visible = false;
                    }
                }
            }
            
            if (combocategorieStock.SelectedItem != null)
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dgvStock.Rows)
                {
                    if ((r.Cells[1].Value).ToString().ToUpper().Contains(combocategorieStock.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dgvStock.CurrentCell = null;
                        dgvStock.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (combotypeStock.SelectedItem != null)
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dgvStock.Rows)
                {
                    if ((r.Cells[2].Value).ToString().ToUpper().Contains(combotypeStock.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dgvStock.CurrentCell = null;
                        dgvStock.Rows[r.Index].Visible = false;
                    }
                }
            }
            for (int i = 0; i < dgvStock.Rows.Count; i++)
            {
                if ((int)dgvStock.Rows[i].Cells[5].Value == 0)
                {
                    dgvStock.Rows[i].Cells[5].Style.BackColor = Color.DimGray;
                }
                else
                {
                    dgvStock.Rows[i].Cells[5].Style.BackColor = Color.DarkGray;
                }
                dgvStock.ClearSelection();
            }
        }

        public void ActualiserdvgAlerte()
        {
            dgvDate.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            db = new dbStockContext();
            dgvDate.Rows.Clear();
            //Pour afficher le nom de categorie a partir de idcategorie
            Categorie Cat = new Categorie();
            Type Typ = new Type();//ajout pout type
            Affectation IDAffect = new Affectation();
            Client NomClient = new Client();
            foreach (var Lis in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == Lis.ID_Categorie);
                Typ = db.Types.SingleOrDefault(s => s.ID_Type == Lis.ID_Type);//ajout type
                
                if (Lis.Date_Controle != "")
                {
                    DateTime date = Convert.ToDateTime(Lis.Date_Controle.ToString());
                    DateTime dateDuJour = DateTime.Now;
                    int nbJours = (date - dateDuJour).Days;
                    if (Cat != null & Typ != null & nbJours <= 30)//si existe
                    {
                        if (db.Affectations.SingleOrDefault(s => s.ID_Produit == Lis.ID_Produit) != null)
                        {
                            IDAffect = db.Affectations.SingleOrDefault(s => s.ID_Produit == Lis.ID_Produit);
                            NomClient = db.Clients.SingleOrDefault(s => s.ID_Client == IDAffect.ID_Client);
                            dgvDate.Rows.Add(Lis.ID_Produit, Cat.Nom_Categorie, Typ.Nom_Type, Lis.NumInventaire, Lis.Nom_Produit, Lis.Date_Controle, nbJours, NomClient.Nom_Client + " " + NomClient.Prenom_Client);//cat.Nom pour afficher nom de cagorie depuis table categorie
                        }
                        else
                        {
                            NomClient = null;
                            dgvDate.Rows.Add(Lis.ID_Produit, Cat.Nom_Categorie, Typ.Nom_Type, Lis.NumInventaire, Lis.Nom_Produit, Lis.Date_Controle, nbJours, NomClient);//cat.Nom pour afficher nom de cagorie depuis table categorie
                        }
                    }
                }
            }
            PL.USER_Dashboard.Instance.txtNbreDateCtrlAlerte.Text = (dgvDate.Rows.Count.ToString());

            if (txtrechercheInvProdCtrl.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dgvDate.Rows)
                {
                    if ((r.Cells[3].Value).ToString().ToUpper().Contains(txtrechercheInvProdCtrl.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dgvDate.CurrentCell = null;
                        dgvDate.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (txtrechercheNomCtrl.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dgvDate.Rows)
                {
                    if ((r.Cells[4].Value).ToString().ToUpper().Contains(txtrechercheNomCtrl.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dgvDate.CurrentCell = null;
                        dgvDate.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (combocategorieCtrl.SelectedItem != null)
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dgvDate.Rows)
                {
                    if ((r.Cells[1].Value).ToString().ToUpper().Contains(combocategorieCtrl.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dgvDate.CurrentCell = null;
                        dgvDate.Rows[r.Index].Visible = false;
                    }
                }
            }
            for (int i = 0; i < dgvDate.Rows.Count; i++)
            {
                if ((int)dgvDate.Rows[i].Cells[6].Value <= 0)
                {
                    dgvDate.Rows[i].Cells[6].Style.BackColor = Color.DimGray;
                }
                else
                {
                    dgvDate.Rows[i].Cells[6].Style.BackColor = Color.DarkGray;
                }
                dgvDate.ClearSelection();
            }
        }
        private void USER_Alerte_Load(object sender, EventArgs e)
        {
            ActualiserdvgStock();
            ActualiserdvgAlerte();
        }
        public void TestDemarageAlerte()
        {
            ActualiserdvgStock();
            ActualiserdvgAlerte();
            /**if (dgvDate.Rows.Count != 0 && dgvDate.Rows != null && dgvStock.Rows.Count != 0 && dgvStock.Rows != null)
            {
              //  MessageBox.Show("Des articles sont en dessous du stock minimum et/ou arrive a terme de leur controle periodique", "Message d'alerte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }**/
        }

        private void combocategorieStock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActualiserdvgStock();
        }

        private void combotypeStock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActualiserdvgStock();
        }

        private void txtrechercheInvProdStock_TextChanged(object sender, EventArgs e)
        {
            ActualiserdvgStock();
        }

        private void txtrechercheNomStock_TextChanged(object sender, EventArgs e)
        {
            ActualiserdvgStock();
        }

        private void btnSupComboStock_Click(object sender, EventArgs e)
        {
            combocategorieStock.SelectedIndex = -1;
            combotypeStock.SelectedIndex = -1;
            txtrechercheInvProdStock.Text = "";
            txtrechercheNomStock.Text = "";
            ActualiserdvgStock();
        }

        private void btnSupComboCtrl_Click(object sender, EventArgs e)
        {
            combocategorieCtrl.SelectedIndex = -1;
            txtrechercheInvProdCtrl.Text = "";
            txtrechercheNomCtrl.Text = "";
            ActualiserdvgAlerte();
        }

        private void combocategorieCtrl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActualiserdvgAlerte();
        }
        private void txtrechercheInvProdCtrl_TextChanged(object sender, EventArgs e)
        {
            ActualiserdvgAlerte();
        }
        private void txtrechercheNomCtrl_TextChanged(object sender, EventArgs e)
        {
            ActualiserdvgAlerte();
        }

        private void txtAffectation_TextChanged(object sender, EventArgs e)
        {
            ActualiserdvgAlerte();
        }

        private void btnexcelStock_Click(object sender, EventArgs e)
        {
            /**using (SaveFileDialog SDF = new SaveFileDialog() { Filter = "Excel Workbook |*xlsx", ValidateNames = true })//filtrer seulement fichier excel
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
                    ws.Cells[1, 3] = "Num Inv";
                    ws.Cells[1, 4] = "Designation";
                    ws.Cells[1, 5] = "Quantite";
                    ws.Cells[1, 6] = "Stock alerte";

                    //liste des produits
                    var ListeProduit = db.Produits.ToList();
                    int i = 2;
                    Categorie Cat = new Categorie();
                    Type Typ = new Type();
                    Affectation IDAffect = new Affectation();

                    foreach (var L in ListeProduit)
                    {
                        Cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == L.ID_Categorie);
                        ws.Cells[i, 1] = Cat.Nom_Categorie;
                        Typ = db.Types.SingleOrDefault(s => s.ID_Type == L.ID_Type);
                        ws.Cells[i, 2] = Typ.Nom_Type;
                        ws.Cells[i, 3] = L.NumInventaire;
                        ws.Cells[i, 4] = L.Nom_Produit;
                        IDAffect = db.Affectations.SingleOrDefault(s => s.)
                        ws.Cells[i, 5] = L.Quantite_affectee;
                        ws.Cells[i, 6] = L.Stock_Alerte;


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
            }**/
        }
    }
}
