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
            panel1.Size=new Size(200, 666);
            
        }
        
        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width==200)
            {
                panel1.Size = new Size(75, 666);
            }else
            {
                panel1.Size = new Size(200, 666);
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
            }
            else
            {
                USER_Liste_Produit.Instance.BringToFront();
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

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlParamettrer_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            //desactiverForm();
        }      
    }
}
