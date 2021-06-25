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

            foreach (var LC in listelivraison)
            {
                c = db.Clients.Single(s => s.ID_Client == LC.ID_Client);
                NomPrenom = c.Nom_Client + " " + c.Prenom_Client;

                dvgLivraison.Rows.Add(LC.ID_Livraison, LC.Date_Livraison, NomPrenom);
            }
            ListSortDirection TryDirection = ListSortDirection.Descending;
            dvgLivraison.Sort(dvgLivraison.Columns[0], TryDirection);
            dvgLivraison.ClearSelection();

            if (txtNumLivraison.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgLivraison.Rows)
                {
                    if ((r.Cells[0].Value).ToString().ToUpper().Contains(txtNumLivraison.Text.ToString().ToUpper()))
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
            if (txtPeriode.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgLivraison.Rows)
                {
                    if ((r.Cells[1].Value).ToString().ToUpper().Contains(txtPeriode.Text.ToString().ToUpper()))
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

        private void USER_Liste_Commande_Load(object sender, EventArgs e)
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
            txtNumLiv.Text = dvgLivraison.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtNumCommande_TextChanged(object sender, EventArgs e)
        {
            txtNumLiv.Text = "";
            Actualisedatagrid();
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            txtNumLiv.Text = "";
            Actualisedatagrid();
        }

        private void txtPeriode_TextChanged(object sender, EventArgs e)
        {
            txtNumLiv.Text = "";
            Actualisedatagrid();
        }
    }
}