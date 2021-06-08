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

            //afficher client selon table dans combobox
            comboclient.DataSource = db.Clients.ToList();
            //pour filtrer seulement les nom de categorie
            comboclient.DisplayMember = ("Nom_Client" + "Premon_Client");//afficher les nom des categorie
            comboclient.ValueMember = "ID_Client";
            comboclient.SelectedIndex = -1;
            
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
            dvgAffectationProduit.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
            db = new dbStockContext();
            var listerecherche = db.Affectations.ToList();//liste de recherche = liste des clients
            /**
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



                listerecherche = listerecherche.Where(s => s.ID_Type && IdCat == s.ID_Categorie).ToList();
            }
            
            if (combocategorie.SelectedItem != null)
            {
                string CategRecherche = combocategorie.SelectedValue.ToString();
                int IdCateg;
                bool testCateg = Int32.TryParse(CategRecherche, out IdCateg);

                listerecherche = listerecherche.Where(s => s.ID_Produit != -1).ToList();
            }

            if (combotype.SelectedItem != null)
            {
                string TypeRecherche = combotype.SelectedValue.ToString();
                int IdType;
                bool testType = Int32.TryParse(TypeRecherche, out IdType);

                listerecherche = listerecherche.Where(s => s.ID_Produit != -1).ToList();
            }
            if (combocategorie.SelectedItem == null && combotype.SelectedItem == null)
                
                listerecherche = listerecherche.Where(s => s.ID_Produit.IndexOf(txtrechercheInvProd.Text, StringComparison.CurrentCultureIgnoreCase) != -1 && s.Nom_Produit.IndexOf(txtrechercheNom.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            **/

            dvgAffectationProduit.Rows.Clear();

            
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

                /**
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

                    listerecherche = listerecherche.Where(s => IdTyp == NomType.ID_Type && IdCat == Nomcat.ID_Categorie).ToList();
                }
                **/
                if (combocategorie.SelectedItem != null)
                {
                    
                    string CategRecherche = combocategorie.SelectedValue.ToString();
                    int IdCateg;
                    bool testCateg = Int32.TryParse(CategRecherche, out IdCateg);

                    string CTR = CatProd.ID_Categorie.ToString();
                    int CT;
                    bool testC = Int32.TryParse(CTR, out CT);


                    MessageBox.Show(CategRecherche.ToString());
                    MessageBox.Show(CTR.ToString());

                    
                    listerecherche = listerecherche.Where(s => IdCateg == CT).ToList();

                    
                        dvgAffectationProduit.Rows.Add(false, false, Clt.Prenom_Client, Nomcat.Nom_Categorie, NomType.Nom_Type, Prod.NumInventaire, Prod.Nom_Produit, l.Quantite_affectee, DateCtrl.Date_Controle);
                    
                }
                else
                {
                    dvgAffectationProduit.Rows.Add(false, false, Clt.Prenom_Client, Nomcat.Nom_Categorie, NomType.Nom_Type, Prod.NumInventaire, Prod.Nom_Produit, l.Quantite_affectee, DateCtrl.Date_Controle);
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Actualiserdvg();
        }
    }
}
