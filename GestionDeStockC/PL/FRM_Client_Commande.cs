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
    public partial class FRM_Client_Commande : Form
    {
        private dbStockContext db;
        public FRM_Client_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        private void FRM_Client_Commande_Load(object sender, EventArgs e)
        {
            //remplir datagrid par la liste des clients
            foreach(var LC in db.Clients)
            {
                dvgclient.Rows.Add(LC.ID_Client, LC.Nom_Client, LC.Prenom_Client, LC.Adresse_Client, LC.Telephone_Client, LC.Email_Client, LC.Ville_Client, LC.Pays_Client);
            }
        }
        private void dvgclient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
