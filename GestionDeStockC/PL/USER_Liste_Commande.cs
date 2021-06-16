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
            dvgCommande.Rows.Clear();
            dvgCommande.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            Client c = new Client();
            string NomPrenom;
            foreach(var LC in db.Commandes)
            {
                //afficher nom + prenom de client a partir de son ID
                c = db.Clients.Single(s => s.ID_Client == LC.ID_Client);
                NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                dvgCommande.Rows.Add(false, LC.ID_Commande, LC.DATE_Commande, NomPrenom, LC.Total_HT);
            }
            dvgCommande.ClearSelection();

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
            Produit Inv = new Produit();
            int NumCde = 0;
            NumCde = Int32.Parse(txtNumCde.Text);

            var detailcommande = db.Details_Commande.ToList();
                if(txtNumCde.Text != "")
                {
                detailcommande = detailcommande.Where(s => s.ID_Commande == NumCde).ToList();
                dvgDetailCde.Rows.Clear();
                foreach (var l in detailcommande)
                {
                    Inv = db.Produits.SingleOrDefault(s => s.ID_Produit == l.ID_Produit);
                    dvgDetailCde.Rows.Add(l.ID_Produit, Inv.NumInventaire, l.Nom_Produit, l.Quantite, l.Remise);
                }
                }
                dvgDetailCde.ClearSelection();
        }

       
        private void dvgCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumCde.Text = dvgCommande.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
