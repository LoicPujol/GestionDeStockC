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
        public void Actualiserdvg()
        {
            db = new dbStockContext();
            dvgStock.Rows.Clear();
            //Pour afficher le nom de categorie a partir de idcategorie
            Categorie Cat = new Categorie();
            Type Typ = new Type();//ajout pout type
            foreach (var Lis in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == Lis.ID_Categorie);
                Typ = db.Types.SingleOrDefault(s => s.ID_Type == Lis.ID_Type);//ajout type
                if (Cat != null & Typ != null & Lis.Quantité_Produit <= Lis.Stock_Alerte)//si existe
                {
                    dvgStock.Rows.Add(false, Lis.ID_Produit, Lis.Nom_Produit, Lis.Quantité_Produit, Cat.Nom_Categorie, Typ.Nom_Type, Lis.Stock_Alerte);//cat.Nom pour afficher nom de cagorie depuis table categorie
                }
            }
            for (int i = 0; i < dvgStock.Rows.Count; i++)
            {
                if ((int)dvgStock.Rows[i].Cells[3].Value == 0)
                {
                    dvgStock.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgStock.Rows[i].Cells[3].Style.BackColor = Color.Orange;
                }
            dvgStock.ClearSelection();
            }
        }

        private void USER_Alerte_Load(object sender, EventArgs e)
        {
            Actualiserdvg();
        }
    }
}
