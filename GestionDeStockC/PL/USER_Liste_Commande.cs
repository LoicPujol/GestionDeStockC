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
            Client c = new Client();
            string NomPrenom;
            foreach(var LC in db.Commandes)
            {
                //afficher nom + prenom de client a partir de son ID
                c = db.Clients.Single(s => s.ID_Client == LC.ID_Client);
                NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                dvgCommande.Rows.Add(LC.ID_Commande, LC.DATE_Commande, NomPrenom, LC.Total_HT, LC.TVA, LC.Total_TTC);
            }
            
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
            int NumCde = 0;
            NumCde = Int32.Parse(txtNumCde.Text);

            var detailcommande = db.Details_Commande.ToList();
                if(txtNumCde.Text != "")
                {
                detailcommande = detailcommande.Where(s => s.ID_Commande == NumCde).ToList();
                dvgDetailCde.Rows.Clear();
                foreach (var l in detailcommande)
                {
                    dvgDetailCde.Rows.Add(l.ID_Produit, l.Nom_Produit, l.Quantite, l.Remise);
                }
                }
        }

        private void dvgCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumCde.Text = dvgCommande.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

    }
}
