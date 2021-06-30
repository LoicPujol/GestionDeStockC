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
    public partial class USER_Liste_Categorie : UserControl
    {
        private static USER_Liste_Categorie Userclient;
        private dbStockContext db;
        //creer instance pour le usercontrole
        public static USER_Liste_Categorie Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Liste_Categorie();
                }
                return Userclient;
            }
        }
        public USER_Liste_Categorie()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        //ajouter des datagridview
        public void Actualisedatagrid()
        {
            db = new dbStockContext();
            dvgCategorie.Rows.Clear();//vider datagrid view
            foreach (var cat in db.Categories)
            {
                dvgCategorie.Rows.Add(false, cat.ID_Categorie, cat.Nom_Categorie);//ajouter ligne dans datagrid
            }
        }
        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void USER_Liste_Categorie_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }
        private void btnajouter_Click(object sender, EventArgs e)
        {
            //afficher formulaire ajout client
            PL.FRM_Ajoute_Modifier_Categorie frmcat = new FRM_Ajoute_Modifier_Categorie(this);
            frmcat.ShowDialog();
        }
        private void dvgCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Categorie frmcat = new FRM_Ajoute_Modifier_Categorie(this);
            if (dvgCategorie.Columns[e.ColumnIndex].Name == "Modifier")
            {
                //id de categorie
                frmcat.idcategorie = (int)dvgCategorie.Rows[e.RowIndex].Cells[1].Value;
                frmcat.lblTitre.Text = "Modifier Categorie";
                frmcat.txtNom.Text = dvgCategorie.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmcat.txtNom.ForeColor = Color.Black;
                frmcat.ShowDialog();
            }
            //supprimer categorie
            if(dvgCategorie.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                BL.CLS_Categorie clscat = new BL.CLS_Categorie();
                DialogResult PR = MessageBox.Show("Voulez vous vraiment suprimer", "supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(PR==DialogResult.Yes)
                {
                    //verifier si categorie non utilise
                    int idcat = (int)dvgCategorie.Rows[e.RowIndex].Cells[1].Value;
                    int P = db.Produits.Count(s => s.ID_Categorie == idcat);//count pour compter le nombre de produit dans la categorie
                    if(P==0)//si non utilise
                    {
                        clscat.Supprimer_Categorie(idcat);
                        Actualisedatagrid();
                        MessageBox.Show("Categorie supprime avec succe", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }else
                    {
                        //si il y a des articles dans la categorie
                        DialogResult PDR = MessageBox.Show("Il y a " + P + " Produit dans cette categorie vous ne pouvez pas la supprimer","Supprime",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("Supprimer annule", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.Categories.ToList();//liste de recherche = liste des categorie

            listerecherche = listerecherche.Where(s => s.Nom_Categorie.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

            //vide datagrid
            dvgCategorie.Rows.Clear();
            foreach (var l in listerecherche)
            {
                dvgCategorie.Rows.Add(false, l.ID_Categorie, l.Nom_Categorie);
            }
        }
    }
}
