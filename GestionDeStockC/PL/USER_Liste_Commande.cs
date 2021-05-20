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

        private void dvgCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txtNumCde.Text = dvgCommande.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtNumCde_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();

            var listerecherche = db.Details_Commande.ToList();//liste de recherche = liste detail commande
            int Num = Int32.Parse(txtNumCde.Text);
            listerecherche = listerecherche.Where(s => s.ID_Commande.CompareTo(Num) != -1).ToList();
            //vide datagrid
            dvgDetailCde.Rows.Clear();
            foreach (var l in listerecherche)
            {
              dvgDetailCde.Rows.Add(l.ID_Produit, l.Nom_Produit, l.Quantite, l.Remise);
               
            }
            
        }
 
    }
}
