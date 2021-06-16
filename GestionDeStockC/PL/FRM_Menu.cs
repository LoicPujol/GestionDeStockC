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
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size=new Size(180, 666);
            USER_Alerte.Instance.TestDemarageAlerte();
            
        }
        
        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width==180)
            {
                panel1.Size = new Size(50, 666);
            }else
            {
                panel1.Size = new Size(180, 666);
            }
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnproduit.Top;
            if (!pnlaficher.Controls.Contains(USER_Liste_Produit.Instance))
            {
                pnlaficher.Controls.Add(USER_Liste_Produit.Instance);
                USER_Liste_Produit.Instance.Dock = DockStyle.Fill;
                USER_Liste_Produit.Instance.BringToFront();
                USER_Liste_Produit.Instance.Actualiserdvg();
            }
            else
            {
                USER_Liste_Produit.Instance.BringToFront();
                USER_Liste_Produit.Instance.Actualiserdvg();
            }
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;
            if(!pnlaficher.Controls.Contains(USER_Liste_Client.Instance))
            {
                pnlaficher.Controls.Add(USER_Liste_Client.Instance);
                USER_Liste_Client.Instance.Dock = DockStyle.Fill;
                USER_Liste_Client.Instance.BringToFront();
            }else
            {
                USER_Liste_Client.Instance.BringToFront();
            }
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncategorie.Top;
            if (!pnlaficher.Controls.Contains(USER_Liste_Categorie.Instance))
            {
                pnlaficher.Controls.Add(USER_Liste_Categorie.Instance);
                USER_Liste_Categorie.Instance.Dock = DockStyle.Fill;
                USER_Liste_Categorie.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Categorie.Instance.BringToFront();
            }
        }

        private void btpcommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncommande.Top;
            if (!pnlaficher.Controls.Contains(USER_Liste_Commande.Instance))
            {
                pnlaficher.Controls.Add(USER_Liste_Commande.Instance);
                USER_Liste_Commande.Instance.Dock = DockStyle.Fill;
                USER_Liste_Commande.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Commande.Instance.BringToFront();
            }
        }
        private void btnalerte_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnalerte.Top;
            if (!pnlaficher.Controls.Contains(USER_Alerte.Instance))
            {
                pnlaficher.Controls.Add(USER_Alerte.Instance);
                USER_Alerte.Instance.Dock = DockStyle.Fill;
                USER_Alerte.Instance.BringToFront();
            }
            else
            {
                USER_Alerte.Instance.BringToFront();
            }
        }

        private void btnaffectation_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnaffectation.Top;
            if (!pnlaficher.Controls.Contains(USER_Affectation.Instance))
            {
                pnlaficher.Controls.Add(USER_Affectation.Instance);
                USER_Affectation.Instance.Dock = DockStyle.Fill;
                USER_Affectation.Instance.BringToFront();
                USER_Affectation.Instance.Actualiserdvg();
            }
            else
            {
                USER_Affectation.Instance.BringToFront();
                USER_Affectation.Instance.Actualiserdvg();
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnDash.Top;
            if (!pnlaficher.Controls.Contains(USER_Dashboard.Instance))
            {
                pnlaficher.Controls.Add(USER_Dashboard.Instance);
                USER_Dashboard.Instance.Dock = DockStyle.Fill;
                USER_Dashboard.Instance.BringToFront();
            }
            else
            {
                USER_Dashboard.Instance.BringToFront();
            }
        }
    }
}
