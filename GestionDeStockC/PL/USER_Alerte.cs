using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }
        //public int NbreArticleStockAlerte;
        public void ActualiserdvgStock()
        {
            db = new dbStockContext();
            dgvStock.Rows.Clear();
            //Pour afficher le nom de categorie a partir de idcategorie
            Categorie Cat = new Categorie();
            Type Typ = new Type();//ajout pout type
            foreach (var Lis in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == Lis.ID_Categorie);
                Typ = db.Types.SingleOrDefault(s => s.ID_Type == Lis.ID_Type);//ajout type
                //if (Cat != null & Typ != null & int.Parse(Lis.Quantité_Produit) <= Lis.Stock_Alerte)//si existe
             //   {
                    dgvStock.Rows.Add(false, false, Cat.Nom_Categorie, Typ.Nom_Type, Lis.NumInventaire, Lis.Nom_Produit, Lis.Quantité_Produit, Lis.Stock_Alerte);//cat.Nom pour afficher nom de cagorie depuis table categorie
            //    }
            }
            /**for (int i = 0; i < dgvStock.Rows.Count; i++)
            {
                if ((int)dgvStock.Rows[i].Cells[6].Value == 0)
                {
                    dgvStock.Rows[i].Cells[6].Style.BackColor = Color.DimGray;
                }
                else
                {
                    dgvStock.Rows[i].Cells[6].Style.BackColor = Color.DarkGray;
                }
                dgvStock.ClearSelection();
            
            }**/
          //  NbreArticleStockAlerte = dgvStock.Rows.Count;

        }
      //  public int NbreArticleDateCtrlAlerte;
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
                        bool TestNomClient;
                        IDAffect = db.Affectations.SingleOrDefault(s => s.ID_Produit == Lis.ID_Produit);
                        NomClient = db.Clients.SingleOrDefault(s => s.ID_Client == IDAffect.ID_Client);
                        if (NomClient != null)
                        {
                            TestNomClient = true;
                            dgvDate.Rows.Add(Lis.ID_Produit, Cat.Nom_Categorie, Typ.Nom_Type, Lis.NumInventaire, Lis.Nom_Produit, Lis.Date_Controle, nbJours, NomClient.Nom_Client + " " + NomClient.Prenom_Client);//cat.Nom pour afficher nom de cagorie depuis table categorie
                        }
                        else
                        {
                            dgvDate.Rows.Add(Lis.ID_Produit, Cat.Nom_Categorie, Typ.Nom_Type, Lis.NumInventaire, Lis.Nom_Produit, Lis.Date_Controle, nbJours, "Non affecte");//cat.Nom pour afficher nom de cagorie depuis table categorie
                        }
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
        //    NbreArticleDateCtrlAlerte = dgvDate.Rows.Count;
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
            if (dgvDate.Rows.Count != 0 && dgvDate.Rows != null && dgvStock.Rows.Count != 0 && dgvStock.Rows != null)
            {
              //  MessageBox.Show("Des articles sont en dessous du stock minimum et/ou arrive a terme de leur controle periodique", "Message d'alerte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
        }
    }
}
