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
    public partial class FRM_Produit_Livraison : Form
    {
        public Form frmdetail;
        public FRM_Produit_Livraison(Form frm)
        {
            InitializeComponent();
            frmdetail = frm;
        }

        private void txtquantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text seulement caractere numerique
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (txtquantite.Text == "")
            {
                MessageBox.Show("Saisir une quantite", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Ajouter produit dans datagrid commande
                BL.D_Livraison DETAIL = new BL.D_Livraison
                {
                    Id = int.Parse(txtIdProduit.Text),
                    Nom = lblnom.Text,
                    Quantite = int.Parse(txtquantite.Text),

                };
                //Ajouter dans liste detail commande
                if (lblTitre.Text == "Ajouter Livraison")
                {
                    if (BL.D_Livraison.listeDetail.SingleOrDefault(s => s.Id == DETAIL.Id) != null)
                    {
                        MessageBox.Show("Produit deja ajoute dans livraison", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        BL.D_Livraison.listeDetail.Add(DETAIL);
                    }
                }
                else
                {
                    //Modifier dans liste avec recherche d'index
                    int index = BL.D_Livraison.listeDetail.FindIndex(s => s.Id == int.Parse(txtIdProduit.Text));
                    BL.D_Livraison.listeDetail[index] = DETAIL;
                }
                //Ajouter dans liste detail affectation
                BL.D_Affectation DetailDestinataire = new BL.D_Affectation
                {
                    Id_Client = int.Parse(txtIdClientAffect.Text),
                    Id_Produit = int.Parse(txtIdProduit.Text),
                    Quantite = int.Parse(txtquantite.Text),
                };
                if (lblTitre.Text == "Ajouter Livraison")
                {
                    if (BL.D_Affectation.listeDetail.SingleOrDefault(s => s.Id_Produit == DetailDestinataire.Id_Produit) != null)
                    {
                        MessageBox.Show("Produit deja ajoute dans livraison", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        BL.D_Affectation.listeDetail.Add(DetailDestinataire);
                    }
                }
                else
                {
                    //Modifier dans liste avec recherche d'index
                    int index = BL.D_Affectation.listeDetail.FindIndex(s => s.Id_Produit == int.Parse(txtIdProduit.Text));
                    BL.D_Affectation.listeDetail[index] = DetailDestinataire;
                }
                //fin ajout table affectation
                (frmdetail as FRM_Detail_Livraison).Actualiser_Detail_Livraison();
                this.Close();
            }
        }
    }
}
