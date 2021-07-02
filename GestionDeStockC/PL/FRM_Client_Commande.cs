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
            Actualiserdvg();
        }
        private void dvgclient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
        public void Actualiserdvg()
        {
            dvgclient.Rows.Clear();
            foreach (var LC in db.Clients)
            {
                dvgclient.Rows.Add(LC.ID_Client, LC.Num_Client, LC.Nom_Client + " " + LC.Prenom_Client, LC.Telephone_Client, LC.Ville_Client, LC.Rabais);
            }
            dvgclient.ClearSelection();
            if (txtID.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgclient.Rows)
                {
                    if ((r.Cells[0].Value).ToString().ToUpper() != (txtID.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgclient.CurrentCell = null;
                        dvgclient.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (txtNumeroClient.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgclient.Rows)
                {
                    if ((r.Cells[1].Value).ToString().ToUpper().Contains(txtNumeroClient.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgclient.CurrentCell = null;
                        dvgclient.Rows[r.Index].Visible = false;
                    }
                }
            }
            if (txtNomClient.Text.ToString() != "")
            {
                foreach (System.Windows.Forms.DataGridViewRow r in dvgclient.Rows)
                {
                    if ((r.Cells[2].Value).ToString().ToUpper().Contains(txtNomClient.Text.ToString().ToUpper()))
                    {
                        //dvgAffectationProduit.Rows[r.Index].Visible = true;
                        //dvgAffectationProduit.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dvgclient.CurrentCell = null;
                        dvgclient.Rows[r.Index].Visible = false;
                    }
                }
            }
        }
        private void txtrechercheInv_TextChanged(object sender, EventArgs e)
        {
            Actualiserdvg();
        }
        private void txtrechercheNom_TextChanged(object sender, EventArgs e)
        {
            Actualiserdvg();
        }
    }
}
